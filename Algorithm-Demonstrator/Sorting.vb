Public Class frmSorting
    Dim blArrayPresent As Boolean
    Dim arrArrayToSort(9) As Integer
    Dim arrOriginalArray As Integer()

    Private Function GenerateRandomNums() As Integer()
        Dim intMyValue As Integer
        Dim arrToSort(9) As Integer

        For Counter = 0 To 9
            '### Intialize Random Generation
            Randomize()
            '### Generating 10 random values
            intMyValue = Int((20 * Rnd()) + 1)
            arrToSort(Counter) = CInt(intMyValue)
        Next
        '################################################################################################
        'arrOriginalArray = arrToSort
        '#################################################################################################
        Return arrToSort
    End Function
    Private Function ReadFromFile(ByVal FilePath As String) As Integer()
        Dim strFileReader As String
        Dim arrNums() As String
        Dim arrToSort(9) As Integer

        Try
            strFileReader = My.Computer.FileSystem.ReadAllText(FilePath)
            arrNums = strFileReader.Split(",")

            For Counter = 0 To 9
                'Storing the read values to an array
                arrToSort(Counter) = CInt(arrNums(Counter))
            Next

            Return arrToSort
        Catch ex As Exception
            MsgBox("Invalid File or Content! Please refer to the 'Help Menu' to confirm it satifies the text file requirements (Main Menu > Help)")
            Exit Function

        End Try

    End Function

    Private Sub BubbleSort(ByVal arrInput() As Integer)
        Dim intPass As Integer
        Dim intTemp As Integer
        Dim index As Integer
        Dim blSwapped As Boolean
        Dim intNumofSteps As Integer
        Dim strOutput As String


        intNumofSteps = 1
        strOutput = ""

        For intPass = 0 To 8
            For index = 0 To 8
                If arrInput(index) > arrInput(index + 1) Then
                    intTemp = arrInput(index + 1)
                    arrInput(index + 1) = arrInput(index)
                    arrInput(index) = intTemp
                    blSwapped = True
                End If

                'Saving the Step
                strOutput = "Step " & intNumofSteps & " : "
                intNumofSteps = intNumofSteps + 1

                For Counter = 0 To UBound(arrInput)
                    strOutput = strOutput & arrInput(Counter) & ","
                Next
                lstOutput.Items.Add(strOutput)

            Next
            If blSwapped = False Then
                Exit For
            Else
                blSwapped = False
            End If
        Next

        'Printing the Final Sorted Array to lblSorted Array
        lblSortedArray.Text = "Sorted Array : "
        For index = 0 To 9
            lblSortedArray.Text = lblSortedArray.Text & arrInput(index) & ","
        Next
    End Sub

    Private Sub InsertionSort(ByVal arrInput() As Integer)
        Dim intNumofSteps As Integer
        Dim strOutput As String

        intNumofSteps = 1

        For index As Integer = 0 To UBound(arrInput)
            Dim index2 As Integer = index
            While (index2 > 0)
                If arrInput(index2 - 1) > arrInput(index2) Then
                    strOutput = "Step " & intNumofSteps & " : "
                    intNumofSteps = intNumofSteps + 1
                    arrInput(index2 - 1) = arrInput(index2 - 1) Xor arrInput(index2)
                    arrInput(index2) = arrInput(index2) Xor arrInput(index2 - 1)
                    arrInput(index2 - 1) = arrInput(index2 - 1) Xor arrInput(index2)

                    index2 -= 1

                    'Printing the Step
                    For Counter = 0 To UBound(arrInput)
                        strOutput = strOutput & arrInput(Counter) & ","
                    Next
                    lstOutput.Items.Add(strOutput)
                Else
                    Exit While
                End If
            End While
        Next

        'Printing the Final Sorted Array to lblSorted Array
        lblSortedArray.Text = "Sorted Array : "
        For index = 0 To 9
            lblSortedArray.Text = lblSortedArray.Text & arrInput(index) & " "
        Next

    End Sub

    'Random Number Generation Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim arrInitialArray() As Integer

        arrInitialArray = GenerateRandomNums()
        lblInitArray01.Text = ""

        For counter = 0 To UBound(arrInitialArray)
            lblInitArray01.Text = lblInitArray01.Text & arrInitialArray(counter) & " , "
        Next

        lblInputArray.Text = "Input Array: " & lblInitArray01.Text

        If lblInitArray01.Text <> "" Then
            blArrayPresent = True
            arrArrayToSort = arrInitialArray
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
                arrArrayToSort = arrInitialArray
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

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        'Clearing the listbox before printing new / initial steps
        lstOutput.Items.Clear()

        If blArrayPresent = True Then
            If rbBubbleSort.Checked = True Then
                BubbleSort(arrArrayToSort)
            ElseIf rbInsertionSort.Checked = True
                InsertionSort(arrArrayToSort)
            End If
        Else
            MessageBox.Show("Plesase provide a suitable array to sort...")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Hide()
    End Sub

End Class