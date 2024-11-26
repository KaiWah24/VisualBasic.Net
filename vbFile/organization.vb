Imports System.Data.SqlClient

Public Class organization
    Friend intSelectedStaff As Integer
    Private selectedRowIndex As Integer = -1

    Private Sub organization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getCboPositionData()
        RefreshAllStaffData()
        With dgvAllStaff
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 36, 66)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        End With


    End Sub


    Sub getCboPositionData()

        Try
            ' Open the database connection
            OpenConnection()

            ' Define the SQL query to retrieve data from the database
            Dim query As String = "SELECT role_name FROM RoleAccess"

            ' Create a SqlCommand object
            Using command As New SqlCommand(query, connection)
                ' Create a SqlDataReader to read the data
                Using reader As SqlDataReader = command.ExecuteReader()
                    ' Clear existing items in the ComboBox
                    cboPosition.Items.Clear()

                    ' Loop through the result set and add each item to the ComboBox
                    While reader.Read()
                        ' Assuming the column index is 0; adjust as needed
                        Dim itemName As String = reader.GetString(0)
                        cboPosition.Items.Add(itemName)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            CloseConnection()
        End Try
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        addStaff.ShowDialog()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim strSql As String = "SELECT staff_id, staff_name, staff_status, staff_position FROM Staff WHERE staff_id LIKE @staff_id + '%' OR staff_name LIKE @staff_name + '%' OR staff_status = @staff_status OR staff_position = @staff_position"

            OpenConnection()

            Using MySqlCommand As New SqlCommand(strSql, connection)
                With MySqlCommand.Parameters
                    ' Add parameters with values based on user input or DBNull.Value if the input is Nothing or empty
                    .AddWithValue("@staff_id", If(Not String.IsNullOrEmpty(txtStaffID.Text), txtStaffID.Text, DBNull.Value))
                    .AddWithValue("@staff_name", If(Not String.IsNullOrEmpty(txtStaffName.Text), txtStaffName.Text, DBNull.Value))
                    .AddWithValue("@staff_status", If(cboStaffStatus.SelectedItem IsNot Nothing, cboStaffStatus.SelectedItem.ToString(), DBNull.Value))
                    .AddWithValue("@staff_position", If(cboPosition.SelectedItem IsNot Nothing, cboPosition.SelectedItem.ToString(), DBNull.Value))
                End With

                Dim adapter As New SqlDataAdapter(MySqlCommand)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvAllStaff.DataSource = table
                Dim totalCount As Integer = table.Rows.Count
                lblTotalStaff.Text = "Total staff : " & totalCount.ToString()
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        With txtStaffID
            .Text = ""
            .Focus()
        End With

        txtStaffName.Text = ""
        cboStaffStatus.SelectedIndex = -1
        cboPosition.SelectedIndex = -1
        RefreshAllStaffData()

    End Sub

    Private Sub dgvAllStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAllStaff.CellClick
        ' Reset the back color of the previously selected row
        If selectedRowIndex >= 0 Then
            dgvAllStaff.Rows(selectedRowIndex).DefaultCellStyle.BackColor = dgvAllStaff.DefaultCellStyle.BackColor
        End If

        ' Set the back color of the clicked row to blue
        If e.RowIndex >= 0 Then
            selectedRowIndex = e.RowIndex
            dgvAllStaff.Rows(selectedRowIndex).DefaultCellStyle.BackColor = SystemColors.Highlight

        End If
    End Sub

    Private Sub dgvAllStaff_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAllStaff.CellDoubleClick
        If selectedRowIndex >= 0 Then
            ' Handle the double-click action with the selected row index
            intSelectedStaff = Convert.ToInt32(dgvAllStaff.Rows(selectedRowIndex).Cells(0).Value)
            editStaff.ShowDialog()
            dgvAllStaff.DataSource = GetStaffData()
            RefreshAllStaffData()
        End If
    End Sub

    Private Function GetStaffData() As DataTable
        Dim strSql As String = "SELECT * FROM Staff"
        OpenConnection()

        Dim MySqlCommand As New SqlCommand(strSql, connection)
        Dim allStaffDA As New SqlDataAdapter(MySqlCommand)
        Dim allStaffDT As New DataTable()

        allStaffDA.Fill(allStaffDT)
        Dim totalCount As Integer = allStaffDT.Rows.Count
        lblTotalStaff.Text = "Total staff : " & totalCount.ToString()
        CloseConnection()

        Return allStaffDT
    End Function

    Sub RefreshAllStaffData()
        Dim daAllStaff As New SqlDataAdapter("SELECT staff_id, staff_name, staff_position,staff_status FROM Staff", connection)
        Dim dtAllStaff As New DataTable
        daAllStaff.Fill(dtAllStaff)
        dgvAllStaff.DataSource = dtAllStaff
        Dim totalCount As Integer = dtAllStaff.Rows.Count
        lblTotalStaff.Text = "Total staff : " & totalCount.ToString()

    End Sub




End Class