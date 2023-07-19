Imports System.Data.OleDb
Module Module1
    Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:\ProjectCode\FINAL\Login with levels\cafe.accdb")
    Sub RefreshDGV()
        Dim sql As String
        sql = "SELECT * FROM tblOrders"
        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("orders")
        adapter.Fill(dt)
        'formorders.DataGridView1.DataSource = dt
    End Sub

    Sub ClearTextBox(ByVal FormName As Form)
        For Each txt As Control In FormName.Controls
            If TypeOf txt Is TextBox Then
                CType(txt, TextBox).Text = ""
            End If
        Next
    End Sub
End Module