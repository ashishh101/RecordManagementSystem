<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackage))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.TblpackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NaoepcDataSet4 = New NaoePC.naoepcDataSet4()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ADDtxtCase = New System.Windows.Forms.TextBox()
        Me.ADDtxtGC = New System.Windows.Forms.TextBox()
        Me.ADDtxtRam = New System.Windows.Forms.TextBox()
        Me.ADDtxtHdd = New System.Windows.Forms.TextBox()
        Me.ADDtxtProc = New System.Windows.Forms.TextBox()
        Me.ADDtxtMobo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PackageidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherboardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraphicCardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblpackageTableAdapter = New NaoePC.naoepcDataSet4TableAdapters.tblpackageTableAdapter()
        Me.StatusStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TblpackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaoepcDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 553)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(655, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssl
        '
        Me.tssl.Name = "tssl"
        Me.tssl.Size = New System.Drawing.Size(39, 17)
        Me.tssl.Text = "Status"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtPrice)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.BindingNavigator1)
        Me.TabPage1.Controls.Add(Me.ADDtxtCase)
        Me.TabPage1.Controls.Add(Me.ADDtxtGC)
        Me.TabPage1.Controls.Add(Me.ADDtxtRam)
        Me.TabPage1.Controls.Add(Me.ADDtxtHdd)
        Me.TabPage1.Controls.Add(Me.ADDtxtProc)
        Me.TabPage1.Controls.Add(Me.ADDtxtMobo)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(580, 214)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblpackageBindingSource, "Price", True))
        Me.txtPrice.Location = New System.Drawing.Point(151, 168)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 15
        '
        'TblpackageBindingSource
        '
        Me.TblpackageBindingSource.DataMember = "tblpackage"
        Me.TblpackageBindingSource.DataSource = Me.NaoepcDataSet4
        '
        'NaoepcDataSet4
        '
        Me.NaoepcDataSet4.DataSetName = "naoepcDataSet4"
        Me.NaoepcDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Price"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.TblpackageBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(574, 25)
        Me.BindingNavigator1.TabIndex = 13
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.MergeIndex = 1
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Save"
        '
        'ADDtxtCase
        '
        Me.ADDtxtCase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblpackageBindingSource, "Case", True))
        Me.ADDtxtCase.Location = New System.Drawing.Point(330, 137)
        Me.ADDtxtCase.Name = "ADDtxtCase"
        Me.ADDtxtCase.Size = New System.Drawing.Size(100, 20)
        Me.ADDtxtCase.TabIndex = 11
        '
        'ADDtxtGC
        '
        Me.ADDtxtGC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblpackageBindingSource, "Graphic_Card", True))
        Me.ADDtxtGC.Location = New System.Drawing.Point(151, 134)
        Me.ADDtxtGC.Name = "ADDtxtGC"
        Me.ADDtxtGC.Size = New System.Drawing.Size(100, 20)
        Me.ADDtxtGC.TabIndex = 10
        '
        'ADDtxtRam
        '
        Me.ADDtxtRam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblpackageBindingSource, "RAM", True))
        Me.ADDtxtRam.Location = New System.Drawing.Point(330, 94)
        Me.ADDtxtRam.Name = "ADDtxtRam"
        Me.ADDtxtRam.Size = New System.Drawing.Size(100, 20)
        Me.ADDtxtRam.TabIndex = 9
        '
        'ADDtxtHdd
        '
        Me.ADDtxtHdd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblpackageBindingSource, "HDD", True))
        Me.ADDtxtHdd.Location = New System.Drawing.Point(151, 94)
        Me.ADDtxtHdd.Name = "ADDtxtHdd"
        Me.ADDtxtHdd.Size = New System.Drawing.Size(100, 20)
        Me.ADDtxtHdd.TabIndex = 8
        '
        'ADDtxtProc
        '
        Me.ADDtxtProc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblpackageBindingSource, "Processor", True))
        Me.ADDtxtProc.Location = New System.Drawing.Point(330, 53)
        Me.ADDtxtProc.Name = "ADDtxtProc"
        Me.ADDtxtProc.Size = New System.Drawing.Size(100, 20)
        Me.ADDtxtProc.TabIndex = 7
        '
        'ADDtxtMobo
        '
        Me.ADDtxtMobo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblpackageBindingSource, "Motherboard", True))
        Me.ADDtxtMobo.Location = New System.Drawing.Point(151, 53)
        Me.ADDtxtMobo.Name = "ADDtxtMobo"
        Me.ADDtxtMobo.Size = New System.Drawing.Size(100, 20)
        Me.ADDtxtMobo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Case"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Graphic Card"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Memory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hard Drive"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Processor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Motherboard"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(32, 263)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(588, 240)
        Me.TabControl1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(363, 31)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Record Management System"
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'txtProd
        '
        Me.txtProd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblpackageBindingSource, "Package_id", True))
        Me.txtProd.Location = New System.Drawing.Point(657, 251)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(100, 20)
        Me.txtProd.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(545, 517)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageidDataGridViewTextBoxColumn, Me.MotherboardDataGridViewTextBoxColumn, Me.ProcessorDataGridViewTextBoxColumn, Me.HDDDataGridViewTextBoxColumn, Me.RAMDataGridViewTextBoxColumn, Me.GraphicCardDataGridViewTextBoxColumn, Me.CaseDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblpackageBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(32, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(588, 186)
        Me.DataGridView1.TabIndex = 17
        '
        'PackageidDataGridViewTextBoxColumn
        '
        Me.PackageidDataGridViewTextBoxColumn.DataPropertyName = "Package_id"
        Me.PackageidDataGridViewTextBoxColumn.HeaderText = "Package_id"
        Me.PackageidDataGridViewTextBoxColumn.Name = "PackageidDataGridViewTextBoxColumn"
        Me.PackageidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotherboardDataGridViewTextBoxColumn
        '
        Me.MotherboardDataGridViewTextBoxColumn.DataPropertyName = "Motherboard"
        Me.MotherboardDataGridViewTextBoxColumn.HeaderText = "Motherboard"
        Me.MotherboardDataGridViewTextBoxColumn.Name = "MotherboardDataGridViewTextBoxColumn"
        Me.MotherboardDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProcessorDataGridViewTextBoxColumn
        '
        Me.ProcessorDataGridViewTextBoxColumn.DataPropertyName = "Processor"
        Me.ProcessorDataGridViewTextBoxColumn.HeaderText = "Processor"
        Me.ProcessorDataGridViewTextBoxColumn.Name = "ProcessorDataGridViewTextBoxColumn"
        Me.ProcessorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HDDDataGridViewTextBoxColumn
        '
        Me.HDDDataGridViewTextBoxColumn.DataPropertyName = "HDD"
        Me.HDDDataGridViewTextBoxColumn.HeaderText = "HDD"
        Me.HDDDataGridViewTextBoxColumn.Name = "HDDDataGridViewTextBoxColumn"
        Me.HDDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RAMDataGridViewTextBoxColumn
        '
        Me.RAMDataGridViewTextBoxColumn.DataPropertyName = "RAM"
        Me.RAMDataGridViewTextBoxColumn.HeaderText = "RAM"
        Me.RAMDataGridViewTextBoxColumn.Name = "RAMDataGridViewTextBoxColumn"
        Me.RAMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GraphicCardDataGridViewTextBoxColumn
        '
        Me.GraphicCardDataGridViewTextBoxColumn.DataPropertyName = "Graphic_Card"
        Me.GraphicCardDataGridViewTextBoxColumn.HeaderText = "Graphic_Card"
        Me.GraphicCardDataGridViewTextBoxColumn.Name = "GraphicCardDataGridViewTextBoxColumn"
        Me.GraphicCardDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CaseDataGridViewTextBoxColumn
        '
        Me.CaseDataGridViewTextBoxColumn.DataPropertyName = "Case"
        Me.CaseDataGridViewTextBoxColumn.HeaderText = "Case"
        Me.CaseDataGridViewTextBoxColumn.Name = "CaseDataGridViewTextBoxColumn"
        Me.CaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblpackageTableAdapter
        '
        Me.TblpackageTableAdapter.ClearBeforeFill = True
        '
        'frmPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 575)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPackage"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TblpackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaoepcDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ADDtxtCase As System.Windows.Forms.TextBox
    Friend WithEvents ADDtxtGC As System.Windows.Forms.TextBox
    Friend WithEvents ADDtxtRam As System.Windows.Forms.TextBox
    Friend WithEvents ADDtxtHdd As System.Windows.Forms.TextBox
    Friend WithEvents ADDtxtProc As System.Windows.Forms.TextBox
    Friend WithEvents ADDtxtMobo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tssl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents txtProd As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NaoepcDataSet4 As NaoePC.naoepcDataSet4
    Friend WithEvents TblpackageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblpackageTableAdapter As NaoePC.naoepcDataSet4TableAdapters.tblpackageTableAdapter
    Friend WithEvents PackageidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotherboardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HDDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GraphicCardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
