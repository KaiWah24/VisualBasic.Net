Module Module1
    Friend Sub grpFreshProduce_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked GroupBox
        Dim clickedGroupBox As GroupBox = DirectCast(sender, GroupBox)

        ' Access the labels within the clicked GroupBox
        Dim productName As String = ""
        Dim price As String = ""
        Dim quantity As String = ""
        Dim description As String = ""
        Dim barcode As Image = Nothing
        ' Check if the GroupBox contains enough controls
        If clickedGroupBox.Controls.Count >= 6 Then
            ' Retrieve label texts by index assuming the order is Name, Price, Quantity
            productName = DirectCast(clickedGroupBox.Controls(0), Label).Text
            price = DirectCast(clickedGroupBox.Controls(1), Label).Text
            quantity = DirectCast(clickedGroupBox.Controls(2), Label).Text
            description = DirectCast(clickedGroupBox.Controls(5), Label).Text
            barcode = DirectCast(clickedGroupBox.Controls(4), PictureBox).Image
        End If

        ' Pass the data to the detail form
        frmInventoryProductDetail.strProductDetailName = productName
        frmInventoryProductDetail.strProductDetailPrice = price
        frmInventoryProductDetail.strProductDetailQuantity = quantity
        frmInventoryProductDetail.strProductDescription = description
        frmInventoryProductDetail.productDetailImage = barcode
        ' Show the detail form
        frmInventoryProductDetail.ShowDialog()
    End Sub

    Friend Sub grpOther_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked GroupBox
        Dim clickedGroupBox As GroupBox = DirectCast(sender, GroupBox)

        ' Access the labels within the clicked GroupBox
        Dim productName As String = ""
        Dim price As String = ""
        Dim quantity As String = ""
        Dim description As String = ""
        Dim barcode As Image = Nothing
        ' Check if the GroupBox contains enough controls
        If clickedGroupBox.Controls.Count >= 6 Then
            ' Retrieve label texts by index assuming the order is Name, Price, Quantity
            productName = DirectCast(clickedGroupBox.Controls(0), Label).Text
            price = DirectCast(clickedGroupBox.Controls(1), Label).Text
            quantity = DirectCast(clickedGroupBox.Controls(2), Label).Text
            description = DirectCast(clickedGroupBox.Controls(5), Label).Text
            barcode = DirectCast(clickedGroupBox.Controls(4), PictureBox).Image
        End If

        ' Pass the data to the detail form
        frmInventoryProductDetail.strProductDetailName = productName
        frmInventoryProductDetail.strProductDetailPrice = price
        frmInventoryProductDetail.strProductDetailQuantity = quantity
        frmInventoryProductDetail.strProductDescription = description
        frmInventoryProductDetail.productDetailImage = barcode
        ' Show the detail form
        frmInventoryProductDetail.ShowDialog()
    End Sub
    Friend Sub grpBeverage_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked GroupBox
        Dim clickedGroupBox As GroupBox = DirectCast(sender, GroupBox)

        ' Access the labels within the clicked GroupBox
        Dim productName As String = ""
        Dim price As String = ""
        Dim quantity As String = ""
        Dim description As String = ""
        Dim barcode As Image = Nothing
        ' Check if the GroupBox contains enough controls
        If clickedGroupBox.Controls.Count >= 6 Then
            ' Retrieve label texts by index assuming the order is Name, Price, Quantity
            productName = DirectCast(clickedGroupBox.Controls(0), Label).Text
            price = DirectCast(clickedGroupBox.Controls(1), Label).Text
            quantity = DirectCast(clickedGroupBox.Controls(2), Label).Text
            description = DirectCast(clickedGroupBox.Controls(5), Label).Text
            barcode = DirectCast(clickedGroupBox.Controls(4), PictureBox).Image
        End If

        ' Pass the data to the detail form
        frmInventoryProductDetail.strProductDetailName = productName
        frmInventoryProductDetail.strProductDetailPrice = price
        frmInventoryProductDetail.strProductDetailQuantity = quantity
        frmInventoryProductDetail.strProductDescription = description
        frmInventoryProductDetail.productDetailImage = barcode
        ' Show the detail form
        frmInventoryProductDetail.ShowDialog()
    End Sub

    Friend Sub grpAllItem_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked GroupBox
        Dim clickedGroupBox As GroupBox = DirectCast(sender, GroupBox)

        ' Access the labels within the clicked GroupBox
        Dim productName As String = ""
        Dim price As String = ""
        Dim quantity As String = ""
        Dim description As String = ""
        Dim barcode As Image = Nothing
        ' Check if the GroupBox contains enough controls
        If clickedGroupBox.Controls.Count >= 6 Then
            ' Retrieve label texts by index assuming the order is Name, Price, Quantity
            productName = DirectCast(clickedGroupBox.Controls(0), Label).Text
            price = DirectCast(clickedGroupBox.Controls(1), Label).Text
            quantity = DirectCast(clickedGroupBox.Controls(2), Label).Text
            description = DirectCast(clickedGroupBox.Controls(5), Label).Text
            barcode = DirectCast(clickedGroupBox.Controls(4), PictureBox).Image
        End If

        ' Pass the data to the detail form
        frmInventoryProductDetail.strProductDetailName = productName
        frmInventoryProductDetail.strProductDetailPrice = price
        frmInventoryProductDetail.strProductDetailQuantity = quantity
        frmInventoryProductDetail.strProductDescription = description
        frmInventoryProductDetail.productDetailImage = barcode
        ' Show the detail form
        frmInventoryProductDetail.ShowDialog()
    End Sub

    Friend Sub grpFreshFruit_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked GroupBox
        Dim clickedGroupBox As GroupBox = DirectCast(sender, GroupBox)

        ' Access the labels within the clicked GroupBox
        Dim productName As String = ""
        Dim price As String = ""
        Dim quantity As String = ""
        Dim description As String = ""
        Dim barcode As Image = Nothing
        ' Check if the GroupBox contains enough controls
        If clickedGroupBox.Controls.Count >= 6 Then
            ' Retrieve label texts by index assuming the order is Name, Price, Quantity
            productName = DirectCast(clickedGroupBox.Controls(0), Label).Text
            price = DirectCast(clickedGroupBox.Controls(1), Label).Text
            quantity = DirectCast(clickedGroupBox.Controls(2), Label).Text
            description = DirectCast(clickedGroupBox.Controls(5), Label).Text
            barcode = DirectCast(clickedGroupBox.Controls(4), PictureBox).Image
        End If

        ' Pass the data to the detail form
        frmInventoryProductDetail.strProductDetailName = productName
        frmInventoryProductDetail.strProductDetailPrice = price
        frmInventoryProductDetail.strProductDetailQuantity = quantity
        frmInventoryProductDetail.strProductDescription = description
        frmInventoryProductDetail.productDetailImage = barcode
        ' Show the detail form
        frmInventoryProductDetail.ShowDialog()
    End Sub

    Friend Sub grpFrozenMeat_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked GroupBox
        Dim clickedGroupBox As GroupBox = DirectCast(sender, GroupBox)

        ' Access the labels within the clicked GroupBox
        Dim productName As String = ""
        Dim price As String = ""
        Dim quantity As String = ""
        Dim description As String = ""
        Dim barcode As Image = Nothing
        ' Check if the GroupBox contains enough controls
        If clickedGroupBox.Controls.Count >= 6 Then
            ' Retrieve label texts by index assuming the order is Name, Price, Quantity
            productName = DirectCast(clickedGroupBox.Controls(0), Label).Text
            price = DirectCast(clickedGroupBox.Controls(1), Label).Text
            quantity = DirectCast(clickedGroupBox.Controls(2), Label).Text
            description = DirectCast(clickedGroupBox.Controls(5), Label).Text
            barcode = DirectCast(clickedGroupBox.Controls(4), PictureBox).Image
        End If

        ' Pass the data to the detail form
        frmInventoryProductDetail.strProductDetailName = productName
        frmInventoryProductDetail.strProductDetailPrice = price
        frmInventoryProductDetail.strProductDetailQuantity = quantity
        frmInventoryProductDetail.strProductDescription = description
        frmInventoryProductDetail.productDetailImage = barcode
        ' Show the detail form
        frmInventoryProductDetail.ShowDialog()
    End Sub

    Friend Sub grpFrozenSeafood_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked GroupBox
        Dim clickedGroupBox As GroupBox = DirectCast(sender, GroupBox)

        ' Access the labels within the clicked GroupBox
        Dim productName As String = ""
        Dim price As String = ""
        Dim quantity As String = ""
        Dim description As String = ""
        Dim barcode As Image = Nothing
        ' Check if the GroupBox contains enough controls
        If clickedGroupBox.Controls.Count >= 6 Then
            ' Retrieve label texts by index assuming the order is Name, Price, Quantity
            productName = DirectCast(clickedGroupBox.Controls(0), Label).Text
            price = DirectCast(clickedGroupBox.Controls(1), Label).Text
            quantity = DirectCast(clickedGroupBox.Controls(2), Label).Text
            description = DirectCast(clickedGroupBox.Controls(5), Label).Text
            barcode = DirectCast(clickedGroupBox.Controls(4), PictureBox).Image
        End If

        ' Pass the data to the detail form
        frmInventoryProductDetail.strProductDetailName = productName
        frmInventoryProductDetail.strProductDetailPrice = price
        frmInventoryProductDetail.strProductDetailQuantity = quantity
        frmInventoryProductDetail.strProductDescription = description
        frmInventoryProductDetail.productDetailImage = barcode
        ' Show the detail form
        frmInventoryProductDetail.ShowDialog()
    End Sub


End Module
