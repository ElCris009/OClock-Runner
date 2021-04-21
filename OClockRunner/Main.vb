Public Class Main
    Private Hora As Integer = 0
    Private Minuto As Integer = 0
    Private Segundo As Integer = 0
    Dim int As Integer = 0

    Private Sub Main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Task1_RunURL = TextBox1.Text
        My.Settings.Task2_RunURL = TextBox2.Text
        My.Settings.Task3_RunURL = TextBox3.Text
        My.Settings.Task1_Hour = NumericUpDown1.Value
        My.Settings.Task1_Minute = NumericUpDown2.Value
        My.Settings.Task1_Second = NumericUpDown3.Value
        My.Settings.Task2_Hour = NumericUpDown4.Value
        My.Settings.Task2_Minute = NumericUpDown5.Value
        My.Settings.Task2_Second = NumericUpDown6.Value
        My.Settings.Task3_Hour = NumericUpDown7.Value
        My.Settings.Task3_Minute = NumericUpDown8.Value
        My.Settings.Task3_Second = NumericUpDown9.Value
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Hora = Format(DateAndTime.TimeOfDay, "hh")
        Minuto = Format(DateAndTime.TimeOfDay, "mm")
        Segundo = Format(DateAndTime.TimeOfDay, "ss")
        MostrarTiempo()
        Label2.Text = (DateAndTime.Today)
        TextBox1.Text = My.Settings.Task1_RunURL
        TextBox2.Text = My.Settings.Task2_RunURL
        TextBox3.Text = My.Settings.Task3_RunURL
        NumericUpDown1.Value = Hora
        NumericUpDown2.Value = Minuto
        NumericUpDown3.Value = Segundo

        NumericUpDown4.Value = Hora
        NumericUpDown5.Value = Minuto
        NumericUpDown6.Value = Segundo

        NumericUpDown7.Value = Hora
        NumericUpDown8.Value = Minuto
        NumericUpDown9.Value = Segundo
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        NotifyIcon1.Text = "O' Clock Runner"
        Me.WindowState = FormWindowState.Normal
        Me.Width = 544
        Me.Height = 363
        Me.Show()
        Me.Focus()
        Me.CenterToScreen()
    End Sub

    Private Sub Main_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Select Case Me.WindowState
            Case FormWindowState.Normal
                NotifyIcon1.Text = "O' Clock Runner"
                Me.ShowInTaskbar = True
                Me.Show()
                Me.Focus()
                Me.CenterToScreen()
            Case FormWindowState.Minimized
                NotifyIcon1.Text = "Click me please, is dark here."
        End Select
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click
        Me.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        NotifyIcon1.Text = "Click me please, is dark here."
        NotifyIcon1.ShowBalloonTip(1, "O' Clock Runner Status", "Still Running in background!", ToolTipIcon.Info)
        Me.Hide()
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

    Private Sub btnTask1_Open_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Title = "Abrir un archivo..."
        OpenFile.FileName = Nothing
        OpenFile.InitialDirectory = "C:\"
        OpenFile.Multiselect = False
        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub btnTask2_Open_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Title = "Abrir un archivo..."
        OpenFile.FileName = Nothing
        OpenFile.InitialDirectory = "C:\"
        OpenFile.Multiselect = False
        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub btnTask3_Open_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Title = "Abrir un archivo..."
        OpenFile.FileName = Nothing
        OpenFile.InitialDirectory = "C:\"
        OpenFile.Multiselect = False
        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox3.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Button1.BackColor = Color.Transparent Then
            NumericUpDown1.Enabled = False
            NumericUpDown2.Enabled = False
            NumericUpDown3.Enabled = False
            Button1.BackColor = Color.Red
        Else
            NumericUpDown1.Enabled = True
            NumericUpDown2.Enabled = True
            NumericUpDown3.Enabled = True
            Button1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Button2.BackColor = Color.Transparent Then
            NumericUpDown4.Enabled = False
            NumericUpDown5.Enabled = False
            NumericUpDown6.Enabled = False
            Button2.BackColor = Color.Red
        Else
            NumericUpDown4.Enabled = True
            NumericUpDown5.Enabled = True
            NumericUpDown6.Enabled = True
            Button2.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Button3.BackColor = Color.Transparent Then
            NumericUpDown7.Enabled = False
            NumericUpDown8.Enabled = False
            NumericUpDown9.Enabled = False
            Button3.BackColor = Color.Red
        Else
            NumericUpDown7.Enabled = True
            NumericUpDown8.Enabled = True
            NumericUpDown9.Enabled = True
            Button3.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If Button1.BackColor = Color.Red Then
            If NumericUpDown1.Value = Val(Hora) And NumericUpDown2.Value = Val(Minuto) And NumericUpDown3.Value = Val(Segundo) Then
                Process.Start(TextBox1.Text)
                NumericUpDown1.Enabled = True
                NumericUpDown2.Enabled = True
                NumericUpDown3.Enabled = True
                Button1.BackColor = Color.Transparent
            End If
        End If
        If Button2.BackColor = Color.Red Then
            If NumericUpDown4.Value = Val(Hora) And NumericUpDown5.Value = Val(Minuto) And NumericUpDown6.Value = Val(Segundo) Then
                Process.Start(TextBox2.Text)
                NumericUpDown4.Enabled = True
                NumericUpDown5.Enabled = True
                NumericUpDown6.Enabled = True
                Button2.BackColor = Color.Transparent
            End If
        End If
        If Button3.BackColor = Color.Red Then
            If NumericUpDown7.Value = Val(Hora) And NumericUpDown8.Value = Val(Minuto) And NumericUpDown9.Value = Val(Segundo) Then
                Process.Start(TextBox3.Text)
                NumericUpDown7.Enabled = True
                NumericUpDown8.Enabled = True
                NumericUpDown9.Enabled = True
                Button3.BackColor = Color.Transparent
                Button3.BackColor = Color.Transparent
            End If
        End If
    End Sub

#Region "Mover el Form"
    Private Arrastrar As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            Arrastrar = True
            Me.Cursor = Cursors.SizeAll
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If Location.X < 30 And Location.Y < 30 Then
            Me.Location = New Point(0, 0)
        End If
        If Arrastrar = True Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            Arrastrar = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region
End Class