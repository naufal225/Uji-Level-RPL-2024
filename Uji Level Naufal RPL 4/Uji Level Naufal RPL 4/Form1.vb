Imports System.Data.Odbc

Public Class Form1
    Private Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data tidak valid")
        Else
            Using conn As New OdbcConnection(lokasi)
                conn.Open()
                Using cmd As New OdbcCommand("select * from tbl_naufal where username = '" & TextBox1.Text & "'", conn)
                    Dim rd As OdbcDataReader = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows Then
                        If TextBox2.Text = rd!password Then
                            Me.Visible = False
                            Form2.Visible = True
                        Else
                            MsgBox("Password salah")
                            TextBox2.Text = ""
                        End If
                    Else
                        MsgBox("Akun tidak ada")
                        Call kondisiawal()
                    End If
                End Using
                conn.Close()
            End Using
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call kondisiawal()
    End Sub
End Class
