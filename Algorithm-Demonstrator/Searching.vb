Public Class frmSearching
    Public Property blArrayPresent As Boolean
    Dim arrArrayToSearch(9) As Integer
    'Public Property PassValue() As New Integer()

    Private Function GenerateRandomNums() As Integer()
        Dim intMyValue As Integer
        Dim arrToSearch(9) As Integer

        For Counter = 0 To 9
            '### Intialize Random Generation
            Randomize()
            '### Generating 10 random values
            intMyValue = Int((20 * Rnd()) + 1)
            arrToSearch(Counter) = CInt(intMyValue)
        Next

        Return arrToSearch
    End Function
    Private Function ReadFromFile(ByVal FilePath As String) As Integer()

        Dim strFileReader As String
        Dim arrNums() As String
        Dim arrToSort(9) As Integer

        Try
            strFileReader = My.Computer.FileSystem.ReadAllText(FilePath)
            arrNums = strFileReader.Split(",")

            For Counter = 0 To 9
                '### Storing the read values to an array###
                arrToSort(Counter) = CInt(arrNums(Counter))
            Next

            Return arrToSort
        Catch ex As Exception
            MsgBox("Invalid File or Content! Please refer to the 'Help Menu' to confirm it satifies the text file requirements (Main Menu > Help)")
            Exit Function

        End Try

    End Function

    Private Sub LinearSearch(ByVal arrInput() As Integer, ByVal intSearchTerm As Integer)
        Dim strIndex As String

        For Counter = 0 To UBound(arrInput)
            If arrInput(Counter) = intSearchTerm Then
                strIndex = strIndex & " " & Counter + 1
                lstOutput.Items.Add("Position " & Counter + 1 & " : Match Found")
            Else
                lstOutput.Items.Add("Position " & Counter + 1 & " : Not Found")
            End If

        Next
    End Sub

    Private Sub BinarySearch(ByVal arrInput() As Integer, ByVal intSearchTerm As Integer)
        Dim dictToSearch As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)()
        Dim arrToSearch(9) As Integer
        Dim Counter2 As Integer = 0
        Dim intLower As Integer
        Dim intHigher As Integer
        Dim intMid As Integer
        Dim blFound As Boolean


        'Initializing Dictionary
        For Counter = 0 To UBound(arrInput)
            dictToSearch.Add(Counter, arrInput(Counter))
        Next

        'Sorting according Values
        Dim sorted = From pair In dictToSearch
                     Order By pair.Value
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)


        'Writing Sorted Values to an Array to Search
        For Each kvp As KeyValuePair(Of Integer, Integer) In sortedDictionary
            Dim key As String = kvp.Key
            Dim value As Integer = kvp.Value

            arrToSearch(Counter2) = value
            Counter2 += 1
        Next

        'Binary Search in Array
        intLower = LBound(arrToSearch)
        intHigher = UBound(arrToSearch)

        Do While intLower <= intHigher
            intMid = ((intLower + intHigher) / 2)
            If intSearchTerm = arrToSearch(intMid) Then
                blFound = True
                Exit Do
            ElseIf intSearchTerm < arrToSearch(intMid) Then
                intHigher = (intMid - 1)
            Else
                intLower = (intMid + 1)
            End If
        Loop

        'Printing the positions if found and error if not
        If blFound = False Then
            MessageBox.Show("Value Not Found")
        Else
            For Each key As Integer In sortedDictionary.Keys
                If sortedDictionary(key) = intSearchTerm Then
                    lstOutput.Items.Add("Found at : " & key + 1)
                End If
            Next
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim arrInitialArray() As Integer

        arrInitialArray = GenerateRandomNums()
        lblInitArray01.Text = ""

        For counter = 0 To UBound(arrInitialArray)
            lblInitArray01.Text = lblInitArray01.Text & arrInitialArray(counter) & " , "
        Next

        lblInputArray.Text = "Input Array: " & lblInitArray01.Text

        If lblInitArray01.Text <> "" Then
            blArrayPresent = True
            arrArrayToSearch = arrInitialArray
        End If

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim arrInitialArray() As Integer

        ofdBrowseFile.FileName = ""
        ofdBrowseFile.Filter = "Text | *.txt;"
        ofdBrowseFile.ShowDialog()
        txtFilePath.Text = ofdBrowseFile.FileName

        Try
            arrInitialArray = ReadFromFile(ofdBrowseFile.FileName)
            lblInitArray02.Text = ""

            For Counter = 0 To UBound(arrInitialArray)
                lblInitArray02.Text = lblInitArray02.Text & arrInitialArray(Counter) & " , "
            Next

            lblInputArray.Text = "Input Array: " & lblInitArray02.Text

            If lblInitArray02.Text <> "" Then
                blArrayPresent = True
                arrArrayToSearch = arrInitialArray
            End If


        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub rbRandomNumbers_CheckedChanged(sender As Object, e As EventArgs) Handles rbRandomNumbers.CheckedChanged
        btnBrowse.Enabled = False
        btnGenerate.Enabled = True
    End Sub

    Private Sub rbFromFile_CheckedChanged(sender As Object, e As EventArgs) Handles rbFromFile.CheckedChanged
        btnGenerate.Enabled = False
        btnBrowse.Enabled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim intSearchTerm As Integer

        '############################################################################
        'Dim BetaArray As Integer()
        ''BetaArray = PassValue
        'For Counter = 0 To 10
        '    MessageBox.Show(BetaArray(Counter))
        'Next
        '###########################################################################

        'Clearing the listbox before printing new / initial steps
        lstOutput.Items.Clear()

        If txtSearchTerm.Text <> "" And IsNumeric(txtSearchTerm.Text) Then
            intSearchTerm = CInt(txtSearchTerm.Text)
            lblSearchTerm.Text = intSearchTerm
        Else
            MessageBox.Show("Please Enter a Numeric Value to continue...")
            Exit Sub
        End If

        If blArrayPresent = True Then
            If rbLinearSearch.Checked = True Then
                LinearSearch(arrArrayToSearch, intSearchTerm)
            ElseIf rbBinarySearch.Checked = True
                BinarySearch(arrArrayToSearch, intSearchTerm)
            End If
        Else
            MessageBox.Show("Plesase provide a suitable array to sort...")
        End If
    End Sub

End Class