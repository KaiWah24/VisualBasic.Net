Imports System.Data.SqlClient

Module Helper
    Public connection As New System.Data.SqlClient.SqlConnection
    Public connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Pos.mdf;Integrated Security=True"

    Friend strValidCustomerId As String = ""


    Public Function OpenConnection() As Boolean

        Try
            connection.ConnectionString = connectionString
            connection.Open()
            Return True
            Console.WriteLine("Connection opened successfully.")
        Catch ex As Exception
            Console.WriteLine("Error opening connection: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function CloseConnection() As Boolean
        Try
            ' Close the database connection
            connection.Close()
            Return True
            Console.WriteLine("Connection closed successfully.")
        Catch ex As Exception
            Console.WriteLine("Error closing connection: " & ex.Message)
            Return False
        End Try
    End Function


    Public Function ValidateNumericInput(strInput As String) As Boolean
        Dim decNumericValue As Decimal
        strInput = strInput.Trim()

        If Not Decimal.TryParse(strInput, decNumericValue) Then
            Return False
        End If

        Return True
    End Function

    'fix this decRounded for lblRounding.Text
    Function RoundToNearestSen(amount As Decimal, ByRef decRounded As Decimal) As Decimal
        ' Check the last digit to determine rounding direction
        Dim lastDigit As Integer = CInt(amount * 100) Mod 10
        ' Rounding logic based on guidelines
        If lastDigit = 1 OrElse lastDigit = 2 OrElse lastDigit = 6 OrElse lastDigit = 7 Then
            decRounded = Math.Abs(amount - Math.Floor(amount * 20) / 20)

            ' Round down to the nearest multiple of 5 sen
            Return Math.Floor(amount * 20) / 20
        ElseIf lastDigit = 3 OrElse lastDigit = 4 OrElse lastDigit = 8 OrElse lastDigit = 9 Then
            decRounded = Math.Abs(amount - Math.Ceiling(amount * 20) / 20)

            ' Round up to the nearest multiple of 5 sen
            Return Math.Ceiling(amount * 20) / 20
        Else
            ' No rounding needed
            Return amount
        End If
    End Function


    Public Function GetValidCustomerId() As String
        Return strValidCustomerId
    End Function

    Public Sub SetValidCustomerId(strCustomerId As String)
        strValidCustomerId = strCustomerId
    End Sub

    Public Sub GetErrorMessage(strErrIndicator As String)
        Select Case strErrIndicator
            Case "INVALID ROW SELECTED"
                MessageBox.Show("Invalid row selected, please select valid row and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case Else
                MessageBox.Show("Unknown error occurred.", "Error")
        End Select
    End Sub


    Public Sub UpdateCustomerTier(strCustomerId As String)

        OpenConnection()
        Dim query As String = "UPDATE Customer SET customer_tier = " &
                   "CASE " &
                   "   WHEN total_points_redeem>= 500 AND customer_points <= 749 THEN 'Standard Tier' " &
                   "   WHEN total_points_redeem >= 750 AND customer_points <= 1250 THEN 'Silver Tier' " &
                   "   WHEN total_points_redeem>= 1251 AND customer_points <= 3500 THEN 'Gold Tier' " &
                   "   WHEN total_points_redeem>= 3001 AND customer_points <= 5999 THEN 'Platinum Tier' " &
                   "   WHEN total_points_redeem> 10000 THEN 'Diamond Tier' " & "WHERE customer_id = @Value1" &
                   "END"

        Using command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Value1", strCustomerId)
            command.ExecuteNonQuery()
        End Using
    End Sub
End Module
