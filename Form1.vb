Public Class Form1
    Public type As String
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        type = "bird"
        frm_bird.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        type = "tiger"
        frm_tiger.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        type = "mouse"
        frm_mouse.Show()
        Me.Hide()

    End Sub
End Class

