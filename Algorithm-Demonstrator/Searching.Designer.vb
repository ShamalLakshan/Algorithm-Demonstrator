<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearching
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearching))
        Me.lblSearchTerm = New System.Windows.Forms.Label()
        Me.ofdBrowseFile = New System.Windows.Forms.OpenFileDialog()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblInputArray = New System.Windows.Forms.Label()
        Me.lblInitArray02 = New System.Windows.Forms.Label()
        Me.pnlInputChoice = New System.Windows.Forms.Panel()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.rbRandomNumbers = New System.Windows.Forms.RadioButton()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblInitArray01 = New System.Windows.Forms.Label()
        Me.rbFromFile = New System.Windows.Forms.RadioButton()
        Me.rbLinearSearch = New System.Windows.Forms.RadioButton()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.rbBinarySearch = New System.Windows.Forms.RadioButton()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblSearchTerm02 = New System.Windows.Forms.Label()
        Me.txtSearchTerm = New System.Windows.Forms.TextBox()
        Me.pnlInputChoice.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSearchTerm
        '
        Me.lblSearchTerm.AutoSize = True
        Me.lblSearchTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchTerm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSearchTerm.Location = New System.Drawing.Point(741, 170)
        Me.lblSearchTerm.Name = "lblSearchTerm"
        Me.lblSearchTerm.Size = New System.Drawing.Size(141, 25)
        Me.lblSearchTerm.TabIndex = 20
        Me.lblSearchTerm.Text = "Search Term..."
        '
        'ofdBrowseFile
        '
        Me.ofdBrowseFile.FileName = "OpenFileDialog1"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 16
        Me.lstOutput.Location = New System.Drawing.Point(747, 215)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(683, 548)
        Me.lstOutput.TabIndex = 18
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOutput.Location = New System.Drawing.Point(739, 103)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(115, 38)
        Me.lblOutput.TabIndex = 14
        Me.lblOutput.Text = "Output"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInput.Location = New System.Drawing.Point(3, 2)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(88, 38)
        Me.lblInput.TabIndex = 3
        Me.lblInput.Text = "Input"
        '
        'lblInputArray
        '
        Me.lblInputArray.AutoSize = True
        Me.lblInputArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputArray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInputArray.Location = New System.Drawing.Point(741, 142)
        Me.lblInputArray.Name = "lblInputArray"
        Me.lblInputArray.Size = New System.Drawing.Size(123, 25)
        Me.lblInputArray.TabIndex = 19
        Me.lblInputArray.Text = "Initial Array..."
        '
        'lblInitArray02
        '
        Me.lblInitArray02.AutoSize = True
        Me.lblInitArray02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitArray02.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInitArray02.Location = New System.Drawing.Point(29, 208)
        Me.lblInitArray02.Name = "lblInitArray02"
        Me.lblInitArray02.Size = New System.Drawing.Size(27, 25)
        Me.lblInitArray02.TabIndex = 11
        Me.lblInitArray02.Text = "..."
        '
        'pnlInputChoice
        '
        Me.pnlInputChoice.Controls.Add(Me.lblInitArray02)
        Me.pnlInputChoice.Controls.Add(Me.btnBrowse)
        Me.pnlInputChoice.Controls.Add(Me.rbRandomNumbers)
        Me.pnlInputChoice.Controls.Add(Me.txtFilePath)
        Me.pnlInputChoice.Controls.Add(Me.btnGenerate)
        Me.pnlInputChoice.Controls.Add(Me.lblInitArray01)
        Me.pnlInputChoice.Controls.Add(Me.rbFromFile)
        Me.pnlInputChoice.Location = New System.Drawing.Point(3, 50)
        Me.pnlInputChoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlInputChoice.Name = "pnlInputChoice"
        Me.pnlInputChoice.Size = New System.Drawing.Size(544, 292)
        Me.pnlInputChoice.TabIndex = 8
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBrowse.Location = New System.Drawing.Point(409, 176)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(93, 37)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'rbRandomNumbers
        '
        Me.rbRandomNumbers.AutoSize = True
        Me.rbRandomNumbers.Checked = True
        Me.rbRandomNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRandomNumbers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbRandomNumbers.Location = New System.Drawing.Point(9, 14)
        Me.rbRandomNumbers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbRandomNumbers.Name = "rbRandomNumbers"
        Me.rbRandomNumbers.Size = New System.Drawing.Size(296, 29)
        Me.rbRandomNumbers.TabIndex = 8
        Me.rbRandomNumbers.TabStop = True
        Me.rbRandomNumbers.Text = "Generate 10 random Numbers"
        Me.rbRandomNumbers.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(35, 185)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(367, 22)
        Me.txtFilePath.TabIndex = 10
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGenerate.Location = New System.Drawing.Point(35, 89)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(93, 37)
        Me.btnGenerate.TabIndex = 7
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'lblInitArray01
        '
        Me.lblInitArray01.AutoSize = True
        Me.lblInitArray01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitArray01.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInitArray01.Location = New System.Drawing.Point(29, 49)
        Me.lblInitArray01.Name = "lblInitArray01"
        Me.lblInitArray01.Size = New System.Drawing.Size(27, 25)
        Me.lblInitArray01.TabIndex = 6
        Me.lblInitArray01.Text = "..."
        '
        'rbFromFile
        '
        Me.rbFromFile.AutoSize = True
        Me.rbFromFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFromFile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbFromFile.Location = New System.Drawing.Point(7, 148)
        Me.rbFromFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbFromFile.Name = "rbFromFile"
        Me.rbFromFile.Size = New System.Drawing.Size(233, 29)
        Me.rbFromFile.TabIndex = 9
        Me.rbFromFile.TabStop = True
        Me.rbFromFile.Text = "Read Values from a file"
        Me.rbFromFile.UseVisualStyleBackColor = True
        '
        'rbLinearSearch
        '
        Me.rbLinearSearch.AutoSize = True
        Me.rbLinearSearch.Checked = True
        Me.rbLinearSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLinearSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbLinearSearch.Location = New System.Drawing.Point(173, 59)
        Me.rbLinearSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbLinearSearch.Name = "rbLinearSearch"
        Me.rbLinearSearch.Size = New System.Drawing.Size(155, 29)
        Me.rbLinearSearch.TabIndex = 1
        Me.rbLinearSearch.TabStop = True
        Me.rbLinearSearch.Text = "Linear Search"
        Me.rbLinearSearch.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeading.Location = New System.Drawing.Point(79, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(327, 38)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Searching Algorithms"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(63, 60)
        Me.btnBack.TabIndex = 8
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'rbBinarySearch
        '
        Me.rbBinarySearch.AutoSize = True
        Me.rbBinarySearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBinarySearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbBinarySearch.Location = New System.Drawing.Point(357, 59)
        Me.rbBinarySearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbBinarySearch.Name = "rbBinarySearch"
        Me.rbBinarySearch.Size = New System.Drawing.Size(156, 29)
        Me.rbBinarySearch.TabIndex = 2
        Me.rbBinarySearch.Text = "Binary Search"
        Me.rbBinarySearch.UseVisualStyleBackColor = True
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Black
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 789)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1445, 49)
        Me.pnlFooter.TabIndex = 16
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Black
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.rbBinarySearch)
        Me.pnlHeader.Controls.Add(Me.rbLinearSearch)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1445, 101)
        Me.pnlHeader.TabIndex = 15
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnSearch.Location = New System.Drawing.Point(15, 454)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(124, 58)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.DimGray
        Me.pnlInput.Controls.Add(Me.lblSearchTerm02)
        Me.pnlInput.Controls.Add(Me.txtSearchTerm)
        Me.pnlInput.Controls.Add(Me.btnSearch)
        Me.pnlInput.Controls.Add(Me.pnlInputChoice)
        Me.pnlInput.Controls.Add(Me.lblInput)
        Me.pnlInput.Location = New System.Drawing.Point(0, 101)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(733, 688)
        Me.pnlInput.TabIndex = 17
        '
        'lblSearchTerm02
        '
        Me.lblSearchTerm02.AutoSize = True
        Me.lblSearchTerm02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchTerm02.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSearchTerm02.Location = New System.Drawing.Point(15, 375)
        Me.lblSearchTerm02.Name = "lblSearchTerm02"
        Me.lblSearchTerm02.Size = New System.Drawing.Size(132, 25)
        Me.lblSearchTerm02.TabIndex = 21
        Me.lblSearchTerm02.Text = "Search Term:"
        '
        'txtSearchTerm
        '
        Me.txtSearchTerm.Location = New System.Drawing.Point(15, 402)
        Me.txtSearchTerm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearchTerm.Name = "txtSearchTerm"
        Me.txtSearchTerm.Size = New System.Drawing.Size(367, 22)
        Me.txtSearchTerm.TabIndex = 12
        '
        'frmSearching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1445, 838)
        Me.Controls.Add(Me.lblSearchTerm)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblInputArray)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmSearching"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Searching"
        Me.pnlInputChoice.ResumeLayout(False)
        Me.pnlInputChoice.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearchTerm As Label
    Friend WithEvents ofdBrowseFile As OpenFileDialog
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents lblInputArray As Label
    Friend WithEvents lblInitArray02 As Label
    Friend WithEvents pnlInputChoice As Panel
    Friend WithEvents btnBrowse As Button
    Friend WithEvents rbRandomNumbers As RadioButton
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblInitArray01 As Label
    Friend WithEvents rbFromFile As RadioButton
    Friend WithEvents rbLinearSearch As RadioButton
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents rbBinarySearch As RadioButton
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents pnlInput As Panel
    Friend WithEvents lblSearchTerm02 As Label
    Friend WithEvents txtSearchTerm As TextBox
End Class
