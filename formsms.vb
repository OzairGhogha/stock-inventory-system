Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Public Class formsms

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const accountSid = "ACf87bc2ef5f6ea667e20552a05d6f6065"
        Const authToken = "5933d9406bc58a24c649659489dc4eb3"
        TwilioClient.Init(accountSid, authToken)

        Dim toNumber = New PhoneNumber(txtpnum.Text)
        Dim message = MessageResource.Create(
                toNumber, from:=New PhoneNumber("+14435514906"),
                body:=txtmsg.Text)

        Console.WriteLine(message.Sid)
        MsgBox("The message has been sent successfully!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub formsms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CafeDataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.CafeDataSet.tblCustomers)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call notFound()
            Exit Sub

        Else
            TblCustomersBindingSource.Filter = "(Convert(CustomerID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (FirstName LIKE'" & txtSearch.Text & "') OR (LastName LIKE '" & txtSearch.Text & "')" &
                "OR (MobileNumber LIKE '" & txtSearch.Text & "')"

            If TblCustomersBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = TblCustomersBindingSource

                End With
            Else
                MsgBox("Search returned no results")
                TblCustomersBindingSource.Filter = Nothing
            End If
        End If

    End Sub

    Private Sub notFound()
        MsgBox("Please enter a search value")
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TblCustomersBindingSource.Filter = Nothing
    End Sub
End Class
