Public Class Form1
    Dim gerak, kedip As Integer
    Dim teks As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teks = TextBox1.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = gerak
        teks = Microsoft.VisualBasic.Right(teks, Len(teks) - 1) & Microsoft.VisualBasic.Left(teks, 1)
        TextBox1.Text = teks
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        kedip = kedip + 1
        If kedip = 2 Then
            kedip = 0
        End If
        If kedip Mod 2 = 0 Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
    End Sub
End Class
