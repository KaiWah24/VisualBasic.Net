Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports ZXing

Public Class frmInventoryProductDetail
    Friend strProductDetailName As String
    Friend strProductDetailPrice As String
    Friend strProductDetailQuantity As String
    Friend productDetailImage As Image
    Friend strProductDescription As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter

    Private Sub frmInventoryProductDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pattern As String = "\d+(\.\d+)?"
        Dim priceMatch As Match = Regex.Match(strProductDetailPrice, pattern)
        Dim quantityMatch As Match = Regex.Match(strProductDetailQuantity, pattern)

        If priceMatch.Success Then
            Dim number As Decimal ' Change to Decimal for handling decimal numbers
            If Decimal.TryParse(priceMatch.Value, number) Then
                lblProductDetailPrice.Text = number.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY"))
            End If
        End If

        lblProductDetailName.Text = strProductDetailName

        If quantityMatch.Success Then
            Dim number As Integer
            If Integer.TryParse(quantityMatch.Value, number) Then
                lblProductDetailQuantity.Text = number.ToString()
            End If
        End If
        txtProductDetailDescription.Text = strProductDescription
        txtProductDetailDescription.ReadOnly = True
        picProductDetailBarcode.Image = productDetailImage
        picProductDetailBarcode.SizeMode = PictureBoxSizeMode.StretchImage
        grpProductDetail.Location = New Point(1680 \ 5, 1050 \ 20)

    End Sub


    Private Sub btnProductDetailCancel_Click(sender As Object, e As EventArgs) Handles btnProductDetailCancel.Click
        Me.Close()
    End Sub

    Private Sub btnProductDetailDelete_Click(sender As Object, e As EventArgs) Handles btnProductDetailDelete.Click
        Dim barreader As New BarcodeReader
        Dim res = barreader.Decode(CType(picProductDetailBarcode.Image, Bitmap))
        Dim strSql As String


        If OpenConnection() = True Then
            strSql = "Select * From Product"
            da = New SqlDataAdapter(strSql, connection)
            ds.Clear()
            da.Fill(ds, "Product")
            For intI As Integer = 0 To ds.Tables("Product").Rows.Count - 1
                If res.Text = ds.Tables("Product").Rows(intI).Item(7) Then
                    Dim query As String
                    Dim strId As String = ds.Tables("Product").Rows(intI).Item(0)
                    Dim strStatus As String

                    If ds.Tables("Product").Rows(intI).Item(6) = "off shelves" Then
                        strStatus = "on shelves"
                        btnProductDetailDelete.Text = "On Shelves"
                    Else
                        strStatus = "off shelves"
                        btnProductDetailDelete.Text = "Off Shelves"
                    End If

                    query = "Update Product set product_status = @product_status Where product_id=@product_id"
                    Dim cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@product_id", strId)
                    cmd.Parameters.AddWithValue("@product_status", strStatus)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Item has been off shelves", "Successful", MessageBoxButtons.OK)
                    CloseConnection()
                    Me.Close()
                End If
            Next
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnQR_Click(sender As Object, e As EventArgs) Handles btnQR.Click
        If btnQR.Text = "QR Code" Then
            Dim barreader As New BarcodeReader
            Dim res = barreader.Decode(CType(picProductDetailBarcode.Image, Bitmap))
            Dim writer As New BarcodeWriter
            writer.Format = BarcodeFormat.QR_CODE
            picProductDetailQrCode.Image = writer.Write(res.Text)
            picProductDetailQrCode.SizeMode = PictureBoxSizeMode.StretchImage

            picProductDetailBarcode.Visible = False
            picProductDetailQrCode.Visible = True
            btnQR.Text = "Bar Code"

        Else
            picProductDetailQrCode.Visible = False
            picProductDetailBarcode.Visible = True
            btnQR.Text = "QR Code"
        End If
    End Sub

End Class