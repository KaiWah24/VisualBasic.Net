Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class frmInventoryEdit
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private strId As String
    Private lblFrmEditTitle = New Label
    Private Sub frmInventoryEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim intGrpEditWidth As Integer = grpEdit.Width
        Dim intGrpEditHeight As Integer = grpEdit.Height
        Dim intGrpEDitX As Integer = 1680 \ 4
        Dim intGrpEditY As Integer = 1050 \ 9
        Dim strSql As String

        If OpenConnection() = True Then
            Dim strCategory As String = frmInventoryCreate.strCategory
            strSql = "Select * From Product Where product_category = @product_category And product_status = 'on shelves'"
            Dim cmd As New SqlCommand(strSql, connection)
            cmd.Parameters.AddWithValue("@product_category", strCategory)

            da = New SqlDataAdapter(cmd)
            ds.Clear()
            da.Fill(ds, "Product")
            If ds.Tables("Product").Rows.Count > 0 Then
                For intIndexI As Integer = 0 To ds.Tables("Product").Rows.Count - 1
                    cboEdit.Items.Add(ds.Tables("Product").Rows(intIndexI).Item(1))
                Next

                CloseConnection()
            End If
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
        grpEdit.Location = New Point(intGrpEDitX, intGrpEditY)
        With lblFrmEditTitle
            .Text = "Edit Inventory In The Form Below"
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Font = New Font("MV Boli", 14, FontStyle.Bold)
            .ForeColor = Color.Black
            .BackColor = Color.White
        End With
        Me.Controls.Add(lblFrmEditTitle)

    End Sub

    Private Sub btnEditCancel_Click(sender As Object, e As EventArgs) Handles btnEditCancel.Click
        cboEdit.Items.Clear()
        err.Clear()
        Me.Close()
    End Sub
    Private Sub cboEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEdit.SelectedIndexChanged
        Dim strSql As String
        Dim imageData As Byte() = Nothing

        If OpenConnection() = True Then
            Dim strCategory As String = frmInventoryCreate.strCategory
            strSql = "Select * From Product Where product_category = @product_category And product_status = 'on shelves'"
            Dim cmd As New SqlCommand(strSql, connection)
            cmd.Parameters.AddWithValue("@product_category", strCategory)

            da = New SqlDataAdapter(cmd)
            ds.Clear()
            da.Fill(ds, "Product")
            If ds.Tables("Product").Rows.Count > 0 Then
                strId = ds.Tables("Product").Rows(cboEdit.SelectedIndex).Item(0)
                txtEditName.Text = ds.Tables("Product").Rows(cboEdit.SelectedIndex).Item(1)
                txtEditPrice.Text = ds.Tables("Product").Rows(cboEdit.SelectedIndex).Item(2)
                txtEditDescription.Text = ds.Tables("Product").Rows(cboEdit.SelectedIndex).Item(8)
                imageData = ds.Tables("Product").Rows(cboEdit.SelectedIndex).Item(5)
                If imageData IsNot Nothing Then
                    ' Convert byte array to Image
                    Using memoryStream As New MemoryStream(imageData)
                        Dim imageFromDatabase As Image = Image.FromStream(memoryStream)

                        picEdit.Image = imageFromDatabase

                    End Using
                Else
                    MessageBox.Show("No image found for the given condition.")
                End If
                CloseConnection()
            Else
                MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
            End If
        End If

    End Sub
    Private Sub btnEditConfirm_Click(sender As Object, e As EventArgs) Handles btnEditConfirm.Click
        Dim strSql As String
        Dim strDescription As String = txtEditName.Text & "" & ":-" & "" & txtEditDescription.Text
        If Me.ValidateChildren() = False Then
            Return
        End If


        If OpenConnection() = True Then

            strSql = "Update Product set product_name=@product_name,product_price=@product_price,product_image=@product_image,product_description=@product_description Where product_id=@product_id"
            Dim cmd As New SqlCommand(strSql, connection)
            cmd.Parameters.AddWithValue("@product_id", strId)
            cmd.Parameters.AddWithValue("@product_name", txtEditName.Text)
            cmd.Parameters.AddWithValue("@product_price", txtEditPrice.Text)
            cmd.Parameters.AddWithValue("@product_image", PictureConversion(picEdit.Image))
            cmd.Parameters.AddWithValue("@product_description", txtEditDescription.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item has been updated", "Successful", MessageBoxButtons.OK)
            CloseConnection()
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
        End If

        cboEdit.Items.Clear()
        err.Clear()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set properties for the file dialog
        openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp"
        openFileDialog.Title = "Select an Image File"

        ' Show the file dialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Set the selected image to the PictureBox
            picEdit.Image = New Bitmap(openFileDialog.FileName)
        End If
    End Sub



    Private Sub txtEditName_Validating(sender As Object, e As CancelEventArgs) Handles txtEditName.Validating
        Dim strName As String = txtEditName.Text
        If strName = "" Then
            Err.SetError(txtEditName, "Please enter valid [Name]")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtEditPrice_Validating(sender As Object, e As CancelEventArgs) Handles txtEditPrice.Validating
        Dim strPrice As String = txtEditPrice.Text
        If strPrice = "" Then
            err.SetError(txtEditPrice, "Please enter valid [Price]")
            e.Cancel = True
        End If


        If strPrice.All(Function(c) Not Char.IsDigit(c)) Then
            err.SetError(txtEditPrice, "Please enter digit [Price]")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtEditDescription_Validating(sender As Object, e As CancelEventArgs) Handles txtEditDescription.Validating
        Dim strDescription As String = txtEditDescription.Text
        If strDescription = "" Then
            err.SetError(txtEditDescription, "Please enter valid [Description]")
            e.Cancel = True
        End If
    End Sub

    Private Function PictureConversion(bitmapData As Bitmap) As Byte()
        picEdit.Image = New Bitmap(picEdit.Image)
        Dim image As Image = picEdit.Image


        Dim imageData As Byte()
        Using memoryStream As New MemoryStream()
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            imageData = memoryStream.ToArray()
            Return imageData
        End Using
    End Function
End Class