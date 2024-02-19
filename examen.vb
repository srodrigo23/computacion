Dim A(1 To 20) As Integer
Dim B(1 To 20) As Integer
Dim interseccion(1 To 20) As Integer
Dim union(1 To 40) As Integer
Dim k As Integer
Dim i As Integer

Sub cmdInterseccion_Click()
    k = 1
    For i = 1 To 20 Step 1
        For j = 1 To 20 Step 1
            If (A(i) = B(j)) Then
                interseccion(k) = A(i)
                k = k + 1
                j = 20
            End If
        Next j
    Next i
    For i = 1 To (k - 1) Step 1
        lstInterSeccion.AddItem (interseccion(i))
    Next i
End Sub

Sub cmdLimpiar_Click()
    lstConjuntoA.Clear
End Sub

Sub cmdLimpiarB_Click()
    lstConjuntoB.Clear
End Sub

Function buscarA(ini As Integer, fin As Integer, buscado As Integer) As Boolean
    Dim res As Boolean
    res = False
    For k = ini To fin Step 1
        If (A(k) = buscado) Then
            res = True
            k = fin
        End If
    Next k
    buscarA = res
End Function

Sub cmdLimpiarInt_Click()
    lstInterSeccion.Clear
End Sub

Sub cmdLimpiarUnion_Click()
    lstUnion.Clear
End Sub

Sub cmdLlenarA_Click()
    Dim num As Integer
    A(1) = Int(1 + Rnd * 50)
    For i = 2 To 20 Step 1
        num = Int(1 + Rnd * 50)
        While (buscarA(1, i, num) = True)
            num = Int(1 + Rnd * 50)
        Wend
        A(i) = num
    Next i
    For i = 1 To 20 Step 1
        lstConjuntoA.AddItem (A(i))
    Next i
End Sub

Sub cmdLlenarB_Click()
    Dim num As Integer
    B(1) = Int(1 + Rnd * 50)
    For i = 2 To 20 Step 1
        num = Int(1 + Rnd * 50)
        While (buscarB(1, i, num) = True)
            num = Int(1 + Rnd * 50)
        Wend
        B(i) = num
    Next i
    For i = 1 To 20 Step 1
        lstConjuntoB.AddItem (B(i))
    Next i
End Sub

Function buscarB(ini As Integer, fin As Integer, buscado As Integer) As Boolean
    Dim res As Boolean
    res = False
    For k = ini To fin Step 1
        If (B(k) = buscado) Then
            res = True
            k = fin
        End If
    Next k
    buscarB = res
End Function

Sub cmdUnion_Click()
    Dim m As Integer
    m = 1
    For i = 1 To 20 Step 1
        union(m) = A(i)
        m = m + 1
    Next i
    For i = 1 To 20 Step 1
        union(m) = B(i)
        m = m + 1
    Next i
    
    For i = 1 To 40 Step 1
        For j = i + 1 To 40 Step 1
            If (union(i) <> 0) Then
                If (union(i) = union(j)) Then
                    union(j) = 0
                    j = 40
                End If
            End If
        Next j
    Next i
    
    For i = 1 To 40 Step 1
        If (union(i) <> 0) Then
            lstUnion.AddItem (union(i))
        End If
    Next i
End Sub

