﻿
Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BCrypt.Net.BCrypt
Public Class Form1
    Dim emp As New Employee
    Dim empDAO As New EmployeeDAO
    Dim empRole As New EmployeeRole
    Dim empRoleDAO As New EmployeeRolesDAO
    Dim empRoleMappingDAO As New EmployeeRolesMappingDAO
    Dim defaultPassword As String = "test123"

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        Dim dbCon As New DatabaseConnection
        dbCon.ConnectDB()
        dbCon.CloseDB()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim empID As String
        Dim emproleLevel As String

        refreshEmployeeObject()

        empDAO.AddEmployee(emp)

        refreshEmployeeGrid()

        empID = empRoleMappingDAO.getLatestEmpID
        emproleLevel = cbxTest1.Text.Substring(0, 1)
        empRoleMappingDAO.insertEmployeeRoleMapping(empID, emproleLevel)

        MessageBox.Show(empID & " " & emproleLevel)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDone.Enabled = False
        btnUpdate.Enabled = False

        refreshEmployeeGrid()
        dgvEmployee.Columns(0).ReadOnly = True
        hashPassword(defaultPassword)

        cbxTest1.DataSource = empRoleDAO.selectEmployeeRoles(empRole).Tables("employeeroles")
        cbxTest1.DisplayMember = "roleinfo"
        cbxTest1.ValueMember = "roleinfo"
    End Sub

    Private Sub refreshEmployeeGrid()
        dgvEmployee.DataSource = empDAO.selectAllEmployee(emp).Tables("Employee")
    End Sub

    Private Sub dgvEmployee_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployee.SelectionChanged
        btnUpdate.Enabled = True

        If dgvEmployee.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvEmployee.SelectedRows(0)

            ' Extract data from specific cells (replace column indexes with your own)
            ' Set TextBox values based on the selected row's data
            txtbxID.Text = selectedRow.Cells(0).Value.ToString()
            txtbxFirstName.Text = selectedRow.Cells(1).Value.ToString()
            txtbxLastName.Text = selectedRow.Cells(2).Value.ToString()
            txtbxUserName.Text = selectedRow.Cells(3).Value.ToString()
            txtbxEmail.Text = selectedRow.Cells(4).Value.ToString()
            Select Case selectedRow.Cells(6).Value.ToString()
                Case 1
                    chbxIsActive.Checked = 1
                Case Else
                    chbxIsActive.Checked = 0
            End Select

        End If
    End Sub

    Private Sub dgvEmployee_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellValueChanged
        Dim colName As String
        Dim newValue As String

        colName = dgvEmployee.Columns(dgvEmployee.SelectedCells(0).ColumnIndex).Name
        newValue = dgvEmployee.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
        hashPassword(defaultPassword)
        refreshEmployeeObject()

        empDAO.updateEmployee(emp, colName, newValue)

    End Sub

    Sub refreshEmployeeObject()
        If Not String.IsNullOrEmpty(txtbxID.Text) Then
            emp.id = Integer.Parse(txtbxID.Text.Trim)
        End If
        emp.firstName = txtbxFirstName.Text.Trim
        emp.lastName = txtbxLastName.Text.Trim
        emp.userName = txtbxUserName.Text.Trim
        emp.eMail = txtbxEmail.Text.Trim
        emp.isActive = chbxIsActive.Checked
    End Sub

    Private Sub dgvEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellClick

        Dim i As Integer = 0

        txtbxID.Text = Integer.Parse(dgvEmployee.Rows(e.RowIndex).Cells(i).Value.ToString.Trim)
        i += 1
        txtbxFirstName.Text = dgvEmployee.Rows(e.RowIndex).Cells(i).Value.ToString.Trim
        i += 1
        txtbxLastName.Text = dgvEmployee.Rows(e.RowIndex).Cells(i).Value.ToString.Trim
        i += 1
        txtbxUserName.Text = dgvEmployee.Rows(e.RowIndex).Cells(i).Value.ToString.Trim
        i += 1
        txtbxEmail.Text = dgvEmployee.Rows(e.RowIndex).Cells(i).Value.ToString.Trim
        i += 1
        Select Case dgvEmployee.Rows(e.RowIndex).Cells(i).Value.ToString.Trim
            Case 1
                chbxIsActive.Checked = 1
            Case Else
                chbxIsActive.Checked = 0
        End Select

    End Sub

    Sub hashPassword(password As String)
        Dim salt As String = BCrypt.Net.BCrypt.GenerateSalt()
        Dim passwordToHash As String = salt & password
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(passwordToHash)

        emp.password = hashedPassword
        emp.salt = salt

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnAdd.Enabled = False
        btnTestConnection.Enabled = False
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        btnAdd.Enabled = True
        btnTestConnection.Enabled = True
        btnDone.Enabled = False
        btnUpdate.Enabled = False
    End Sub
End Class
