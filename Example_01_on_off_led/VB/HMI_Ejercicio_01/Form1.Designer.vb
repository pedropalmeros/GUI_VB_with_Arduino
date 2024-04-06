<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnSearchPorts = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CBoxPort = New System.Windows.Forms.ComboBox()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.SP_Arduino = New System.IO.Ports.SerialPort(Me.components)
        Me.BtnLed13 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSearchPorts
        '
        Me.BtnSearchPorts.Location = New System.Drawing.Point(34, 33)
        Me.BtnSearchPorts.Name = "BtnSearchPorts"
        Me.BtnSearchPorts.Size = New System.Drawing.Size(151, 64)
        Me.BtnSearchPorts.TabIndex = 0
        Me.BtnSearchPorts.Text = "BUSCAR PUERTOS"
        Me.BtnSearchPorts.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(479, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 8)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CBoxPort
        '
        Me.CBoxPort.FormattingEnabled = True
        Me.CBoxPort.Location = New System.Drawing.Point(216, 54)
        Me.CBoxPort.Name = "CBoxPort"
        Me.CBoxPort.Size = New System.Drawing.Size(350, 24)
        Me.CBoxPort.TabIndex = 2
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(618, 33)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(151, 64)
        Me.BtnConnect.TabIndex = 3
        Me.BtnConnect.Text = "CONECTAR"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'BtnLed13
        '
        Me.BtnLed13.BackgroundImage = Global.HMI_Ejercicio_01.My.Resources.Resources.led_on
        Me.BtnLed13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLed13.Location = New System.Drawing.Point(388, 192)
        Me.BtnLed13.Name = "BtnLed13"
        Me.BtnLed13.Size = New System.Drawing.Size(125, 125)
        Me.BtnLed13.TabIndex = 4
        Me.BtnLed13.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 448)
        Me.Controls.Add(Me.BtnLed13)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.CBoxPort)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSearchPorts)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSearchPorts As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CBoxPort As ComboBox
    Friend WithEvents BtnConnect As Button
    Friend WithEvents SP_Arduino As IO.Ports.SerialPort
    Friend WithEvents BtnLed13 As Button
End Class
