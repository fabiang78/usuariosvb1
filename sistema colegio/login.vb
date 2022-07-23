Public Class login

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        Close()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBoxUsuario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxUsuario.Click
        TextBoxUsuario.Text = ""
        TextBoxUsuario.Focus()

    End Sub

    Private Sub TextBoxUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxUsuario.TextChanged

    End Sub

    Private Sub TextBoxContrasena_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxContrasena.Click
        TextBoxContrasena.Text = ""
        TextBoxContrasena.Focus()

    End Sub

    Private Sub TextBoxContrasena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxContrasena.TextChanged

    End Sub
End Class
