Option Explicit
Sub CommandButton1_Click()
    'ejercicio 1
    Dim num, cont, may As Integer
    cont = 0
    may = 0
    While (cont < 10)
        num = InputBox("Ingrese un numero")
        ListBox1.AddItem (num)
        If num > may Then
            may = num
        End If
        cont = cont + 1
    Wend
    MsgBox ("El numero mayor : " & may)
End Sub

Sub CommandButton2_Click()
    ' factorial
    ' n! = 1*2*3* ... * n
    Dim n As Integer
    Dim i As Integer
    Dim f As Integer
    Dim vb As Boolean 'variable bandera
    vb = True
    'factorial de n
    While vb = True
        n = InputBox("ingrese un numero")
        If n > 0 Then
            vb = False
        End If
    Wend
    i = 1
    f = 1
    While i <= n
        f = f * i
        i = i + 1
    Wend
    MsgBox ("Factorial de : " & n & " es " & f)
End Sub

Sub CommandButton3_Click()
    'cantidad de digitos de un numero
    'n = 53466 => 5
    'n = 987 = > 3
    Dim num As Integer, cont As Integer, lim_inf As Integer, lim_sup As Integer
    Dim cp As Integer
    'num = InputBox("Ingrese un numero")
    lim_inf = 1
    lim_sup = 10
    cont = 0
    num = Int(lim_inf + Rnd * (lim_sup - lim_inf + 1))
    cp = num
    '987 / 10 = 98
    '98  / 10 = 9
    '9   / 10 = 0
    While num > 0
        num = num \ 10 'division entera
        cont = cont + 1
    Wend
    MsgBox (cp & " tiene " & cont & " digito(s)")
End Sub


Sub CommandButton4_Click()
    'generar 10 numeros aleatorios de entre 1 y 1000 e invertirlos
    ' n = 54 => 45
    ' n = 234 => 432
    Dim num As Integer, ls As Integer, li As Integer
    Dim i As Integer, nn As Integer, dig As Integer
    Dim cp As Integer
    i = 0
    li = 1
    ls = 1000
    ListBox2.Clear
    'nn = 0
    '23456 -> 65432
    '2345  -> 6 = nn*10 + 6
    '234   -> 65 = nn*10 + 5
    '23    -> 654 = nn*10 +4
    '2     -> 6543 = nn*10 + 3
    '0     -> 65432 = nn*10 + 2
    While i < 10
        num = Int(li + Rnd * (ls - li + 1))
        cp = num
        i = i + 1
        nn = 0
        While num > 0
            dig = num Mod 10
            nn = (nn * 10) + dig
            num = num \ 10
        Wend
        ListBox2.AddItem (cp & " -> " & nn)
    Wend
End Sub



Private Sub CommandButton5_Click()
    'Generar las notas de 20 estudiantes (PP, SP, *EF) mostrar si aprobo o no la materia
    Dim i As Integer, pp As Integer, sp As Integer
    Dim prom As Double, ef As Integer
    For i = 1 To 20 Step 1 'inicio del for i=1,2,3,4,5,6,...20
        pp = Rnd() * 100 + 1
        sp = Rnd() * 100 + 1
        
        prom = (pp + sp) / 2
        If prom >= 51 Then
            ListBox3.AddItem (i & ".- pp: " & pp & " sp:" & sp & " prom:" & prom & " APROBADO")
        Else
            ef = Rnd() * 100 + 1
            If ef >= 51 Then
                ListBox3.AddItem (i & ".- pp:" & pp & " sp:" & sp & " ef:" & ef & " APROBADO")
            Else
                 ListBox3.AddItem (i & ".- pp:" & pp & " sp:" & sp & " ef:" & ef & " REPROBADO")
            End If
        End If
    Next i 'fin for
End Sub

Private Sub CommandButton6_Click()
    'Generar automaticamente la tabla de multiplicar de los numeros del 1 al 10
    ' 1 x 1 = 1
    ' 1 x 2 = 2
    ' ......
    ' 1 x 10 = 10
    '----------------
    ' 2 x 1 = 2
    ' 2 x 2 = 4
    ' ................
    ' 10 x 1 = 10
    ' 10 x 2 = 20
    ' .....
    ' 10 x 10 = 100
    Dim num As Integer, i As Integer, m As Integer
    For num = 5 To 10 Step 1
        ListBox4.AddItem ("-----------------")
        For i = 1 To 10 Step 1
            m = i * num
            ListBox4.AddItem (num & " x " & i & " = " & m)
        Next i
    Next num
End Sub

Private Sub CommandButton7_Click()
    'mostrar los numeros primos comprendidos entre el 1 y 100
    ' primo es un numero que solo es divisible entre 1 y si mismo
    ' 3 = 1, 3
    ' 8 = 1, 2, 4, 8
    ' 10 = 1, 2, 5, 10
    ' 11 = 1, 11
    Dim num As Integer, cd As Integer, i As Integer
    For num = 1 To 100 Step 1
        cd = 0
        For i = 1 To num Step 1
            If num Mod i = 0 Then
                cd = cd + 1
            End If
        Next i
        If cd = 2 Then
            'MsgBox (num & " es primo")
            ListBox5.AddItem (num & " es primo")
        'Else
            'MsgBox (num & " no es primo")
            'ListBox5.AddItem (num & " no es primo")
        End If
    Next num
End Sub
