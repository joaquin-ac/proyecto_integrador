<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.BListarClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.BProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BNuevoProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.BListarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.BVendedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.BListarVendedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BClientes, Me.BProductos, Me.BVendedores})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(126, 431)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'BClientes
        '
        Me.BClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BListarClientes})
        Me.BClientes.Image = Global.proyecto_integrador.My.Resources.Resources.cliente
        Me.BClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BClientes.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.BClientes.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.BClientes.ShowShortcutKeys = False
        Me.BClientes.Size = New System.Drawing.Size(113, 46)
        Me.BClientes.Text = "  &Clientes"
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BListarClientes
        '
        Me.BListarClientes.Image = Global.proyecto_integrador.My.Resources.Resources.listar
        Me.BListarClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BListarClientes.ImageTransparentColor = System.Drawing.Color.Black
        Me.BListarClientes.Name = "BListarClientes"
        Me.BListarClientes.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.BListarClientes.ShowShortcutKeys = False
        Me.BListarClientes.Size = New System.Drawing.Size(196, 38)
        Me.BListarClientes.Text = "&Listar"
        '
        'BProductos
        '
        Me.BProductos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BNuevoProducto, Me.BListarProducto})
        Me.BProductos.Image = Global.proyecto_integrador.My.Resources.Resources.productos
        Me.BProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BProductos.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.BProductos.Size = New System.Drawing.Size(113, 46)
        Me.BProductos.Text = "  &Productos"
        '
        'BNuevoProducto
        '
        Me.BNuevoProducto.Image = Global.proyecto_integrador.My.Resources.Resources.agregar_prod1
        Me.BNuevoProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BNuevoProducto.Name = "BNuevoProducto"
        Me.BNuevoProducto.Size = New System.Drawing.Size(196, 38)
        Me.BNuevoProducto.Text = "&Nuevo"
        '
        'BListarProducto
        '
        Me.BListarProducto.Image = Global.proyecto_integrador.My.Resources.Resources.lista_prod1
        Me.BListarProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BListarProducto.Name = "BListarProducto"
        Me.BListarProducto.Size = New System.Drawing.Size(196, 38)
        Me.BListarProducto.Text = "&Listar"
        '
        'BVendedores
        '
        Me.BVendedores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BListarVendedores})
        Me.BVendedores.Image = Global.proyecto_integrador.My.Resources.Resources.vendedor
        Me.BVendedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVendedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BVendedores.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BVendedores.Name = "BVendedores"
        Me.BVendedores.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.BVendedores.Size = New System.Drawing.Size(113, 46)
        Me.BVendedores.Text = "  &Vendedores"
        '
        'BListarVendedores
        '
        Me.BListarVendedores.CheckOnClick = True
        Me.BListarVendedores.Image = Global.proyecto_integrador.My.Resources.Resources.listar
        Me.BListarVendedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BListarVendedores.Name = "BListarVendedores"
        Me.BListarVendedores.ShowShortcutKeys = False
        Me.BListarVendedores.Size = New System.Drawing.Size(196, 38)
        Me.BListarVendedores.Text = "&Listar"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents BClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BListarClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents BProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BVendedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BListarVendedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BNuevoProducto As ToolStripMenuItem
    Friend WithEvents BListarProducto As ToolStripMenuItem
End Class
