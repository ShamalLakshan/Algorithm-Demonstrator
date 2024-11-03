Public Class frmMainMenu

    Private Sub cmdSort_MouseHover(sender As Object, e As EventArgs) Handles cmdSort.MouseHover
        lblDescription.Text = "Allows a user to Sort an array of numbers by importing from a text file or by generating 10 numbers randomly"
    End Sub

    Private Sub cmdSearch_MouseHover(sender As Object, e As EventArgs) Handles cmdSearch.MouseHover
        lblDescription.Text = "Allows a user to Search for a specific number in an array which is loaded on to the program by the user via a " & vbNewLine & " text file or by generating 10 random numbers"
    End Sub

    Private Sub cmdHelp_MouseHover(sender As Object, e As EventArgs) Handles cmdHelp.MouseHover
        lblDescription.Text = "Display a detailed Help Guide on how to use the program"
    End Sub

    Private Sub cmdExit_MouseHover(sender As Object, e As EventArgs) Handles cmdExit.MouseHover
        lblDescription.Text = "Exit application"
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSort_Click(sender As Object, e As EventArgs) Handles cmdSort.Click
        frmSorting.Show()
        Me.Hide()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        frmSearching.Show()
        Me.Hide()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        frmHelp.Show()
        Me.Hide()
    End Sub
End Class
