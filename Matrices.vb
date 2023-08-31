Option Explicit

Dim M(1 To 15, 1 To 15) As Integer
Dim N As Integer
Dim D(1 To 15) As Integer

'CARGAR NUMERO
Private Sub CommandButton1_Click()
    N = LeerNumero(5, 15)
    Dim fila As String, i As Integer, j As Integer
    Randomize
    ListBox1.Clear
    For i = 1 To N
        fila = ""
        For j = 1 To N
            M(i, j) = Int(Rnd() * (2))
            fila = fila & M(i, j) & "   "
        Next j
        ListBox1.AddItem fila
    Next i
End Sub

Function LeerNumero(min As Integer, max As Integer) As Integer
    Dim N As Integer
    N = InputBox("Ingresar un numero")
    While N < min Or N > max
        N = InputBox("Ingresar un numero")
    Wend
    LeerNumero = N
End Function

'TRANSPUESTA
Private Sub CommandButton2_Click()
    Dim i As Integer, j As Integer, fila As String
    ListBox2.Clear
    For j = 1 To N
        fila = ""
        For i = 1 To N
            fila = fila & M(i, j) & "   "
        Next i
        ListBox2.AddItem fila
    Next j
End Sub

'DIAGONAL EN VECTOR
Private Sub CommandButton4_Click()
    Dim i As Integer, diag As String
    diag = ""
    For i = 1 To N
        D(i) = M(i, i)
        diag = diag & D(i) & " "
    Next i
    TextBox1.Text = diag
End Sub


'DETERMINANTE
Private Sub CommandButton3_Click()
    
    
End Sub

