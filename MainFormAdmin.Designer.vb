<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFormAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFormAdmin))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet1 = New Login_with_levels.stockDataSet()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.RepairIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompletedRepairDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblRepairsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairsDataSet = New Login_with_levels.repairsDataSet()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblcpu = New System.Windows.Forms.Label()
        Me.lblram = New System.Windows.Forms.Label()
        Me.lblcpu1 = New System.Windows.Forms.Label()
        Me.lblram1 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.TblRepairsTableAdapter = New Login_with_levels.repairsDataSetTableAdapters.tblRepairsTableAdapter()
        Me.Table1TableAdapter1 = New Login_with_levels.stockDataSetTableAdapters.Table1TableAdapter()
        Me.Panel9.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRepairsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel36.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Black
        Me.Panel13.Location = New System.Drawing.Point(230, -4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(3, 586)
        Me.Panel13.TabIndex = 11
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel9.Controls.Add(Me.DataGridView1)
        Me.Panel9.Controls.Add(Me.Panel7)
        Me.Panel9.Controls.Add(Me.Panel35)
        Me.Panel9.Controls.Add(Me.Panel34)
        Me.Panel9.Controls.Add(Me.Panel33)
        Me.Panel9.Controls.Add(Me.Button11)
        Me.Panel9.Location = New System.Drawing.Point(258, 78)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(293, 410)
        Me.Panel9.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataGridView1.DataSource = Me.BindingSource1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(9, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(275, 350)
        Me.DataGridView1.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SKU"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SKU"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ItemManufacturerName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ItemManufacturerName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ItemName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ItemName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "StockCount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "StockCount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Table1"
        Me.BindingSource1.DataSource = Me.StockDataSet1
        '
        'StockDataSet1
        '
        Me.StockDataSet1.DataSetName = "stockDataSet"
        Me.StockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(2, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(291, 3)
        Me.Panel7.TabIndex = 20
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.Black
        Me.Panel35.Location = New System.Drawing.Point(290, 2)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(10, 406)
        Me.Panel35.TabIndex = 16
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.Black
        Me.Panel34.Location = New System.Drawing.Point(1, 407)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(291, 3)
        Me.Panel34.TabIndex = 19
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.Black
        Me.Panel33.Location = New System.Drawing.Point(0, 4)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(3, 402)
        Me.Panel33.TabIndex = 15
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(6, 5)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(179, 36)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "Latest Stock"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel8.Controls.Add(Me.DataGridView3)
        Me.Panel8.Controls.Add(Me.Panel27)
        Me.Panel8.Controls.Add(Me.Panel24)
        Me.Panel8.Controls.Add(Me.Button9)
        Me.Panel8.Location = New System.Drawing.Point(583, 78)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(291, 410)
        Me.Panel8.TabIndex = 4
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairIDDataGridViewTextBoxColumn, Me.RepairDateDataGridViewTextBoxColumn, Me.CompletedRepairDateDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerFirstNameDataGridViewTextBoxColumn, Me.CustomerLastNameDataGridViewTextBoxColumn, Me.DeviceIDDataGridViewTextBoxColumn, Me.IssueDataGridViewTextBoxColumn, Me.RepairCostDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.TblRepairsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView3.Location = New System.Drawing.Point(8, 50)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(274, 122)
        Me.DataGridView3.TabIndex = 17
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
        'TblRepairsBindingSource
        '
        Me.TblRepairsBindingSource.DataMember = "tblRepairs"
        Me.TblRepairsBindingSource.DataSource = Me.RepairsDataSet
        '
        'RepairsDataSet
        '
        Me.RepairsDataSet.DataSetName = "repairsDataSet"
        Me.RepairsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.Black
        Me.Panel27.Location = New System.Drawing.Point(0, 407)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(291, 3)
        Me.Panel27.TabIndex = 16
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Black
        Me.Panel24.Location = New System.Drawing.Point(288, 1)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(3, 408)
        Me.Panel24.TabIndex = 14
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(1, -5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(262, 49)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Upcoming Repairs"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.Controls.Add(Me.Panel42)
        Me.Panel6.Controls.Add(Me.Panel38)
        Me.Panel6.Controls.Add(Me.Panel12)
        Me.Panel6.Controls.Add(Me.lbldt)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Button7)
        Me.Panel6.Controls.Add(Me.Button6)
        Me.Panel6.Controls.Add(Me.Button5)
        Me.Panel6.Controls.Add(Me.PictureBox6)
        Me.Panel6.Location = New System.Drawing.Point(231, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(692, 44)
        Me.Panel6.TabIndex = 2
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.Black
        Me.Panel42.Location = New System.Drawing.Point(664, -3)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(3, 586)
        Me.Panel42.TabIndex = 12
        '
        'Panel38
        '
        Me.Panel38.BackColor = System.Drawing.Color.Black
        Me.Panel38.Location = New System.Drawing.Point(-5, 0)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(690, 3)
        Me.Panel38.TabIndex = 13
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Black
        Me.Panel12.Location = New System.Drawing.Point(-2, 41)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(690, 3)
        Me.Panel12.TabIndex = 12
        '
        'lbldt
        '
        Me.lbldt.AutoSize = True
        Me.lbldt.BackColor = System.Drawing.Color.Transparent
        Me.lbldt.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Location = New System.Drawing.Point(239, 9)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(51, 26)
        Me.lbldt.TabIndex = 3
        Me.lbldt.Text = "lbldt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dashboard"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(566, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(53, 37)
        Me.Button7.TabIndex = 2
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(517, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 32)
        Me.Button6.TabIndex = 1
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(622, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 32)
        Me.Button5.TabIndex = 0
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-9, 8)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(77, 36)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-24, -14)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(281, 108)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(127, 230)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 36)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "SMS"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(123, 284)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 36)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Users"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(20, 223)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(13, 282)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(82, 46)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(108, 340)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 36)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Repairs"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(16, 335)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'lblcpu
        '
        Me.lblcpu.AutoSize = True
        Me.lblcpu.BackColor = System.Drawing.Color.Transparent
        Me.lblcpu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcpu.Location = New System.Drawing.Point(14, 511)
        Me.lblcpu.Name = "lblcpu"
        Me.lblcpu.Size = New System.Drawing.Size(34, 18)
        Me.lblcpu.TabIndex = 13
        Me.lblcpu.Text = "CPU"
        '
        'lblram
        '
        Me.lblram.AutoSize = True
        Me.lblram.BackColor = System.Drawing.Color.Transparent
        Me.lblram.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblram.Location = New System.Drawing.Point(122, 511)
        Me.lblram.Name = "lblram"
        Me.lblram.Size = New System.Drawing.Size(38, 18)
        Me.lblram.TabIndex = 14
        Me.lblram.Text = "RAM"
        '
        'lblcpu1
        '
        Me.lblcpu1.AutoSize = True
        Me.lblcpu1.BackColor = System.Drawing.Color.Transparent
        Me.lblcpu1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcpu1.Location = New System.Drawing.Point(56, 511)
        Me.lblcpu1.Name = "lblcpu1"
        Me.lblcpu1.Size = New System.Drawing.Size(19, 18)
        Me.lblcpu1.TabIndex = 17
        Me.lblcpu1.Text = "%"
        '
        'lblram1
        '
        Me.lblram1.AutoSize = True
        Me.lblram1.BackColor = System.Drawing.Color.Transparent
        Me.lblram1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblram1.Location = New System.Drawing.Point(169, 511)
        Me.lblram1.Name = "lblram1"
        Me.lblram1.Size = New System.Drawing.Size(19, 18)
        Me.lblram1.TabIndex = 18
        Me.lblram1.Text = "%"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(98, 399)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(127, 36)
        Me.Button13.TabIndex = 19
        Me.Button13.Text = "Customers"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(15, 392)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(76, 50)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 20
        Me.PictureBox8.TabStop = False
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Black
        Me.Panel16.Location = New System.Drawing.Point(0, 498)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(232, 3)
        Me.Panel16.TabIndex = 12
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(123, 455)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(74, 36)
        Me.Button14.TabIndex = 21
        Me.Button14.Text = "Cafe"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button14.UseVisualStyleBackColor = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(13, 449)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(82, 49)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 22
        Me.PictureBox9.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel44)
        Me.Panel1.Controls.Add(Me.Panel40)
        Me.Panel1.Controls.Add(Me.Panel39)
        Me.Panel1.Controls.Add(Me.Panel37)
        Me.Panel1.Controls.Add(Me.Panel20)
        Me.Panel1.Controls.Add(Me.Panel19)
        Me.Panel1.Controls.Add(Me.Panel18)
        Me.Panel1.Controls.Add(Me.Panel17)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox9)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.Panel16)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.lblram1)
        Me.Panel1.Controls.Add(Me.lblcpu1)
        Me.Panel1.Controls.Add(Me.lblram)
        Me.Panel1.Controls.Add(Me.lblcpu)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Panel36)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 563)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(115, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 36)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Orders"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.Black
        Me.Panel44.Location = New System.Drawing.Point(1, 159)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(232, 3)
        Me.Panel44.TabIndex = 14
        '
        'Panel40
        '
        Me.Panel40.BackColor = System.Drawing.Color.Black
        Me.Panel40.Location = New System.Drawing.Point(-1, 536)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(690, 3)
        Me.Panel40.TabIndex = 14
        '
        'Panel39
        '
        Me.Panel39.BackColor = System.Drawing.Color.Black
        Me.Panel39.Location = New System.Drawing.Point(0, 1)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(3, 586)
        Me.Panel39.TabIndex = 12
        '
        'Panel37
        '
        Me.Panel37.BackColor = System.Drawing.Color.Black
        Me.Panel37.Location = New System.Drawing.Point(-1, 0)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(690, 3)
        Me.Panel37.TabIndex = 13
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Black
        Me.Panel20.Location = New System.Drawing.Point(0, 444)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(232, 3)
        Me.Panel20.TabIndex = 13
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Black
        Me.Panel19.Location = New System.Drawing.Point(-1, 386)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(232, 3)
        Me.Panel19.TabIndex = 13
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Black
        Me.Panel18.Location = New System.Drawing.Point(-1, 330)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(232, 3)
        Me.Panel18.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Black
        Me.Panel17.Location = New System.Drawing.Point(0, 276)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(232, 3)
        Me.Panel17.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(0, 219)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 3)
        Me.Panel4.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(-1, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 3)
        Me.Panel2.TabIndex = 13
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.Transparent
        Me.Panel36.Controls.Add(Me.PictureBox2)
        Me.Panel36.Controls.Add(Me.Button2)
        Me.Panel36.Location = New System.Drawing.Point(-1, 100)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(231, 58)
        Me.Panel36.TabIndex = 23
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(123, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Stock"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.Black
        Me.Panel22.Location = New System.Drawing.Point(257, 78)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(3, 191)
        Me.Panel22.TabIndex = 12
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.Black
        Me.Panel25.Location = New System.Drawing.Point(582, 78)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(291, 3)
        Me.Panel25.TabIndex = 15
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.Black
        Me.Panel26.Location = New System.Drawing.Point(582, 78)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(3, 409)
        Me.Panel26.TabIndex = 13
        '
        'Panel41
        '
        Me.Panel41.BackColor = System.Drawing.Color.Black
        Me.Panel41.Location = New System.Drawing.Point(231, 536)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(690, 3)
        Me.Panel41.TabIndex = 13
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.Black
        Me.Panel43.Location = New System.Drawing.Point(895, 41)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(3, 586)
        Me.Panel43.TabIndex = 13
        '
        'TblRepairsTableAdapter
        '
        Me.TblRepairsTableAdapter.ClearBeforeFill = True
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'MainFormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(898, 539)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel43)
        Me.Controls.Add(Me.Panel41)
        Me.Controls.Add(Me.Panel26)
        Me.Controls.Add(Me.Panel25)
        Me.Controls.Add(Me.Panel22)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainFormAdmin"
        Me.Text = "MainForm"
        Me.Panel9.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRepairsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel36.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents lbldt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents StockDataSet As stockDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As stockDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemManufacturerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemManufacturerNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StockCountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblcpu As Label
    Friend WithEvents lblram As Label
    Friend WithEvents lblcpu1 As Label
    Friend WithEvents lblram1 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel38 As Panel
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Panel39 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel40 As Panel
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView3 As DataGridView
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents StockDataSet1 As stockDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Table1TableAdapter1 As stockDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
