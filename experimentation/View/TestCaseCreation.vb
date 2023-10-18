Public Class TestCaseCreation
    Dim templateDAO As New TemplateDAO
    Dim template As New Template


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

        For Each column As DataGridViewColumn In dgvTestCase.Columns
            Dim columnName As String = column.Name
            Dim dataType As Type = column.ValueType ' Get the data type of the column

            ' Display the column name and data type
            MessageBox.Show($"Column Name: {columnName}, Data Type: {dataType.Name}")
        Next



    End Sub

    Private Sub dgvTestCase_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTestCase.CellValueChanged
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class