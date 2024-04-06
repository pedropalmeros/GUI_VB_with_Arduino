Public Class Form1
    Dim lLed13_Status As Boolean = False

    Dim StrBufferOut As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnConnect.Enabled = False
        BtnLed13.Enabled = False
        UpdateButtonImage()
    End Sub

    Private Sub BtnSearchPorts_Click(sender As Object, e As EventArgs) Handles BtnSearchPorts.Click
        CBoxPort.Items.Clear() 'Clear the ComboBox
        For Each availablePort As String In My.Computer.Ports.SerialPortNames
            CBoxPort.Items.Add(availablePort)
        Next

        If CBoxPort.Items.Count > 0 Then
            CBoxPort.Text = CBoxPort.Items(0)
            MessageBox.Show("SELECCIONA EL PUERTO DE TRABAJO")
            BtnConnect.Enabled = True
        Else
            MessageBox.Show("NO SE HA ENCONTRADO NINGÚN PUERTO")
            BtnConnect.Enabled = False
            BtnLed13.Enabled = False
        End If
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        If BtnConnect.Text = "CONECTAR" Then
            Try
                With SP_Arduino
                    .BaudRate = 9600
                    .DataBits = 8
                    .Parity = IO.Ports.Parity.None
                    .PortName = CBoxPort.Text
                End With
                SP_Arduino.Open()
                BtnConnect.Text = "DESCONECTAR"
                BtnLed13.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        ElseIf BtnConnect.Text = "DESCONECTAR" Then
            BtnConnect.Text = "CONECTAR"
            BtnLed13.Enabled = False
            SP_Arduino.Close()
        End If
    End Sub

    Private Sub BtnLed13_Click(sender As Object, e As EventArgs) Handles BtnLed13.Click
        Try
            ToogleLedStatus()

            SP_Arduino.DiscardInBuffer()
            If lLed13_Status Then
                StrBufferOut = "1"
            Else
                StrBufferOut = "0"
            End If
            SP_Arduino.Write(StrBufferOut)
            UpdateButtonImage()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToogleLedStatus()
        lLed13_Status = Not lLed13_Status
    End Sub

    Private Sub UpdateButtonImage()
        If lLed13_Status Then
            BtnLed13.BackgroundImage = My.Resources.led_on
        Else
            BtnLed13.BackgroundImage = My.Resources.led_off
        End If
    End Sub
End Class
