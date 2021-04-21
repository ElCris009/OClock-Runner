Public Class Test
    Private Hora As Integer = 0
    Private Minuto As Integer = 0
    Private Segundo As Integer = 0
    Dim int As Integer = 0

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub MostrarTiempo()
        Label1.Text = Hora.ToString.PadLeft(2, "0") & ":"
        Label1.Text &= Minuto.ToString.PadLeft(2, "0") & ":"
        Label1.Text &= Segundo.ToString.PadLeft(2, "0")
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Hora = Format(DateAndTime.TimeOfDay, "hh")
        Minuto = Format(DateAndTime.TimeOfDay, "mm")
        Segundo = Format(DateAndTime.TimeOfDay, "ss")
        MostrarTiempo()
        Label2.Text = (DateAndTime.Today)
    End Sub

    Private Sub btnNewTask_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub btnRemoveTask_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
