Imports System.Data.OleDb
Public Class formorders
    'Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:\ProjectCode\FINAL\Login with levels\cafe.accdb")
    Private Sub formorders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CafeDataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.CafeDataSet.tblCustomers)
        'TODO: This line of code loads data into the 'StockDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.StockDataSet.Table1)

        'TODO: This line of code loads data into the 'OrdersDataSet.tblOrders' table. You can move, or remove it, as needed.
        Me.TblOrdersTableAdapter.Fill(Me.OrdersDataSet.tblOrders)



        'Dim sql As String
        'Sql = "SELECT * FROM tblOrders"
        'Dim adapter As New OleDbDataAdapter(sql, con1)
        'Dim dt As New DataTable("orders")
        'adapter.Fill(dt)
        'DataGridView1.DataSource = dt

        'Dim sql1 As String
        'sql1 = "SELECT * FROM tblOrders"
        'Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        'Dim cmd1 As New OleDbCommand(sql1, con1)
        ''Dim dt1 As New DataTable("users")
        'con1.Open()
        'Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        'myreader.Read()

        'con1.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblOrdersBindingSource.AddNew()
        'TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        'TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        'TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        'TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        'TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        'TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        'TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        'TextBox8.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        'TextBox9.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        'TextBox10.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TblOrdersBindingSource.RemoveCurrent()
        ' We use the WHERE to be sure only that record that the user has selected is deleted.
        'Dim sqldelete As String
        'sqldelete = "DELETE * FROM tblOrders WHERE SKU='" & DataGridView1.CurrentRow.Cells(7).Value.ToString & "'"
        ' This is our DataAdapter. This executes our SQL Statement above against the Database
        ' we defined in the Connection String
        'Dim adapter As New OleDbDataAdapter(sqldelete, con1)
        ' Gets the records from the table and fills our adapter with those.
        'Dim dt As New DataTable("orders")
        'adapter.Fill(dt)
        ' Assigns the edited DataSource on the DataGridView and the refreshes the 
        ' view to ensure everything is up to date in real time.
        'DataGridView1.DataSource = dt
        ' This is a Sub in Module 1 to refresh the DataGridView when information is added,
        '  updated, or deleted.
        'RefreshDGV()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' SQL Statement so our User can search for either FirstName or LastName
        'Dim sqlsearch As String
        'sqlsearch = "SELECT * FROM tblOrders WHERE CustomerFirstName LIKE '%" & txtSearch.Text & "%'" & " OR CustomerLastName LIKE '%" & txtSearch.Text & "%'" & " OR OrderID LIKE '%" & txtSearch.Text & "%'" & " OR CustomerID LIKE '%" & txtSearch.Text & "%'" & " OR SKU LIKE '%" & txtSearch.Text & "%'" & " OR ItemName LIKE '%" & txtSearch.Text & "%'" & " OR Quantity LIKE '%" & txtSearch.Text & "%'" & " OR ItemCost LIKE '%" & txtSearch.Text & "%'" & " OR TotalCost LIKE '%" & txtSearch.Text & "%'"
        ' Once again we execute the SQL statements against our DataBase
        'Dim adapter As New OleDbDataAdapter(sqlsearch, con1)
        ' Shows the records and updates the DataGridView
        'Dim dt As New DataTable("orders")
        'adapter.Fill(dt)
        'DataGridView1.DataSource = dt
        If txtSearch.Text = "" Then
            Call notFound()
            Exit Sub

        Else
            TblOrdersBindingSource.Filter = "(Convert(OrderID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (CustomerID LIKE'" & txtSearch.Text & "') OR (CustomerFirstName LIKE '" & txtSearch.Text & "')" &
                "OR (CustomerLastName LIKE '" & txtSearch.Text & "') OR (SKU LIKE '" & txtSearch.Text & " ')" &
                "OR (ItemName LIKE '" & txtSearch.Text & " ') OR (Quantity LIKE '" & txtSearch.Text & " ')" &
                "OR (ItemCost LIKE '" & txtSearch.Text & " ') OR (TotalCost LIKE '" & txtSearch.Text & " ')"


            If TblOrdersBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = TblOrdersBindingSource

                End With
            Else
                MsgBox("Search returned no results")
                TblOrdersBindingSource.Filter = Nothing
            End If
        End If
    End Sub
    Private Sub notFound()
        MsgBox("Please enter a search value")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo SaveErr
        TblOrdersBindingSource.EndEdit()
        TblOrdersTableAdapter.Update(OrdersDataSet.tblOrders)
        MessageBox.Show("Successfully Saved")
