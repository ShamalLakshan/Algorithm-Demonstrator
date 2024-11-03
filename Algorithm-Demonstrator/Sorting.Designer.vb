<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSorting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSorting))
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.rbInsertionSort = New System.Windows.Forms.RadioButton()
        Me.rbBubbleSort = New System.Windows.Forms.RadioButton()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.pnlInputChoice = New System.Windows.Forms.Panel()
        Me.lblInitArray02 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.rbRandomNumbers = New System.Windows.Forms.RadioButton()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblInitArray01 = New System.Windows.Forms.Label()
        Me.rbFromFile = New System.Windows.Forms.RadioButton()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.ofdBrowseFile = New System.Windows.Forms.OpenFileDialog()
        Me.lblInputArray = New System.Windows.Forms.Label()
        Me.lblSortedArray = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlInputChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Black
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 789)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1445, 49)
        Me.pnlFooter.TabIndex = 7
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Black
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.rbInsertionSort)
        Me.pnlHeader.Controls.Add(Me.rbBubbleSort)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1445, 101)
        Me.pnlHeader.TabIndex = 6
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
        'rbInsertionSort
        '
        Me.rbInsertionSort.AutoSize = True
        Me.rbInsertionSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInsertionSort.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbInsertionSort.Location = New System.Drawing.Point(357, 59)
        Me.rbInsertionSort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbInsertionSort.Name = "rbInsertionSort"
        Me.rbInsertionSort.Size = New System.Drawing.Size(148, 29)
        Me.rbInsertionSort.TabIndex = 2
        Me.rbInsertionSort.Text = "Insertion Sort"
        Me.rbInsertionSort.UseVisualStyleBackColor = True
        '
        'rbBubbleSort
        '
        Me.rbBubbleSort.AutoSize = True
        Me.rbBubbleSort.Checked = True
        Me.rbBubbleSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBubbleSort.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbBubbleSort.Location = New System.Drawing.Point(173, 59)
        Me.rbBubbleSort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbBubbleSort.Name = "rbBubbleSort"
        Me.rbBubbleSort.Size = New System.Drawing.Size(135, 29)
        Me.rbBubbleSort.TabIndex = 1
        Me.rbBubbleSort.TabStop = True
        Me.rbBubbleSort.Text = "Bubble Sort"
        Me.rbBubbleSort.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeading.Location = New System.Drawing.Point(79, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(283, 38)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Sorting Algorithms"
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.DimGray
        Me.pnlInput.Controls.Add(Me.btnSort)
        Me.pnlInput.Controls.Add(Me.pnlInputChoice)
        Me.pnlInput.Controls.Add(Me.lblInput)
        Me.pnlInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInput.Location = New System.Drawing.Point(0, 101)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(733, 688)
        Me.pnlInput.TabIndex = 8
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnSort.Location = New System.Drawing.Point(24, 359)
        Me.btnSort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(124, 58)
        Me.btnSort.TabIndex = 12
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = False
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
        Me.txtFilePath.Location = New System.Drawing.Point(35, 183)
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
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOutput.Location = New System.Drawing.Point(739, 103)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(115, 38)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "Output"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 16
        Me.lstOutput.Location = New System.Drawing.Point(747, 215)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(683, 548)
        Me.lstOutput.TabIndex = 9
        '
        'ofdBrowseFile
        '
        Me.ofdBrowseFile.FileName = "OpenFileDialog1"
        '
        'lblInputArray
        '
        Me.lblInputArray.AutoSize = True
        Me.lblInputArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputArray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInputArray.Location = New System.Drawing.Point(741, 142)
        Me.lblInputArray.Name = "lblInputArray"
        Me.lblInputArray.Size = New System.Drawing.Size(123, 25)
        Me.lblInputArray.TabIndex = 12
        Me.lblInputArray.Text = "Initial Array..."
        '
        'lblSortedArray
        '
        Me.lblSortedArray.AutoSize = True
        Me.lblSortedArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortedArray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSortedArray.Location = New System.Drawing.Point(741, 170)
        Me.lblSortedArray.Name = "lblSortedArray"
        Me.lblSortedArray.Size = New System.Drawing.Size(137, 25)
        Me.lblSortedArray.TabIndex = 13
        Me.lblSortedArray.Text = "Sorted Array..."
        '
        'frmSorting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1445, 838)
        Me.Controls.Add(Me.lblSortedArray)
        Me.Controls.Add(Me.lblInputArray)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmSorting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sorting"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlInputChoice.ResumeLayout(False)
        Me.pnlInputChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents rbInsertionSort As RadioButton
    Friend WithEvents rbBubbleSort As RadioButton
    Friend WithEvents pnlInput As Panel
    Friend WithEvents lblInput As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents rbFromFile As RadioButton
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents ofdBrowseFile As OpenFileDialog
    Friend WithEvents pnlInputChoice As Panel
    Friend WithEvents rbRandomNumbers As RadioButton
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblInitArray01 As Label
    Friend WithEvents lblInitArray02 As Label
    Friend WithEvents btnSort As Button
    Friend WithEvents lblInputArray As Label
    Friend WithEvents lblSortedArray As Label
End Class
