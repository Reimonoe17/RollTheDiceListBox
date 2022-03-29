'Jamison Burton
'RCET0265
'Spring 2022
'Roll The Dice ListBox
'https://github.com/Reimonoe17/RollTheDiceListBox

Public Class RollTheDiceListBoxForm
    Sub Roll()
        Dim firstRoll As Integer
        Dim secondRoll As Integer
        Dim Result(12) As Integer
        Dim columnTemp As String
        Dim resultTemp As String

        'Writes out title
        DisplayListBox.Items.Add(CStr("Roll of the Dice").PadLeft(45))
        DisplayListBox.Items.Add((StrDup(77, "-")))

        'perform calcutations using Randomizer with dice values and adds to Result array
        For i = 0 To 999
            firstRoll = RollDice()
            secondRoll = RollDice()
            Result(firstRoll + secondRoll) += 1
        Next

        'displays array columns
        For i = 2 To UBound(Result)
            columnTemp &= (CStr(i).PadLeft(5) & " |")
        Next
        DisplayListBox.Items.Add(columnTemp)

        DisplayListBox.Items.Add((StrDup(77, "-")))

        'displays array results
        For i = 2 To UBound(Result)
            resultTemp &= (CStr(Result(i)).PadLeft(5) & " |")
        Next
        DisplayListBox.Items.Add(resultTemp)
        DisplayListBox.Items.Add((StrDup(77, "-")))
    End Sub
    Function RollDice() As Integer
        Randomize()
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Return value 'Outputs a random value between 1 and 6
    End Function

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Roll()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub

End Class