SaveErr:
        'Dim sqlinsert As String
        ' We use the INSERT statement which tells our program to add the information
        ' from the Forms Text fields into the Databases columns. 
        'sqlinsert = "INSERT INTO tblOrders([OrderID], [OrderDate], [CustomerID], [CustomerFirstName], [CustomerLastName], [SKU], [ItemName], [Quantity], [ItemCost], [TotalCost])" &
        '"VALUES(@OrderID, @OrderDate, @CustomerID, @CustomerFirstName, @CustomerLastName, @SKU, @ItemName, @Quantity, @ItemCost, @TotalCost)"
        'Dim cmd As New OleDbCommand(sqlinsert, con1)
        ' This assigns the values for our columns in the DataBase. 
        ' To ensure the correct values are written to the correct column
        'cmd.Parameters.Add(New OleDbParameter("@OrderID", TextBox1.Text))
        'cmd.Parameters.Add(New OleDbParameter("@OrderDate", TextBox2.Text))
        'cmd.Parameters.Add(New OleDbParameter("@CustomerID", TextBox3.Text))
        'cmd.Parameters.Add(New OleDbParameter("@CustomerFirstName", TextBox4.Text))
        'cmd.Parameters.Add(New OleDbParameter("@CustomerLastName", TextBox5.Text))
        'cmd.Parameters.Add(New OleDbParameter("@SKU", TextBox6.Text))
        'cmd.Parameters.Add(New OleDbParameter("@ItemName", TextBox7.Text))
        'cmd.Parameters.Add(New OleDbParameter("@Quantity", TextBox8.Text))
        'cmd.Parameters.Add(New OleDbParameter("@ItemCost", TextBox9.Text))
        'cmd.Parameters.Add(New OleDbParameter("@TotalCost", TextBox10.Text))
        ' This is what actually writes our changes to the DataBase.
        ' You have to open the connection, execute the commands and
        ' then close connection.
        'con1.Open()
        'Try
        'cmd.ExecuteNonQuery()
        'Catch ex As Exception

        'End Try

        'con1.Close()
        ' This are subs in Module1, to clear all the TextBoxes on the form
        ' and refresh the DataGridView on the MainForm to show our new records.
        'ClearTextBox(Me)
        'RefreshDGV()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblOrdersBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblOrdersBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TblOrdersBindingSource.Filter = Nothing
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox2.Text = "" Then
            Call notFound()
            Exit Sub

        Else
            Table1BindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & TextBox2.Text & "')" &
                "OR (SKU LIKE'" & TextBox2.Text & "') OR (ItemManufacturerName LIKE '" & TextBox2.Text & "')" &
                "OR (ItemName LIKE '" & TextBox2.Text & "') OR (StockCount LIKE '" & TextBox2.Text & " ')"

            If Table1BindingSource.Count <> 0 Then
                With DataGridView2
                    .DataSource = Table1BindingSource

                End With
            Else
                MsgBox("Search returned no results")
                Table1BindingSource.Filter = Nothing
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Table1BindingSource.Filter = Nothing
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox11.Text = "" Then
            Call notFound()
            Exit Sub

        Else
            TblCustomersBindingSource.Filter = "(Convert(CustomerID, 'System.String') LIKE '" & TextBox11.Text & "')" &
                "OR (FirstName LIKE'" & TextBox11.Text & "') OR (LastName LIKE '" & TextBox11.Text & "')" &
                "OR (PostCode LIKE '" & TextBox11.Text & "') OR (Address LIKE '" & TextBox11.Text & " ')" &
                "OR (MobileNumber LIKE '" & TextBox11.Text & " ')"

            If TblCustomersBindingSource.Count <> 0 Then
                With DataGridView3
                    .DataSource = TblCustomersBindingSource

                End With
            Else
                MsgBox("Search returned no results")
                TblCustomersBindingSource = Nothing
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TblCustomersBindingSource.Filter = Nothing
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TextBox10.Text = "£" & Val(TextBox8.Text) * Val(TextBox9.Text)
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        TextBox10.Text = "£" & Val(TextBox8.Text) * Val(TextBox9.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim id As String = Guid.NewGuid().ToString("N")
        TextBox1.Text = id
    End Sub
End Class
