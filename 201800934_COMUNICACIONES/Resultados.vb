Module Resultados

    Const tablet = 375
    Const drone = 560
    Const celular = 1450
    Const televisor = 3250


    Function Comision() As Long
        Dim comision1 As Long

        Select Case Form1.cb_articulo.SelectedIndex
            Case 0
                comision1 = tablet * 0.055
            Case 1
                comision1 = drone * 0.055
            Case 2
                Comision = celular * 0.055
            Case 3
                comision1 = televisor * 0.055
        End Select

        Return comision1
    End Function

    Function Bono(sueldo As Long) As Long
        Dim bono1 As Long

        If sueldo <= 2000 Then
            bono1 = sueldo * 0.03
        ElseIf sueldo <= 5000 Then
            bono1 = sueldo * 0.04
        Else
            bono1 = sueldo * 0.05
        End If

        Return bono1
    End Function

    Function SueldoFinal()
        Dim sueldo As Long

        sueldo = Form1.txt_valorbruto.Text + Comision() + Bono(Form1.txt_valorbruto.Text)
        Return sueldo
    End Function
    Sub LimpiarVectores()
        Form1.lb_nombre.Items.Clear()
        Form1.lb_valorbruto.Items.Clear()
        Form1.lb_articulo.Items.Clear()
        Form1.lb_comision.Items.Clear()
        Form1.lb_bono.Items.Clear()
        Form1.lb_sueldofinal.Items.Clear()

        For i = 0 To 6

            Form1.nombre(i) = ""
            Form1.valorbruto(i) = ""
            Form1.articulo(i) = ""
            Form1.comision(i) = ""
            Form1.bono(i) = ""
            Form1.sueldofinal(i) = ""

        Next i

        Form1.index = 0
    End Sub

End Module
