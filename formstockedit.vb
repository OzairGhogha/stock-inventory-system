Public Class formstockedit
    Private Sub formstockedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.StockDataSet.Table1)

        btnaddnew.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Table1BindingSource.MovePrevious()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        Table1BindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Table1BindingSource.MoveNext()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        On Error GoTo SaveErr
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(StockDataSet.Table1)
        MessageBox.Show("Successfully Saved")
SaveErr:

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Table1BindingSource.RemoveCurrent()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(StockDataSet.Table1)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call notFound()
            Exit Sub

        Else
            Table1BindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (SKU LIKE'" & txtSearch.Text & "') OR (ItemManufacturerName LIKE '" & txtSearch.Text & "')" &
                "OR (ItemName LIKE '" & txtSearch.Text & "') OR (StockCount LIKE '" & txtSearch.Text & " ')"

            If Table1BindingSource.Count <> 0 Then
                With DvgStock
                    .DataSource = Table1BindingSource

                End With
            Else
                MsgBox("Search returned no results")
                Table1BindingSource.Filter = Nothing
            End If
        End If


    End Sub

    Private Sub notFound()
        MsgBox("Please enter a search value")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Table1BindingSource.Filter = Nothing
    End Sub
End Class