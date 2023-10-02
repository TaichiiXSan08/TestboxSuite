<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtbxFirstName = New TextBox()
        lblFName = New Label()
        lblLName = New Label()
        txtbxLastName = New TextBox()
        lblUserName = New Label()
        txtbxUserName = New TextBox()
        lblEmail = New Label()
        txtbxEmail = New TextBox()
        chbxIsActive = New CheckBox()
        lblAccessLevel = New Label()
        dgvEmployee = New DataGridView()
        DatabaseConnectionBindingSource = New BindingSource(components)
        btnTestConnection = New Button()
        btnAdd = New Button()
        DatabaseConnectionBindingSource1 = New BindingSource(components)
        btnUpdate = New Button()
        lblID = New Label()
        txtbxID = New TextBox()
        cbxTest1 = New ComboBox()
        btnDone = New Button()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(DatabaseConnectionBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(DatabaseConnectionBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtbxFirstName
        ' 
        txtbxFirstName.Location = New Point(176, 55)
        txtbxFirstName.Name = "txtbxFirstName"
        txtbxFirstName.Size = New Size(242, 27)
        txtbxFirstName.TabIndex = 0
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.Location = New Point(69, 55)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(80, 20)
        lblFName.TabIndex = 1
        lblFName.Text = "First Name"
        ' 
        ' lblLName
        ' 
        lblLName.AutoSize = True
        lblLName.Location = New Point(69, 106)
        lblLName.Name = "lblLName"
        lblLName.Size = New Size(79, 20)
        lblLName.TabIndex = 3
        lblLName.Text = "Last Name"
        ' 
        ' txtbxLastName
        ' 
        txtbxLastName.Location = New Point(176, 106)
        txtbxLastName.Name = "txtbxLastName"
        txtbxLastName.Size = New Size(242, 27)
        txtbxLastName.TabIndex = 2
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(69, 157)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(82, 20)
        lblUserName.TabIndex = 5
        lblUserName.Text = "User Name"
        ' 
        ' txtbxUserName
        ' 
        txtbxUserName.Location = New Point(176, 157)
        txtbxUserName.Name = "txtbxUserName"
        txtbxUserName.Size = New Size(242, 27)
        txtbxUserName.TabIndex = 4
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(66, 209)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email"
        ' 
        ' txtbxEmail
        ' 
        txtbxEmail.Location = New Point(173, 209)
        txtbxEmail.Name = "txtbxEmail"
        txtbxEmail.Size = New Size(242, 27)
        txtbxEmail.TabIndex = 6
        ' 
        ' chbxIsActive
        ' 
        chbxIsActive.AutoSize = True
        chbxIsActive.Location = New Point(173, 242)
        chbxIsActive.Name = "chbxIsActive"
        chbxIsActive.Size = New Size(72, 24)
        chbxIsActive.TabIndex = 9
        chbxIsActive.Text = "Active"
        chbxIsActive.UseVisualStyleBackColor = True
        ' 
        ' lblAccessLevel
        ' 
        lblAccessLevel.AutoSize = True
        lblAccessLevel.Location = New Point(500, 55)
        lblAccessLevel.Name = "lblAccessLevel"
        lblAccessLevel.Size = New Size(91, 20)
        lblAccessLevel.TabIndex = 14
        lblAccessLevel.Text = "Access Level"
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.AllowUserToAddRows = False
        dgvEmployee.AllowUserToDeleteRows = False
        dgvEmployee.BackgroundColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployee.Location = New Point(56, 289)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.RowHeadersWidth = 51
        dgvEmployee.RowTemplate.Height = 29
        dgvEmployee.Size = New Size(890, 262)
        dgvEmployee.TabIndex = 16
        ' 
        ' DatabaseConnectionBindingSource
        ' 
        DatabaseConnectionBindingSource.DataSource = GetType(DatabaseConnection)
        ' 
        ' btnTestConnection
        ' 
        btnTestConnection.Location = New Point(595, 97)
        btnTestConnection.Name = "btnTestConnection"
        btnTestConnection.Size = New Size(175, 29)
        btnTestConnection.TabIndex = 17
        btnTestConnection.Text = "TestConnection"
        btnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(595, 132)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(175, 29)
        btnAdd.TabIndex = 18
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' DatabaseConnectionBindingSource1
        ' 
        DatabaseConnectionBindingSource1.DataSource = GetType(DatabaseConnection)
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(595, 167)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(175, 29)
        btnUpdate.TabIndex = 19
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(69, 22)
        lblID.Name = "lblID"
        lblID.Size = New Size(24, 20)
        lblID.TabIndex = 21
        lblID.Text = "ID"
        ' 
        ' txtbxID
        ' 
        txtbxID.Enabled = False
        txtbxID.Location = New Point(176, 22)
        txtbxID.Name = "txtbxID"
        txtbxID.Size = New Size(242, 27)
        txtbxID.TabIndex = 20
        ' 
        ' cbxTest1
        ' 
        cbxTest1.FormattingEnabled = True
        cbxTest1.Location = New Point(619, 54)
        cbxTest1.Name = "cbxTest1"
        cbxTest1.Size = New Size(151, 28)
        cbxTest1.TabIndex = 22
        ' 
        ' btnDone
        ' 
        btnDone.Location = New Point(595, 202)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(175, 29)
        btnDone.TabIndex = 23
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(997, 739)
        Controls.Add(btnDone)
        Controls.Add(cbxTest1)
        Controls.Add(lblID)
        Controls.Add(txtbxID)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(btnTestConnection)
        Controls.Add(dgvEmployee)
        Controls.Add(lblAccessLevel)
        Controls.Add(chbxIsActive)
        Controls.Add(lblEmail)
        Controls.Add(txtbxEmail)
        Controls.Add(lblUserName)
        Controls.Add(txtbxUserName)
        Controls.Add(lblLName)
        Controls.Add(txtbxLastName)
        Controls.Add(lblFName)
        Controls.Add(txtbxFirstName)
        Name = "Form1"
        Text = "Form1"
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        CType(DatabaseConnectionBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(DatabaseConnectionBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbxFirstName As TextBox
    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents txtbxLastName As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtbxUserName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents chbxIsActive As CheckBox
    Friend WithEvents lblAccessLevel As Label
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents btnTestConnection As Button
    Friend WithEvents DatabaseConnectionBindingSource As BindingSource
    Friend WithEvents btnAdd As Button
    Friend WithEvents DatabaseConnectionBindingSource1 As BindingSource
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblID As Label
    Friend WithEvents txtbxID As TextBox
    Friend WithEvents cbxTest1 As ComboBox
    Friend WithEvents btnDone As Button
End Class
