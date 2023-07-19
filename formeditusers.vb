Imports MySql.Data.MySqlClient
Public Class formeditusers
    Private Sub formeditusers_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtfirstname.Select()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstname As String = txtfirstname.Text
        Dim lastname As String = txtlastname.Text
        Dim email As String = txtemail.Text
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim cpassword As String = txtconfirmpassword.Text

        If firstname.Trim() = "" Or lastname.Trim() = "" Or username.Trim() = "" Or email.Trim() = "" Or password.Trim() = "" Then
            MessageBox.Show("Please fill in all fields.", "Error")

        ElseIf Not String.Equals(password, cpassword) Then
            MessageBox.Show("Passwords do not match.", "Error")
            txtpassword.Clear()
            txtconfirmpassword.Clear()
            txtpassword.Focus()
        ElseIf usernameExist(username) Then
            MessageBox.Show("Username already exists.", "Error")
            txtusername.Clear()
            txtusername.Focus()
        Else
            Dim conn As New My_Connection()
            Dim command As New MySqlCommand("INSERT INTO `users`(`first_name`, `last_name`, `email`, `username`, `password`) VALUES (@fn, @ln, @mail, @usn, @pass)", conn.getConnection)

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstname
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastname
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("User has been created.", "Error")
                txtfirstname.Focus()
                conn.closeConnection()
            Else
                MessageBox.Show("User has not been created.", "Error")
                txtfirstname.Focus()
                conn.closeConnection()
            End If
        End If

    End Sub
    Public Function usernameExist(ByVal username As String) As Boolean

        Dim conn As New My_Connection
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", conn.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False

        End If

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub
End Class