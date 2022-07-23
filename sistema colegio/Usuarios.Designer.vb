<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.PanelUsuarios = New System.Windows.Forms.Panel()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxBusca = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PanelDatosA = New System.Windows.Forms.Panel()
        Me.LabelIdU = New System.Windows.Forms.Label()
        Me.TextBoxContraU = New System.Windows.Forms.TextBox()
        Me.TextBoxUsuarioU = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreU = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.GUARDARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUARDARCAMBIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelUsuarios.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosA.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelUsuarios
        '
        Me.PanelUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelUsuarios.Controls.Add(Me.ButtonCerrar)
        Me.PanelUsuarios.Controls.Add(Me.Panel1)
        Me.PanelUsuarios.Controls.Add(Me.Label1)
        Me.PanelUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsuarios.Name = "PanelUsuarios"
        Me.PanelUsuarios.Size = New System.Drawing.Size(938, 74)
        Me.PanelUsuarios.TabIndex = 0
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.FlatAppearance.BorderSize = 0
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Location = New System.Drawing.Point(828, 12)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCerrar.TabIndex = 2
        Me.ButtonCerrar.Text = "X"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 5)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(33, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIOS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxBusca)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 65)
        Me.Panel2.TabIndex = 1
        '
        'TextBoxBusca
        '
        Me.TextBoxBusca.Location = New System.Drawing.Point(124, 22)
        Me.TextBoxBusca.Name = "TextBoxBusca"
        Me.TextBoxBusca.Size = New System.Drawing.Size(617, 26)
        Me.TextBoxBusca.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(82, 22)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(36, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarToolStripMenuItem.ForeColor = System.Drawing.Color.Transparent
        Me.BuscarToolStripMenuItem.Image = CType(resources.GetObject("BuscarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.BackgroundColor = System.Drawing.Color.White
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.DataListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataListado.Location = New System.Drawing.Point(0, 139)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.RowHeadersVisible = False
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(811, 427)
        Me.DataListado.TabIndex = 2
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        '
        'PanelDatosA
        '
        Me.PanelDatosA.BackColor = System.Drawing.Color.White
        Me.PanelDatosA.Controls.Add(Me.LabelIdU)
        Me.PanelDatosA.Controls.Add(Me.TextBoxContraU)
        Me.PanelDatosA.Controls.Add(Me.TextBoxUsuarioU)
        Me.PanelDatosA.Controls.Add(Me.TextBoxNombreU)
        Me.PanelDatosA.Controls.Add(Me.Label4)
        Me.PanelDatosA.Controls.Add(Me.Label3)
        Me.PanelDatosA.Controls.Add(Me.Label2)
        Me.PanelDatosA.Controls.Add(Me.MenuStrip2)
        Me.PanelDatosA.Location = New System.Drawing.Point(140, 139)
        Me.PanelDatosA.Name = "PanelDatosA"
        Me.PanelDatosA.Size = New System.Drawing.Size(665, 313)
        Me.PanelDatosA.TabIndex = 3
        '
        'LabelIdU
        '
        Me.LabelIdU.AutoSize = True
        Me.LabelIdU.Location = New System.Drawing.Point(570, 12)
        Me.LabelIdU.Name = "LabelIdU"
        Me.LabelIdU.Size = New System.Drawing.Size(57, 20)
        Me.LabelIdU.TabIndex = 7
        Me.LabelIdU.Text = "Label5"
        '
        'TextBoxContraU
        '
        Me.TextBoxContraU.Location = New System.Drawing.Point(163, 162)
        Me.TextBoxContraU.Name = "TextBoxContraU"
        Me.TextBoxContraU.Size = New System.Drawing.Size(413, 26)
        Me.TextBoxContraU.TabIndex = 5
        '
        'TextBoxUsuarioU
        '
        Me.TextBoxUsuarioU.Location = New System.Drawing.Point(163, 103)
        Me.TextBoxUsuarioU.Name = "TextBoxUsuarioU"
        Me.TextBoxUsuarioU.Size = New System.Drawing.Size(413, 26)
        Me.TextBoxUsuarioU.TabIndex = 4
        '
        'TextBoxNombreU
        '
        Me.TextBoxNombreU.Location = New System.Drawing.Point(163, 40)
        Me.TextBoxNombreU.Name = "TextBoxNombreU"
        Me.TextBoxNombreU.Size = New System.Drawing.Size(413, 26)
        Me.TextBoxNombreU.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GUARDARToolStripMenuItem, Me.GUARDARCAMBIOSToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 288)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(665, 25)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'GUARDARToolStripMenuItem
        '
        Me.GUARDARToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.GUARDARToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUARDARToolStripMenuItem.Name = "GUARDARToolStripMenuItem"
        Me.GUARDARToolStripMenuItem.Size = New System.Drawing.Size(82, 21)
        Me.GUARDARToolStripMenuItem.Text = "GUARDAR"
        '
        'GUARDARCAMBIOSToolStripMenuItem
        '
        Me.GUARDARCAMBIOSToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.GUARDARCAMBIOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUARDARCAMBIOSToolStripMenuItem.Name = "GUARDARCAMBIOSToolStripMenuItem"
        Me.GUARDARCAMBIOSToolStripMenuItem.Size = New System.Drawing.Size(144, 21)
        Me.GUARDARCAMBIOSToolStripMenuItem.Text = "GUARDAR CAMBIOS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(811, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 427)
        Me.Panel3.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 566)
        Me.Controls.Add(Me.PanelDatosA)
        Me.Controls.Add(Me.DataListado)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelUsuarios)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.PanelUsuarios.ResumeLayout(False)
        Me.PanelUsuarios.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatosA.ResumeLayout(False)
        Me.PanelDatosA.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelUsuarios As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxBusca As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataListado As System.Windows.Forms.DataGridView
    Friend WithEvents PanelDatosA As System.Windows.Forms.Panel
    Friend WithEvents TextBoxContraU As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUsuarioU As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombreU As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents GUARDARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GUARDARCAMBIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelIdU As System.Windows.Forms.Label
    Friend WithEvents Eli As System.Windows.Forms.DataGridViewImageColumn
End Class
