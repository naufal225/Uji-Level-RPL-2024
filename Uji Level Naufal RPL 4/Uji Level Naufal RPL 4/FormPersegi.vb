Public Class FormPersegi

    Private Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub FormPersegi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hasil As Integer
        hasil = Val(TextBox1.Text) * Val(TextBox2.Text)
        Call kondisiawal()
        lblhasil.Text = "Luas Persegi Nya Adalah " & hasil.ToString & " cm^2"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblhasil.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        lblhasil.Text = "



"
    End Sub
End Class