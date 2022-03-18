Public Class Form1

    Public nombre(6) As String
    Public valorbruto(6) As String
    Public articulo(6) As String
    Public comision(6) As String
    Public bono(6) As String
    Public sueldofinal(6) As String
    Public index As Byte = 0



    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

        If index < 7 Then
            If txt_nombre.Text <> "" Then
                nombre(index) = txt_nombre.Text


            Else
                MsgBox("Debe ingresar un nombre...")
                Exit Sub
            End If

            If txt_valorbruto.Text <> "" Then
                valorbruto(index) = txt_valorbruto.Text

            Else
                MsgBox("Debe ingresar un valor bruto...")
                Exit Sub
            End If

            If cb_articulo.SelectedIndex <> -1 Then
                articulo(index) = cb_articulo.SelectedItem

            Else
                MsgBox("Debe seleccionar un articulo...")
                Exit Sub
            End If

            lb_nombre.Items.Add(nombre(index))
            lb_valorbruto.Items.Add(valorbruto(index))
            lb_articulo.Items.Add(articulo(index))
            lb_comision.Items.Add(System.Math.Round(Resultados.Comision, 2))
            lb_bono.Items.Add(System.Math.Round(Resultados.Bono(Str(txt_valorbruto.Text)), 2))
            lb_sueldofinal.Items.Add(System.Math.Round(Resultados.SueldoFinal, 2))

            index = index + 1
        Else
                MsgBox("Las listas estan llenas...")
            Exit Sub
        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        txt_nombre.Clear()
        txt_nombre.Focus()
        txt_valorbruto.Clear()

    End Sub

    Private Sub LIMPIARTABLAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARTABLAToolStripMenuItem.Click
        Resultados.LimpiarVectores()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("Deseas salir", vbYesNo, "") = vbYes Then
            End
        End If
    End Sub


End Class
