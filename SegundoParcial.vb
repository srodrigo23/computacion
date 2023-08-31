Dim v(1 To 4) As String
Dim s(1 To 4) As String

Dim autores(1 To 4) As String
Dim titulos(1 To 4) As String

Dim isbn As String
Dim titulo As String
Dim autor As String
Dim edit As String
Dim anio As Integer
Dim numPag As Integer
Dim numEjem As Integer
Dim cantA As Integer

Dim cad As String
Dim posEsp As Integer

Dim datosMayorCantEjemplares As String
Dim cantEjemMay As Integer


Private Sub cmdEjecutar_Click()
    
    datosMayorCantEjemplares = ""
    cantEjemMay = 0
    
    'Cargar y mostrar el arreglo (a y b)
    For i = 1 To 4 Step 1
        v(i) = InputBox("Ingresar datos del libro " & i)
        ListBox1.AddItem (v(i))
    Next i
    
    'Desarrollo de los demas incisos
    cantA = 0
    
    For i = 1 To 4 Step 1
        cad = v(i)
        posEsp = InStr(cad, " ")
        isbn = Left(cad, posEsp - 1)
        cad = Mid(cad, posEsp + 1, Len(cad) - posEsp)
        
        posEsp = InStr(cad, " ")
        titulo = Left(cad, posEsp - 1)
        cad = Mid(cad, posEsp + 1, Len(cad) - posEsp)
        
        posEsp = InStr(cad, " ")
        autor = Left(cad, posEsp - 1)
        cad = Mid(cad, posEsp + 1, Len(cad) - posEsp)
        
        posEsp = InStr(cad, " ")
        edit = Left(cad, posEsp - 1)
        cad = Mid(cad, posEsp + 1, Len(cad) - posEsp)
        
        posEsp = InStr(cad, " ")
        anio = Val(Left(cad, posEsp - 1))
        cad = Mid(cad, posEsp + 1, Len(cad) - posEsp)
        
        posEsp = InStr(cad, " ")
        numPag = Val(Left(cad, posEsp - 1))
        cad = Mid(cad, posEsp + 1, Len(cad) - posEsp)
        
        numEjem = Val(Trim(cad))
        
        'Para la ordenacion
        s(i) = anio & " " & titulo & " " & autor & " " & edit & " " & numPag
        
        'Para la busqueda dado un nombre de un Autor
        autores(i) = autor
        titulos(i) = titulo
        
        'anio de edicion el 2013
        If (anio = 2013) Then
            ListBox2.AddItem (isbn & " " & autor & " " & titulo)
        End If
        
        'cantidad de ejemplares mayor a 3
        If (numEjem >= 3) Then
            ListBox3.AddItem (isbn & " " & autor & " " & titulo)
        End If
            
        'la cantidad de ejemplares cuyo nombre empieza con A o a
        If (UCase(Left(titulo, 1)) = "A") Then
            cantA = cantA + 1
        End If
        
        'los datos del libro con mayor cantidad de ejemplares
        If (numEjem > cantEjemMay) Then
            cantEjemMay = numEjem
            datosMayorCantEjemplares = isbn & " " & autor & " " & titulo
        End If
    Next i
    
    TextBox1.Text = datosMayorCantEjemplares
    TextBox2.Text = cantA
    
    'burbuja para ordenar
    For i = 1 To 4 Step 1
        For j = i + 1 To 4 Step 1
            If (s(i) > s(j)) Then
                aux = s(i)
                s(i) = s(j)
                s(j) = aux
            End If
        Next j
        ListBox5.AddItem (s(i))
    Next i
End Sub

Sub cmdBuscarAutor_Click()
    Dim nomAutor As String
    nomAutor = InputBox("Ingrese el nombre del autor")
    Dim ninguno As Boolean
    ninguno = False
    For i = 1 To 4 Step 1
        If (nomAutor = autores(i)) Then
            ListBox4.AddItem (titulos(i))
            ninguno = True
        End If
    Next i
    If (ninguno = False) Then
        MsgBox ("No existe este autor")
    End If
End Sub
