Public Class Form1

    Dim a() As String = Nothing
    Dim inp() As String = {}
    Dim len As Integer = 0
    Dim cnt As Integer = 1
    Dim arr As Decimal() = {}
    Dim Fail As Boolean = 0
    Dim siz As Integer = 0
    Dim flgdec As Integer = 0
    Dim flgstr As Integer = 0


    Private Sub Clr()
        txtNum.Clear()
        txtArr.Clear()
        txtOutput.Clear()
        a = {}
        inp = {}
        arr = {}
        cnt = 1
        len = 0
        Fail = 0
        siz = 0
        flgdec = 0
        flgstr = 0
        btnSort.Show()
    End Sub

    Private Sub InpFail()
        MessageBox.Show("Enter valid input", "Error")
        Console.Write("Error: Invalid input type")
    End Sub

    Private Sub TxtIndex(ByRef strt As Integer, ByRef fin As Integer, cnt As Integer, ParamArray Op() As String)
        Dim ind As Integer = 0
        For i As Integer = 0 To cnt
            ind += (Op(i).Length + 1)
        Next
        If cnt = Op.Length() Then
            ind -= 1
        End If
        'MessageBox.Show(ind)
        fin = strt + ind
    End Sub

    Private Sub SortStr()
        Dim tmp As String = Nothing
        If len > 1 Then
            Dim j As Integer = cnt - 1
            Dim cur As String = inp(cnt)
            While j >= 0
                If String.Compare(cur, inp(j)) = -1 Then
                    inp(j + 1) = inp(j)
                    j -= 1
                Else
                    Exit While
                End If
            End While
            inp(j + 1) = cur
            cnt += 1

        End If

        'Dim txt() As String = Nothing
        'For k As Integer = 0 To inp.Length - 1
        '    txt(k) = CStr(inp(k))
        'Next
        Dim strt As Integer = 0
        Dim fin As Integer = 0
        TxtIndex(strt, fin, cnt - 2, inp)
        'MessageBox.Show(strt)
        'MessageBox.Show(fin)
        'inp.SetValue(strt, fin)
        'inp.BackColor()
        'tmp = Nothing
        For k As Integer = 0 To inp.Length - 1
            tmp &= CStr(inp(k)) & " "
        Next
        tmp &= Environment.NewLine
        'If j <> cnt - 1 Then
        txtOutput.Text &= tmp
        'txtOutput.Select(strt, fin - strt)
        txtOutput.SelectionStart = strt
        txtOutput.SelectionLength = fin - strt

        txtOutput.SelectionBackColor = Color.Green
        txtOutput.DeselectAll()

        'txtOutput.SetBackColor = Color.Aqua


        'End If

    End Sub

    Private Sub SortDec()
        Dim tmp As String = Nothing
        If len > 1 Then
            Dim j As Integer = cnt - 1
            Dim cur As Decimal = arr(cnt)
            While j >= 0
                If cur < arr(j) Then
                    arr(j + 1) = arr(j)
                    j -= 1
                Else
                    Exit While
                End If
            End While
            arr(j + 1) = cur
            cnt += 1

        End If

        For k As Integer = 0 To arr.Length - 1
            tmp &= CStr(arr(k)) & "; "
        Next
        tmp &= Environment.NewLine

        'If j <> cnt - 1 Then
        txtOutput.Text &= tmp
        'End If

    End Sub

    'Private Sub SortDec2(ParamArray num() As Decimal)
    '    Dim tmp As String = Nothing
    '    For i As Integer = 1 To num.Length - 1
    '        Dim j As Integer = i - 1
    '        Dim cur As Decimal = num(i)
    '        While j >= 0
    '            If cur < num(j) Then
    '                num(j + 1) = num(j)
    '                j -= 1
    '            Else
    '                Exit While
    '            End If
    '        End While
    '        num(j + 1) = cur
    '        For k As Integer = 0 To num.Length - 1
    '            tmp &= CStr(num(k)) & "; "
    '        Next
    '        tmp &= Environment.NewLine
    '    Next

    '    For i As Integer = 0 To num.Length - 1
    '        tmp &= CStr(num(i)) & "; "
    '    Next
    '    txtOutput.Text = tmp
    'End Sub

    Private Function Sorter()
        btnNxt.Hide()
        Try
            Dim sz As String = CStr(txtNum.Text)
            If sz.Contains(".") Then
                InpFail()
                Clr()
                Fail = 1
            Else
                siz = CInt(sz)
            End If

        Catch ex As System.InvalidCastException
            InpFail()
            Clr()
            Fail = 1
        Catch ex As Exception
            MessageBox.Show("Unknown Error", "Error")
            Console.Write("Unknown Error")
            Clr()
            Fail = 1

        End Try

        a = Split(txtArr.Text(), " ")

        Dim tmp As String = Nothing
        'Dim cnt As Integer = 0

        For i As Integer = 0 To a.Length - 1
            If a(i).Trim = "" Then
                Continue For
            End If
            Dim isLetter As Boolean = True
            If IsNumeric(a(i)) Then
                flgdec = 1
                'tmp &= flgdec & " "
            Else
                For j = 1 To a(i).Length
                    Select Case Asc(Mid(a(i), j, 1))
                        Case 65 To 90, 97 To 122
                            Continue For
                        Case Else
                            isLetter = False
                            Exit For
                    End Select
                Next
                If isLetter = True Then
                    flgstr = 1
                Else
                    InpFail()
                    Clr()
                    Fail = 1
                    Exit For
                End If
            End If

            If flgdec = 1 And flgstr = 1 Then
                MessageBox.Show("Input of mixed type", "Error")
                Console.Write("Error: Input of mixed type")
                Clr()
                Fail = 1
                Exit For
            End If

            Array.Resize(inp, inp.Length + 1)
            inp(inp.Length - 1) = a(i)
            'tmp &= a(i) & "; "
        Next


        If inp.Length <> siz Then
            MessageBox.Show(inp.Length, "Error")
            MessageBox.Show(siz, "Error")
            MessageBox.Show("Incorrect number of entries", "Error")
            Console.Write("Error: Incorrect number of entries")
            Clr()
            Fail = 1
        End If

        For i As Integer = 0 To inp.Length - 1
            tmp &= inp(i) & "; "
        Next

        len = inp.Length
        If flgdec = 1 And Fail = 0 Then
            For i As Integer = 0 To inp.Length - 1
                Array.Resize(arr, arr.Length + 1)
                arr(arr.Length - 1) = CDec(inp(i))
            Next
            SortDec()
        End If
        If flgstr = 1 And Fail = 0 Then
            SortStr()
        End If
        btnSort.Hide()
        btnNxt.Show()
        'If Fail = 0 Then
        '    txtOutput.Text = tmp
        'End If

        Return 0
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Sorter()
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        Clr()
    End Sub

    Private Sub btnNxt_Click(sender As Object, e As EventArgs) Handles btnNxt.Click

        If cnt < len Then
            If flgdec = 1 Then
                SortDec()
            ElseIf flgstr = 1 Then
                SortStr()
            End If
        ElseIf cnt = len Then
            btnNxt.Hide()
        End If

    End Sub

End Class
