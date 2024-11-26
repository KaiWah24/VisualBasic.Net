Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions

Public Class roleAccess
    Private selectedRowIndex As Integer = -1
    Private strRoleName As String
    Private strRootUser As String
    Private strGeneralUser As String


    Private Sub roleAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboRoleData(cboRole)
        RefreshRoleAccessData()

        With dgvRole
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 36, 66)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        End With

        With dgvRootAccess
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 36, 66)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        End With

        With dgvGeneralAccess
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 36, 66)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        End With

    End Sub


    'Create role
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim format As String = "^[a-zA-Z\s]+$"
        Dim reName As New Regex(format)

        If String.IsNullOrEmpty(txtStaffRole.Text) Then
            err.AppendLine("-Role name is empty")
            ctr = If(ctr, txtStaffRole)

        ElseIf Not reName.IsMatch(txtStaffRole.Text) Then
            err.AppendLine("-Role name must be Characters.")
            ctr = If(ctr, txtStaffRole)
        End If

        If String.IsNullOrEmpty(txtStaffRoleDesc.Text) Then
            err.AppendLine("-Role description is empty")
            ctr = If(ctr, txtStaffRole)
        ElseIf Not reName.IsMatch(txtStaffRoleDesc.Text) Then
            err.AppendLine("-Role description must be Characters.")
            ctr = If(ctr, txtStaffRole)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            Dim strSql As String
            Dim MySqlCommand As New SqlCommand
            strSql = "INSERT INTO RoleAccess (role_name, role_description, access_type) VALUES (@role_name,@role_description, @access_type)"

            errRoleName.Clear()
            OpenConnection()
            MySqlCommand = New SqlCommand(strSql, connection)
            With MySqlCommand.Parameters
                .AddWithValue("@role_name", txtStaffRole.Text)
                .AddWithValue("@role_description", txtStaffRoleDesc.Text)
                .AddWithValue("@access_type", "Guest_Access")
            End With

            MySqlCommand.ExecuteNonQuery()
            MessageBox.Show("Role Added.", "Add role", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboRoleData(cboRole)
            CloseConnection()

            With txtStaffRole
                .Text = ""
                .Focus()
            End With
            txtStaffRoleDesc.Text = ""

            RefreshRoleAccessData()

        End If



    End Sub


    'delete role
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If strRoleName IsNot Nothing Then
            If strRoleName = "SUPER_ADMIN" Then
                MessageBox.Show("You cannot remove the SUPER_ADMIN role.", "Role deletion unsuccessful.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim strSql As String = "DELETE FROM RoleAccess WHERE role_name = @role_name"
                OpenConnection()

                Using MySqlCommand As New SqlCommand(strSql, connection)
                    MySqlCommand.Parameters.AddWithValue("@role_name", strRoleName)
                    MySqlCommand.ExecuteNonQuery()
                End Using

                CloseConnection()

                MessageBox.Show("Role Deleted.", "Delete Role")

                ' Refresh the DataGridView after deletion
                RefreshRoleAccessData()
                cboRoleData(cboRole)

            End If
        Else
            MessageBox.Show("Please select a row", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub




    'manage access
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        If cboRole.SelectedIndex = -1 Then
            err.AppendLine("-select one role")
            ctr = If(ctr, cboRole)
        End If

        If radGeneralAccess.Checked = False And radRootAccess.Checked = False Then
            err.AppendLine("-select one access type")
            ctr = If(ctr, cboRole)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            updateRole()
            RefreshRoleAccessData()
            cboRole.SelectedIndex = -1
            radRootAccess.Checked = False
            radGeneralAccess.Checked = False
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim strUser As String
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = "UPDATE RoleAccess set access_type = @access_type WHERE role_name = @role_name"

        If strRootUser IsNot Nothing AndAlso strGeneralUser IsNot Nothing Then
            If strRootUser = "SUPER_ADMIN" Then
                MessageBox.Show("You cannot remove the SUPER_ADMIN access", "Remove Access Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                If strGeneralUser IsNot Nothing Then
                    strUser = strGeneralUser
                Else
                    strUser = strRootUser
                End If

                OpenConnection()
                MySqlCommand = New SqlCommand(strSql, connection)
                With MySqlCommand.Parameters
                    .AddWithValue("@access_type", "Guest_Access")
                    .AddWithValue("@role_name", strUser)
                End With
                MySqlCommand.ExecuteNonQuery()
                MessageBox.Show("Access Updated.", "Update Access")
                CloseConnection()

                ' Refresh the DataGridView after deletion
                RefreshRoleAccessData()
            End If
        Else
            MessageBox.Show("Please select a row", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    'function
    Private Sub updateRole()
        Dim strAccessType As String

        If radRootAccess.Checked = True Then
            strAccessType = "Root_Access"
        Else
            strAccessType = "General_Access"
        End If

        Dim strSql As String = "UPDATE RoleAccess SET access_type = @access_type WHERE role_name = @role_name"
        Dim MySqlCommand As New SqlCommand

        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        With MySqlCommand.Parameters
            .AddWithValue("@access_type", strAccessType)
            .AddWithValue("@role_name", cboRole.SelectedItem.ToString)
        End With
        MySqlCommand.ExecuteNonQuery()
        MessageBox.Show("Access Updated.", "Update Access")

        CloseConnection()

    End Sub



    'Refresh Data
    Sub RefreshRoleAccessData()
        ' Refresh the DataGridView with updated data
        Dim daManageRole As New SqlDataAdapter("SELECT role_name, role_description FROM RoleAccess ORDER BY role_name DESC;", connection)
        Dim dtManageRole As New DataTable
        daManageRole.Fill(dtManageRole)
        dgvRole.DataSource = dtManageRole
        dtManageRole.DefaultView.AllowEdit = False

        Dim daRootAccess As New SqlDataAdapter("SELECT role_name FROM RoleAccess WHERE access_type = 'Root_Access' ORDER BY role_name DESC;", connection)
        Dim dtRootAccess As New DataTable
        daRootAccess.Fill(dtRootAccess)
        dgvRootAccess.DataSource = dtRootAccess

        Dim daGenralAccess As New SqlDataAdapter("SELECT role_name FROM RoleAccess WHERE access_type = 'General_Access' ORDER BY role_name DESC;", connection)
        Dim dtGeneralAccess As New DataTable
        daGenralAccess.Fill(dtGeneralAccess)
        dgvGeneralAccess.DataSource = dtGeneralAccess

    End Sub


    Private Sub dgvRole_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRole.CellClick
        ' Reset the back color of the previously selected row
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < dgvRole.Rows.Count Then
            dgvRole.Rows(selectedRowIndex).DefaultCellStyle.BackColor = dgvRole.DefaultCellStyle.BackColor
        End If

        ' Set the back color of the clicked row to blue
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvRole.Rows.Count Then
            selectedRowIndex = e.RowIndex
            dgvRole.Rows(selectedRowIndex).DefaultCellStyle.BackColor = SystemColors.Highlight
            strRoleName = dgvRole.Rows(selectedRowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub dgvRootAccess_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRootAccess.CellClick
        ' Reset the back color of the previously selected row
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < dgvRootAccess.Rows.Count Then
            dgvRootAccess.Rows(selectedRowIndex).DefaultCellStyle.BackColor = dgvRole.DefaultCellStyle.BackColor
        End If

        ' Set the back color of the clicked row to blue
        If e.RowIndex >= 0 < dgvRootAccess.Rows.Count Then
            selectedRowIndex = e.RowIndex
            dgvRootAccess.Rows(selectedRowIndex).DefaultCellStyle.BackColor = SystemColors.Highlight
            strRootUser = dgvRootAccess.Rows(selectedRowIndex).Cells(0).Value

        End If
    End Sub
    Private Sub dgvGeneralAccess_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGeneralAccess.CellClick
        ' Reset the back color of the previously selected row
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < dgvGeneralAccess.Rows.Count Then
            dgvGeneralAccess.Rows(selectedRowIndex).DefaultCellStyle.BackColor = dgvRole.DefaultCellStyle.BackColor
        End If

        ' Set the back color of the clicked row to blue
        If e.RowIndex >= 0 < dgvGeneralAccess.Rows.Count Then
            selectedRowIndex = e.RowIndex
            dgvGeneralAccess.Rows(selectedRowIndex).DefaultCellStyle.BackColor = SystemColors.Highlight
            strGeneralUser = dgvGeneralAccess.Rows(selectedRowIndex).Cells(0).Value

        End If
    End Sub


    Sub cboRoleData(cboRole As ComboBox)
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
                    cboRole.Items.Clear()

                    ' Loop through the result set and add each item to the ComboBox
                    While reader.Read()
                        ' Assuming the column index is 0; adjust as needed
                        Dim itemName As String = reader.GetString(0)
                        cboRole.Items.Add(itemName)
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

End Class