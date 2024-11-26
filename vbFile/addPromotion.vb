Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions
''todo make the date validation to when user press save promotion
Public Class addPromotion
    Private Sub CreatePromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Set the format for dateTimePickerDOB and dateTimePicker DOJ
        dtpStartDate.Format = DateTimePickerFormat.Custom
        dtpStartDate.CustomFormat = "dd/MM/yyyy"
        dtpEndDate.Format = DateTimePickerFormat.Custom
        dtpEndDate.CustomFormat = "dd/MM/yyyy"
        dtpStartDate.Value = DateTime.Now.Date.ToShortDateString
        dtpEndDate.Value = DateTime.Now.Date.ToShortDateString


        dtpStartDate.Visible = False
        dtpEndDate.Visible = False

        grpVoucher.Visible = False
        grpProduct.Visible = False

        Dim strSql As String = "SELECT * FROM product"
        Try
            If OpenConnection() = True Then
                Using cmd As New SqlCommand(strSql, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        cboProduct.Items.Clear()

                        While reader.Read()
                            cboProduct.Items.Add(reader("product_name").ToString())
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading products.", "Error")
        Finally
            CloseConnection()
        End Try
        cboProduct.SelectedItem = 0
    End Sub

    Private Sub cboDiscountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDiscountType.SelectedIndexChanged
        If cboDiscountType.SelectedItem.ToString() = "Percentage" Then
            lblDiscountValue.Text = "Discount (%)"
            numDiscountValue.DecimalPlaces = 2
            numDiscountValue.Minimum = 0
            numDiscountValue.Maximum = 100
            numDiscountValue.Increment = 1
        ElseIf cboDiscountType.SelectedItem.ToString() = "Fixed Amount" Then
            lblDiscountValue.Text = "Discount Amount"
            numDiscountValue.DecimalPlaces = 2
            numDiscountValue.Minimum = 0
            numDiscountValue.Maximum = 100
            numDiscountValue.Increment = 1
        End If
    End Sub

    Private Sub radStartNow_CheckedChanged(sender As Object, e As EventArgs) Handles radStartNow.CheckedChanged
        If radStartNow.Checked Then
            ' Set the start date to today
            dtpStartDate.Value = DateTime.Now.Date.ToShortDateString
            ' Set the end date to today
            dtpEndDate.Value = DateTime.Now.Date.ToShortDateString

            lblPromoStatus.Text = "Active"

            ' Show and enable the end date control
            dtpStartDate.Enabled = False
            dtpStartDate.Visible = True
            dtpEndDate.Visible = True
            dtpEndDate.Enabled = True
        End If
    End Sub

    Private Sub radStartLater_CheckedChanged(sender As Object, e As EventArgs) Handles radStartLater.CheckedChanged
        If radStartLater.Checked Then
            ' Set the start date to tomorrow
            dtpStartDate.Value = DateTime.Now.Date.AddDays(1)

            ' Set the end date to tomorrow
            dtpEndDate.Value = DateTime.Now.AddDays(1)
            lblPromoStatus.Text = "Pending"

            ' Show and enable the end date control
            dtpStartDate.Visible = True
            dtpStartDate.Enabled = True
            dtpEndDate.Visible = True
            dtpEndDate.Enabled = True
        End If
    End Sub
    Private Sub cboPromotionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPromotionType.SelectedIndexChanged

        If cboPromotionType.SelectedItem.ToString = "Voucher" Then
            grpVoucher.Visible = True
            grpProduct.Visible = False
        ElseIf cboPromotionType.SelectedItem.ToString = "Product" Then
            grpVoucher.Visible = False
            grpProduct.Visible = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRandomGenerate_Click(sender As Object, e As EventArgs) Handles btnRandomGenerate.Click
        Dim characters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        Dim codeLength As Integer = 6

        Dim random As New Random()

        Dim voucherCode As String = ""

        For i As Integer = 1 To codeLength
            voucherCode &= characters(random.Next(0, characters.Length))
        Next

        txtVoucherCode.Text = voucherCode.ToString()
    End Sub


    Private Sub btnSavePromotion_Click(sender As Object, e As EventArgs) Handles btnSavePromotion.Click
        If CheckValidate() Then
            ' Check if the status is 'Invalid'
            If lblPromoStatus.Text = "Invalid" Then
                MessageBox.Show("Cannot add promotion with 'Invalid' status of time. Please choose valid start and end dates.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Stop further processing
            End If

            Dim dlgResult As DialogResult
            Try
                ' Handle additional logic here if needed
            Catch ex As Exception
                MessageBox.Show("Something went wrong", "Error")
            End Try

            dlgResult = MessageBox.Show("Are you sure you want to add this promotion?", "Add Promotion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlgResult = DialogResult.Yes Then
                addPromotion()
                'btnClear_Click(Nothing, Nothing)
                Dim dlgContinue As DialogResult = MessageBox.Show("Do you want to continue adding promotions?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If dlgContinue = DialogResult.No Then
                    PromotionMenu.ShowDialog()
                    Me.Close()
                End If
            Else
                btnCancel_Click(Nothing, Nothing)
            End If
        End If
    End Sub


    Private Sub addPromotion()
        'add to promotion table
        If lblPromoStatus.Text <> "Invalid" Then
            Dim strSql As String
            strSql = "INSERT INTO Promotion (promotion_name, start_date, end_date, promotion_type, discount_type, discount_value, promotion_status, product_id, voucher_code, usage_limit)Values(@promotion_name, @start_date, @end_date, @promotion_type, @discount_type, @discount_value, @promotion_status, @product_id, @voucher_code, @usage_limit)"

            'Update the discount price in the prodcut table
            Dim updateProductSql As String = "UPDATE Product SET discounted_price = @discounted_price, discount_status = @discount_status WHERE product_id = @product_id"
            Try
                OpenConnection()
                Try
                    Using Mysqlcommand As New SqlCommand()
                        With Mysqlcommand
                            .Connection = connection
                            .CommandType = CommandType.Text
                            .CommandText = strSql

                            .Parameters.AddWithValue("@promotion_name", txtPromoName.Text)
                            .Parameters.AddWithValue("@start_date", dtpStartDate.Value.ToShortDateString)
                            .Parameters.AddWithValue("@end_date", dtpEndDate.Value.ToShortDateString)
                            .Parameters.AddWithValue("@promotion_type", cboPromotionType.SelectedItem.ToString)
                            .Parameters.AddWithValue("@discount_type", cboDiscountType.SelectedItem.ToString)
                            .Parameters.AddWithValue("@discount_value", numDiscountValue.Value)
                            .Parameters.AddWithValue("@promotion_status", lblPromoStatus.Text)
                            .Parameters.AddWithValue("@product_id", lblProductID.Text)
                            .Parameters.AddWithValue("@voucher_code", txtVoucherCode.Text)
                            .Parameters.AddWithValue("@usage_limit", numUsageLimit.Value)
                        End With

                        Dim originalPriceSql As String = "SELECT product_price FROM Product WHERE product_id = @product_id"
                        Using getPriceCommand As New SqlCommand(originalPriceSql, connection)
                            getPriceCommand.Parameters.AddWithValue("@product_id", lblProductID.Text)

                            Dim originalPrice As Decimal = Convert.ToDecimal(getPriceCommand.ExecuteScalar())

                            Dim discountedPrice As Decimal
                            If cboDiscountType.SelectedItem.ToString() = "Percentage" Then
                                discountedPrice = originalPrice - (originalPrice * numDiscountValue.Value / 100)
                            ElseIf cboDiscountType.SelectedItem.ToString() = "Fixed Amount" Then
                                discountedPrice = originalPrice - numDiscountValue.Value
                            End If

                            ' Update the discounted price in the product table
                            Using updateProductCommand As New SqlCommand(updateProductSql, connection)
                                updateProductCommand.Parameters.AddWithValue("@product_id", lblProductID.Text)
                                updateProductCommand.Parameters.AddWithValue("@discounted_price", discountedPrice)
                                updateProductCommand.Parameters.AddWithValue("@discount_status", lblPromoStatus.Text)
                                updateProductCommand.ExecuteNonQuery()
                            End Using
                        End Using

                        Mysqlcommand.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error adding promotion: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Catch ex As Exception
                MessageBox.Show("Error opening database connection: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try

            MessageBox.Show("Promotion Saved.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cannot add promotion with 'Invalid' status of time.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub txtPromoName_Leave(sender As Object, e As EventArgs) Handles txtPromoName.Leave
        If String.IsNullOrEmpty(txtPromoName.Text) = True Then
            txtPromoName.Focus()
            ErrorProvider1.SetError(Me.txtPromoName, "- Please Enter Promotion Name!")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cboPromotionType_Leave(sender As Object, e As EventArgs) Handles cboPromotionType.Leave
        If cboPromotionType.SelectedItem Is Nothing Then
            cboPromotionType.Focus()
            ErrorProvider2.SetError(Me.cboPromotionType, "- Please Select a Promotion Type!")
        Else
            ErrorProvider2.Clear()
        End If
    End Sub
    Private Sub cboDiscountType_Leave(sender As Object, e As EventArgs) Handles cboDiscountType.Leave
        If cboDiscountType.SelectedItem Is Nothing Then
            cboDiscountType.Focus()
            ErrorProvider3.SetError(Me.cboDiscountType, "- Please Select a Discount Type!")
        Else
            ErrorProvider3.Clear()
        End If
    End Sub
    Private Function ProductExistedInPromotion(productid As String) As Boolean
        Dim strSql As String = "SELECT COUNT (*) FROM Promotion WHERE product_id = @product_id"
        Dim existingPromotionCount As Integer = 0

        Try
            If OpenConnection() Then
                Using command As New SqlCommand(strSql, connection)
                    command.Parameters.AddWithValue("@product_id", productid)
                    existingPromotionCount = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking existing promotion: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ' Return True if there is already an existing promotion for the product
        Return existingPromotionCount > 0
    End Function

    Private Function CheckValidate() As Boolean
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        ' Validate promotion name
        If String.IsNullOrWhiteSpace(txtPromoName.Text) Then
            err.AppendLine(" - Promotion Name cannot be empty.")
            ctr = If(ctr, txtPromoName)
        End If

        ' Validate promotion type
        If cboPromotionType.SelectedItem Is Nothing Then
            err.AppendLine(" - Please select a Promotion Type.")
            ctr = If(ctr, cboPromotionType)
        End If

        ' Validate discount type
        If cboDiscountType.SelectedItem Is Nothing Then
            err.AppendLine(" - Please select a Discount Type.")
            ctr = If(ctr, cboDiscountType)
        End If

        ' Validate discount value
        If numDiscountValue.Value <= 0 Then
            err.AppendLine(" - Discount Value should be greater than zero.")
            ctr = If(ctr, numDiscountValue)
        End If

        ' Validate product selection 
        If grpProduct.Visible Then
            If cboProduct.SelectedItem Is Nothing Then
                err.AppendLine(" - Please choose a product to apply the promotion.")
                ctr = If(ctr, cboProduct)
            ElseIf ProductExistedInPromotion(lblProductID.Text) Then
                err.AppendLine(" - This product already has an existing promotion.")
                ctr = If(ctr, cboProduct)
            End If
        End If

        ' Validate voucher code and usage limit 
        If grpVoucher.Visible Then
            If String.IsNullOrWhiteSpace(txtVoucherCode.Text) Then
                err.AppendLine(" - Please generate or enter a Voucher Code.")
                ctr = If(ctr, txtVoucherCode)
            ElseIf txtVoucherCode.Text.Length > 6 Then
                err.AppendLine(" - Voucher Code must be a maximum of 6 characters only.")
                ctr = If(ctr, txtVoucherCode)
            End If

            ' Validate usage limit
            If numUsageLimit.Value <= 0 Then
                err.AppendLine(" - Usage limit should be a non-negative value.")
                ctr = If(ctr, numUsageLimit)
            End If
        End If

        ' Display error messages and set focus
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        UpdateStatusLabel()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        UpdateStatusLabel()
    End Sub

    Private Sub UpdateStatusLabel()
        Dim currentDate As Date = DateTime.Now.Date
        Dim startDate As Date = dtpStartDate.Value.Date
        Dim endDate As Date = dtpEndDate.Value.Date

        If startDate.Date = currentDate AndAlso endDate.Date > currentDate Then
            lblPromoStatus.Text = "Active"
        ElseIf startDate.Date > currentDate AndAlso endDate.Date > currentDate AndAlso endDate.Date > startDate Then
            lblPromoStatus.Text = "Pending"
        ElseIf startDate.Date > endDate.Date OrElse endDate.Date < startDate.date OrElse startDate.Date < currentDate OrElse endDate.Date > startDate.Date Then
            lblPromoStatus.Text = "Invalid"
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPromoName.Text = ""
        txtVoucherCode.Text = ""

        ' Reset datetime pickers
        dtpStartDate.Value = DateTime.Now.Date
        dtpEndDate.Value = DateTime.Now.Date

        ' Reset numeric up-down controls
        numDiscountValue.Value = 0
        numUsageLimit.Value = 0

        ' Reset radio buttons
        radStartNow.Checked = True

        ' Reset combo boxes
        cboPromotionType.SelectedIndex = 0
        cboDiscountType.SelectedIndex = 0
        cboProduct.SelectedIndex = -1

        ' Reset labels
        lblProductID.Text = ""
        lblProductPrice.Text = ""
        lblPriceAfterDiscount.Text = ""
        lblPromoStatus.Text = ""

        ' Reset error providers
        ErrorProvider1.Clear()
        ErrorProvider2.Clear()
        ErrorProvider3.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If cboProduct.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a product to calculate price.", "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim selectedProductName As String = cboProduct.SelectedItem.ToString()

        Dim strSql As String = "SELECT * FROM Product WHERE product_name = @product_name"

        Try
            If OpenConnection() = True Then
                Using cmd As New SqlCommand(strSql, connection)
                    cmd.Parameters.AddWithValue("@product_name", selectedProductName)
                    Dim originalPrice As Decimal
                    Dim showDiscountedPrice As Decimal
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblProductID.Text = reader("product_id").ToString()
                            originalPrice = reader("product_price").ToString()
                        End If
                        lblProductPrice.Text = originalPrice.ToString("C2")
                        If cboDiscountType.SelectedItem.ToString() = "Percentage" Then
                            showDiscountedPrice = originalPrice - (originalPrice * numDiscountValue.Value / 100)
                            lblPriceAfterDiscount.Text = showDiscountedPrice.ToString("C2")
                        ElseIf cboDiscountType.SelectedItem.ToString() = "Fixed Amount" Then
                            showDiscountedPrice = originalPrice - numDiscountValue.Value
                            lblPriceAfterDiscount.Text = showDiscountedPrice.ToString("C2")
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving product name: " & ex.Message, "Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub numDiscountValue_ValueChanged(sender As Object, e As EventArgs) Handles numDiscountValue.ValueChanged
        If cboPromotionType.SelectedItem IsNot Nothing AndAlso cboPromotionType.SelectedItem.ToString() = "Product" AndAlso numDiscountValue.Value > 0 Then
            grpProduct.Visible = True
        Else
            grpProduct.Visible = False
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)
        Me.Close()
        promotionMenu.ShowDialog()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)
        Me.Close()
        promotionMenu.ShowDialog()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
        Me.Hide()
        promotionMenu.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)
        Me.Hide()
        promotionMenu.ShowDialog()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        Me.Hide()
        promotionReport.ShowDialog()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)
        Me.Hide()
        promotionReport.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        promotionReport.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class