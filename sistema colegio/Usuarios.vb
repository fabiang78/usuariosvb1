Imports System.Data.SqlClient

Public Class Usuarios

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelDatosA.Visible = False
        mostrar()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PanelDatosA.Visible = True
    End Sub

    Private Sub PanelAgregaR_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try


            Dim cmd As New SqlCommand
            iniciar()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombre", TextBoxNombreU.Text)
            cmd.Parameters.AddWithValue("@login", TextBoxUsuarioU.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxContraU.Text)
            cmd.ExecuteNonQuery()
            terminar()
            mostrar()
            PanelDatosA.Visible = False
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Sub mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            iniciar()
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(dt)
            DataListado.DataSource = dt
            terminar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub PanelBotonAgregar_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub DataListado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Close()

    End Sub

    Private Sub PanelRegistro_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelDatosA.Paint

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PanelDatosA.Visible = True
    End Sub

    Private Sub GUARDARToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARToolStripMenuItem.Click
        Try


            Dim cmd As New SqlCommand
            iniciar()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombre", TextBoxNombreU.Text)
            cmd.Parameters.AddWithValue("@login", TextBoxUsuarioU.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxContraU.Text)
            cmd.ExecuteNonQuery()
            terminar()
            mostrar()
            PanelDatosA.Visible = False
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado.CellClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("eli").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Está seguro de eliminar a este usuario?", "Elimando usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try


                    Dim cmd As New SqlCommand
                    iniciar()
                    cmd = New SqlCommand("eliminar_usuario", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idusuario", DataListado.SelectedCells.Item(1).Value)
                    cmd.ExecuteNonQuery()
                    terminar()
                    mostrar()

                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("Cancelando eliminacion de registro", "registro usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub DataListado_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado.CellContentClick

    End Sub

    Private Sub DataListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        Try
            PanelDatosA.Visible = True
            GUARDARToolStripMenuItem.Visible = False
            GUARDARCAMBIOSToolStripMenuItem.Visible = True
            TextBoxNombreU.Text = DataListado.SelectedCells.Item(2).Value
            TextBoxUsuarioU.Text = DataListado.SelectedCells.Item(3).Value
            TextBoxContraU.Text = DataListado.SelectedCells.Item(4).Value
            LabelIdU.Text = DataListado.SelectedCells.Item(1).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        Try


            Dim cmd As New SqlCommand
            iniciar()
            cmd = New SqlCommand("editar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idusuario", LabelIdU.Text)
            cmd.Parameters.AddWithValue("@nombre", TextBoxNombreU.Text)
            cmd.Parameters.AddWithValue("@login", TextBoxUsuarioU.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxContraU.Text)
            cmd.ExecuteNonQuery()
            terminar()
            mostrar()
            PanelDatosA.Visible = False
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
    Sub buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            iniciar()
            da = New SqlDataAdapter("buscar_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", TextBoxBusca.Text)
            da.Fill(dt)
            DataListado.DataSource = dt
            terminar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub TextBoxBusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBusca.TextChanged
        buscar()

    End Sub
End Class