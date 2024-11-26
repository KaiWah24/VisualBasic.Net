Public Class customerDetails
    Private Sub customerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If customerMenu.strCurrentGender.ToString = "Male" Then
            PictureBox1.Image = My.Resources.Male_icon
        ElseIf customerMenu.strCurrentGender.ToString = "Female" Then
            PictureBox1.Image = My.Resources.Female_icon
        End If

        lblCustomerID.Text = customerMenu.strCurrentCustID.ToString()
        lblName.Text = customerMenu.strCurrentName.ToString()
        lblTierlevel.Text = customerMenu.strCurrentTier.ToString()
        lblCurrentStatus.Text = customerMenu.strCurrentCustStatus.ToString()
        lblDateofJoined.Text = customerMenu.strCurrentDateJoined.ToString()
        lblEmail.Text = customerMenu.strCurrentEmail.ToString()
        lblGender.Text = customerMenu.strCurrentGender.ToString()
        lblPhoneNumber.Text = customerMenu.strCurrentPhone.ToString()
        lblDOB.Text = customerMenu.strCurrentDateOfBirth.ToString()
        lblAge.Text = customerMenu.strCurrentAge.ToString()
        lblCurrentAdd.Text = customerMenu.strCurrentCaddress.ToString()
        lblPermanentAdd.Text = customerMenu.strCurrentPaddress.ToString()
        lblPoints.Text = customerMenu.strCurrentPoints.ToString()


    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Customer.lblCustAdd.Show()
    End Sub
    ' Other code in the ViewDetailsForm class...

    ' Add a constructor that accepts customerId as a parameter
    ' Other code in the ViewDetailsForm class...
End Class
