<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestCaseCreation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvTestCase = New DataGridView()
        btnSave = New Button()
        btnClose = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        cbxTemplate = New ComboBox()
        btnExport = New Button()
        CType(dgvTestCase, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTestCase
        ' 
        dgvTestCase.BorderStyle = BorderStyle.Fixed3D
        dgvTestCase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTestCase.Location = New Point(12, 169)
        dgvTestCase.Name = "dgvTestCase"
        dgvTestCase.RowHeadersWidth = 51
        dgvTestCase.RowTemplate.Height = 29
        dgvTestCase.Size = New Size(984, 315)
        dgvTestCase.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(195, 502)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(335, 502)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 20)
        Label1.TabIndex = 3
        Label1.Text = "TestCase Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(153, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(228, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(153, 54)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(228, 27)
        TextBox2.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 5
        Label2.Text = "Project"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(598, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 7
        Label3.Text = "Template"
        ' 
        ' cbxTemplate
        ' 
        cbxTemplate.FormattingEnabled = True
        cbxTemplate.Location = New Point(675, 18)
        cbxTemplate.Name = "cbxTemplate"
        cbxTemplate.Size = New Size(321, 28)
        cbxTemplate.TabIndex = 8
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(493, 502)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(94, 29)
        btnExport.TabIndex = 9
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' TestCaseCreation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1008, 551)
        Controls.Add(btnExport)
        Controls.Add(cbxTemplate)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(dgvTestCase)
        Name = "TestCaseCreation"
        Text = "TestCaseCreation"
        CType(dgvTestCase, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTestCase As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxTemplate As ComboBox
    Friend WithEvents btnExport As Button
End Class
