﻿
'Jessica McArthur
'Class example....terminals 


'Imports System.Text.RegularExpressions

Public Class Form1
    Dim portState As Boolean
    Dim receiveByte(18) As Byte        'Receive Data Bytes
    'Public dataOut As String
    Public TXdata(3) As Byte
    Dim Val, receiveCount, TransmitCount As Double
    Dim newData, readSize As Integer
    Dim dataIn1, dataIn2, dataIn3, dataIn4, dataIn5, dataIn6, dataIn7, dataIn8 As Integer


    'Closes Serial Ports when forms closes
    Private Sub Form1_UnLoad()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try
    End Sub

    'Loads serial settings when load the form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Color.FromArgb(0, 0, 0)
        'PictureBox2.BackColor = Color.FromArgb(0, 0, 0)
        'Clears old Com Ports
        portState = False                              'Disables serial port

        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity

        Timer1.Enabled = True                           'timer set to 100 ms
    End Sub

    'Finds and list all com ports present on the system
    Private Sub ComPortButton_Click(sender As Object, e As EventArgs) Handles ComPortButton.Click
        ComPortListBox.Items.Clear()                                    'Clears past com ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComPortListBox.Items.Add(sp)                                'Loads all current com ports to list box
        Next
    End Sub




    'Activates selected comport
    Private Sub PortOpenButton_Click(sender As Object, e As EventArgs) Handles PortOpenButton.Click
        If PortOpenButton.Text = "Connect" Then                     'Com port is disconnected. Press button to connect.
            Try
                SerialPort1.Open()
                PortOpenButton.Text = "Disconnect"                  'Displays that con port is connected
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                PortOpenButton.Text = "Connect"
                portState = False
            End Try
        Else                                                        'Com port is disconnected. Press button to connect.
            Try                                                     'Com port stays disconned until button is pressed
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            portState = False
            PortOpenButton.Text = "Connect"
        End If
    End Sub


    Private Sub ComPortList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortListBox.SelectedIndexChanged
        Try
            SerialPort1.Close()                             'Try to close port before change

        Catch ex As Exception

        End Try

        PortOpenButton.Text = "Connect"
        portState = False
        Try
            SerialPort1.BaudRate = ComPortListBox.SelectedItem 'See if baud rate data is in the list box
        Catch ex As Exception
            SerialPort1.PortName = ComPortListBox.SelectedItem 'Bot baud rate, save port name
        End Try
    End Sub



    'Displays serial port data in a list box
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dataIn As String
        dataIn = ""
        PortDataListBox.Items.Clear()
        PortDataListBox.Items.Add("Com port = " & SerialPort1.PortName)  'Show current baud rate
        PortDataListBox.Items.Add("Baud Rate = " & SerialPort1.BaudRate) 'Show current baud rate
        PortDataListBox.Items.Add("Data bits = " & SerialPort1.DataBits)
        PortDataListBox.Items.Add("Stop bits = " & SerialPort1.StopBits)
        PortDataListBox.Items.Add("Parity = " & SerialPort1.Parity)


        'added 10.5 
        'updates output listbox
        Dim inPut1, inPut2, inPut3, inPut4, inPut5, inPut6, inPut7, inPut8 As Integer

        If newData > 0 Then                             'Test newData if >0 there is information to display
            Select Case newData
                Case = 8
                    inPut8 = dataIn8
                    newData -= 1
            End Select
            Select Case newData
                Case = 7
                    inPut7 = dataIn7
                    newData -= 1
            End Select
            Select Case newData
                Case = 6
                    inPut6 = dataIn6
                    newData -= 1
            End Select
            Select Case newData
                Case = 5
                    inPut5 = dataIn5
                    newData -= 1
            End Select
            Select Case newData
                Case = 4
                    inPut4 = dataIn4
                    newData -= 1
            End Select
            Select Case newData
                Case = 3
                    inPut3 = dataIn3
                    newData -= 1
            End Select
            Select Case newData
                Case = 2
                    inPut2 = dataIn2
                    newData -= 1
            End Select
            Select Case newData
                Case = 1
                    inPut1 = dataIn1
                    newData -= 1
            End Select
            'Update input listboxs with new data
            RXAscListBox.Items.Add(Chr(inPut1) & Chr(inPut2) & Chr(inPut3) & Chr(inPut4) & Chr(inPut5) & Chr(inPut6) & Chr(inPut7) & Chr(inPut8))
            RXAscLabel.Text = (Chr(inPut1) & Chr(inPut2) & Chr(inPut3) & Chr(inPut4) & Chr(inPut5) & Chr(inPut6) & Chr(inPut7) & Chr(inPut8))

            RXDecListBox.Items.Add(Asc(inPut1) & Asc(inPut2) & Asc(inPut3) & Asc(inPut4) & Asc(inPut5) & Asc(inPut6) & Asc(inPut7) & Asc(inPut8))
            RXDecLabel.Text = (Asc(inPut1) & Asc(inPut2) & Asc(inPut3) & Asc(inPut4) & Asc(inPut5) & Asc(inPut6) & Asc(inPut7) & Asc(inPut8))

            RXLabel.Text = inPut1 & inPut2 & inPut2 & inPut3 & inPut4 & inPut5 & inPut6 & inPut7 & inPut8


            'Only one if else works....????????
            If inPut1 = 254 Then
                PictureBox1.BackColor = Color.FromArgb(255, 0, 255)
            Else
                PictureBox1.BackColor = Color.FromArgb(0, 0, 0)
            End If

            ' NOT WORK..... Why not?  need new variable
            'Select Case inPut1

            '    Case = 0
            '        inPut1 = 254
            '        PictureBox1.BackColor = Color.FromArgb(255, 255, 0)
            '    Case = 1
            '        inPut1 = 253
            '        PictureBox1.BackColor = Color.FromArgb(0, 255, 255)
            '    Case Else
            '        PictureBox1.BackColor = Color.FromArgb(0, 0, 0)
            'End Select

        End If




    End Sub



    Private Sub Analog1Button_Click(sender As Object, e As EventArgs) Handles Analog1Button.Click

        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = "Q"


        If portState = True Then
            If portState = True Then
                SerialPort1.Write(dataOut, 0, 1)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        End If

        'If portState = True Then
        '    If portState = True Then
        '        SerialPort1.Write(dataOut1, 0, 1)
        '        'ListBox1.Items.Add(dataOut)
        '    Else
        '        MsgBox("Please configure and open serial port to procede")

        '    End If
        'End If

        'Timer1.Enabled = False

        ''Dim dataOut1 As String
        ''Dim dataOut2 As String
        ''Dim dataOut3 As String
        ''Dim dataOut4 As String




        'If portState = True Then
        '    If dataOut IsNot "" Then
        '        SerialPort1.Write(dataOut, 0, 1)
        '        OutTermListBox.Items.Add(dataOut)

        '    Else
        '        Timer1.Enabled = True
        '        Exit Sub

        '    End If


        '    Try
        '        SerialPort1.Read(receiveByte, 0, 10)
        '        dataIn1 = receiveByte(0)
        '        dataIn2 = receiveByte(1)
        '        dataIn3 = receiveByte(2)
        '        dataIn4 = receiveByte(3)
        '        InTermListBox.Items.Add(Chr(dataIn1) & vbTab & Chr(dataIn2) & vbTab & Chr(dataIn3) & vbTab & Chr(dataIn4))
        '    Catch ex As Exception

        '    End Try

        'Else
        '    MsgBox("Please configure and open serial port to procede")
        '    TextBox1.Text = " "
        'End If
        Timer1.Enabled = True



    End Sub

    Private Sub Analog2Button_Click(sender As Object, e As EventArgs) Handles Analog2Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = "R"


        If portState = True Then
            If portState = True Then
                SerialPort1.Write(dataOut, 0, 1)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        End If

        Timer1.Enabled = True
    End Sub



    Private Sub Analog3Button_Click(sender As Object, e As EventArgs) Handles Analog3Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = "T"


        If portState = True Then
            If portState = True Then
                SerialPort1.Write(dataOut, 0, 1)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        End If

        Timer1.Enabled = True
    End Sub

    Private Sub Analog4Button_Click(sender As Object, e As EventArgs) Handles Analog4Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = "X"


        If portState = True Then
            If portState = True Then
                SerialPort1.Write(dataOut, 0, 1)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        End If

        Timer1.Enabled = True
    End Sub
    'Works
    Private Sub AnOut1Button_Click(sender As Object, e As EventArgs) Handles AnOut1Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = "A"


        If portState = True Then
            If portState = True Then
                SerialPort1.Write(dataOut, 0, 1)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        End If

        Timer1.Enabled = True
    End Sub
    Private Sub AnOut2Button_Click(sender As Object, e As EventArgs) Handles AnOut2Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = "B"


        If portState = True Then
            If portState = True Then
                SerialPort1.Write(dataOut, 0, 1)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        End If

        Timer1.Enabled = True
    End Sub

    ''Not control anything
    'Private Sub AnOut3Button_Click(sender As Object, e As EventArgs)
    '    Timer1.Enabled = False                                  'Stop Timer


    '    ' Dim dataOut1 As String
    '    Dim dataOut As String

    '    dataOut = "D"


    '    If portState = True Then
    '        If portState = True Then
    '            SerialPort1.Write(dataOut, 0, 1)
    '            TXDataListBox.Items.Add(dataOut)
    '            TXLabel.Text = dataOut
    '        Else
    '            MsgBox("Please configure and open serial port to procede")

    '        End If
    '    End If

    '    Timer1.Enabled = True
    'End Sub


    ''not control anything
    'Private Sub AnOut4Button_Click(sender As Object, e As EventArgs)
    '    Timer1.Enabled = False                                  'Stop Timer


    '    ' Dim dataOut1 As String
    '    Dim dataOut As String

    '    dataOut = "H"


    '    If portState = True Then
    '        If portState = True Then
    '            SerialPort1.Write(dataOut, 0, 1)
    '            TXDataListBox.Items.Add(dataOut)
    '            TXLabel.Text = dataOut
    '        Else
    '            MsgBox("Please configure and open serial port to procede")

    '        End If
    '    End If

    '    Timer1.Enabled = True
    'End Sub


    'Works
    Private Sub DIn1Button_Click(sender As Object, e As EventArgs) Handles DIn1Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = "0"


        ' If portState = True Then
        If portState = True Then
                SerialPort1.Write(dataOut, 0, 1)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        ' End If

        Timer1.Enabled = True
    End Sub

    Private Sub DOut1Button_Click(sender As Object, e As EventArgs) Handles DOut1Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = Chr(32) & Chr(1)


        ' If portState = True Then
        If portState = True Then
                SerialPort1.Write(dataOut, 0, 2)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        ' End If

        Timer1.Enabled = True
    End Sub

    Private Sub DOut2Button_Click(sender As Object, e As EventArgs) Handles DOut2Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = Chr(32) & Chr(2)


        'If portState = True Then
        If portState = True Then
                SerialPort1.Write(dataOut, 0, 2)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        'End If

        Timer1.Enabled = True
    End Sub

    Private Sub DOut3Button_Click(sender As Object, e As EventArgs) Handles DOut3Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = Chr(32) & Chr(4)


        ' If portState = True Then
        If portState = True Then
                SerialPort1.Write(dataOut, 0, 2)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        ' End If

        Timer1.Enabled = True
    End Sub

    Private Sub DOut4Button_Click(sender As Object, e As EventArgs) Handles DOut4Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = Chr(32) & Chr(8)


        'If portState = True Then
        If portState = True Then
            SerialPort1.Write(dataOut, 0, 2)
            TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        'End If

        Timer1.Enabled = True
    End Sub

    Private Sub DOut5Button_Click(sender As Object, e As EventArgs) Handles DOut5Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        Dim dataOut As String

        dataOut = Chr(32) & Chr(16)

        'If portState = True Then
        If portState = True Then
                SerialPort1.Write(dataOut, 0, 2)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        'End If

        Timer1.Enabled = True
    End Sub

    Private Sub DOut6Button_Click(sender As Object, e As EventArgs) Handles DOut6Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = Chr(32) & Chr(32)


        ' If portState = True Then
        If portState = True Then
                SerialPort1.Write(dataOut, 0, 2)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        ' End If

        Timer1.Enabled = True
    End Sub



    Private Sub DOut7Button_Click(sender As Object, e As EventArgs) Handles DOut7Button.Click
        Timer1.Enabled = False                                  'Stop Timer


        ' Dim dataOut1 As String
        Dim dataOut As String

        dataOut = Chr(32) & Chr(64)


        ' If portState = True Then
        If portState = True Then
                SerialPort1.Write(dataOut, 0, 2)
                TXDataListBox.Items.Add(dataOut)
                TXLabel.Text = dataOut
            Else
                MsgBox("Please configure and open serial port to procede")

            End If
        'End If

        Timer1.Enabled = True
    End Sub


    '?????? How send as byte????
    Private Sub DOut8Button_Click(sender As Object, e As EventArgs) Handles DOut8Button.Click
        ' Timer1.Enabled = False                                  'Stop Timer



        TXdata(0) = 32
        TXdata(1) = 128
        TXdata(2) = 0
        SendData()
        ''If portState = True Then
        'If portState = True Then
        '    'message = Int(dataOut)
        '    SerialPort1.Write(TXdata, 0, 3)
        '    'SerialPort1.Write(message, 0, message.Length)
        '    'TXDataListBox.Items.Add(message)
        '    TXDataListBox.Items.Add(TXdata)
        '    TXLabel.Text = TXdata(0) & TXdata(1) & TXdata(2)
        'Else
        '    MsgBox("Please configure and open serial port to procede")

        '    End If
        ''End If

        'Timer1.Enabled = True
    End Sub


    Function SendData() As Byte
        Timer1.Enabled = False
        If portState = True Then
            SerialPort1.Write(TXdata, 0, 3)
            TXDataListBox.Items.Add(TXdata)
            TXLabel.Text = TXdata(0) & TXdata(1) & TXdata(2)
        Else
            MsgBox("Please configure and open serial port to procede")
        End If
        Timer1.Enabled = True
        ' Return _Something?
    End Function

    Function AnVoltage() As Integer
        Dim vPort As Integer
        Dim n1 As Integer
        Dim n2 As Integer

        n1 = dataIn1 * 4
        n2 = dataIn2 / 64



    End Function

    Private Sub Clear1Button_Click(sender As Object, e As EventArgs) Handles Clear1Button.Click
        TXDataListBox.Items.Clear()
        TXLabel.Text = " "
    End Sub

    Private Sub Clear2Button_Click(sender As Object, e As EventArgs) Handles Clear2Button.Click
        RXAscListBox.Items.Clear()
        RXAscLabel.Text = " "
    End Sub

    Private Sub Clear3Button_Click(sender As Object, e As EventArgs) Handles Clear3Button.Click
        RXDecListBox.Items.Clear()
        RXDecLabel.Text = " "
    End Sub

    Private Sub Clear4Button_Click(sender As Object, e As EventArgs) Handles Clear4Button.Click
        RXLabel.Text = " "
    End Sub

    Private Sub Clear5Button_Click(sender As Object, e As EventArgs) Handles Clear5Button.Click
        TXDataListBox.Items.Clear()
        TXLabel.Text = " "
        RXAscListBox.Items.Clear()
        RXAscLabel.Text = " "
        RXDecListBox.Items.Clear()
        RXDecLabel.Text = " "
        RXLabel.Text = " "
    End Sub


    'Exits Program when button is pressed 
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub


    'Loads baud rate values into list box
    Private Sub BaudRateButton_Click(sender As Object, e As EventArgs) Handles BaudRateButton.Click
        BaudRateListBox.Items.Clear()                          'Clear list box and load baud rate values
        BaudRateListBox.Items.Add(1200)
        BaudRateListBox.Items.Add(2400)
        BaudRateListBox.Items.Add(4800)
        BaudRateListBox.Items.Add(9600)
        BaudRateListBox.Items.Add(19200)
        BaudRateListBox.Items.Add(38400)
        BaudRateListBox.Items.Add(57600)
        BaudRateListBox.Items.Add(115200)
        BaudRateListBox.Items.Add(230400)
        BaudRateListBox.Items.Add(230400)
        BaudRateListBox.Items.Add(460800)
        BaudRateListBox.Items.Add(921600)
    End Sub




    'Added 10.5 

    'Asynchronous Serial receive subroutine triggered by serial receive event
    Private Sub DataReceived(sender As Object, e As EventArgs) Handles SerialPort1.DataReceived
        'readSize = SerialPort1.BytesToRead
        'Throw New NotImplementedException


        receiveCount += 1                                           'increment recieve byte counter
        SerialPort1.Read(receiveByte, 0, 4)                         'read serial buffer value

        Select Case newData                                         'test case to determine where to place info
            Case = 0
                dataIn1 = receiveByte(0)
            Case = 1
                dataIn2 = receiveByte(0)
            Case = 2
                dataIn3 = receiveByte(0)
            Case = 3
                dataIn4 = receiveByte(0)
            Case = 4
                dataIn5 = receiveByte(0)
            Case = 5
                dataIn6 = receiveByte(0)
            Case = 6
                dataIn7 = receiveByte(0)
            Case = 7
                dataIn8 = receiveByte(0)

            Case Else
                newData = 0                                             'possible over flow, reset newData
                Exit Sub

        End Select
        newData += 1                                                    'Increment newData once loop is complete



    End Sub







End Class




