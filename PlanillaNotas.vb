Dim N(1 To 10) As String
Dim notas(1 To 10, 1 To 3) As Integer

Dim nf(1 To 10) As Double

Dim val As String

'cargar y mostrar nombres y notas
Sub CommandButton1_Click()
    For i = 1 To 10 Step 1
        N(i) = InputBox("Ingrese un nombre")
        ListBox1.AddItem (N(i))
        'nota del primer parcial
        notas(i, 1) = Int(Rnd * 101)
        val = notas(i, 1) & "       "
        'nota del segundo parcial
        notas(i, 2) = Int(Rnd * 101)
        val = val & notas(i, 2) & "       "
        'nota del ex final
        notas(i, 3) = Int(Rnd * 101)
        val = val & notas(i, 3)
        ListBox2.AddItem (val)
    Next i
End Sub

'mostrando aprobados y reprobados
Sub CommandButton2_Click()
    Dim prom As Double
    For i = 1 To 10 Step 1
        prom = (notas(i, 1) + notas(i, 2)) / 2
        If (prom >= 51 Or notas(i, 3) >= 51) Then
            ListBox3.AddItem (N(i))
        Else
            ListBox4.AddItem (N(i))
        End If
    Next i
End Sub
'Cargar y mostrar las notas finales
Sub CommandButton3_Click()
    Dim prom As Double
    For i = 1 To 10 Step 1
        prom = (notas(i, 1) + notas(i, 2)) / 2
        If (prom > notas(i, 3)) Then
            nf(i) = prom
        Else
            nf(i) = notas(i, 3)
        End If
        ListBox5.AddItem (nf(i))
    Next i
End Sub

'Mayor y menor nota
Sub CommandButton4_Click()
    Dim nomMay As String
    Dim nomMen As String
    Dim notaMay As Double
    Dim notaMen As Double
    nomMay = N(1)
    notaMay = nf(1)
    
    nomMen = N(1)
    notaMen = nf(1)
    
    For i = 2 To 10 Step 1
        If (nf(i) > notaMay) Then
            nomMay = N(i)
            notaMay = nf(i)
        End If
        If (nf(i) < notaMen) Then
            nomMen = N(i)
            notaMen = nf(i)
        End If
    Next i
    MsgBox (nomMay & " tiene la mayor nota : " & notaMay)
    MsgBox (nomMen & " tiene la menor nota : " & notaMen)
End Sub


