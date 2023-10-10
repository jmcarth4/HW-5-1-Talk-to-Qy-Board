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
        Me.Clear3Button = New System.Windows.Forms.Button()
        Me.Clear1Button = New System.Windows.Forms.Button()
        Me.RXDecListBox = New System.Windows.Forms.ListBox()
        Me.TXDataListBox = New System.Windows.Forms.ListBox()
        Me.RXAscListBox = New System.Windows.Forms.ListBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Clear2Button = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.RXLabel = New System.Windows.Forms.Label()
        Me.RXAscLabel = New System.Windows.Forms.Label()
        Me.RXDecLabel = New System.Windows.Forms.Label()
        Me.Analog2Button = New System.Windows.Forms.Button()
        Me.Analog1Button = New System.Windows.Forms.Button()
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.BaudRateListBox = New System.Windows.Forms.ListBox()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.BaudRateButton = New System.Windows.Forms.Button()
        Me.TXLabel = New System.Windows.Forms.Label()
        Me.Clear4Button = New System.Windows.Forms.Button()
        Me.Clear5Button = New System.Windows.Forms.Button()
        Me.Analog4Button = New System.Windows.Forms.Button()
        Me.Analog3Button = New System.Windows.Forms.Button()
        Me.AnOut1Button = New System.Windows.Forms.Button()
        Me.DIn1Button = New System.Windows.Forms.Button()
        Me.DOut1Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Clear3Button
        '
        Me.Clear3Button.Location = New System.Drawing.Point(933, 349)
        Me.Clear3Button.Name = "Clear3Button"
        Me.Clear3Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear3Button.TabIndex = 114
        Me.Clear3Button.Text = "Clear RX Decimal"
        Me.Clear3Button.UseVisualStyleBackColor = True
        '
        'Clear1Button
        '
        Me.Clear1Button.Location = New System.Drawing.Point(644, 343)
        Me.Clear1Button.Name = "Clear1Button"
        Me.Clear1Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear1Button.TabIndex = 112
        Me.Clear1Button.Text = "Clear TX"
        Me.Clear1Button.UseVisualStyleBackColor = True
        '
        'RXDecListBox
        '
        Me.RXDecListBox.FormattingEnabled = True
        Me.RXDecListBox.ItemHeight = 20
        Me.RXDecListBox.Location = New System.Drawing.Point(899, 7)
        Me.RXDecListBox.Name = "RXDecListBox"
        Me.RXDecListBox.Size = New System.Drawing.Size(179, 284)
        Me.RXDecListBox.TabIndex = 111
        '
        'TXDataListBox
        '
        Me.TXDataListBox.FormattingEnabled = True
        Me.TXDataListBox.ItemHeight = 20
        Me.TXDataListBox.Location = New System.Drawing.Point(617, 7)
        Me.TXDataListBox.Name = "TXDataListBox"
        Me.TXDataListBox.Size = New System.Drawing.Size(154, 284)
        Me.TXDataListBox.TabIndex = 110
        '
        'RXAscListBox
        '
        Me.RXAscListBox.FormattingEnabled = True
        Me.RXAscListBox.ItemHeight = 20
        Me.RXAscListBox.Location = New System.Drawing.Point(777, 7)
        Me.RXAscListBox.Name = "RXAscListBox"
        Me.RXAscListBox.Size = New System.Drawing.Size(116, 284)
        Me.RXAscListBox.TabIndex = 109
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Clear2Button
        '
        Me.Clear2Button.Location = New System.Drawing.Point(777, 343)
        Me.Clear2Button.Name = "Clear2Button"
        Me.Clear2Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear2Button.TabIndex = 113
        Me.Clear2Button.Text = "Clear RX Character"
        Me.Clear2Button.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(996, 544)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(82, 76)
        Me.QuitButton.TabIndex = 108
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'RXLabel
        '
        Me.RXLabel.AutoSize = True
        Me.RXLabel.Location = New System.Drawing.Point(817, 446)
        Me.RXLabel.Name = "RXLabel"
        Me.RXLabel.Size = New System.Drawing.Size(18, 20)
        Me.RXLabel.TabIndex = 105
        Me.RXLabel.Text = "0"
        '
        'RXAscLabel
        '
        Me.RXAscLabel.AutoSize = True
        Me.RXAscLabel.Location = New System.Drawing.Point(792, 309)
        Me.RXAscLabel.Name = "RXAscLabel"
        Me.RXAscLabel.Size = New System.Drawing.Size(18, 20)
        Me.RXAscLabel.TabIndex = 104
        Me.RXAscLabel.Text = "0"
        '
        'RXDecLabel
        '
        Me.RXDecLabel.AutoSize = True
        Me.RXDecLabel.Location = New System.Drawing.Point(914, 309)
        Me.RXDecLabel.Name = "RXDecLabel"
        Me.RXDecLabel.Size = New System.Drawing.Size(18, 20)
        Me.RXDecLabel.TabIndex = 102
        Me.RXDecLabel.Text = "0"
        '
        'Analog2Button
        '
        Me.Analog2Button.Location = New System.Drawing.Point(12, 419)
        Me.Analog2Button.Name = "Analog2Button"
        Me.Analog2Button.Size = New System.Drawing.Size(139, 47)
        Me.Analog2Button.TabIndex = 101
        Me.Analog2Button.Text = "Analog Input 2"
        Me.Analog2Button.UseVisualStyleBackColor = True
        '
        'Analog1Button
        '
        Me.Analog1Button.Location = New System.Drawing.Point(12, 356)
        Me.Analog1Button.Name = "Analog1Button"
        Me.Analog1Button.Size = New System.Drawing.Size(139, 49)
        Me.Analog1Button.TabIndex = 100
        Me.Analog1Button.Text = "Analog Input 1"
        Me.Analog1Button.UseVisualStyleBackColor = True
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(352, 2)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 204)
        Me.PortDataListBox.TabIndex = 99
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(371, 217)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(154, 104)
        Me.PortOpenButton.TabIndex = 98
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'ComPortListBox
        '
        Me.ComPortListBox.FormattingEnabled = True
        Me.ComPortListBox.ItemHeight = 20
        Me.ComPortListBox.Location = New System.Drawing.Point(215, 7)
        Me.ComPortListBox.Name = "ComPortListBox"
        Me.ComPortListBox.Size = New System.Drawing.Size(110, 184)
        Me.ComPortListBox.TabIndex = 97
        '
        'BaudRateListBox
        '
        Me.BaudRateListBox.FormattingEnabled = True
        Me.BaudRateListBox.ItemHeight = 20
        Me.BaudRateListBox.Location = New System.Drawing.Point(30, 7)
        Me.BaudRateListBox.Name = "BaudRateListBox"
        Me.BaudRateListBox.Size = New System.Drawing.Size(165, 204)
        Me.BaudRateListBox.TabIndex = 96
        '
        'ComPortButton
        '
        Me.ComPortButton.Location = New System.Drawing.Point(192, 212)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(154, 104)
        Me.ComPortButton.TabIndex = 95
        Me.ComPortButton.Text = "Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'BaudRateButton
        '
        Me.BaudRateButton.Location = New System.Drawing.Point(30, 217)
        Me.BaudRateButton.Name = "BaudRateButton"
        Me.BaudRateButton.Size = New System.Drawing.Size(127, 95)
        Me.BaudRateButton.TabIndex = 94
        Me.BaudRateButton.Text = "Baud Rate"
        Me.BaudRateButton.UseVisualStyleBackColor = True
        '
        'TXLabel
        '
        Me.TXLabel.AutoSize = True
        Me.TXLabel.Location = New System.Drawing.Point(657, 309)
        Me.TXLabel.Name = "TXLabel"
        Me.TXLabel.Size = New System.Drawing.Size(18, 20)
        Me.TXLabel.TabIndex = 115
        Me.TXLabel.Text = "0"
        '
        'Clear4Button
        '
        Me.Clear4Button.Location = New System.Drawing.Point(767, 481)
        Me.Clear4Button.Name = "Clear4Button"
        Me.Clear4Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear4Button.TabIndex = 116
        Me.Clear4Button.Text = "Clear RX "
        Me.Clear4Button.UseVisualStyleBackColor = True
        '
        'Clear5Button
        '
        Me.Clear5Button.Location = New System.Drawing.Point(767, 558)
        Me.Clear5Button.Name = "Clear5Button"
        Me.Clear5Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear5Button.TabIndex = 117
        Me.Clear5Button.Text = "Clear All "
        Me.Clear5Button.UseVisualStyleBackColor = True
        '
        'Analog4Button
        '
        Me.Analog4Button.Location = New System.Drawing.Point(12, 535)
        Me.Analog4Button.Name = "Analog4Button"
        Me.Analog4Button.Size = New System.Drawing.Size(139, 47)
        Me.Analog4Button.TabIndex = 119
        Me.Analog4Button.Text = "Analog Input 4"
        Me.Analog4Button.UseVisualStyleBackColor = True
        '
        'Analog3Button
        '
        Me.Analog3Button.Location = New System.Drawing.Point(12, 472)
        Me.Analog3Button.Name = "Analog3Button"
        Me.Analog3Button.Size = New System.Drawing.Size(139, 49)
        Me.Analog3Button.TabIndex = 118
        Me.Analog3Button.Text = "Analog Input 3"
        Me.Analog3Button.UseVisualStyleBackColor = True
        '
        'AnOut1Button
        '
        Me.AnOut1Button.Location = New System.Drawing.Point(171, 356)
        Me.AnOut1Button.Name = "AnOut1Button"
        Me.AnOut1Button.Size = New System.Drawing.Size(139, 49)
        Me.AnOut1Button.TabIndex = 120
        Me.AnOut1Button.Text = "Analog Output 1"
        Me.AnOut1Button.UseVisualStyleBackColor = True
        '
        'DIn1Button
        '
        Me.DIn1Button.Location = New System.Drawing.Point(327, 356)
        Me.DIn1Button.Name = "DIn1Button"
        Me.DIn1Button.Size = New System.Drawing.Size(139, 49)
        Me.DIn1Button.TabIndex = 121
        Me.DIn1Button.Text = "Digital Input 1"
        Me.DIn1Button.UseVisualStyleBackColor = True
        '
        'DOut1Button
        '
        Me.DOut1Button.Location = New System.Drawing.Point(483, 356)
        Me.DOut1Button.Name = "DOut1Button"
        Me.DOut1Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut1Button.TabIndex = 122
        Me.DOut1Button.Text = "Digital Output 1"
        Me.DOut1Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 666)
        Me.Controls.Add(Me.DOut1Button)
        Me.Controls.Add(Me.DIn1Button)
        Me.Controls.Add(Me.AnOut1Button)
        Me.Controls.Add(Me.Analog4Button)
        Me.Controls.Add(Me.Analog3Button)
        Me.Controls.Add(Me.Clear5Button)
        Me.Controls.Add(Me.Clear4Button)
        Me.Controls.Add(Me.TXLabel)
        Me.Controls.Add(Me.Clear3Button)
        Me.Controls.Add(Me.Clear1Button)
        Me.Controls.Add(Me.RXDecListBox)
        Me.Controls.Add(Me.TXDataListBox)
        Me.Controls.Add(Me.RXAscListBox)
        Me.Controls.Add(Me.Clear2Button)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.RXLabel)
        Me.Controls.Add(Me.RXAscLabel)
        Me.Controls.Add(Me.RXDecLabel)
        Me.Controls.Add(Me.Analog2Button)
        Me.Controls.Add(Me.Analog1Button)
        Me.Controls.Add(Me.PortDataListBox)
        Me.Controls.Add(Me.PortOpenButton)
        Me.Controls.Add(Me.ComPortListBox)
        Me.Controls.Add(Me.BaudRateListBox)
        Me.Controls.Add(Me.ComPortButton)
        Me.Controls.Add(Me.BaudRateButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clear3Button As Button
    Friend WithEvents Clear1Button As Button
    Friend WithEvents RXDecListBox As ListBox
    Friend WithEvents TXDataListBox As ListBox
    Friend WithEvents RXAscListBox As ListBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Clear2Button As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents RXLabel As Label
    Friend WithEvents RXAscLabel As Label
    Friend WithEvents RXDecLabel As Label
    Friend WithEvents Analog2Button As Button
    Friend WithEvents Analog1Button As Button
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents BaudRateListBox As ListBox
    Friend WithEvents ComPortButton As Button
    Friend WithEvents BaudRateButton As Button
    Friend WithEvents TXLabel As Label
    Friend WithEvents Clear4Button As Button
    Friend WithEvents Clear5Button As Button
    Friend WithEvents Analog4Button As Button
    Friend WithEvents Analog3Button As Button
    Friend WithEvents AnOut1Button As Button
    Friend WithEvents DIn1Button As Button
    Friend WithEvents DOut1Button As Button
End Class
