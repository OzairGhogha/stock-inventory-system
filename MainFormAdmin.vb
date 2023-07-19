Public Class MainFormAdmin
    Dim cpuUsage As New PerformanceCounter("Processor", "% Processor Time", "_Total")
    Dim ramUsage As New PerformanceCounter("Memory", "% Committed Bytes in Use")
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to exit?", "Login System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MainFormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.StockDataSet1.Table1)
        'TODO: This line of code loads data into the 'StockDataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.StockDataSet1.Table1)
        'TODO: This line of code loads data into the 'StockDataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.StockDataSet1.Table1)

        'TODO: This line of code loads data into the 'RepairsDataSet.tblRepairs' table. You can move, or remove it, as needed.
        Me.TblRepairsTableAdapter.Fill(Me.RepairsDataSet.tblRepairs)

        Timer1.Interval = 1000
        Timer1.Enabled = True
        'Dim min As Integer
        'Dim max As Integer
        'Dim sum As Integer

        'For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
        'sum = (sum + DataGridView1.Rows(i).Cells(4).Value)
        'If i = 0 Then
        'max = DataGridView1.Rows(i).Cells(4).Value
        'min = DataGridView1.Rows(i).Cells(4).Value
        'End If
        'If max < DataGridView1.Rows(i).Cells(4).Value Then
        'max = DataGridView1.Rows(i).Cells(4).Value
        'End If
        'If min > DataGridView1.Rows(i).Cells(4).Value Then
        'min = DataGridView1.Rows(i).Cells(4).Value
        'End If
        'Next
        'lbltotal.Text = sum.ToString
        'Table1TableAdapter.Update(StockDataSet.Table1)




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = Date.Now.ToString("dd-MM-yyyy   I   hh:mm:ss")
        lblcpu1.Text = Math.Round((cpuUsage.NextValue), 2) & "%"
        lblram1.Text = Math.Round((ramUsage.NextValue), 2) & "%"
        DataGridView1.Update()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formstockedit.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formsms.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formeditusers.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        formrepairs.show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        formcustomers.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        frmcafe.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        formorders.Show()
    End Sub
End Class



