
Imports System.Data.OleDb
Public Class frmcafe

    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.available)
    Dim provisionalIcon As New System.Drawing.Bitmap(My.Resources.provisional)
    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.booked)
    Private Sub frmcafe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CafeDataSet.tblBookings' table. You can move, or remove it, as needed.
        Me.TblBookingsTableAdapter.Fill(Me.CafeDataSet.tblBookings)
        'TODO: This line of code loads data into the 'CafeDataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.CafeDataSet.tblCustomers)
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableIcon
                AddHandler c.Click, AddressOf PictureBox1_Click
            End If
        Next

        Call UpdateBookings()

    End Sub

    Sub UpdateBookings()
        Dim stSQL As String
        stSQL = "SELECT BookingID, Customer, Seat From tblBookings"

        Dim stConString As String
        stConString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:\ProjectCode\FINAL\Login with levels\cafe.accdb"
        Dim conBookings As OleDbConnection
        conBookings = New OleDbConnection
        conBookings.ConnectionString = stConString
        conBookings.Open()

        Dim cmdSelectBookings As OleDbCommand
        cmdSelectBookings = New OleDbCommand
        cmdSelectBookings.CommandText = stSQL
        cmdSelectBookings.Connection = conBookings

        Dim dsBookings As New DataSet
        Dim daBookings As New OleDbDataAdapter(cmdSelectBookings)
        daBookings.Fill(dsBookings, "Bookings")
        conBookings.Close()

        'Dim stOut As String
        Dim t1 As DataTable = dsBookings.Tables("Bookings")
        Dim row As DataRow

        For Each row In t1.Rows
            'stOut = stOut & row(0) & " " & row(1) & " " & row(2) & vbNewLine
            CType(Controls("PictureBox" & row(2)), PictureBox).Image = bookedIcon
        Next

        'MsgBox(stOut)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = provisionalIcon
        ElseIf CType(sender, PictureBox).Image Is provisionalIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Public Sub btnContinue_Click_1(sender As Object, e As EventArgs) Handles btnContinue.Click

        Dim c As Control
        Dim bSelected As Boolean

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                If CType(c, PictureBox).Image Is provisionalIcon Then
                    bSelected = True
                    Exit For
                End If
            End If
        Next
        If bSelected = False Then
            MsgBox("Please select at least one seat")
            Exit Sub
        End If

        Dim stSQLInsert As String
        stSQLInsert = "INSERT INTO tblBookings (Customer, Seat) VALUES ('ES001', 9)"
        Dim stConString As String
        stConString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:\ProjectCode\Login with levels\cafe.accdb"

        Dim conBookings As OleDbConnection
        conBookings = New OleDbConnection
        conBookings.ConnectionString = stConString
        conBookings.Open()

        Dim cmdMakeBookings As OleDbCommand
        cmdMakeBookings = New OleDbCommand
        cmdMakeBookings.Connection = conBookings


        Dim iSeatNum As Integer
        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                If CType(c, PictureBox).Image Is provisionalIcon Then
                    iSeatNum = Mid(CType(c, PictureBox).Name, 11)
                    stSQLInsert = "INSERT INTO tblBookings (Customer, Seat) VALUES('" & Me.txtbooking.Text & "', " & iSeatNum & ")"
                    cmdMakeBookings.CommandText = stSQLInsert
                    cmdMakeBookings.ExecuteNonQuery()
                    Exit For
                End If
                AddHandler c.Click, AddressOf PictureBox1_Click

            End If
        Next
        conBookings.Close()
        Call UpdateBookings()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainFormAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        TblBookingsBindingSource.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        TblBookingsBindingSource.MoveNext()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim c As Control
        On Error GoTo SaveErr
        TblBookingsBindingSource.EndEdit()
        TblBookingsTableAdapter.Update(CafeDataSet.tblBookings)
        MessageBox.Show("Successfully Saved")
        Call UpdateBookings()
SaveErr:
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        TblBookingsBindingSource.RemoveCurrent()
        Call UpdateBookings()
    End Sub


End Class