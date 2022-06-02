Public Class FrmVistaAdmin

    Dim emp As New BDSistemaEySDataSetTableAdapters.tbl_EmpleadoTableAdapter
    Dim tblEmp As New BDSistemaEySDataSet.tbl_EmpleadoDataTable

    Dim Dept As New BDSistemaEySDataSetTableAdapters.tbl_DepartamentoTableAdapter
    Dim tblDept As New BDSistemaEySDataSet.tbl_DepartamentoDataTable

    Dim Carg As New BDSistemaEySDataSetTableAdapters.tbl_CargoTableAdapter
    Dim tblCarg As New BDSistemaEySDataSet.tbl_CargoDataTable


    Private GR As Graphics

    'declaramos la constante de PI
    Const PI As Double = 3.14159265

    'declaramos la constante de conversion de radianes
    Const ConvRad As Double = PI / 180

    'declaramos un temporizador que actualiza la informacion de las horas
    Private WithEvents Temporizador As New Timer

    Private CentroX As Single = 300 / 2
    Private CentroY As Single = 280 / 2

    Private idEmp As Integer
    Private idUsuario As Integer

    Private Sub AñadirEntidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirEntidadToolStripMenuItem.Click
    End Sub

    Private Sub FrmVistaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDSistemaEySDataSet.Vw_RegistrosDia' Puede moverla o quitarla según sea necesario.
        Me.Vw_RegistrosDiaTableAdapter.Fill(Me.BDSistemaEySDataSet.Vw_RegistrosDia)
        'TODO: esta línea de código carga datos en la tabla 'BDSistemaEySDataSet.tbl_Usuario' Puede moverla o quitarla según sea necesario.
        'Me.Tbl_UsuarioTableAdapter1.Fill(Me.BDSistemaEySDataSet.tbl_Usuario)
        BDSistemaEySDataSet.EnforceConstraints = False

        Temporizador.Interval = 1000
        Temporizador.Enabled = True
        GR = Me.Panel4.CreateGraphics
        GR.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        RefrescarGraficos()

        If VwVistaAdminBindingSource IsNot Nothing Then
            Me.Vw_VistaAdminTableAdapter.Fill(Me.BDSistemaEySDataSet.Vw_VistaAdmin)
        End If

    End Sub

    Public Sub AsignarUsuario(idEmp As Integer, idUsuario As Integer)
        Me.idEmp = idEmp
        Me.idUsuario = idUsuario
        Dim atito As String

        Me.Vw_UsuarioTableAdapter.EncontrarUser(Me.BDSistemaEySDataSet.Vw_Usuario, idUsuario)

        lbCargo.Text = BDSistemaEySDataSet.Vw_Usuario.First.Rol.ToString()
        lbEmp.Text = BDSistemaEySDataSet.Vw_Usuario.First.Username.ToString()

        If idEmp <> 0 Then
            Me.Vw_EmpDataTableAdapter.ObtenerEmp(Me.BDSistemaEySDataSet.Vw_EmpData, idEmp)
            lbEmp.Text += " / " + BDSistemaEySDataSet.Vw_EmpData.First.Nombre.ToString() + " " + BDSistemaEySDataSet.Vw_EmpData.First.Apellido.ToString()
            lbCargo.Text += " / " + BDSistemaEySDataSet.Vw_EmpData.First.Cargo.ToString()
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ParámetrosGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParámetrosGeneralesToolStripMenuItem.Click
        frmParametrosGen.Show()
    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        FrmAddDepartamento.Show()
    End Sub

    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click
        FrmAddCargo.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        FrmAddEmpleado.Show()
    End Sub

    Private Sub DepartamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem1.Click
        frmListarDept.Show()
    End Sub

    Private Sub CargoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem1.Click
        frmListarCargo.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        frmListarEmp.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim opcion As DialogResult = MessageBox.Show("Seguro que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelHora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click
        frmAddRol.Show()
    End Sub

    Private Sub RolToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem1.Click
        frmListarRoles.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem1.Click
        frmAdminCredenciales.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem2.Click
        frmListarCredenciales.Show()
    End Sub



    'METODOS PARA EL RELOJ
    Private Sub DibujarMarcadores()

        For i As Double = 0 To 360 Step 360 / 60


            Dim AnguloTemp As Single = i * ConvRad

            Dim TempXInicial As Single = CentroX - (Math.Cos(AnguloTemp) * 80)
            Dim TempYInicial As Single = CentroY - (Math.Sin(AnguloTemp) * 80)

            Dim TempXInicialMaior As Single = CentroX - (Math.Cos(AnguloTemp) * 75)
            Dim TempYInicialMaior As Single = CentroY - (Math.Sin(AnguloTemp) * 75)

            Dim TempXInicialMenor As Single = CentroX - (Math.Cos(AnguloTemp) * 85)
            Dim TempYInicialMenor As Single = CentroY - (Math.Sin(AnguloTemp) * 85)


            Dim TempXFinal As Single = CentroX - (Math.Cos(AnguloTemp) * 90)
            Dim TempYFinal As Single = CentroY - (Math.Sin(AnguloTemp) * 90)


            Dim M1 As New Pen(Color.Black, 2)
            Dim M2 As New Pen(Color.Black, 2)
            Dim M3 As New Pen(Color.Black, 2)


            M1.StartCap = Drawing2D.LineCap.Triangle
            M2.StartCap = Drawing2D.LineCap.DiamondAnchor
            M3.StartCap = Drawing2D.LineCap.Triangle

            'aplicamos um pouco de lógica para determinar onde desenhar qual marcador
            If i = 0 Or i = 90 Or i = 180 Or i = 270 Then
                'dibujar marcadores de cuarto de hora
                GR.DrawLine(M2, TempXInicialMaior, TempYInicialMaior, TempXFinal, TempYFinal)
            ElseIf i = 30 Or i = 60 Or i = 120 Or i = 150 Or i = 210 Or i = 240 Or i = 300 Or i = 330 Then
                'dibujar los marcadores cada cinco minutos
                GR.DrawLine(M3, TempXInicial, TempYInicial, TempXFinal, TempYFinal)
            Else
                'dibujar los marcadores comunes restantes
                GR.DrawLine(M1, TempXInicialMenor, TempYInicialMenor, TempXFinal, TempYFinal)
            End If

        Next

    End Sub 'fin del metodo

    Private Sub DibujarPuntos()
        'para dibujar las manecillas primero necesitamos saber exactamente qué hora es.
        'A partir de estos valores trabajaremos sobre los segundos para calcular las posiciones de los puntos

        'elemento por elemento, obtiene la hora actual
        Dim Hora As Integer = My.Computer.Clock.LocalTime.Hour
        Dim Minuto As Integer = My.Computer.Clock.LocalTime.Minute
        Dim Segundo As Integer = My.Computer.Clock.LocalTime.Second

        ' luego calculamos a cuántos segundos corresponde la hora actual, sumando el equivalente a segundos de todos
        'los elementos.
        Dim SegundosTotais As Long = (Hora * 3600) + (Minuto * 60) + Segundo

        'conociendo los segundos totales, usemos este valor para calcular el equivalente del ángulo en los 360 del círculo
        'del reloj.
        'A través de cálculos de relación (o reglas simples de 3), es posible determinar exactamente el ángulo
        'de los punteros
        Dim AnguloSegundo As Double = ((SegundosTotais Mod 60) * 360) / 60
        Dim AnguloMinuto As Double = ((SegundosTotais / 60 Mod 60) * 360) / 60
        Dim AnguloHora As Double = ((SegundosTotais / 3600 Mod 24) * 360 / 12)

        'además de las tres manecillas, calcularemos otra para que sirva de "cola" de la segundera.
        'Por lo tanto, es inverso al ángulo de los segundos y le sumamos al ángulo de los segundos los 90 del "offset" más 180 de la inversión
        'haciendo 270º
        Dim AnguloSegundoInverso As Double = (AnguloSegundo + 270) * ConvRad

        'aplicamos un offset de 90º a todos los ángulos de las manos para ponerlas en el lugar correcto
        ' y convertimos el ángulo
        AnguloHora = (AnguloHora + 90) * ConvRad
        AnguloMinuto = (AnguloMinuto + 89.9) * ConvRad
        AnguloSegundo = (AnguloSegundo + 90) * ConvRad

        'con el valor del ángulo correcto, es hora de calcular todos los puntos usando las proyecciones
        'al igual que los marcadores, pero esta vez solo los puntos finales porque el punto de inicio es siempre el mismo: el centro del reloj
        Dim TempHoraXFinal As Single = CentroX - Math.Cos(AnguloHora) * 40
        Dim TempHoraYFinal As Single = CentroY - Math.Sin(AnguloHora) * 40

        Dim TempMinutoXFinal As Single = CentroX - Math.Cos(AnguloMinuto) * 75
        Dim TempMinutoYFinal As Single = CentroY - Math.Sin(AnguloMinuto) * 75

        Dim TempSegundoXFinal As Single = CentroX - Math.Cos(AnguloSegundo) * 85
        Dim TempSegundoYFinal As Single = CentroY - Math.Sin(AnguloSegundo) * 85

        Dim TempSegundoInversoXFinal As Single = CentroX - Math.Cos(AnguloSegundoInverso) * 18
        Dim TempSegundoInversoYFinal As Single = CentroY - Math.Sin(AnguloSegundoInverso) * 18

        'declaramos todos los puntos para todos los punteros
        Dim PHora As New Pen(Color.FromArgb(170, 0, 0, 0), 4)
        Dim PMinuto As New Pen(Color.FromArgb(170, 0, 0, 0), 4)
        Dim PSegundo As New Pen(Color.FromArgb(200, 255, 0, 0), 0.8)
        Dim PSegundoInverso As New Pen(Color.Red, 0.8)

        ' y determinar la terminación de las líneas
        PHora.EndCap = Drawing2D.LineCap.ArrowAnchor
        PMinuto.EndCap = Drawing2D.LineCap.ArrowAnchor
        PSegundo.EndCap = Drawing2D.LineCap.ArrowAnchor
        PSegundoInverso.EndCap = Drawing2D.LineCap.Round

        'con todo calculado y listo, es hora de dibujarlos
        GR.DrawLine(PHora, CentroX, CentroY, TempHoraXFinal, TempHoraYFinal)
        GR.DrawLine(PMinuto, CentroX, CentroY, TempMinutoXFinal, TempMinutoYFinal)
        GR.DrawLine(PSegundo, CentroX, CentroY, TempSegundoXFinal, TempSegundoYFinal)
        GR.DrawLine(PSegundoInverso, CentroX, CentroY, TempSegundoInversoXFinal, TempSegundoInversoYFinal)

        'finalmente, dibujamos un pequeño círculo en el centro y encima de todos los punteros
        Dim Rect As New Rectangle(0, 0, 10, 10)
        Rect.X = ((CentroX) - Rect.Width / 2)
        Rect.Y = ((CentroY) - Rect.Height / 2)
        GR.FillEllipse(Brushes.Red, Rect)

    End Sub

    Private Sub RefrescarGraficos()
        Me.SuspendLayout()

        'primero limpiamos toda la superficie
        GR.Clear(Me.BackColor)

        'entonces los límites están trazados
        DibujarLimites()
        'despues los marcadores
        DibujarMarcadores()

        'finalmente los punteros, ya que son elementos móviles y están en la capa superior
        DibujarPuntos()

        Me.ResumeLayout()
    End Sub
    Private Sub DibujarLimites()

        'definimos el rectangulo para dibujar el circulo principal
        Dim R1 As New Rectangle(0, 0, 200, 200)

        'centramos el rectangulo con el formulario
        R1.X = ((CentroX) - R1.Width / 2)
        R1.Y = ((CentroY) - R1.Height / 2)

        'Dibujamos el círculo, rellenado
        GR.FillEllipse(Brushes.Black, R1)

        'repetimos el proceso para dibujar otro círculo más pequeño
        'diferente color para hacer el fondo del reloj
        Dim Rect As New Rectangle(0, 0, 190, 190)
        Rect.X = ((CentroX) - Rect.Width / 2)
        Rect.Y = ((CentroY) - Rect.Height / 2)
        GR.FillEllipse(Brushes.AliceBlue, Rect)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        RefrescarGraficos()
    End Sub

    Private Sub EmpleadoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem2.Click
        emp.Fill(tblEmp)
        VerReporteEmp(tblEmp, "dtEmpleado", ".\Reportes\rptEmpleado.rdlc")
    End Sub

    Private Sub DepartamentoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem2.Click
        Dept.Fill(tblDept)
        VerReporteDept(tblDept, "dsDepartamento", ".\Reportes\rptDepartamento.rdlc")
    End Sub

    Private Sub CargoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem2.Click
        Carg.Fill(tblCarg)
        VerReporteCargo(tblCarg, "dsCargo", ".\Reportes\rptCargo.rdlc")
    End Sub

    Private Sub labelHora_Click(sender As Object, e As EventArgs) Handles labelHora.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub lbEmp_Click(sender As Object, e As EventArgs) Handles lbEmp.Click

    End Sub
End Class