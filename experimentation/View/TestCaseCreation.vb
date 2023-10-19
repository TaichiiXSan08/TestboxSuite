Public Class TestCaseCreation
    Dim templateDAO As New TemplateDAO
    Dim template As New Template
    Dim projectDAO As New ProjectDAO
    Dim project As New Project


    Private Sub TestCaseCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate template dropdown
        cbxTemplate.DataSource = templateDAO.selectTemplateNames.Tables("templates")
        cbxTemplate.ValueMember = "templatename"
        cbxTemplate.DisplayMember = "templatename"

        'set properties of template obj based on selected template.
        If cbxTemplate.Items.Count > 0 Then
            cbxTemplate.SelectedItem = cbxTemplate.Items(0)
            template.templateName = cbxTemplate.SelectedValue
            template = templateDAO.selectTemplateByName(template)
        End If


        'populate the grid initially with columns from the chosen template
        dgvTestCase.DataSource = templateDAO.selectFieldsOfTemplate(template).tables("testcasefields")
        dgvTestCase.Refresh()

        'populate project textfield
        project = projectDAO.selectSpecficProjectByProjectName(Login.currentUser.projDetails)
        txtbxProject.Text = project.projectname


    End Sub

    Private Sub dgvTestCase_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTestCase.CellValueChanged
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class