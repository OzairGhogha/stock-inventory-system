Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Login_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtusername.Select()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim conn As New My_Connection()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()

        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `users` WHERE `username` = @usn and `password`= @pass", conn.getConnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtusername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtpassword.Text
        adapter.SelectCommand = command
        adapter.Fill(table)

        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Error")
            txtusername.Focus()
        ElseIf table.Rows.Count > 0 Then
            Me.Hide()
            txtusername.Clear()
            txtpassword.Clear()
            MainFormAdmin.Show()
        Else
            MessageBox.Show("The username or password does not exist.", "Error")
            txtusername.Clear()
            txtpassword.Clear()
            txtusername.Focus()
        End If


    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to exit?", "Login System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Focus()
    End Sub
End Class