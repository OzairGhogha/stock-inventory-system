Public Class formrepairs
    Private Sub formrepairs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CafeDataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.CafeDataSet.tblCustomers)
        'TODO: This line of code loads data into the 'RepairsDataSet.tblRepairs' table. You can move, or remove it, as needed.
        Me.TblRepairsTableAdapter.Fill(Me.RepairsDataSet.tblRepairs)

    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        TblRepairsBindingSource.AddNew()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        TblRepairsBindingSource.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        TblRepairsBindingSource.MoveNext()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        On Error GoTo SaveErr
        TblRepairsBindingSource.EndEdit()
        TblRepairsTableAdapter.Update(RepairsDataSet.tblRepairs)
        MessageBox.Show("Successfully Saved")
SaveErr:
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        TblRepairsBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
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
                With DataGridView2
                    .DataSource = TblCustomersBindingSource

                End With
            Else
                MsgBox("Search returned no results")
                TblCustomersBindingSource = Nothing
            End If
        End If
    End Sub

    Private Sub notFound()
        MsgBox("Please enter a search value")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TblCustomersBindingSource.Filter = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            Call notFound()
            Exit Sub

        Else
            TblRepairsBindingSource.Filter = "(Convert(RepairID, 'System.String') LIKE '" & TextBox2.Text & "')" &
                "OR (CustomerID LIKE'" & TextBox2.Text & "') OR (CustomerFirstName LIKE '" & TextBox2.Text & "')" &
                "OR (CustomerLastName LIKE '" & TextBox2.Text & "') OR (DeviceID LIKE '" & TextBox2.Text & " ')" &
                "OR (Issue LIKE '" & TextBox2.Text & " ') OR (RepairCost LIKE '" & TextBox2.Text & " ')"


            If TblRepairsBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = TblRepairsBindingSource

                End With
            Else
                MsgBox("Search returned no results")
                TblRepairsBindingSource.Filter = Nothing
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblRepairsBindingSource.Filter = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String = Guid.NewGuid().ToString("N")
        TextBox1.Text = id


    End Sub
End Class