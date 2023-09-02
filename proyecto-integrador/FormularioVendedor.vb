Imports System.Text.RegularExpressions ' Regular Expressions
Public Class FormularioVendedor

    'variable global para el archivo destino
    Dim destinationPathFile As String

    Private Sub Formulario5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'establecemos altura de las filas
        DGV1.RowTemplate.Height = 50
    End Sub


    'Agregamo Foto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BFoto.Click

        'generamos un opendialog file
        Dim AbrirArchivo As OpenFileDialog = New OpenFileDialog()
        AbrirArchivo.Filter = "JPeg Image|*.jpg|Png Image|*.png"
        AbrirArchivo.Title = "Seleccione imagen"
        'Timestamp Unixstamp
        Dim uTime As Integer
        uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        'si el open dialog da OK procedemos
        If (AbrirArchivo.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then

            'comprobamos existencia de carpeta
            Dim folder As String = My.Computer.FileSystem.CurrentDirectory.ToString() + "\Fotos"

            'establecemos destino del archivo
            destinationPathFile = folder + "\" + uTime.ToString + AbrirArchivo.SafeFileName

            'si el directorio no existe lo creamos
            If (Not System.IO.Directory.Exists(folder)) Then
                System.IO.Directory.CreateDirectory(folder)
            End If

            'copias el archivo a la carpeta generada con sobreescritura
            My.Computer.FileSystem.CopyFile(AbrirArchivo.FileName, destinationPathFile, True)

            'mostrar path original imagen el textbox
            TBFoto.Text = AbrirArchivo.FileName

            'cambiar imagen del PictureBox principal
            PBAvatar.BackgroundImage = Image.FromFile(destinationPathFile)

        End If

    End Sub

    'agregamos cliente
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        'variable de control
        Dim errorCheck As Boolean = False

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos: "

        'verificamos campo vacio Saldo
        If Regex.IsMatch(TBSaldo.Text.Trim, "^\S+$") = False Then
            msjTxt = msjTxt + " Introduzca Saldo. "
            errorCheck = True
        Else
            'solo números
            If IsNumeric(TBSaldo.Text.Trim) = False Then
                msjTxt = msjTxt + " Introduzca un valor númerico con o sin decimales en el campo Saldo.  "
                errorCheck = True
            End If
        End If

        'verificamos campo vacio Apellido
        If Regex.IsMatch(TBApellido.Text.Trim, "^\S+$") = False Then
            msjTxt = msjTxt + " Introduzca Apellido. "
            errorCheck = True
        Else
            'solo caracteres alfabéticos
            If Regex.IsMatch(TBApellido.Text.Trim, "^[A-Za-z ]+$") = False Then
                msjTxt = msjTxt + " Introduzca solo caracteres alfabéticos en el campo Apellido. "
                errorCheck = True
            End If
        End If

        'verificamos campo vacio Nombre
        If Regex.IsMatch(TBNombre.Text.Trim, "^\S+$") = False Then
            msjTxt = msjTxt + " Introduzca Nombre. "
            errorCheck = True
        Else
            'solo caracteres alfabéticos
            If Regex.IsMatch(TBNombre.Text.Trim, "^[A-Za-z ]+$") = False Then
                msjTxt = msjTxt + " Introduzca solo caracteres alfabéticos en el campo Nombre. "
                errorCheck = True
            End If
        End If

        'si campos no validan
        If errorCheck Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            'mensaje y almacenamiento de resultado en variable
            Dim ask As Integer = MsgBox("¿Seguro que desea Guardar el Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")

            'si acepta guardamos / mensaje
            If ask = DialogResult.Yes Then
                'cambiamos el tipo de fuente de la columna apellido y nombre
                DGV1.Columns(0).DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)
                DGV1.Columns(1).DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)


                ' Dim ejemplo As New System.Windows.Forms.DataGridViewTextBoxColumn  tipo de dato texto
                '  Dim ejemplo As New System.Windows.Forms.DataGridViewButtonCell
                '  ejemplo.Value = "Eliminar"


                'creamos una fila y obtenemos numero de fila
                Dim numRow As Integer = DGV1.Rows.Add()
                'completamos los campos
                DGV1.Rows(numRow).Cells(0).Value = TBApellido.Text.Trim 'Nombre
                DGV1.Rows(numRow).Cells(1).Value = TBNombre.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(2).Value = DTPFecnac.Text.Trim 'Fecha Nacimiento
                If RBMasculino.Checked Then 'Si es Masculino
                    DGV1.Rows(numRow).Cells(3).Value = "Masculino"
                End If
                If RBFemenino.Checked Then 'Si es Femenino
                    DGV1.Rows(numRow).Cells(3).Value = "Femenino"
                End If
                DGV1.Rows(numRow).Cells(4).Value = "Eliminar" 'Titulo boton Eliminar
                DGV1.Rows(numRow).Cells(5).Value = TBSaldo.Text.Trim 'Saldo
                'Si existe imagen, cargamos en celda
                If (System.IO.File.Exists(destinationPathFile)) Then
                    DGV1.Rows(numRow).Cells(6).Value = Image.FromFile(destinationPathFile)
                Else
                    'sino, tomamos avatar por defecto
                    DGV1.Rows(numRow).Cells(6).Value = My.Resources.avatar
                End If
                DGV1.Rows(numRow).Cells(7).Value = destinationPathFile 'Ruta del archivo destino

                'Si el saldo es meenor a 50 establecemos fondo rojo
                Dim ValSaldo As Double = Convert.ToDouble(TBSaldo.Text)
                If ValSaldo < 50 Then
                    DGV1.Rows(numRow).DefaultCellStyle.BackColor = Color.Red
                End If

                'Reseteamos Form
                TBApellido.Clear()
                TBNombre.Clear()
                TBSaldo.Clear()
                TBFoto.Clear()
                PBAvatar.BackgroundImage = My.Resources.avatar
                destinationPathFile = ""
                DTPFecnac.ResetText()
                RBMasculino.Checked = True


            End If
        End If

    End Sub

    'eliminar fila y archivo asociado
    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

        'variable/objeto seleccionado
        Dim cell As DataGridViewButtonCell = TryCast(DGV1.CurrentCell, DataGridViewButtonCell)

        'si la celda no es vacia
        If cell IsNot Nothing Then

            'Genero una variable que contiene el boton en el datagrid
            Dim bc As DataGridViewButtonColumn = TryCast(DGV1.Columns(e.ColumnIndex), DataGridViewButtonColumn)

            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Eliminar" 'Nombre del boton / celda
                        'mensaje y almacenamiento de resultado en variable
                        Dim ask As Integer = MsgBox("¿Seguro que desea Eliminar el Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")

                        'si acepta guardamos / mensaje
                        'Quitamos fila        
                        DGV1.Rows.RemoveAt(cell.RowIndex)

                        Exit Select
                End Select

            End If
        End If

    End Sub
End Class
