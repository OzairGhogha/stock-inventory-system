<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formrepairs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formrepairs))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RepairsDataSet = New Login_with_levels.repairsDataSet()
        Me.TblRepairsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRepairsTableAdapter = New Login_with_levels.repairsDataSetTableAdapters.tblRepairsTableAdapter()
        Me.RepairIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompletedRepairDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnaddnew = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CafeDataSet = New Login_with_levels.cafeDataSet()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomersTableAdapter = New Login_with_levels.cafeDataSetTableAdapters.tblCustomersTableAdapter()
        Me.CustomerIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRepairsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CafeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairIDDataGridViewTextBoxColumn, Me.RepairDateDataGridViewTextBoxColumn, Me.CompletedRepairDateDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerFirstNameDataGridViewTextBoxColumn, Me.CustomerLastNameDataGridViewTextBoxColumn, Me.DeviceIDDataGridViewTextBoxColumn, Me.IssueDataGridViewTextBoxColumn, Me.RepairCostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblRepairsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1181, 227)
        Me.DataGridView1.TabIndex = 0
        '
        'RepairsDataSet
        '
        Me.RepairsDataSet.DataSetName = "repairsDataSet"
        Me.RepairsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRepairsBindingSource
        '
        Me.TblRepairsBindingSource.DataMember = "tblRepairs"
        Me.TblRepairsBindingSource.DataSource = Me.RepairsDataSet
        '
        'TblRepairsTableAdapter
        '
        Me.TblRepairsTableAdapter.ClearBeforeFill = True
        '
        'RepairIDDataGridViewTextBoxColumn
        '
        Me.RepairIDDataGridViewTextBoxColumn.DataPropertyName = "RepairID"
        Me.RepairIDDataGridViewTextBoxColumn.HeaderText = "RepairID"
        Me.RepairIDDataGridViewTextBoxColumn.Name = "RepairIDDataGridViewTextBoxColumn"
        '
        'RepairDateDataGridViewTextBoxColumn
        '
        Me.RepairDateDataGridViewTextBoxColumn.DataPropertyName = "RepairDate"
        Me.RepairDateDataGridViewTextBoxColumn.HeaderText = "RepairDate"
        Me.RepairDateDataGridViewTextBoxColumn.Name = "RepairDateDataGridViewTextBoxColumn"
        '
        'CompletedRepairDateDataGridViewTextBoxColumn
        '
        Me.CompletedRepairDateDataGridViewTextBoxColumn.DataPropertyName = "CompletedRepairDate"
        Me.CompletedRepairDateDataGridViewTextBoxColumn.HeaderText = "CompletedRepairDate"
        Me.CompletedRepairDateDataGridViewTextBoxColumn.Name = "CompletedRepairDateDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'CustomerFirstNameDataGridViewTextBoxColumn
        '
        Me.CustomerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName"
        Me.CustomerFirstNameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstName"
        Me.CustomerFirstNameDataGridViewTextBoxColumn.Name = "CustomerFirstNameDataGridViewTextBoxColumn"
        '
        'CustomerLastNameDataGridViewTextBoxColumn
        '
        Me.CustomerLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastName"
        Me.CustomerLastNameDataGridViewTextBoxColumn.HeaderText = "CustomerLastName"
        Me.CustomerLastNameDataGridViewTextBoxColumn.Name = "CustomerLastNameDataGridViewTextBoxColumn"
        '
        'DeviceIDDataGridViewTextBoxColumn
        '
        Me.DeviceIDDataGridViewTextBoxColumn.DataPropertyName = "DeviceID"
        Me.DeviceIDDataGridViewTextBoxColumn.HeaderText = "DeviceID"
        Me.DeviceIDDataGridViewTextBoxColumn.Name = "DeviceIDDataGridViewTextBoxColumn"
        '
        'IssueDataGridViewTextBoxColumn
        '
        Me.IssueDataGridViewTextBoxColumn.DataPropertyName = "Issue"
        Me.IssueDataGridViewTextBoxColumn.HeaderText = "Issue"
        Me.IssueDataGridViewTextBoxColumn.Name = "IssueDataGridViewTextBoxColumn"
        '
        'RepairCostDataGridViewTextBoxColumn
        '
        Me.RepairCostDataGridViewTextBoxColumn.DataPropertyName = "RepairCost"
        Me.RepairCostDataGridViewTextBoxColumn.HeaderText = "RepairCost"
        Me.RepairCostDataGridViewTextBoxColumn.Name = "RepairCostDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1744, 153)
        Me.Panel1.TabIndex = 1
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Silver
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(1492, 480)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(96, 47)
        Me.btnclose.TabIndex = 25
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Silver
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(1391, 480)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(96, 47)
        Me.btndelete.TabIndex = 24
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Silver
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(1289, 480)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 47)
        Me.btnsave.TabIndex = 23
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Silver
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnext.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(1492, 427)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(96, 47)
        Me.btnnext.TabIndex = 22
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnaddnew
        '
        Me.btnaddnew.BackColor = System.Drawing.Color.Silver
        Me.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaddnew.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddnew.Location = New System.Drawing.Point(1391, 427)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(96, 47)
        Me.btnaddnew.TabIndex = 21
        Me.btnaddnew.Text = "Add New"
        Me.btnaddnew.UseVisualStyleBackColor = False
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.Color.Silver
        Me.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnprevious.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.Location = New System.Drawing.Point(1289, 427)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(96, 47)
        Me.btnprevious.TabIndex = 20
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "RepairID", True))
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1341, 163)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(286, 21)
        Me.TextBox1.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "CustomerID", True))
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1341, 240)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(286, 21)
        Me.TextBox2.TabIndex = 34
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "CustomerFirstName", True))
        Me.TextBox3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1341, 265)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(286, 21)
        Me.TextBox3.TabIndex = 35
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "CustomerLastName", True))
        Me.TextBox4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(1341, 292)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(286, 21)
        Me.TextBox4.TabIndex = 36
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "DeviceID", True))
        Me.TextBox5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1341, 319)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(286, 21)
        Me.TextBox5.TabIndex = 37
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "Issue", True))
        Me.TextBox6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1341, 346)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(286, 21)
        Me.TextBox6.TabIndex = 38
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "RepairCost", True))
        Me.TextBox7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1341, 373)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(286, 21)
        Me.TextBox7.TabIndex = 39
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "RepairDate", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1341, 189)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(286, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRepairsBindingSource, "CompletedRepairDate", True))
        Me.DateTimePicker2.Location = New System.Drawing.Point(1341, 215)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(286, 20)
        Me.DateTimePicker2.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1211, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Repair ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1211, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Repair Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1211, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Completed Repair Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1211, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Customer ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1211, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Customer First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1211, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Customer Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1211, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Device ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1211, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Issue"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1211, 378)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Repair Cost"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn1, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.PostCodeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.MobileNumberDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TblCustomersBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 433)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(835, 150)
        Me.DataGridView2.TabIndex = 51
        '
        'CafeDataSet
        '
        Me.CafeDataSet.DataSetName = "cafeDataSet"
        Me.CafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.CafeDataSet
        '
        'TblCustomersTableAdapter
        '
        Me.TblCustomersTableAdapter.ClearBeforeFill = True
        '
        'CustomerIDDataGridViewTextBoxColumn1
        '
        Me.CustomerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn1.Name = "CustomerIDDataGridViewTextBoxColumn1"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'PostCodeDataGridViewTextBoxColumn
        '
        Me.PostCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode"
        Me.PostCodeDataGridViewTextBoxColumn.HeaderText = "PostCode"
        Me.PostCodeDataGridViewTextBoxColumn.Name = "PostCodeDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1016, 502)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 35)
        Me.Button9.TabIndex = 55
        Me.Button9.Text = "Reset View"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(870, 502)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(140, 35)
        Me.Button10.TabIndex = 54
        Me.Button10.Text = "Search"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(870, 476)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(274, 20)
        Me.TextBox11.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1445, 563)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 35)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Reset View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1299, 563)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 35)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(1299, 537)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(274, 20)
        Me.TextBox8.TabIndex = 56
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1656, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "IDGen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(748, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Black
        Me.Panel12.Location = New System.Drawing.Point(0, 150)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1759, 3)
        Me.Panel12.TabIndex = 60
        '
        'formrepairs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1737, 738)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnaddnew)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formrepairs"
        Me.Text = "formrepairs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRepairsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CafeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RepairsDataSet As repairsDataSet
    Friend WithEvents TblRepairsBindingSource As BindingSource
    Friend WithEvents TblRepairsTableAdapter As repairsDataSetTableAdapters.tblRepairsTableAdapter
    Friend WithEvents RepairIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepairDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompletedRepairDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepairCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnaddnew As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CafeDataSet As cafeDataSet
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents TblCustomersTableAdapter As cafeDataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel12 As Panel
End Class
