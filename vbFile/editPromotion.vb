Imports System.Data.SqlClient
Imports System.Text

Public Class editPromotion
    Private strPromotionID As String = PromotionMenu.strPromoID
    Private Sub editPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Set the format for dateTimePickerDOB and dateTimePicker DOJ
        dtpStartDate.Format = DateTimePickerFormat.Custom
        dtpStartDate.CustomFormat = "dd/MM/yyyy"
        dtpEndDate.Format = DateTimePickerFormat.Custom
        dtpEndDate.CustomFormat = "dd/MM/yyyy"
        dtpStartDate.Value = DateTime.Parse(PromotionMenu.strPromoStartDate)
        dtpEndDate.Value = DateTime.Parse(PromotionMenu.strPromoEndDate)
        cboPromotionType.Enabled = False


        SetControlDisabled()

        txtPromoName.Text = PromotionMenu.strPromoName.ToString()
        dtpStartDate.Value = PromotionMenu.strPromoStartDate.ToString()
        dtpEndDate.Value = PromotionMenu.strPromoEndDate.ToString()
        cboPromotionType.Text = promotionMenu.strPromoType.ToString()
        cboDiscountType.Text = PromotionMenu.strPromoDiscountType.ToString()
        numDiscountValue.Value = promotionMenu.strPromoDiscountValue.ToString()
        lblPromoStatus.Text = promotionMenu.strPromoStatus.ToString()
        lblProductID.Text = PromotionMenu.strPromoProductID.ToString()
        txtVoucherCode.Text = PromotionMenu.strVoucherCode.ToString()
        numUsageLimit.Value = PromotionMenu.strUsageLimit.ToString()

        Dim strSql As String = "SELECT * FROM product"

    End Sub

    Private Sub SetControlsEnabled()

        btnEditPromotion.Text = "Update"

        txtPromoName.Enabled = True
        dtpStartDate.Enabled = True
        dtpEndDate.Enabled = True
        lblPromoStatus.Enabled = True
        cboDiscountType.Enabled = True
        numDiscountValue.Enabled = True
        btnRandomGenerate.Enabled = True
        btnCalculate.Enabled = True
    End Sub
    Private Sub SetControlDisabled()
        btnEditPromotion.Text = "Edit"

        txtPromoName.Enabled = False
        dtpStartDate.Enabled = False
        dtpEndDate.Enabled = False
        lblPromoStatus.Enabled = False
        cboDiscountType.Enabled = False
        numDiscountValue.Enabled = False
        btnRandomGenerate.Enabled = False
        btnCalculate.Enabled = False

    End Sub

    Private Sub btnEditPromotion_Click(sender As Object, e As EventArgs) Handles btnEditPromotion.Click
        If btnEditPromotion.Text = "Edit" Then
            If lblPromoStatus.Text = "Invalid" Then
                MessageBox.Show("You cannot edit a promotion with an 'Invalid' status. Please choose a valid promotion.", "Invalid Promotion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            SetControlsEnabled()
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update the details?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If CheckValidate() Then
                    SaveandUpdateDetails()
                    SetControlDisabled()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub SaveandUpdateDetails()
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Try
            Dim strSql As String = "UPDATE Promotion SET " &
                       "promotion_name = @promotion_name, " &
                       "start_date = @start_date, " &
                       "end_date = @end_date, " &
                       "promotion_type = @promotion_type, " &
                       "discount_type = @discount_type, " &
                       "discount_value = @discount_value, " &
                       "promotion_status = @promotion_status, " &
                       "product_id = @product_id, " &
                       "voucher_code = @voucher_code, " &
                       "usage_limit = @usage_limit " &
                       "WHERE promotion_id = @promotion_id"
            OpenConnection()
            Using Mysqlcommand As New SqlCommand()

                With Mysqlcommand
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = strSql
                    .Parameters.AddWithValue("promotion_id", strPromotionID)
                    .Parameters.AddWithValue("@promotion_name", txtPromoName.Text)
                    .Parameters.AddWithValue("@start_date", dtpStartDate.Value.ToShortDateString())
                    .Parameters.AddWithValue("@end_date", dtpEndDate.Value.ToShortDateString())
                    .Parameters.AddWithValue("@promotion_type", cboPromotionType.SelectedItem.ToString)
                    .Parameters.AddWithValue("@discount_type", cboDiscountType.SelectedItem.ToString)
                    .Parameters.AddWithValue("@discount_value", numDiscountValue.Value)
                    .Parameters.AddWithValue("@promotion_status", lblPromoStatus.Text)
                    .Parameters.AddWithValue("@product_id", lblProductID.Text)
                    .Parameters.AddWithValue("@voucher_code", txtVoucherCode.Text)
                    .Parameters.AddWithValue("@usage_limit", numUsageLimit.Value)

                End With
                Mysqlcommand.ExecuteNonQuery()
                MessageBox.Show("Details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
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
    Private Sub numDiscountValue_ValueChanged(sender As Object, e As EventArgs) Handles numDiscountValue.ValueChanged
        ' Enable product-related controls when a numeric value is provided
        If cboDiscountType.SelectedItem IsNot Nothing AndAlso (cboDiscountType.SelectedItem.ToString() = "Percentage" OrElse cboDiscountType.SelectedItem.ToString() = "Fixed Amount") Then
            If numDiscountValue.Value > 0 Then
                lblProductID.Enabled = True
                lblProductPrice.Enabled = True
                lblPriceAfterDiscount.Enabled = True
            Else
                ' Disable product-related controls if the discount value becomes 0 or less
                lblProductID.Enabled = False
                lblProductPrice.Enabled = False
                lblPriceAfterDiscount.Enabled = False
            End If
        End If
        If numDiscountValue.Value <= 0 Then
            numDiscountValue.Focus()
            ErrorProvider4.SetError(Me.numDiscountValue, "- Discount Value should be greater than zero!")
        Else
            ErrorProvider4.Clear()
        End If
    End Sub
    Private Sub txtVoucherCode_Leave(sender As Object, e As EventArgs) Handles txtVoucherCode.Leave
        If String.IsNullOrEmpty(txtVoucherCode.Text) = True Then
            txtVoucherCode.Focus()
            ErrorProvider5.SetError(Me.txtVoucherCode, "- Please Generate or Enter a Voucher Name!")
        ElseIf txtVoucherCode.Text.Length > 6 Then
            txtVoucherCode.Focus()
            ErrorProvider5.SetError(txtVoucherCode, "- Voucher Code must be a maxiumum 6 characters only!.")
        Else
            ErrorProvider5.Clear()
        End If
    End Sub

    Private Sub numUsageLimit_ValueChanged(sender As Object, e As EventArgs) Handles numUsageLimit.ValueChanged
        If numUsageLimit.Value <= 0 Then
            numUsageLimit.Focus()
            ErrorProvider6.SetError(numUsageLimit, "Usage limit should be a non-negative value!")
        Else
            ErrorProvider6.Clear()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "Cancel" Then
            getPromotionData()
            SetControlDisabled()
        End If
    End Sub


    Sub getPromotionData()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = "SELECT * FROM Promotion WHERE promotion_id = @promotion_id"

        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        MySqlCommand.Parameters.AddWithValue("@promotion_id", PromotionMenu.strPromoID)
        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        reader.Read()
        MySqlCommand.Parameters.AddWithValue("@promotion_id", PromotionMenu.strPromoID)
        MySqlCommand.Parameters.AddWithValue("@promotion_name", PromotionMenu.strPromoName)
        MySqlCommand.Parameters.AddWithValue("@start_date", PromotionMenu.strPromoStartDate)
        MySqlCommand.Parameters.AddWithValue("@end_date", PromotionMenu.strPromoEndDate)
        MySqlCommand.Parameters.AddWithValue("@promotion_type", PromotionMenu.strPromoType)
        MySqlCommand.Parameters.AddWithValue("@discount_type", PromotionMenu.strPromoDiscountType)
        MySqlCommand.Parameters.AddWithValue("@discount_value", PromotionMenu.strPromoDiscountValue)
        MySqlCommand.Parameters.AddWithValue("@promotion_status", PromotionMenu.strPromoStatus)
        MySqlCommand.Parameters.AddWithValue("@product_id", PromotionMenu.strPromoID)
        MySqlCommand.Parameters.AddWithValue("@voucher_code", PromotionMenu.strVoucherCode)
        MySqlCommand.Parameters.AddWithValue("@usage_limit", PromotionMenu.strUsageLimit)

        reader.Close()
        CloseConnection()
    End Sub

    Private Sub cboDiscountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDiscountType.SelectedIndexChanged
        If cboDiscountType.SelectedItem.ToString() = "Percentage" OrElse cboDiscountType.SelectedItem.ToString() = "Fixed Amount" Then
            If numDiscountValue.Value > 0 Then
                lblProductID.Enabled = True
                lblProductPrice.Enabled = True
                lblPriceAfterDiscount.Enabled = True
            End If
        End If

        If cboDiscountType.SelectedItem.ToString = "Percentage" Then
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

    Private Sub cboPromotionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPromotionType.SelectedIndexChanged
        If cboPromotionType.SelectedItem.ToString = "Voucher" Then
            cboPromotionType.Enabled = False
            ' If the promotion type is Voucher, show the Voucher-related controls and hide the Product-related controls
            grpVoucher.Visible = True
            grpProduct.Visible = False

            ' Disable the Product-related controls
            lblProductID.Enabled = False
            lblProductPrice.Enabled = False
            lblPriceAfterDiscount.Enabled = False
        ElseIf cboPromotionType.SelectedItem.ToString = "Product" Then
            cboPromotionType.Enabled = False

            ' If the promotion type is Product, show the Product-related controls and hide the Voucher-related controls
            grpVoucher.Visible = False
            grpProduct.Visible = True

            ' Enable the Product-related controls
            lblProductID.Enabled = True
            lblProductPrice.Enabled = True
            lblPriceAfterDiscount.Enabled = True
        End If
    End Sub



    Private Sub btnRandomGenerate_Click(sender As Object, e As EventArgs) Handles btnRandomGenerate.Click
        ' Define the characters to use in the voucher code
        Dim characters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        Dim codeLength As Integer = 6

        Dim random As New Random()

        Dim voucherCode As String = ""

        For i As Integer = 1 To codeLength
            voucherCode &= characters(random.Next(0, characters.Length))
        Next

        txtVoucherCode.Text = voucherCode.ToString()
    End Sub
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
        ElseIf startDate.Date > endDate.Date OrElse endDate.Date < startDate.Date OrElse startDate.Date < currentDate OrElse endDate.Date > startDate.Date Then
            lblPromoStatus.Text = "Invalid"
        End If


    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Me.Hide()
        promotionMenu.ShowDialog()
    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click
        Me.Hide()
        promotionMenu.ShowDialog()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Me.Hide()
        promotionMenu.ShowDialog()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
        promotionMenu.ShowDialog()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Hide()
        promotionReport.ShowDialog()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Me.Hide()
        promotionReport.ShowDialog()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Not String.IsNullOrEmpty(promotionMenu.strPromoProductID) Then
            Dim selectedProductId As String = promotionMenu.strPromoProductID

            Dim strSql As String = "SELECT product_name, product_price FROM Product WHERE product_id = @product_id"

            Try
                If OpenConnection() Then
                    Using cmd As New SqlCommand(strSql, connection)
                        cmd.Parameters.AddWithValue("@product_id", selectedProductId)
                        Dim originalPrice As Decimal
                        Dim productName As String
                        Dim showDiscountedPrice As Decimal
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                productName = reader("product_name").ToString()
                                originalPrice = Convert.ToDecimal(reader("product_price"))
                                lblProductID.Text = selectedProductId
                                lblProductName.Text = productName ' Added line to display product name
                                lblProductPrice.Text = originalPrice.ToString("C2")
                                ' Assuming you want to calculate discounted price based on existing discount type and value
                                If cboDiscountType.SelectedItem IsNot Nothing Then
                                    If cboDiscountType.SelectedItem.ToString() = "Percentage" Then
                                        showDiscountedPrice = originalPrice - (originalPrice * numDiscountValue.Value / 100)
                                    ElseIf cboDiscountType.SelectedItem.ToString() = "Fixed Amount" Then
                                        showDiscountedPrice = originalPrice - numDiscountValue.Value
                                    End If
                                    lblPriceAfterDiscount.Text = showDiscountedPrice.ToString("C2")
                                End If
                            End If
                        End Using
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving product details: " & ex.Message, "Error")
            Finally
                CloseConnection()
            End Try
        Else
            MessageBox.Show("Please select a product to calculate price.", "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class