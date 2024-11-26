Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Public Class frmInventoryCreate
    Friend strCategory As String
    Friend intCount As Integer = 0
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private randomInt As Object
    Private lblFrmEditTitle = New Label
    Private Sub frmInventoryCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim intGrpCreateWidth As Integer = grpCreate.Width
        Dim intGrpCreateHeight As Integer = grpCreate.Height
        Dim intGrpCreateX As Integer = 1680 \ 4
        Dim intGrpCreateY As Integer = 1050 \ 12

        grpCreate.Location = New Point(intGrpCreateX, intGrpCreateY)
        Me.AutoScroll = True
        With lblCreateCategory
            .Enabled = False
            .Text = strCategory
        End With

        With lblFrmEditTitle
            .Text = "Create Inventory In The Form Below"
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("MV Boli", 14, FontStyle.Bold)
            .ForeColor = Color.FromArgb(26, 66, 36)
            .Dock = DockStyle.Top
            .BackColor = Color.White
        End With
        Me.Controls.Add(lblFrmEditTitle)
    End Sub

    Private Sub txtCreateName_Validating(sender As Object, e As CancelEventArgs) Handles txtCreateName.Validating
        Dim strName As String = txtCreateName.Text
        If strName = "" Then
            err.SetError(txtCreateName, "Please enter valid [Name]")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtCreatePrice_Validating(sender As Object, e As CancelEventArgs) Handles txtCreatePrice.Validating
        Dim strPrice As String = txtCreatePrice.Text
        If strPrice = "" Then
            err.SetError(txtCreatePrice, "Please enter valid [Price]")
            e.Cancel = True
        End If

        If strPrice.All(Function(c) Not Char.IsDigit(c)) Then
            err.SetError(txtCreatePrice, "Please enter digit [Price]")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtCreateQuantity_Validating(sender As Object, e As CancelEventArgs) Handles txtCreateQuantity.Validating
        Dim strQuantity As String = txtCreateQuantity.Text
        If strQuantity = "" Then
            err.SetError(txtCreateQuantity, "Please enter valid [Quantity]")
            e.Cancel = True
        End If

        If strQuantity.All(Function(c) Not Char.IsDigit(c)) Then
            err.SetError(txtCreatePrice, "Please enter digit [Quantity]")
            e.Cancel = True
        End If
    End Sub
    Private Sub txtCreateDescription_Validating(sender As Object, e As CancelEventArgs) Handles txtCreateDescription.Validating
        Dim strDescription As String = txtCreateDescription.Text
        If strDescription = "" Then
            err.SetError(txtCreateDescription, "Please enter valid [Description]")
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCreateConfirm_Click(sender As Object, e As EventArgs) Handles btnCreateConfirm.Click
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strDescription As String = txtCreateName.Text & "" & ":-" & "" & txtCreateDescription.Text
        If Me.ValidateChildren() = False Then
            Return
        End If
        If IsDuplicate(txtCreateName.Text) Then
            MessageBox.Show("Product name already exists.", "Duplicate", MessageBoxButtons.OK)
            Return
        End If
        If OpenConnection() = True Then

            strSql = "Insert Into Product(product_id,product_name,product_price,product_quantity,product_category,product_image,product_status,product_barcode,product_description)Values(@product_id,@product_name,@product_price,@product_quantity,@product_category,@product_image,@product_status,@product_barcode,@product_description)"
            MySqlCommand = New SqlCommand(strSql, connection)
            MySqlCommand.Parameters.AddWithValue("@product_id", GetNextId)
            MySqlCommand.Parameters.AddWithValue("@product_name", txtCreateName.Text)
            MySqlCommand.Parameters.AddWithValue("@product_price", txtCreatePrice.Text)
            MySqlCommand.Parameters.AddWithValue("@product_quantity", txtCreateQuantity.Text)
            MySqlCommand.Parameters.AddWithValue("@product_category", lblCreateCategory.Text)
            MySqlCommand.Parameters.AddWithValue("@product_image", PictureConversion())
            MySqlCommand.Parameters.AddWithValue("@product_status", "on shelves")
            MySqlCommand.Parameters.AddWithValue("@product_barcode", BarCode())
            MySqlCommand.Parameters.AddWithValue("@product_description", strDescription)
            MySqlCommand.ExecuteNonQuery()
            MessageBox.Show("Item has been added", "Successful", MessageBoxButtons.OK)
            CloseConnection()
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
        End If
        ClearText()
        Me.Close()
    End Sub
    Private Function IsDuplicate(productName As String) As Boolean
        Dim isDuplicateName As Boolean = False
        Dim checkCommand As New SqlCommand
        Dim checkSql As String = "SELECT COUNT(*) FROM Product WHERE product_name = @product_name"

        If OpenConnection() = True Then
            checkCommand = New SqlCommand(checkSql, connection)
            checkCommand.Parameters.AddWithValue("@product_name", productName)
            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

            ' If count is greater than 0, it means the name already exists
            If count > 0 Then
                isDuplicate = True
            End If

            CloseConnection()
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
        End If

        Return isDuplicate
    End Function
    Public Function GetNextId() As String
        Dim strSql As String
        strSql = "Select * From Product"
        da = New SqlDataAdapter(strSql, connection)
        ds.Clear()
        da.Fill(ds, "Product")
        intCount = ds.Tables("Product").Rows.Count
        Return (intCount + 1).ToString("P1000")
    End Function
    Private Sub btnCreateImage_Click(sender As Object, e As EventArgs) Handles btnCreateImage.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set properties for the file dialog
        openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp"
        openFileDialog.Title = "Select an Image File"

        ' Show the file dialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Set the selected image to the PictureBox
            picCreate.Image = New Bitmap(openFileDialog.FileName)
        End If
    End Sub
    Private Sub btnCreateCancel_Click(sender As Object, e As EventArgs) Handles btnCreateCancel.Click
        ClearText()
        Me.Close()
    End Sub

    Private Sub ClearText()
        picCreate.Image = Nothing
        txtCreateName.Clear()
        txtCreatePrice.Clear()
        txtCreateQuantity.Clear()
        txtCreateDescription.Clear()
        err.Clear()
    End Sub

    Private Function BarCode() As String
        Dim rnd As New Random()
        Dim randomNumber As Integer = rnd.Next(1000, 9999)
        BarCode = GetNextId() & randomNumber
    End Function




    Private Function PictureConversion() As Byte()
        Dim image As Image = picCreate.Image
        If picCreate.Image Is Nothing Then
            ' Use a placeholder image when no image is selected
            picCreate.Image = My.Resources.noImage
            image = picCreate.Image
        End If

        Dim imageData As Byte()
        Using memoryStream As New MemoryStream()
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            imageData = memoryStream.ToArray()
            Return imageData
        End Using

    End Function
End Class