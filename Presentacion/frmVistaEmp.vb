Public Class frmVistaEmp



    Private GR As Graphics = Me.CreateGraphics

    'declaramos la constante de PI
    Const PI As Double = 3.14159265

    'declaramos la constante de conversion de radianes
    Const ConvRad As Double = PI / 180

    'declaramos un temporizador que actualiza la informacion de las horas
    Private WithEvents Temporizador As New Timer

    Private CentroX As Single
    Private CentroY As Single

    Dim flagTiempo As Boolean = False
    Dim flag As Boolean = False
    Dim flagAlm As Boolean = False

    Dim idEmp As Integer
    Dim idReg As Integer

    Private Sub frmVistaEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CentroX = 230 / 2
        CentroY = 220 / 2

        Temporizador.Interval = 1000
        Temporizador.Enabled = True
        BDSistemaEySDataSet.EnforceConstraints = False

        RefrescarGraficos()

    End Sub

    Public Sub CargarDatos(idEmp As Integer)
        Me.idEmp = idEmp
        Me.Vw_EmpDataTableAdapter.ObtenerEmp(Me.BDSistemaEySDataSet.Vw_EmpData, idEmp)
        lbBienvenida.Text = "Bienvenido, " + BDSistemaEySDataSet.Vw_EmpData.First.Nombre.ToString() + " " + BDSistemaEySDataSet.Vw_EmpData.First.Apellido.ToString()
        Dim fechaAct As String = DateTime.Today.Date + " 00:00:00.000"

        If Me.Tbl_RegistroTableAdapter1.RegistroDiaAct(Me.BDSistemaEySDataSet.tbl_Registro, fechaAct, idEmp) <> 0 Then
            flag = True
            idReg = BDSistemaEySDataSet.tbl_Registro.First.idRegstro
            buttonEntrada.Enabled = False
        End If

        Try
            If Not IsNothing(BDSistemaEySDataSet.tbl_Registro.First.horaSalida) Then
                lbHoraEntrada.Text = "Jornada laboral terminada"
                lbTiempoTrab.Text = "Tiempo trabajado: " + BDSistemaEySDataSet.tbl_Registro.First.horaSalida.Subtract(BDSistemaEySDataSet.tbl_Registro.First.horaEntrada).ToString.Substring(0, 8)
                buttonSalida.Enabled = False
                buttonEntrada.Enabled = False
                buttonAlmuerzo.Enabled = False
                Return
            End If
        Catch ex As Exception
        End Try

        Try
            If Not IsNothing(BDSistemaEySDataSet.tbl_Registro.First.horaAlmuerzoIn) Then
                flagAlm = True
                buttonSalida.Enabled = False
            End If
        Catch ex As Exception
        End Try

        Try
            If Not IsNothing(BDSistemaEySDataSet.tbl_Registro.First.horaAlmuerzoOut) Then
                buttonAlmuerzo.Enabled = False
                buttonSalida.Enabled = True
            End If
        Catch ex As Exception
        End Try


        If flag = False Then
            lbHoraEntrada.Text = "No se ha iniciado la jornada laboral"
            lbTiempoTrab.Text = ""
            buttonSalida.Enabled = False
            buttonAlmuerzo.Enabled = False
        Else
            lbHoraEntrada.Text = "Hora de entrada: " + BDSistemaEySDataSet.tbl_Registro.First.horaEntrada.ToString("hh:mm:ss")
            flagTiempo = True
        End If

    End Sub

    Private Sub confirmarAlmuerzo()

        If EsHoraAlmuerzo() = False Then
            Return
        End If

        If flagAlm = False Then
            Dim result As DialogResult = MessageBox.Show("¿Deseas comenzar tu almuerzo?", "Almuerzo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Me.Tbl_RegistroTableAdapter1.InsertarAlmIn(DateTime.Now, idReg, idReg)
                MessageBox.Show("Has marcado tu salida al almuerzo", "Almuerzo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

        Else
            Dim result As DialogResult = MessageBox.Show("¿Deseas regresar de tu almuerzo?", "Almuerzo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Me.Tbl_RegistroTableAdapter1.InsertarAlmOut(DateTime.Now, idReg, idReg)
                MessageBox.Show("Has regresado a tu labor", "Almuerzo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

        End If
        Me.CargarDatos(idEmp)
    End Sub

    Private Sub MarcarEntrada()
        Dim result As DialogResult = MessageBox.Show("¿Deseas Marcar tu entrada?", "Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Tbl_RegistroTableAdapter1.InsertarEntrada(DateTime.Now, idEmp)
            MessageBox.Show("Se ha marcado la entrada", "Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
        Me.CargarDatos(idEmp)
    End Sub

    Private Sub MarcarSalida()
        Dim result As DialogResult = MessageBox.Show("¿Deseas Marcar tu salida?", "Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Tbl_RegistroTableAdapter1.InsertarSalida(DateTime.Now, idReg, idReg)
            MessageBox.Show("Se ha marcado la Salida", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            flagTiempo = False
        End If
        Me.CargarDatos(idEmp)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelHora.Text = DateTime.Now.ToLongTimeString

        If flagTiempo = True Then
            lbTiempoTrab.Text = "Tiempo trabajado: " + DateTime.Now.Subtract(BDSistemaEySDataSet.tbl_Registro.First.horaEntrada).ToString().Substring(0, 8)
        End If

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

    Private Sub btnIng_Click(sender As Object, e As EventArgs) Handles btnIng.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub buttonEntrada_MouseEnter(sender As Object, e As EventArgs) Handles buttonEntrada.MouseEnter
        buttonEntrada.BackColor = Color.SteelBlue
        buttonEntrada.ForeColor = Color.White
    End Sub

    Private Sub buttonEntrada_MouseLeave(sender As Object, e As EventArgs) Handles buttonEntrada.MouseLeave
        buttonEntrada.BackColor = Color.LightGray
        buttonEntrada.ForeColor = Color.DimGray
    End Sub

    Private Sub buttonSalida_MouseEnter(sender As Object, e As EventArgs) Handles buttonSalida.MouseEnter
        buttonSalida.BackColor = Color.SteelBlue
        buttonSalida.ForeColor = Color.White
    End Sub

    Private Sub buttonSalida_MouseLeave(sender As Object, e As EventArgs) Handles buttonSalida.MouseLeave
        buttonSalida.BackColor = Color.LightGray
        buttonSalida.ForeColor = Color.DimGray
    End Sub

    Private Sub buttonAlmuerzo_MouseEnter(sender As Object, e As EventArgs) Handles buttonAlmuerzo.MouseEnter
        buttonAlmuerzo.BackColor = Color.SteelBlue
        buttonAlmuerzo.ForeColor = Color.White
    End Sub

    Private Sub buttonAlmuerzo_MouseLeave(sender As Object, e As EventArgs) Handles buttonAlmuerzo.MouseLeave
        buttonAlmuerzo.BackColor = Color.LightGray
        buttonAlmuerzo.ForeColor = Color.DimGray
    End Sub

    Private Sub buttonEntrada_Click(sender As Object, e As EventArgs) Handles buttonEntrada.Click
        MarcarEntrada()
    End Sub

    Private Sub buttonSalida_Click(sender As Object, e As EventArgs) Handles buttonSalida.Click
        MarcarSalida()
    End Sub

    Private Sub buttonAlmuerzo_Click(sender As Object, e As EventArgs) Handles buttonAlmuerzo.Click
        confirmarAlmuerzo()
    End Sub
    Private Function EsHoraAlmuerzo() As Boolean
        Me.Tbl_ConfigTableAdapter1.ObtenerAlmuerzo(BDSistemaEySDataSet.tbl_Config)

        If (BDSistemaEySDataSet.tbl_Config.First.horarioAlmuerzoIn.Hour < DateTime.Now.Hour) Then
            Return True
        Else
            MessageBox.Show($"Aún no es hora de almuerzo, comienza a las {BDSistemaEySDataSet.tbl_Config.First.horarioAlmuerzoIn.Hour}hrs", "Almuerzo", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return False
        End If

    End Function

End Class