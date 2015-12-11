'Patricia Hanus
'151211
'Duplicate Values
'Public Class Form1
'____________________________________________________________________________________________
Public Class Form1

    Private Sub btnInputNumbers_Click(sender As Object, e As EventArgs) Handles btnInputNumbers.Click
        Dim numbers(0) As Integer
        Dim length As Integer = 0
        Dim inputNum As Integer

        Me.lstValues.Items.Clear()

        inputNum = Val(InputBox("Please input a number from 1 to 99"))

        Do While FindItemIndex(numbers, inputNum) = -1
            numbers(length) = inputNum
            length += 1
            ReDim Preserve numbers(length)
            inputNum = Val(InputBox("Please input a number from 1 to 99"))
        Loop



        Call DisplayArray(Me.lstValues, numbers, length, Me.lblDuplicate)

    End Sub
    '********************************************************************************************
    'DisplayArray
    'Displays the contents of the passed array in the passed list box values index
    '
    'post:  Array results displayed in list box 
    '********************************************************************************************
    Sub DisplayArray(ByRef lstBox As ListBox, ByRef array() As Integer, ByVal duplicateIndex As Integer, ByRef lblDuplicate As Label)
        For i As Integer = 0 To array.Length - 2
            lstBox.Items.Add(array(i))
        Next
        Me.lblDuplicate.Text = "Duplicate after " & duplicateIndex & " numbers"
    End Sub
    '********************************************************************************************
    'Returns the index of the first occurrence of searchItem in
    'dataArray or -1 if searchItem not found.
    '
    'post: Index of the first occurrence of searchItem has been 
    'returned, or -1 has been returned if searchItem not found.
    '********************************************************************************************
    Function FindItemIndex(ByRef dataArray() As Integer, _
    ByVal searchItem As Integer) As Integer
        'Empty array
        If dataArray.Length = 0 Then
            Return -1               'item not found
        End If

        'Find search item
        Dim index As Integer = 0
        Do While (dataArray(index) <> searchItem) _
        And (index < dataArray.Length - 1)
            index += 1
        Loop
        If dataArray(index) = searchItem Then
            Return index            'item found
        Else
            Return -1               'item not found
        End If
    End Function
End Class
