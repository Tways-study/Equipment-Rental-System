<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKiosk
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTagLine = New System.Windows.Forms.Label()
        Me.MainSplitter = New System.Windows.Forms.SplitContainer()
        Me.pnlFilterBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlGrid = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblCartTitle = New System.Windows.Forms.Label()
        Me.pnlCartItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCartBottom = New System.Windows.Forms.Panel()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnClearCart = New System.Windows.Forms.Button()
        Me.lblDaysLabel = New System.Windows.Forms.Label()
        Me.btnDaysDown = New System.Windows.Forms.Button()
        Me.lblDaysValue = New System.Windows.Forms.Label()
        Me.btnDaysUp = New System.Windows.Forms.Button()
        Me.btnPillAllGear = New System.Windows.Forms.Button()
        Me.btnPillSeating = New System.Windows.Forms.Button()
        Me.btnPillAudioVisual = New System.Windows.Forms.Button()
        Me.btnPillTables = New System.Windows.Forms.Button()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.lblIcon1 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.lblRate1 = New System.Windows.Forms.Label()
        Me.lblStock1 = New System.Windows.Forms.Label()
        Me.btnAddCart1 = New System.Windows.Forms.Button()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.lblIcon2 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblRate2 = New System.Windows.Forms.Label()
        Me.lblStock2 = New System.Windows.Forms.Label()
        Me.btnAddCart2 = New System.Windows.Forms.Button()
        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.lblIcon3 = New System.Windows.Forms.Label()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.lblRate3 = New System.Windows.Forms.Label()
        Me.lblStock3 = New System.Windows.Forms.Label()
        Me.btnAddCart3 = New System.Windows.Forms.Button()
        Me.pnlCard4 = New System.Windows.Forms.Panel()
        Me.lblIcon4 = New System.Windows.Forms.Label()
        Me.lblName4 = New System.Windows.Forms.Label()
        Me.lblRate4 = New System.Windows.Forms.Label()
        Me.lblStock4 = New System.Windows.Forms.Label()
        Me.btnAddCart4 = New System.Windows.Forms.Button()
        Me.pnlCard5 = New System.Windows.Forms.Panel()
        Me.lblIcon5 = New System.Windows.Forms.Label()
        Me.lblName5 = New System.Windows.Forms.Label()
        Me.lblRate5 = New System.Windows.Forms.Label()
        Me.lblStock5 = New System.Windows.Forms.Label()
        Me.btnAddCart5 = New System.Windows.Forms.Button()
        Me.pnlCard6 = New System.Windows.Forms.Panel()
        Me.lblIcon6 = New System.Windows.Forms.Label()
        Me.lblName6 = New System.Windows.Forms.Label()
        Me.lblRate6 = New System.Windows.Forms.Label()
        Me.lblStock6 = New System.Windows.Forms.Label()
        Me.btnAddCart6 = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitter.Panel1.SuspendLayout()
        Me.MainSplitter.Panel2.SuspendLayout()
        Me.MainSplitter.SuspendLayout()
        Me.pnlCartBottom.SuspendLayout()
        Me.pnlFilterBar.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlCard3.SuspendLayout()
        Me.pnlCard4.SuspendLayout()
        Me.pnlCard5.SuspendLayout()
        Me.pnlCard6.SuspendLayout()
        Me.SuspendLayout()
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(127, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "2C Rentals"
        '
        ' lblTagLine
        '
        Me.lblTagLine.AutoSize = True
        Me.lblTagLine.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTagLine.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220)
        Me.lblTagLine.Location = New System.Drawing.Point(180, 18)
        Me.lblTagLine.Name = "lblTagLine"
        Me.lblTagLine.Size = New System.Drawing.Size(340, 15)
        Me.lblTagLine.TabIndex = 1
        Me.lblTagLine.Text = "Equipment Rental System  |  Press F12 for Admin"
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblTagLine)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1264, 56)
        Me.pnlHeader.TabIndex = 0
        '
        ' btnPillAllGear
        '
        Me.btnPillAllGear.AutoSize = True
        Me.btnPillAllGear.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnPillAllGear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPillAllGear.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnPillAllGear.FlatAppearance.BorderSize = 1
        Me.btnPillAllGear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPillAllGear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPillAllGear.ForeColor = System.Drawing.Color.White
        Me.btnPillAllGear.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
        Me.btnPillAllGear.Name = "btnPillAllGear"
        Me.btnPillAllGear.Padding = New System.Windows.Forms.Padding(12, 4, 12, 4)
        Me.btnPillAllGear.Tag = "All Gear"
        Me.btnPillAllGear.Text = "All Gear"
        Me.btnPillAllGear.UseVisualStyleBackColor = False
        '
        ' btnPillSeating
        '
        Me.btnPillSeating.AutoSize = True
        Me.btnPillSeating.BackColor = System.Drawing.Color.White
        Me.btnPillSeating.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPillSeating.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnPillSeating.FlatAppearance.BorderSize = 1
        Me.btnPillSeating.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPillSeating.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPillSeating.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnPillSeating.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
        Me.btnPillSeating.Name = "btnPillSeating"
        Me.btnPillSeating.Padding = New System.Windows.Forms.Padding(12, 4, 12, 4)
        Me.btnPillSeating.Tag = "Seating"
        Me.btnPillSeating.Text = "Seating"
        Me.btnPillSeating.UseVisualStyleBackColor = False
        '
        ' btnPillAudioVisual
        '
        Me.btnPillAudioVisual.AutoSize = True
        Me.btnPillAudioVisual.BackColor = System.Drawing.Color.White
        Me.btnPillAudioVisual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPillAudioVisual.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnPillAudioVisual.FlatAppearance.BorderSize = 1
        Me.btnPillAudioVisual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPillAudioVisual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPillAudioVisual.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnPillAudioVisual.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
        Me.btnPillAudioVisual.Name = "btnPillAudioVisual"
        Me.btnPillAudioVisual.Padding = New System.Windows.Forms.Padding(12, 4, 12, 4)
        Me.btnPillAudioVisual.Tag = "Audio/Visual"
        Me.btnPillAudioVisual.Text = "Audio/Visual"
        Me.btnPillAudioVisual.UseVisualStyleBackColor = False
        '
        ' btnPillTables
        '
        Me.btnPillTables.AutoSize = True
        Me.btnPillTables.BackColor = System.Drawing.Color.White
        Me.btnPillTables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPillTables.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnPillTables.FlatAppearance.BorderSize = 1
        Me.btnPillTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPillTables.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPillTables.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnPillTables.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
        Me.btnPillTables.Name = "btnPillTables"
        Me.btnPillTables.Padding = New System.Windows.Forms.Padding(12, 4, 12, 4)
        Me.btnPillTables.Tag = "Tables"
        Me.btnPillTables.Text = "Tables"
        Me.btnPillTables.UseVisualStyleBackColor = False
        '
        ' pnlFilterBar  (DockStyle.Top inside Panel1)
        '
        Me.pnlFilterBar.AutoSize = False
        Me.pnlFilterBar.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0F2F5")
        Me.pnlFilterBar.Controls.Add(Me.btnPillAllGear)
        Me.pnlFilterBar.Controls.Add(Me.btnPillSeating)
        Me.pnlFilterBar.Controls.Add(Me.btnPillAudioVisual)
        Me.pnlFilterBar.Controls.Add(Me.btnPillTables)
        Me.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterBar.Location = New System.Drawing.Point(16, 10)
        Me.pnlFilterBar.Name = "pnlFilterBar"
        Me.pnlFilterBar.Size = New System.Drawing.Size(796, 44)
        Me.pnlFilterBar.TabIndex = 1
        Me.pnlFilterBar.WrapContents = False
        '
        ' pnlGrid  (DockStyle.Fill inside Panel1 — added first so FilterBar docks on top)
        '
        Me.pnlGrid.AutoScroll = True
        Me.pnlGrid.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0F2F5")
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(16, 54)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.pnlGrid.Size = New System.Drawing.Size(796, 641)
        Me.pnlGrid.TabIndex = 0
        Me.pnlGrid.Controls.Add(Me.pnlCard1)
        Me.pnlGrid.Controls.Add(Me.pnlCard2)
        Me.pnlGrid.Controls.Add(Me.pnlCard3)
        Me.pnlGrid.Controls.Add(Me.pnlCard4)
        Me.pnlGrid.Controls.Add(Me.pnlCard5)
        Me.pnlGrid.Controls.Add(Me.pnlCard6)
        Me.pnlGrid.WrapContents = True
        '
        ' lblIcon1
        '
        Me.lblIcon1.Font = New System.Drawing.Font("Segoe UI Emoji", 28.0!)
        Me.lblIcon1.Location = New System.Drawing.Point(10, 4)
        Me.lblIcon1.Name = "lblIcon1"
        Me.lblIcon1.Size = New System.Drawing.Size(210, 50)
        Me.lblIcon1.TabIndex = 0
        Me.lblIcon1.Text = "📽️"
        Me.lblIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblName1
        '
        Me.lblName1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblName1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblName1.Location = New System.Drawing.Point(10, 56)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(210, 22)
        Me.lblName1.TabIndex = 1
        Me.lblName1.Text = "4K Projector"
        Me.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblRate1
        '
        Me.lblRate1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRate1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F47C20")
        Me.lblRate1.Location = New System.Drawing.Point(10, 80)
        Me.lblRate1.Name = "lblRate1"
        Me.lblRate1.Size = New System.Drawing.Size(210, 22)
        Me.lblRate1.TabIndex = 2
        Me.lblRate1.Text = "₱2,500/day"
        Me.lblRate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblStock1
        '
        Me.lblStock1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblStock1.ForeColor = System.Drawing.Color.Gray
        Me.lblStock1.Location = New System.Drawing.Point(10, 104)
        Me.lblStock1.Name = "lblStock1"
        Me.lblStock1.Size = New System.Drawing.Size(210, 18)
        Me.lblStock1.TabIndex = 3
        Me.lblStock1.Text = "Stock: 3"
        Me.lblStock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnAddCart1
        '
        Me.btnAddCart1.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnAddCart1.FlatAppearance.BorderSize = 0
        Me.btnAddCart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCart1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCart1.ForeColor = System.Drawing.Color.White
        Me.btnAddCart1.Location = New System.Drawing.Point(15, 128)
        Me.btnAddCart1.Name = "btnAddCart1"
        Me.btnAddCart1.Size = New System.Drawing.Size(200, 36)
        Me.btnAddCart1.TabIndex = 4
        Me.btnAddCart1.Text = "Add to Cart"
        Me.btnAddCart1.UseVisualStyleBackColor = False
        '
        ' pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.White
        Me.pnlCard1.Controls.Add(Me.lblIcon1)
        Me.pnlCard1.Controls.Add(Me.lblName1)
        Me.pnlCard1.Controls.Add(Me.lblRate1)
        Me.pnlCard1.Controls.Add(Me.lblStock1)
        Me.pnlCard1.Controls.Add(Me.btnAddCart1)
        Me.pnlCard1.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlCard1.Size = New System.Drawing.Size(230, 190)
        Me.pnlCard1.TabIndex = 10
        '
        ' lblIcon2
        '
        Me.lblIcon2.Font = New System.Drawing.Font("Segoe UI Emoji", 28.0!)
        Me.lblIcon2.Location = New System.Drawing.Point(10, 4)
        Me.lblIcon2.Name = "lblIcon2"
        Me.lblIcon2.Size = New System.Drawing.Size(210, 50)
        Me.lblIcon2.TabIndex = 0
        Me.lblIcon2.Text = "🍽️"
        Me.lblIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblName2
        '
        Me.lblName2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblName2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblName2.Location = New System.Drawing.Point(10, 56)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(210, 22)
        Me.lblName2.TabIndex = 1
        Me.lblName2.Text = "Banquet Table"
        Me.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblRate2
        '
        Me.lblRate2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRate2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F47C20")
        Me.lblRate2.Location = New System.Drawing.Point(10, 80)
        Me.lblRate2.Name = "lblRate2"
        Me.lblRate2.Size = New System.Drawing.Size(210, 22)
        Me.lblRate2.TabIndex = 2
        Me.lblRate2.Text = "₱450/day"
        Me.lblRate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblStock2
        '
        Me.lblStock2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblStock2.ForeColor = System.Drawing.Color.Gray
        Me.lblStock2.Location = New System.Drawing.Point(10, 104)
        Me.lblStock2.Name = "lblStock2"
        Me.lblStock2.Size = New System.Drawing.Size(210, 18)
        Me.lblStock2.TabIndex = 3
        Me.lblStock2.Text = "Stock: 14"
        Me.lblStock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnAddCart2
        '
        Me.btnAddCart2.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnAddCart2.FlatAppearance.BorderSize = 0
        Me.btnAddCart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCart2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCart2.ForeColor = System.Drawing.Color.White
        Me.btnAddCart2.Location = New System.Drawing.Point(15, 128)
        Me.btnAddCart2.Name = "btnAddCart2"
        Me.btnAddCart2.Size = New System.Drawing.Size(200, 36)
        Me.btnAddCart2.TabIndex = 4
        Me.btnAddCart2.Text = "Add to Cart"
        Me.btnAddCart2.UseVisualStyleBackColor = False
        '
        ' pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.White
        Me.pnlCard2.Controls.Add(Me.lblIcon2)
        Me.pnlCard2.Controls.Add(Me.lblName2)
        Me.pnlCard2.Controls.Add(Me.lblRate2)
        Me.pnlCard2.Controls.Add(Me.lblStock2)
        Me.pnlCard2.Controls.Add(Me.btnAddCart2)
        Me.pnlCard2.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlCard2.Size = New System.Drawing.Size(230, 190)
        Me.pnlCard2.TabIndex = 11
        '
        ' lblIcon3
        '
        Me.lblIcon3.Font = New System.Drawing.Font("Segoe UI Emoji", 28.0!)
        Me.lblIcon3.Location = New System.Drawing.Point(10, 4)
        Me.lblIcon3.Name = "lblIcon3"
        Me.lblIcon3.Size = New System.Drawing.Size(210, 50)
        Me.lblIcon3.TabIndex = 0
        Me.lblIcon3.Text = "🪑"
        Me.lblIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblName3
        '
        Me.lblName3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblName3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblName3.Location = New System.Drawing.Point(10, 56)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(210, 22)
        Me.lblName3.TabIndex = 1
        Me.lblName3.Text = "Executive Chair"
        Me.lblName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblRate3
        '
        Me.lblRate3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRate3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F47C20")
        Me.lblRate3.Location = New System.Drawing.Point(10, 80)
        Me.lblRate3.Name = "lblRate3"
        Me.lblRate3.Size = New System.Drawing.Size(210, 22)
        Me.lblRate3.TabIndex = 2
        Me.lblRate3.Text = "₱250/day"
        Me.lblRate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblStock3
        '
        Me.lblStock3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblStock3.ForeColor = System.Drawing.Color.Gray
        Me.lblStock3.Location = New System.Drawing.Point(10, 104)
        Me.lblStock3.Name = "lblStock3"
        Me.lblStock3.Size = New System.Drawing.Size(210, 18)
        Me.lblStock3.TabIndex = 3
        Me.lblStock3.Text = "Stock: 19"
        Me.lblStock3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnAddCart3
        '
        Me.btnAddCart3.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnAddCart3.FlatAppearance.BorderSize = 0
        Me.btnAddCart3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCart3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCart3.ForeColor = System.Drawing.Color.White
        Me.btnAddCart3.Location = New System.Drawing.Point(15, 128)
        Me.btnAddCart3.Name = "btnAddCart3"
        Me.btnAddCart3.Size = New System.Drawing.Size(200, 36)
        Me.btnAddCart3.TabIndex = 4
        Me.btnAddCart3.Text = "Add to Cart"
        Me.btnAddCart3.UseVisualStyleBackColor = False
        '
        ' pnlCard3
        '
        Me.pnlCard3.BackColor = System.Drawing.Color.White
        Me.pnlCard3.Controls.Add(Me.lblIcon3)
        Me.pnlCard3.Controls.Add(Me.lblName3)
        Me.pnlCard3.Controls.Add(Me.lblRate3)
        Me.pnlCard3.Controls.Add(Me.lblStock3)
        Me.pnlCard3.Controls.Add(Me.btnAddCart3)
        Me.pnlCard3.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlCard3.Size = New System.Drawing.Size(230, 190)
        Me.pnlCard3.TabIndex = 12
        '
        ' lblIcon4
        '
        Me.lblIcon4.Font = New System.Drawing.Font("Segoe UI Emoji", 28.0!)
        Me.lblIcon4.Location = New System.Drawing.Point(10, 4)
        Me.lblIcon4.Name = "lblIcon4"
        Me.lblIcon4.Size = New System.Drawing.Size(210, 50)
        Me.lblIcon4.TabIndex = 0
        Me.lblIcon4.Text = "☂️"
        Me.lblIcon4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblName4
        '
        Me.lblName4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblName4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblName4.Location = New System.Drawing.Point(10, 56)
        Me.lblName4.Name = "lblName4"
        Me.lblName4.Size = New System.Drawing.Size(210, 22)
        Me.lblName4.TabIndex = 1
        Me.lblName4.Text = "Outdoor Umbrella"
        Me.lblName4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblRate4
        '
        Me.lblRate4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRate4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F47C20")
        Me.lblRate4.Location = New System.Drawing.Point(10, 80)
        Me.lblRate4.Name = "lblRate4"
        Me.lblRate4.Size = New System.Drawing.Size(210, 22)
        Me.lblRate4.TabIndex = 2
        Me.lblRate4.Text = "₱350/day"
        Me.lblRate4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblStock4
        '
        Me.lblStock4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblStock4.ForeColor = System.Drawing.Color.Gray
        Me.lblStock4.Location = New System.Drawing.Point(10, 104)
        Me.lblStock4.Name = "lblStock4"
        Me.lblStock4.Size = New System.Drawing.Size(210, 18)
        Me.lblStock4.TabIndex = 3
        Me.lblStock4.Text = "Stock: 10"
        Me.lblStock4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnAddCart4
        '
        Me.btnAddCart4.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnAddCart4.FlatAppearance.BorderSize = 0
        Me.btnAddCart4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCart4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCart4.ForeColor = System.Drawing.Color.White
        Me.btnAddCart4.Location = New System.Drawing.Point(15, 128)
        Me.btnAddCart4.Name = "btnAddCart4"
        Me.btnAddCart4.Size = New System.Drawing.Size(200, 36)
        Me.btnAddCart4.TabIndex = 4
        Me.btnAddCart4.Text = "Add to Cart"
        Me.btnAddCart4.UseVisualStyleBackColor = False
        '
        ' pnlCard4
        '
        Me.pnlCard4.BackColor = System.Drawing.Color.White
        Me.pnlCard4.Controls.Add(Me.lblIcon4)
        Me.pnlCard4.Controls.Add(Me.lblName4)
        Me.pnlCard4.Controls.Add(Me.lblRate4)
        Me.pnlCard4.Controls.Add(Me.lblStock4)
        Me.pnlCard4.Controls.Add(Me.btnAddCart4)
        Me.pnlCard4.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCard4.Name = "pnlCard4"
        Me.pnlCard4.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlCard4.Size = New System.Drawing.Size(230, 190)
        Me.pnlCard4.TabIndex = 13
        '
        ' lblIcon5
        '
        Me.lblIcon5.Font = New System.Drawing.Font("Segoe UI Emoji", 28.0!)
        Me.lblIcon5.Location = New System.Drawing.Point(10, 4)
        Me.lblIcon5.Name = "lblIcon5"
        Me.lblIcon5.Size = New System.Drawing.Size(210, 50)
        Me.lblIcon5.TabIndex = 0
        Me.lblIcon5.Text = "🎵"
        Me.lblIcon5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblName5
        '
        Me.lblName5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblName5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblName5.Location = New System.Drawing.Point(10, 56)
        Me.lblName5.Name = "lblName5"
        Me.lblName5.Size = New System.Drawing.Size(210, 22)
        Me.lblName5.TabIndex = 1
        Me.lblName5.Text = "PA System"
        Me.lblName5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblRate5
        '
        Me.lblRate5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRate5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F47C20")
        Me.lblRate5.Location = New System.Drawing.Point(10, 80)
        Me.lblRate5.Name = "lblRate5"
        Me.lblRate5.Size = New System.Drawing.Size(210, 22)
        Me.lblRate5.TabIndex = 2
        Me.lblRate5.Text = "₱1,200/day"
        Me.lblRate5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblStock5
        '
        Me.lblStock5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblStock5.ForeColor = System.Drawing.Color.Gray
        Me.lblStock5.Location = New System.Drawing.Point(10, 104)
        Me.lblStock5.Name = "lblStock5"
        Me.lblStock5.Size = New System.Drawing.Size(210, 18)
        Me.lblStock5.TabIndex = 3
        Me.lblStock5.Text = "Stock: 4"
        Me.lblStock5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnAddCart5
        '
        Me.btnAddCart5.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnAddCart5.FlatAppearance.BorderSize = 0
        Me.btnAddCart5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCart5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCart5.ForeColor = System.Drawing.Color.White
        Me.btnAddCart5.Location = New System.Drawing.Point(15, 128)
        Me.btnAddCart5.Name = "btnAddCart5"
        Me.btnAddCart5.Size = New System.Drawing.Size(200, 36)
        Me.btnAddCart5.TabIndex = 4
        Me.btnAddCart5.Text = "Add to Cart"
        Me.btnAddCart5.UseVisualStyleBackColor = False
        '
        ' pnlCard5
        '
        Me.pnlCard5.BackColor = System.Drawing.Color.White
        Me.pnlCard5.Controls.Add(Me.lblIcon5)
        Me.pnlCard5.Controls.Add(Me.lblName5)
        Me.pnlCard5.Controls.Add(Me.lblRate5)
        Me.pnlCard5.Controls.Add(Me.lblStock5)
        Me.pnlCard5.Controls.Add(Me.btnAddCart5)
        Me.pnlCard5.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCard5.Name = "pnlCard5"
        Me.pnlCard5.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlCard5.Size = New System.Drawing.Size(230, 190)
        Me.pnlCard5.TabIndex = 14
        '
        ' lblIcon6
        '
        Me.lblIcon6.Font = New System.Drawing.Font("Segoe UI Emoji", 28.0!)
        Me.lblIcon6.Location = New System.Drawing.Point(10, 4)
        Me.lblIcon6.Name = "lblIcon6"
        Me.lblIcon6.Size = New System.Drawing.Size(210, 50)
        Me.lblIcon6.TabIndex = 0
        Me.lblIcon6.Text = "💡"
        Me.lblIcon6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblName6
        '
        Me.lblName6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblName6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblName6.Location = New System.Drawing.Point(10, 56)
        Me.lblName6.Name = "lblName6"
        Me.lblName6.Size = New System.Drawing.Size(210, 22)
        Me.lblName6.TabIndex = 1
        Me.lblName6.Text = "Stage Lighting Kit"
        Me.lblName6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblRate6
        '
        Me.lblRate6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRate6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F47C20")
        Me.lblRate6.Location = New System.Drawing.Point(10, 80)
        Me.lblRate6.Name = "lblRate6"
        Me.lblRate6.Size = New System.Drawing.Size(210, 22)
        Me.lblRate6.TabIndex = 2
        Me.lblRate6.Text = "₱800/day"
        Me.lblRate6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblStock6
        '
        Me.lblStock6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblStock6.ForeColor = System.Drawing.Color.Gray
        Me.lblStock6.Location = New System.Drawing.Point(10, 104)
        Me.lblStock6.Name = "lblStock6"
        Me.lblStock6.Size = New System.Drawing.Size(210, 18)
        Me.lblStock6.TabIndex = 3
        Me.lblStock6.Text = "Stock: 3"
        Me.lblStock6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnAddCart6
        '
        Me.btnAddCart6.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnAddCart6.FlatAppearance.BorderSize = 0
        Me.btnAddCart6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCart6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCart6.ForeColor = System.Drawing.Color.White
        Me.btnAddCart6.Location = New System.Drawing.Point(15, 128)
        Me.btnAddCart6.Name = "btnAddCart6"
        Me.btnAddCart6.Size = New System.Drawing.Size(200, 36)
        Me.btnAddCart6.TabIndex = 4
        Me.btnAddCart6.Text = "Add to Cart"
        Me.btnAddCart6.UseVisualStyleBackColor = False
        '
        ' pnlCard6
        '
        Me.pnlCard6.BackColor = System.Drawing.Color.White
        Me.pnlCard6.Controls.Add(Me.lblIcon6)
        Me.pnlCard6.Controls.Add(Me.lblName6)
        Me.pnlCard6.Controls.Add(Me.lblRate6)
        Me.pnlCard6.Controls.Add(Me.lblStock6)
        Me.pnlCard6.Controls.Add(Me.btnAddCart6)
        Me.pnlCard6.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCard6.Name = "pnlCard6"
        Me.pnlCard6.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlCard6.Size = New System.Drawing.Size(230, 190)
        Me.pnlCard6.TabIndex = 15
        '
        ' MainSplitter.Panel1
        '
        Me.MainSplitter.Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0F2F5")
        Me.MainSplitter.Panel1.Controls.Add(Me.pnlGrid)
        Me.MainSplitter.Panel1.Controls.Add(Me.pnlFilterBar)
        Me.MainSplitter.Panel1.Padding = New System.Windows.Forms.Padding(16, 10, 8, 10)
        '
        ' lblCartTitle  (DockStyle.Top inside Panel2)
        '
        Me.lblCartTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCartTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblCartTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblCartTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblCartTitle.Name = "lblCartTitle"
        Me.lblCartTitle.Size = New System.Drawing.Size(418, 38)
        Me.lblCartTitle.TabIndex = 0
        Me.lblCartTitle.Text = "🛒  Your Cart"
        '
        ' pnlCartItems  (DockStyle.Fill inside Panel2 — added first)
        '
        Me.pnlCartItems.AutoScroll = True
        Me.pnlCartItems.BackColor = System.Drawing.Color.White
        Me.pnlCartItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCartItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlCartItems.Location = New System.Drawing.Point(12, 50)
        Me.pnlCartItems.Name = "pnlCartItems"
        Me.pnlCartItems.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.pnlCartItems.Size = New System.Drawing.Size(418, 483)
        Me.pnlCartItems.TabIndex = 1
        Me.pnlCartItems.WrapContents = False
        '
        ' lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtotal.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtotal.Location = New System.Drawing.Point(8, 44)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 17)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal: ₱0.00"
        '
        ' lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblDeposit.ForeColor = System.Drawing.Color.Gray
        Me.lblDeposit.Location = New System.Drawing.Point(8, 68)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(170, 17)
        Me.lblDeposit.TabIndex = 1
        Me.lblDeposit.Text = "Security Deposit: ₱500.00"
        '
        ' lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblTotal.Location = New System.Drawing.Point(8, 96)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(140, 22)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total: ₱500.00"
        '
        ' btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.ColorTranslator.FromHtml("#F47C20")
        Me.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(8, 136)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(280, 48)
        Me.btnCheckout.TabIndex = 3
        Me.btnCheckout.Text = "PROCEED TO CHECKOUT →"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        ' btnClearCart
        '
        Me.btnClearCart.BackColor = System.Drawing.Color.FromArgb(180, 30, 30)
        Me.btnClearCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearCart.FlatAppearance.BorderSize = 0
        Me.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearCart.ForeColor = System.Drawing.Color.White
        Me.btnClearCart.Location = New System.Drawing.Point(296, 136)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(114, 48)
        Me.btnClearCart.TabIndex = 4
        Me.btnClearCart.Text = "🗑 Clear Cart"
        Me.btnClearCart.UseVisualStyleBackColor = False
        '
        ' pnlCartBottom  (DockStyle.Bottom inside Panel2)
        '
        '
        ' lblDaysLabel
        '
        Me.lblDaysLabel.AutoSize = True
        Me.lblDaysLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDaysLabel.ForeColor = System.Drawing.Color.Gray
        Me.lblDaysLabel.Location = New System.Drawing.Point(8, 14)
        Me.lblDaysLabel.Name = "lblDaysLabel"
        Me.lblDaysLabel.TabIndex = 5
        Me.lblDaysLabel.Text = "Rental Days:"
        '
        ' btnDaysDown
        '
        Me.btnDaysDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaysDown.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDaysDown.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnDaysDown.Location = New System.Drawing.Point(108, 6)
        Me.btnDaysDown.Name = "btnDaysDown"
        Me.btnDaysDown.Size = New System.Drawing.Size(28, 28)
        Me.btnDaysDown.TabIndex = 6
        Me.btnDaysDown.Text = "−"
        Me.btnDaysDown.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        '
        ' lblDaysValue
        '
        Me.lblDaysValue.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDaysValue.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.lblDaysValue.Location = New System.Drawing.Point(138, 6)
        Me.lblDaysValue.Name = "lblDaysValue"
        Me.lblDaysValue.Size = New System.Drawing.Size(34, 28)
        Me.lblDaysValue.TabIndex = 7
        Me.lblDaysValue.Text = "1"
        Me.lblDaysValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnDaysUp
        '
        Me.btnDaysUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaysUp.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDaysUp.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1E3A5F")
        Me.btnDaysUp.Location = New System.Drawing.Point(174, 6)
        Me.btnDaysUp.Name = "btnDaysUp"
        Me.btnDaysUp.Size = New System.Drawing.Size(28, 28)
        Me.btnDaysUp.TabIndex = 8
        Me.btnDaysUp.Text = "+"
        Me.btnDaysUp.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        '
        ' pnlCartBottom
        '
        Me.pnlCartBottom.BackColor = System.Drawing.Color.White
        Me.pnlCartBottom.Controls.Add(Me.lblSubtotal)
        Me.pnlCartBottom.Controls.Add(Me.lblDeposit)
        Me.pnlCartBottom.Controls.Add(Me.lblTotal)
        Me.pnlCartBottom.Controls.Add(Me.lblDaysLabel)
        Me.pnlCartBottom.Controls.Add(Me.btnDaysDown)
        Me.pnlCartBottom.Controls.Add(Me.lblDaysValue)
        Me.pnlCartBottom.Controls.Add(Me.btnDaysUp)
        Me.pnlCartBottom.Controls.Add(Me.btnCheckout)
        Me.pnlCartBottom.Controls.Add(Me.btnClearCart)
        Me.pnlCartBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCartBottom.Location = New System.Drawing.Point(12, 497)
        Me.pnlCartBottom.Name = "pnlCartBottom"
        Me.pnlCartBottom.Size = New System.Drawing.Size(418, 196)
        Me.pnlCartBottom.TabIndex = 2
        '
        ' MainSplitter.Panel2
        '
        Me.MainSplitter.Panel2.BackColor = System.Drawing.Color.White
        Me.MainSplitter.Panel2.Controls.Add(Me.pnlCartItems)
        Me.MainSplitter.Panel2.Controls.Add(Me.lblCartTitle)
        Me.MainSplitter.Panel2.Controls.Add(Me.pnlCartBottom)
        Me.MainSplitter.Panel2.Padding = New System.Windows.Forms.Padding(12)
        '
        ' MainSplitter
        '
        Me.MainSplitter.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0F2F5")
        Me.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.MainSplitter.Location = New System.Drawing.Point(0, 56)
        Me.MainSplitter.Name = "MainSplitter"
        Me.MainSplitter.Size = New System.Drawing.Size(1264, 705)
        Me.MainSplitter.SplitterDistance = 820
        Me.MainSplitter.SplitterWidth = 2
        Me.MainSplitter.TabIndex = 1
        '
        ' FrmKiosk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0F2F5")
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.MainSplitter)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "FrmKiosk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2C Rentals — Equipment Rental Kiosk"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitter.Panel1.ResumeLayout(False)
        Me.MainSplitter.Panel2.ResumeLayout(False)
        Me.MainSplitter.ResumeLayout(False)
        Me.pnlCard1.ResumeLayout(False)
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard3.ResumeLayout(False)
        Me.pnlCard4.ResumeLayout(False)
        Me.pnlCard5.ResumeLayout(False)
        Me.pnlCard6.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlFilterBar.ResumeLayout(False)
        Me.pnlCartBottom.ResumeLayout(False)
        Me.pnlCartBottom.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTagLine As System.Windows.Forms.Label
    Friend WithEvents MainSplitter As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlFilterBar As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlGrid As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblCartTitle As System.Windows.Forms.Label
    Friend WithEvents pnlCartItems As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlCartBottom As System.Windows.Forms.Panel
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblDeposit As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCheckout As System.Windows.Forms.Button
    Friend WithEvents btnClearCart As System.Windows.Forms.Button
    Friend WithEvents lblDaysLabel As System.Windows.Forms.Label
    Friend WithEvents btnDaysDown As System.Windows.Forms.Button
    Friend WithEvents lblDaysValue As System.Windows.Forms.Label
    Friend WithEvents btnDaysUp As System.Windows.Forms.Button
    Friend WithEvents btnPillAllGear As System.Windows.Forms.Button
    Friend WithEvents btnPillSeating As System.Windows.Forms.Button
    Friend WithEvents btnPillAudioVisual As System.Windows.Forms.Button
    Friend WithEvents btnPillTables As System.Windows.Forms.Button
    Friend WithEvents pnlCard1 As System.Windows.Forms.Panel
    Friend WithEvents lblIcon1 As System.Windows.Forms.Label
    Friend WithEvents lblName1 As System.Windows.Forms.Label
    Friend WithEvents lblRate1 As System.Windows.Forms.Label
    Friend WithEvents lblStock1 As System.Windows.Forms.Label
    Friend WithEvents btnAddCart1 As System.Windows.Forms.Button
    Friend WithEvents pnlCard2 As System.Windows.Forms.Panel
    Friend WithEvents lblIcon2 As System.Windows.Forms.Label
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents lblRate2 As System.Windows.Forms.Label
    Friend WithEvents lblStock2 As System.Windows.Forms.Label
    Friend WithEvents btnAddCart2 As System.Windows.Forms.Button
    Friend WithEvents pnlCard3 As System.Windows.Forms.Panel
    Friend WithEvents lblIcon3 As System.Windows.Forms.Label
    Friend WithEvents lblName3 As System.Windows.Forms.Label
    Friend WithEvents lblRate3 As System.Windows.Forms.Label
    Friend WithEvents lblStock3 As System.Windows.Forms.Label
    Friend WithEvents btnAddCart3 As System.Windows.Forms.Button
    Friend WithEvents pnlCard4 As System.Windows.Forms.Panel
    Friend WithEvents lblIcon4 As System.Windows.Forms.Label
    Friend WithEvents lblName4 As System.Windows.Forms.Label
    Friend WithEvents lblRate4 As System.Windows.Forms.Label
    Friend WithEvents lblStock4 As System.Windows.Forms.Label
    Friend WithEvents btnAddCart4 As System.Windows.Forms.Button
    Friend WithEvents pnlCard5 As System.Windows.Forms.Panel
    Friend WithEvents lblIcon5 As System.Windows.Forms.Label
    Friend WithEvents lblName5 As System.Windows.Forms.Label
    Friend WithEvents lblRate5 As System.Windows.Forms.Label
    Friend WithEvents lblStock5 As System.Windows.Forms.Label
    Friend WithEvents btnAddCart5 As System.Windows.Forms.Button
    Friend WithEvents pnlCard6 As System.Windows.Forms.Panel
    Friend WithEvents lblIcon6 As System.Windows.Forms.Label
    Friend WithEvents lblName6 As System.Windows.Forms.Label
    Friend WithEvents lblRate6 As System.Windows.Forms.Label
    Friend WithEvents lblStock6 As System.Windows.Forms.Label
    Friend WithEvents btnAddCart6 As System.Windows.Forms.Button

End Class
