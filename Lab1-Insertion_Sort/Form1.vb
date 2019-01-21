'Authors -
'   Mayank Baranwal (baran170102035@iitg.ac.in) 
'   Soumik Paul (paul170101066@iitg.ac.in)
'    



''' <summary>
''' Implemented startup pop-up form for help of beginners (Form2.vb)
''' Form1.vb takes variable number of inuputs (tested till 50)
''' highlights sorted output as green and unsorted part as red
''' every 0.5 seconds, current compa
''' all out of bounds exceptions handled
''' "input of different types" exception handled
''' sorting for decimals as well as strings
''' for strings the increasing order is a,A,b,B,c,C,....
''' After error messagebox, need to restart program -handled
''' 
''' </summary>
''' <remarks></remarks>

Public Class Form1
    'Declarations being used across various functions

    'array of strings to store split input
    Dim a() As String = {}
    Dim inp() As String = {}
    Dim arr As Decimal() = {}

    'Utility variables
    Dim len As Integer = 0
    Dim cnt As Integer = 1
    Dim counter As Integer = 1

    'Checking processing strings or decimals
    Dim Fail As Boolean = 0
    Dim flgdec As Integer = 0
    Dim flgstr As Integer = 0

    'Position of dynamically allocated textboxes
    Dim y As Integer = 1
    Dim x As Integer = 1


    'Utility to clear all input and outputs and reset utility variables
    Private Sub Clr()

        'Clearing all textboxes
        txtArr.ReadOnly = False
        txtOutput1.Clear()
        txtCmp1.Clear()
        txtCmp2.Clear()
        txtCmpRes.Clear()

        'deleting dynamically allocated controls
        For i As Integer = 2 To counter - 1
            Me.Controls.Remove(Me.Controls.Find("txtOutput" & CStr(i), True)(0))
        Next

        'Resetting arrays and flags
        a = {}
        inp = {}
        arr = {}
        cnt = 1
        len = 0
        Fail = 0
        flgdec = 0
        flgstr = 0
        y = txtOutput1.Location.Y
        x = txtOutput1.Location.X
        counter = 1
        btnSort.Show()
        btnNxt.Hide()
        btnClr.Text = "Clear"
        txtArr.Focus()

    End Sub

    'utility to display error
    Private Sub InpFail()
        MessageBox.Show("Enter valid input", "Error")
        Console.Write("Error: Invalid input type")
    End Sub


    'Function to determine till which index of textbox is to be coloured green and red
    Private Sub TxtIndex(ByRef strt As Integer, ByRef fin As Integer, cnt As Integer, ParamArray Op() As String)
        Dim ind As Integer = 0
        'Adding length of each entity till count to determine till where green backcolour should be present
        For i As Integer = 0 To cnt
            ind += (Op(i).Length + 1)
        Next
        If cnt = Op.Length() Then
            ind -= 1
        End If
        fin = strt + ind
    End Sub

    

    'Function to dynamically allocate new richtextboxes'
    Private Sub outTextAdder(i As Integer, tmp As String, strt As Integer, fin As Integer)
        Dim txtName As String
        txtName = "txtOutput" & CStr(i)
        Dim yt As Integer = txtOutput1.Location.Y + 25 * (i - 1)
        Dim txt1 As New RichTextBox
        txt1.Name = txtName
        txt1.Width = 714
        txt1.Height = 25
        txt1.ReadOnly = True
        Me.Controls.Add(txt1)
        txt1.Location = New Point(x, yt)
        txt1.Text = tmp
        txt1.BackColor = Color.Cornsilk
        'Adding green and red colour for sorted and unsorted portion of array
        txt1.Select(strt, fin - strt)
        txt1.SelectionBackColor = Color.Lime
        txt1.Select(fin, tmp.Length)
        txt1.SelectionBackColor = Color.Red
    End Sub

    'Function to make system pause to allow showing comparisions
    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop
    End Sub

    'One iteration of insertion sort of strings
    Private Sub SortStr()

        Dim tmp As String = Nothing
        If len > 1 Then
            Dim j As Integer = cnt - 1
            Dim cur As String = inp(cnt)
            While j >= 0
                'Output in comparison boxes the current strings being compared and result
                txtCmp1.Text = cur
                txtCmp2.Text = inp(j)
                'Shift based on comparison
                If String.Compare(cur, inp(j)) = -1 Then
                    inp(j + 1) = inp(j)
                    j -= 1
                    txtCmpRes.Text = "<"
                Else
                    txtCmpRes.Text = ">="
                    Exit While
                End If
                Delay(0.5)
            End While
            inp(j + 1) = cur
            cnt += 1

        End If
        '''''''insertion sort end'''''''''''

        For k As Integer = 0 To inp.Length - 1
            tmp &= inp(k) & " "
        Next
        tmp &= Environment.NewLine

        Dim txt() As String = {}
        For k As Integer = 0 To inp.Length - 1
            Array.Resize(txt, txt.Length + 1)
            txt(k) = inp(k)
        Next
        Dim strt As Integer = 0
        Dim fin As Integer = 0
        TxtIndex(strt, fin, cnt - 1, txt)

        'Assigning green and red colour for textboxes
        If counter = 1 Then
            txtOutput1.Text = tmp
            txtOutput1.Select(strt, tmp.Length - 1)
            txtOutput1.SelectionBackColor = Color.Red
            txtOutput1.Select(strt, fin - strt)
            txtOutput1.SelectionBackColor = Color.Lime

            counter += 1
        Else
            outTextAdder(counter, tmp, strt, fin)
            counter += 1
        End If

    End Sub

    'One iteration of insertion sort of decimals
    Private Sub SortDec()
        Dim tmp As String = Nothing
        If len > 1 Then
            Dim j As Integer = cnt - 1
            Dim cur As Decimal = arr(cnt)
            While j >= 0
                'Output in comparison boxes the current decimals being compared and result
                txtCmp1.Text = CStr(cur)
                txtCmp2.Text = CStr(arr(j))
                'Shift based on comparison
                If cur < arr(j) Then
                    arr(j + 1) = arr(j)
                    j -= 1
                    txtCmpRes.Text = CStr("<")
                Else
                    txtCmpRes.Text = CStr(">=")
                    Exit While
                End If

                Delay(0.5)
            End While
            arr(j + 1) = cur
            cnt += 1
        End If

        For k As Integer = 0 To arr.Length - 1
            tmp &= CStr(arr(k)) & " "
        Next
        tmp &= Environment.NewLine
        '''''''insertion sort end'''''''''''

        Dim txt() As String = {}
        For k As Integer = 0 To inp.Length - 1
            Array.Resize(txt, txt.Length + 1)
            txt(k) = CStr(arr(k))
        Next
        Dim strt As Integer = 0
        Dim fin As Integer = 0
        TxtIndex(strt, fin, cnt - 1, txt)

        'Assigning green and red colour for textboxes
        If counter = 1 Then
            txtOutput1.Text = tmp
            txtOutput1.Select(strt, tmp.Length - 1)
            txtOutput1.SelectionBackColor = Color.Red
            txtOutput1.Select(strt, fin - strt)
            txtOutput1.SelectionBackColor = Color.Lime

            counter += 1
        Else
            outTextAdder(counter, tmp, strt, fin)
            counter += 1
        End If

    End Sub

    'Function to take input and handle exception cases
    Private Function Checker()
        btnNxt.Hide()
        a = Split(txtArr.Text(), " ")

        Dim tmp As String = Nothing

        For i As Integer = 0 To a.Length - 1
            'Removing strings that are whitespaces
            If a(i).Trim = "" Then
                Continue For
            End If
            Dim isLetter As Boolean = True
            'Check if string is a decimal
            If IsNumeric(a(i)) Then
                flgdec = 1
            Else
                'Check if string is composed of lowercase and uppercase characters
                For j = 1 To a(i).Length
                    Select Case Asc(Mid(a(i), j, 1))
                        Case 65 To 90, 97 To 122
                            Continue For
                        Case Else
                            isLetter = False
                            Exit For
                    End Select
                Next
                'Reject if contains non alphanumeric characters
                If isLetter = True Then
                    flgstr = 1
                Else
                    InpFail()
                    Clr()
                    Fail = 1
                    btnClr.Text = "Click here to try again!"
                    Exit For
                End If
            End If

            'Reject if both strings and decimals present in input
            If flgdec = 1 And flgstr = 1 Then
                btnNxt.Hide()
                MessageBox.Show("Input of mixed type", "Error")
                Console.Write("Error: Input of mixed type")
                Clr()
                Fail = 1
                btnClr.Text = "Click here to try again!"
                Exit For
            End If

            'Add correct input to inp() array
            Array.Resize(inp, inp.Length + 1)
            inp(inp.Length - 1) = a(i)
        Next

        For i As Integer = 0 To inp.Length - 1
            tmp &= inp(i) & "; "
        Next

        len = inp.Length
        If flgdec = 1 And Fail = 0 Then
            'Check overflow and extra - error and sed for sorting
            For i As Integer = 0 To inp.Length - 1
                Array.Resize(arr, arr.Length + 1)
                If inp(i).EndsWith("-") Or inp(i).EndsWith("+") Then
                    InpFail()
                    Clr()
                    Fail = 1
                    btnClr.Text = "Click here to try again!"
                    Exit For
                End If
                Try
                    arr(arr.Length - 1) = CDec(inp(i))


                Catch ex As Exception
                    MessageBox.Show("Number overflow/underflow", "Error")
                    Console.Write("Error: Number overflow/underflow")
                    Clr()
                    Fail = 1
                    btnClr.Text = "Click here to try again!"
                    Exit For
                End Try

            Next
            If Fail = 0 Then
                SortDec()
            End If

        End If
        'Sort for string inputs
        If flgstr = 1 And Fail = 0 Then
            SortStr()
        End If
        btnSort.Hide()
        If Fail = 0 Then
            btnNxt.Show()
        End If
        Return 0
    End Function

    'Exit button click function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Sorting click start 
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        txtArr.ReadOnly = True
        Checker()
    End Sub

    'Clear button command
    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        Clr()
    End Sub

    'Button to run next iteration of insertion sort if sorting incomplete
    Private Sub btnNxt_Click(sender As Object, e As EventArgs) Handles btnNxt.Click
        btnNxt.Hide()
        btnClr.Hide()
        If cnt < len Then
            If flgdec = 1 Then
                SortDec()
            ElseIf flgstr = 1 Then
                SortStr()
            End If
            btnNxt.Show()
        ElseIf cnt = len Then
            btnNxt.Hide()
            btnClr.Text = "Done! Click here to reset!"
        End If
        btnClr.Show()
    End Sub

    'Initialize values and load forms
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        y = txtOutput1.Location.Y
        x = txtOutput1.Location.X
        Dim xForm As New Form2
        If xForm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            System.Diagnostics.Process.Start("https://www.geeksforgeeks.org/sorting-algorithms/")
        Else
            xForm.Close()
        End If
    End Sub

    'Starting insertion sort by pressing Enter key
    Private Sub txtArr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtArr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cnt = 1 Then
                txtArr.ReadOnly = True
                Checker()
            End If
        End If
    End Sub

    'Enable reading text from file --> Space separated input
    Private Sub btnTxtFile_Click(sender As Object, e As EventArgs) Handles btnTxtFile.Click
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            txtArr.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub


    'Resetting input field
    Private Sub btnResInp_Click(sender As Object, e As EventArgs) Handles btnResInp.Click
        txtArr.Clear()
        txtArr.Focus()
        txtArr.ReadOnly = False
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show("Please refer to User Documentation")
    End Sub
End Class
