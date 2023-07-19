Public Class formcustomers
    Dim query As String
    Private Sub formcustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CafeDataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.CafeDataSet.tblCustomers)
        btnaddnew.Select()

    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        TblCustomersBindingSource.AddNew()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        TblCustomersBindingSource.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        TblCustomersBindingSource.MoveNext()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        On Error GoTo SaveErr
        TblCustomersBindingSource.EndEdit()
        TblCustomersTableAdapter.Update(CafeDataSet.tblCustomers)
        MessageBox.Show("Successfully Saved")
SaveErr:
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        TblCustomersBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        TblCustomersBindingSource.EndEdit()
        TblCustomersTableAdapter.Update(CafeDataSet.tblCustomers)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String = Guid.NewGuid().ToString("N")
        TextBox1.Text = id
    End Sub
End Class