Public Class Form1

    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        If txt_login.Text = "Hichem" And txt_password.Text = "mohamed" Then
            Acceuil.Show()

            Me.Hide()

        Else
            Me.lbl_err.Visible = True
        End If
    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        Me.Close()
    End Sub



End Class
