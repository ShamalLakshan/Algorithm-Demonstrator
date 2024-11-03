<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.cmdSort = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlStripMenu = New System.Windows.Forms.Panel()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlStripMenu.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSort
        '
        Me.cmdSort.AutoSize = True
        Me.cmdSort.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdSort.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdSort.FlatAppearance.BorderSize = 0
        Me.cmdSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSort.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdSort.Image = CType(resources.GetObject("cmdSort.Image"), System.Drawing.Image)
        Me.cmdSort.Location = New System.Drawing.Point(0, 0)
        Me.cmdSort.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(289, 84)
        Me.cmdSort.TabIndex = 0
        Me.cmdSort.Text = "Sort"
        Me.cmdSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSort.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Black
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1084, 82)
        Me.pnlHeader.TabIndex = 4
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeading.Location = New System.Drawing.Point(57, 26)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(300, 31)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Algorithm Demonstrator"
        '
        'cmdHelp
        '
        Me.cmdHelp.AutoSize = True
        Me.cmdHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdHelp.FlatAppearance.BorderSize = 0
        Me.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdHelp.Image = CType(resources.GetObject("cmdHelp.Image"), System.Drawing.Image)
        Me.cmdHelp.Location = New System.Drawing.Point(0, 168)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(289, 84)
        Me.cmdHelp.TabIndex = 3
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.AutoSize = True
        Me.cmdExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdExit.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdExit.FlatAppearance.BorderSize = 0
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(0, 252)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(289, 84)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 641)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1084, 40)
        Me.pnlFooter.TabIndex = 5
        '
        'pnlStripMenu
        '
        Me.pnlStripMenu.BackColor = System.Drawing.Color.Black
        Me.pnlStripMenu.Controls.Add(Me.cmdExit)
        Me.pnlStripMenu.Controls.Add(Me.cmdHelp)
        Me.pnlStripMenu.Controls.Add(Me.cmdSearch)
        Me.pnlStripMenu.Controls.Add(Me.cmdSort)
        Me.pnlStripMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlStripMenu.Location = New System.Drawing.Point(0, 82)
        Me.pnlStripMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlStripMenu.Name = "pnlStripMenu"
        Me.pnlStripMenu.Size = New System.Drawing.Size(289, 559)
        Me.pnlStripMenu.TabIndex = 6
        '
        'cmdSearch
        '
        Me.cmdSearch.AutoSize = True
        Me.cmdSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdSearch.FlatAppearance.BorderSize = 0
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(0, 84)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(289, 84)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.DimGray
        Me.pnlInfo.Controls.Add(Me.lblDescription)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInfo.Location = New System.Drawing.Point(289, 82)
        Me.pnlInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(795, 559)
        Me.pnlInfo.TabIndex = 7
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescription.Location = New System.Drawing.Point(31, 24)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(178, 20)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Algorithm Demonstrator"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 681)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlStripMenu)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlStripMenu.ResumeLayout(False)
        Me.pnlStripMenu.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdSort As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents pnlStripMenu As Panel
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblDescription As Label
    Friend WithEvents cmdSearch As Button
End Class
