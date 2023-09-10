<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario1
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
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.RBFemenino = New System.Windows.Forms.RadioButton()
        Me.RBMasculino = New System.Windows.Forms.RadioButton()
        Me.PanelSexo = New System.Windows.Forms.Panel()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TBFoto = New System.Windows.Forms.TextBox()
        Me.BFoto = New System.Windows.Forms.Button()
        Me.TBSaldo = New System.Windows.Forms.TextBox()
        Me.DTPFecnac = New System.Windows.Forms.DateTimePicker()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LSaldo = New System.Windows.Forms.Label()
        Me.LFecnac = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.PBAvatar = New System.Windows.Forms.PictureBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecnac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.bg
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.RBFemenino)
        Me.PanelPrincipal.Controls.Add(Me.RBMasculino)
        Me.PanelPrincipal.Controls.Add(Me.PanelSexo)
        Me.PanelPrincipal.Controls.Add(Me.LSexo)
        Me.PanelPrincipal.Controls.Add(Me.BAgregar)
        Me.PanelPrincipal.Controls.Add(Me.TBFoto)
        Me.PanelPrincipal.Controls.Add(Me.BFoto)
        Me.PanelPrincipal.Controls.Add(Me.TBSaldo)
        Me.PanelPrincipal.Controls.Add(Me.DTPFecnac)
        Me.PanelPrincipal.Controls.Add(Me.TBApellido)
        Me.PanelPrincipal.Controls.Add(Me.TBNombre)
        Me.PanelPrincipal.Controls.Add(Me.LSaldo)
        Me.PanelPrincipal.Controls.Add(Me.LFecnac)
        Me.PanelPrincipal.Controls.Add(Me.LApellido)
        Me.PanelPrincipal.Controls.Add(Me.LNombre)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(113, 24)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(401, 341)
        Me.PanelPrincipal.TabIndex = 0
        '
        'RBFemenino
        '
        Me.RBFemenino.AutoSize = True
        Me.RBFemenino.BackColor = System.Drawing.Color.Transparent
        Me.RBFemenino.ForeColor = System.Drawing.Color.White
        Me.RBFemenino.Location = New System.Drawing.Point(271, 197)
        Me.RBFemenino.Name = "RBFemenino"
        Me.RBFemenino.Size = New System.Drawing.Size(79, 17)
        Me.RBFemenino.TabIndex = 13
        Me.RBFemenino.Text = "Femenino"
        Me.RBFemenino.UseVisualStyleBackColor = False
        '
        'RBMasculino
        '
        Me.RBMasculino.AutoSize = True
        Me.RBMasculino.BackColor = System.Drawing.Color.Transparent
        Me.RBMasculino.Checked = True
        Me.RBMasculino.ForeColor = System.Drawing.Color.White
        Me.RBMasculino.Location = New System.Drawing.Point(157, 197)
        Me.RBMasculino.Name = "RBMasculino"
        Me.RBMasculino.Size = New System.Drawing.Size(82, 17)
        Me.RBMasculino.TabIndex = 12
        Me.RBMasculino.TabStop = True
        Me.RBMasculino.Text = "Masculino"
        Me.RBMasculino.UseVisualStyleBackColor = False
        '
        'PanelSexo
        '
        Me.PanelSexo.BackColor = System.Drawing.Color.Transparent
        Me.PanelSexo.Location = New System.Drawing.Point(146, 188)
        Me.PanelSexo.Name = "PanelSexo"
        Me.PanelSexo.Size = New System.Drawing.Size(209, 38)
        Me.PanelSexo.TabIndex = 14
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.BackColor = System.Drawing.Color.Transparent
        Me.LSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSexo.ForeColor = System.Drawing.Color.White
        Me.LSexo.Location = New System.Drawing.Point(16, 188)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(67, 25)
        Me.LSexo.TabIndex = 11
        Me.LSexo.Text = "Sexo:"
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.proyecto_integrador.My.Resources.Resources.diskette
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(129, 272)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BAgregar.Size = New System.Drawing.Size(110, 47)
        Me.BAgregar.TabIndex = 10
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'TBFoto
        '
        Me.TBFoto.Location = New System.Drawing.Point(124, 236)
        Me.TBFoto.Name = "TBFoto"
        Me.TBFoto.ReadOnly = True
        Me.TBFoto.Size = New System.Drawing.Size(254, 20)
        Me.TBFoto.TabIndex = 9
        '
        'BFoto
        '
        Me.BFoto.Location = New System.Drawing.Point(31, 236)
        Me.BFoto.Name = "BFoto"
        Me.BFoto.Size = New System.Drawing.Size(75, 23)
        Me.BFoto.TabIndex = 8
        Me.BFoto.Text = "Foto"
        Me.BFoto.UseVisualStyleBackColor = True
        '
        'TBSaldo
        '
        Me.TBSaldo.Location = New System.Drawing.Point(124, 150)
        Me.TBSaldo.Name = "TBSaldo"
        Me.TBSaldo.Size = New System.Drawing.Size(254, 20)
        Me.TBSaldo.TabIndex = 7
        '
        'DTPFecnac
        '
        Me.DTPFecnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecnac.Location = New System.Drawing.Point(236, 104)
        Me.DTPFecnac.Name = "DTPFecnac"
        Me.DTPFecnac.Size = New System.Drawing.Size(142, 20)
        Me.DTPFecnac.TabIndex = 6
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(124, 61)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(254, 20)
        Me.TBApellido.TabIndex = 5
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(124, 18)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(254, 20)
        Me.TBNombre.TabIndex = 4
        '
        'LSaldo
        '
        Me.LSaldo.AutoSize = True
        Me.LSaldo.BackColor = System.Drawing.Color.Transparent
        Me.LSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSaldo.ForeColor = System.Drawing.Color.White
        Me.LSaldo.Location = New System.Drawing.Point(16, 142)
        Me.LSaldo.Name = "LSaldo"
        Me.LSaldo.Size = New System.Drawing.Size(73, 25)
        Me.LSaldo.TabIndex = 3
        Me.LSaldo.Text = "Saldo:"
        '
        'LFecnac
        '
        Me.LFecnac.AutoSize = True
        Me.LFecnac.BackColor = System.Drawing.Color.Transparent
        Me.LFecnac.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecnac.ForeColor = System.Drawing.Color.White
        Me.LFecnac.Location = New System.Drawing.Point(16, 99)
        Me.LFecnac.Name = "LFecnac"
        Me.LFecnac.Size = New System.Drawing.Size(227, 25)
        Me.LFecnac.TabIndex = 2
        Me.LFecnac.Text = "Fecha de Nacimiento: "
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.Color.Transparent
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(16, 53)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(95, 25)
        Me.LApellido.TabIndex = 1
        Me.LApellido.Text = "Apellido:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(16, 10)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(105, 25)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre2:"
        '
        'PBAvatar
        '
        Me.PBAvatar.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.avatar
        Me.PBAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBAvatar.Location = New System.Drawing.Point(621, 54)
        Me.PBAvatar.Name = "PBAvatar"
        Me.PBAvatar.Size = New System.Drawing.Size(254, 275)
        Me.PBAvatar.TabIndex = 1
        Me.PBAvatar.TabStop = False
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.Fecnac, Me.Sexo, Me.Eliminar, Me.Saldo, Me.Foto, Me.Ruta})
        Me.DGV1.Location = New System.Drawing.Point(25, 389)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(931, 164)
        Me.DGV1.TabIndex = 2
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Fecnac
        '
        Me.Fecnac.HeaderText = "Fecha de Nacimienot"
        Me.Fecnac.Name = "Fecnac"
        Me.Fecnac.ReadOnly = True
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'Foto
        '
        Me.Foto.HeaderText = "Foto"
        Me.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Foto.Name = "Foto"
        Me.Foto.ReadOnly = True
        '
        'Ruta
        '
        Me.Ruta.HeaderText = "Ruta"
        Me.Ruta.Name = "Ruta"
        Me.Ruta.ReadOnly = True
        '
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(977, 579)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PBAvatar)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Name = "Formulario1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario con DataGrid"
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents PBAvatar As PictureBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents TBSaldo As TextBox
    Friend WithEvents DTPFecnac As DateTimePicker
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LSaldo As Label
    Friend WithEvents LFecnac As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents BFoto As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents TBFoto As TextBox
    Friend WithEvents LSexo As Label
    Friend WithEvents RBFemenino As RadioButton
    Friend WithEvents RBMasculino As RadioButton
    Friend WithEvents PanelSexo As Panel
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecnac As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents Ruta As DataGridViewTextBoxColumn
End Class
