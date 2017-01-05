<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.zipcodebox = New System.Windows.Forms.TextBox()
        Me.PriceCalBut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BXRadio = New System.Windows.Forms.RadioButton()
        Me.SIRadio = New System.Windows.Forms.RadioButton()
        Me.MHRadio = New System.Windows.Forms.RadioButton()
        Me.BKRadio = New System.Windows.Forms.RadioButton()
        Me.JFKRadio = New System.Windows.Forms.RadioButton()
        Me.FLRadio = New System.Windows.Forms.RadioButton()
        Me.LGARadio = New System.Windows.Forms.RadioButton()
        Me.EWRadio = New System.Windows.Forms.RadioButton()
        Me.RTcheck = New System.Windows.Forms.CheckBox()
        Me.DiffPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TownLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.TollLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PriceOpt = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WTOpt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZipCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.特殊地点ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZipCodeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeicalZoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.备份ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.VNRadio = New System.Windows.Forms.RadioButton()
        Me.SUVRadio = New System.Windows.Forms.RadioButton()
        Me.SDRadio = New System.Windows.Forms.RadioButton()
        Me.AirportBut = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DistanceLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MultiAreaPrices = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'zipcodebox
        '
        Me.zipcodebox.Location = New System.Drawing.Point(26, 59)
        Me.zipcodebox.MaxLength = 5
        Me.zipcodebox.Multiline = True
        Me.zipcodebox.Name = "zipcodebox"
        Me.zipcodebox.Size = New System.Drawing.Size(56, 20)
        Me.zipcodebox.TabIndex = 0
        '
        'PriceCalBut
        '
        Me.PriceCalBut.Location = New System.Drawing.Point(131, 210)
        Me.PriceCalBut.Name = "PriceCalBut"
        Me.PriceCalBut.Size = New System.Drawing.Size(85, 21)
        Me.PriceCalBut.TabIndex = 1
        Me.PriceCalBut.Text = "Final Price"
        Me.PriceCalBut.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BXRadio)
        Me.GroupBox1.Controls.Add(Me.SIRadio)
        Me.GroupBox1.Controls.Add(Me.MHRadio)
        Me.GroupBox1.Controls.Add(Me.BKRadio)
        Me.GroupBox1.Controls.Add(Me.JFKRadio)
        Me.GroupBox1.Controls.Add(Me.FLRadio)
        Me.GroupBox1.Controls.Add(Me.LGARadio)
        Me.GroupBox1.Controls.Add(Me.EWRadio)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 135)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "目的地"
        '
        'BXRadio
        '
        Me.BXRadio.AutoSize = True
        Me.BXRadio.Location = New System.Drawing.Point(6, 81)
        Me.BXRadio.Name = "BXRadio"
        Me.BXRadio.Size = New System.Drawing.Size(35, 16)
        Me.BXRadio.TabIndex = 7
        Me.BXRadio.Text = "BX"
        Me.BXRadio.UseVisualStyleBackColor = True
        '
        'SIRadio
        '
        Me.SIRadio.AutoSize = True
        Me.SIRadio.Location = New System.Drawing.Point(6, 102)
        Me.SIRadio.Name = "SIRadio"
        Me.SIRadio.Size = New System.Drawing.Size(35, 16)
        Me.SIRadio.TabIndex = 6
        Me.SIRadio.Text = "SI"
        Me.SIRadio.UseVisualStyleBackColor = True
        '
        'MHRadio
        '
        Me.MHRadio.AutoSize = True
        Me.MHRadio.Location = New System.Drawing.Point(6, 39)
        Me.MHRadio.Name = "MHRadio"
        Me.MHRadio.Size = New System.Drawing.Size(35, 16)
        Me.MHRadio.TabIndex = 5
        Me.MHRadio.Text = "MH"
        Me.MHRadio.UseVisualStyleBackColor = True
        '
        'BKRadio
        '
        Me.BKRadio.AutoSize = True
        Me.BKRadio.Location = New System.Drawing.Point(6, 60)
        Me.BKRadio.Name = "BKRadio"
        Me.BKRadio.Size = New System.Drawing.Size(35, 16)
        Me.BKRadio.TabIndex = 4
        Me.BKRadio.Text = "BK"
        Me.BKRadio.UseVisualStyleBackColor = True
        '
        'JFKRadio
        '
        Me.JFKRadio.AutoSize = True
        Me.JFKRadio.Location = New System.Drawing.Point(62, 60)
        Me.JFKRadio.Name = "JFKRadio"
        Me.JFKRadio.Size = New System.Drawing.Size(41, 16)
        Me.JFKRadio.TabIndex = 3
        Me.JFKRadio.Text = "JFK"
        Me.JFKRadio.UseVisualStyleBackColor = True
        '
        'FLRadio
        '
        Me.FLRadio.AutoSize = True
        Me.FLRadio.Checked = True
        Me.FLRadio.Location = New System.Drawing.Point(6, 18)
        Me.FLRadio.Name = "FLRadio"
        Me.FLRadio.Size = New System.Drawing.Size(35, 16)
        Me.FLRadio.TabIndex = 2
        Me.FLRadio.TabStop = True
        Me.FLRadio.Text = "FL"
        Me.FLRadio.UseVisualStyleBackColor = True
        '
        'LGARadio
        '
        Me.LGARadio.AutoSize = True
        Me.LGARadio.Location = New System.Drawing.Point(62, 18)
        Me.LGARadio.Name = "LGARadio"
        Me.LGARadio.Size = New System.Drawing.Size(41, 16)
        Me.LGARadio.TabIndex = 1
        Me.LGARadio.Text = "LGA"
        Me.LGARadio.UseVisualStyleBackColor = True
        '
        'EWRadio
        '
        Me.EWRadio.AutoSize = True
        Me.EWRadio.Location = New System.Drawing.Point(62, 39)
        Me.EWRadio.Name = "EWRadio"
        Me.EWRadio.Size = New System.Drawing.Size(41, 16)
        Me.EWRadio.TabIndex = 0
        Me.EWRadio.Text = "EWR"
        Me.EWRadio.UseVisualStyleBackColor = True
        '
        'RTcheck
        '
        Me.RTcheck.AutoSize = True
        Me.RTcheck.Location = New System.Drawing.Point(19, 143)
        Me.RTcheck.Name = "RTcheck"
        Me.RTcheck.Size = New System.Drawing.Size(84, 16)
        Me.RTcheck.TabIndex = 3
        Me.RTcheck.Text = "Round Trip"
        Me.RTcheck.UseVisualStyleBackColor = True
        '
        'DiffPrice
        '
        Me.DiffPrice.Location = New System.Drawing.Point(19, 210)
        Me.DiffPrice.Name = "DiffPrice"
        Me.DiffPrice.Size = New System.Drawing.Size(54, 21)
        Me.DiffPrice.TabIndex = 5
        Me.DiffPrice.Text = "0"
        Me.DiffPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "差价"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Zip Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Town:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Toll:"
        '
        'TownLabel
        '
        Me.TownLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TownLabel.Location = New System.Drawing.Point(56, 87)
        Me.TownLabel.Name = "TownLabel"
        Me.TownLabel.Size = New System.Drawing.Size(160, 16)
        Me.TownLabel.TabIndex = 11
        '
        'PriceLabel
        '
        Me.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PriceLabel.Location = New System.Drawing.Point(56, 105)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(54, 16)
        Me.PriceLabel.TabIndex = 12
        '
        'TollLabel
        '
        Me.TollLabel.AutoSize = True
        Me.TollLabel.Location = New System.Drawing.Point(159, 126)
        Me.TollLabel.Name = "TollLabel"
        Me.TollLabel.Size = New System.Drawing.Size(23, 12)
        Me.TollLabel.TabIndex = 13
        Me.TollLabel.Text = "N/A"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "建议车费:"
        '
        'PriceOpt
        '
        Me.PriceOpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PriceOpt.Location = New System.Drawing.Point(88, 241)
        Me.PriceOpt.Name = "PriceOpt"
        Me.PriceOpt.Size = New System.Drawing.Size(65, 16)
        Me.PriceOpt.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 12)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "等候时间:"
        Me.Label8.Visible = False
        '
        'WTOpt
        '
        Me.WTOpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WTOpt.Location = New System.Drawing.Point(88, 259)
        Me.WTOpt.Name = "WTOpt"
        Me.WTOpt.Size = New System.Drawing.Size(43, 16)
        Me.WTOpt.TabIndex = 17
        Me.WTOpt.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(137, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "hr(s)"
        Me.Label10.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(26, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Zip Code"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(109, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.Text = "特殊地点"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 24
        Me.ComboBox1.Text = "选择地点"
        Me.ComboBox1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 12)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Region:"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(56, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 16)
        Me.Label13.TabIndex = 26
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(365, 25)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.编辑ToolStripMenuItem, Me.备份ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripMenuItem1.Text = "数据"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZipCodeToolStripMenuItem, Me.特殊地点ToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem3.Text = "添加"
        '
        'ZipCodeToolStripMenuItem
        '
        Me.ZipCodeToolStripMenuItem.Name = "ZipCodeToolStripMenuItem"
        Me.ZipCodeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ZipCodeToolStripMenuItem.Text = "Zip Code"
        '
        '特殊地点ToolStripMenuItem
        '
        Me.特殊地点ToolStripMenuItem.Name = "特殊地点ToolStripMenuItem"
        Me.特殊地点ToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.特殊地点ToolStripMenuItem.Text = "Special Zone"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZipCodeToolStripMenuItem1, Me.SpeicalZoneToolStripMenuItem})
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.编辑ToolStripMenuItem.Text = "编辑"
        Me.编辑ToolStripMenuItem.Visible = False
        '
        'ZipCodeToolStripMenuItem1
        '
        Me.ZipCodeToolStripMenuItem1.Name = "ZipCodeToolStripMenuItem1"
        Me.ZipCodeToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.ZipCodeToolStripMenuItem1.Text = "Zip Code"
        '
        'SpeicalZoneToolStripMenuItem
        '
        Me.SpeicalZoneToolStripMenuItem.Name = "SpeicalZoneToolStripMenuItem"
        Me.SpeicalZoneToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SpeicalZoneToolStripMenuItem.Text = "Speical Zone"
        '
        '备份ToolStripMenuItem
        '
        Me.备份ToolStripMenuItem.Name = "备份ToolStripMenuItem"
        Me.备份ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.备份ToolStripMenuItem.Text = "备份"
        Me.备份ToolStripMenuItem.Visible = False
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.VNRadio)
        Me.GroupBox2.Controls.Add(Me.SUVRadio)
        Me.GroupBox2.Controls.Add(Me.SDRadio)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 42)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "车型"
        '
        'VNRadio
        '
        Me.VNRadio.AutoSize = True
        Me.VNRadio.Location = New System.Drawing.Point(132, 15)
        Me.VNRadio.Name = "VNRadio"
        Me.VNRadio.Size = New System.Drawing.Size(35, 16)
        Me.VNRadio.TabIndex = 33
        Me.VNRadio.TabStop = True
        Me.VNRadio.Text = "VN"
        Me.VNRadio.UseVisualStyleBackColor = True
        '
        'SUVRadio
        '
        Me.SUVRadio.AutoSize = True
        Me.SUVRadio.Location = New System.Drawing.Point(82, 15)
        Me.SUVRadio.Name = "SUVRadio"
        Me.SUVRadio.Size = New System.Drawing.Size(41, 16)
        Me.SUVRadio.TabIndex = 32
        Me.SUVRadio.TabStop = True
        Me.SUVRadio.Text = "SUV"
        Me.SUVRadio.UseVisualStyleBackColor = True
        '
        'SDRadio
        '
        Me.SDRadio.AutoSize = True
        Me.SDRadio.Checked = True
        Me.SDRadio.Location = New System.Drawing.Point(38, 15)
        Me.SDRadio.Name = "SDRadio"
        Me.SDRadio.Size = New System.Drawing.Size(35, 16)
        Me.SDRadio.TabIndex = 31
        Me.SDRadio.TabStop = True
        Me.SDRadio.Text = "SD"
        Me.SDRadio.UseVisualStyleBackColor = True
        '
        'AirportBut
        '
        Me.AirportBut.Location = New System.Drawing.Point(239, 29)
        Me.AirportBut.Name = "AirportBut"
        Me.AirportBut.Size = New System.Drawing.Size(107, 22)
        Me.AirportBut.TabIndex = 32
        Me.AirportBut.Text = "航站楼查询"
        Me.AirportBut.UseVisualStyleBackColor = True
        Me.AirportBut.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(241, 299)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 21)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "计算器"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 336)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(365, 189)
        Me.WebBrowser1.TabIndex = 43
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'TimeLabel
        '
        Me.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeLabel.Location = New System.Drawing.Point(88, 307)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(91, 18)
        Me.TimeLabel.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 12)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "时间:"
        '
        'DistanceLabel
        '
        Me.DistanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DistanceLabel.Location = New System.Drawing.Point(88, 284)
        Me.DistanceLabel.Name = "DistanceLabel"
        Me.DistanceLabel.Size = New System.Drawing.Size(88, 18)
        Me.DistanceLabel.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 12)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "距离:"
        '
        'MultiAreaPrices
        '
        Me.MultiAreaPrices.Location = New System.Drawing.Point(241, 270)
        Me.MultiAreaPrices.Name = "MultiAreaPrices"
        Me.MultiAreaPrices.Size = New System.Drawing.Size(110, 23)
        Me.MultiAreaPrices.TabIndex = 44
        Me.MultiAreaPrices.Text = "多地区查询"
        Me.MultiAreaPrices.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(365, 525)
        Me.Controls.Add(Me.MultiAreaPrices)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DistanceLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.AirportBut)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.WTOpt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PriceOpt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TollLabel)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.TownLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DiffPrice)
        Me.Controls.Add(Me.RTcheck)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PriceCalBut)
        Me.Controls.Add(Me.zipcodebox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Price Cal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zipcodebox As System.Windows.Forms.TextBox
    Friend WithEvents PriceCalBut As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MHRadio As System.Windows.Forms.RadioButton
    Friend WithEvents BKRadio As System.Windows.Forms.RadioButton
    Friend WithEvents JFKRadio As System.Windows.Forms.RadioButton
    Friend WithEvents FLRadio As System.Windows.Forms.RadioButton
    Friend WithEvents LGARadio As System.Windows.Forms.RadioButton
    Friend WithEvents EWRadio As System.Windows.Forms.RadioButton
    Friend WithEvents RTcheck As System.Windows.Forms.CheckBox
    Friend WithEvents DiffPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TownLabel As System.Windows.Forms.Label
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents TollLabel As System.Windows.Forms.Label
    Friend WithEvents BXRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SIRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PriceOpt As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents WTOpt As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 备份ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents VNRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SUVRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SDRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ZipCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 特殊地点ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AirportBut As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents 编辑ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZipCodeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeicalZoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DistanceLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MultiAreaPrices As Button
End Class
