Public Class SzEdit
    Dim SpecialPlace As String
    Dim SZNameE, SZNameZ, SZRegion As String
    Dim SZWaitingTime, SzQSd, SzQSdRt, SzQVn, SzQVnRt As Double
    Dim SzBkSd, SzBkSdRt, SzBkVn, SzBkVnRt As Double
    Dim SzMSd, SzMSdRt, SzMVn, SzMVnRt As Double
    Dim SzSiSd, SzSiSdRt, SzSiVn, SzSiVnRt As Double
    Dim SzBxSd, SzBxSdRt, SzBxVn, SzBxVnRt As Double
    Private Sub ReturnToMain_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("退出本界面?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If MainForm.Visible = False Then
                MainForm.Show()
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AddSZone.Show()
        Me.Visible = False
    End Sub

    Private Sub SzEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim specialzone As IO.StreamReader
        specialzone = IO.File.OpenText("specialZone.txt")
        Do Until specialzone.EndOfStream
            Dim str() As String = Split(specialzone.ReadLine, ",")
            SZNameE = str(0)
            SZNameZ = str(1)
            SZRegion = str(2)
            SZWaitingTime = str(3)
            SzQSd = str(4)
            SzQSdRt = str(5)
            SzQVn = str(6)
            SzQVnRt = str(7)
            SzBkSd = str(8)
            SzBkSdRt = str(9)
            SzBkVn = str(10)
            SzBkVnRt = str(11)
            SzMSd = str(12)
            SzMSdRt = str(13)
            SzMVn = str(14)
            SzMVnRt = str(15)
            SzBxSd = str(16)
            SzBxSdRt = str(17)
            SzBxVn = str(18)
            SzBxVnRt = str(19)
            SzSiSd = str(20)
            SzSiSdRt = str(21)
            SzSiVn = str(22)
            SzSiVnRt = str(23)
            ComboBox1.Items.Add(SZNameE & " (" & SZNameZ & ")")
            ComboBox1.AutoCompleteCustomSource.Add(SZNameE & " (" & SZNameZ & ")")

        Loop
        specialzone.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SpecialPlace As String
        If ComboBox1.Text <> "" Then
            Regions.Enabled = True
            WTInput.Enabled = True
            sNameE.Enabled = True
            sNameZ.Enabled = True
            Label1.Enabled = True
            Label2.Enabled = True
            Label3.Enabled = True
            Label4.Enabled = True
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            GroupBox5.Enabled = True
            Button1.Enabled = True
            Button3.Enabled = True
            Label23.Enabled = True
            Label24.Enabled = True
            Label25.Enabled = True
            Label5.Enabled = True
            Label6.Enabled = True
            Label7.Enabled = True
            Label10.Enabled = True
            Label11.Enabled = True
            Label12.Enabled = True
            Label13.Enabled = True
            Label8.Enabled = True
            Label9.Enabled = True
            Label14.Enabled = True
            Label15.Enabled = True
            Label16.Enabled = True
            Label17.Enabled = True
            Label18.Enabled = True
            Label19.Enabled = True
            Label20.Enabled = True
            Label21.Enabled = True
            Label22.Enabled = True

        End If
        If ComboBox1.Text <> "" Then
            SpecialPlace = ComboBox1.SelectedItem()
            Dim specialzfile As IO.StreamReader = IO.File.OpenText("specialZone.txt")
            Do Until specialzfile.EndOfStream
                Dim str() As String = Split(specialzfile.ReadLine, ",")
                SZNameE = str(0)
                SZNameZ = str(1)
                SZRegion = str(2)
                SZWaitingTime = str(3)
                SzQSd = str(4)
                SzQSdRt = str(5)
                SzQVn = str(6)
                SzQVnRt = str(7)
                SzBkSd = str(8)
                SzBkSdRt = str(9)
                SzBkVn = str(10)
                SzBkVnRt = str(11)
                SzMSd = str(12)
                SzMSdRt = str(13)
                SzMVn = str(14)
                SzMVnRt = str(15)
                SzBxSd = str(16)
                SzBxSdRt = str(17)
                SzBxVn = str(18)
                SzBxVnRt = str(19)
                SzSiSd = str(20)
                SzSiSdRt = str(21)
                SzSiVn = str(22)
                SzSiVnRt = str(23)
                If SpecialPlace = SZNameE & " (" & SZNameZ & ")" Then
                    sNameE.Text = SZNameE
                    sNameZ.Text = SZNameZ
                    Regions.Text = SZRegion
                    WTInput.Text = SZWaitingTime
                    TextBox1.Text = SzQSd
                    TextBox2.Text = SzQSdRt
                    TextBox3.Text = SzQVn
                    TextBox4.Text = SzQVnRt
                    TextBox10.Text = SzBkSd
                    TextBox9.Text = SzBkSdRt
                    TextBox8.Text = SzBkVn
                    TextBox7.Text = SzBkVnRt
                    TextBox14.Text = SzMSd
                    TextBox13.Text = SzMSdRt
                    TextBox12.Text = SzMVn
                    TextBox11.Text = SzMVnRt
                    TextBox18.Text = SzBxSd
                    TextBox17.Text = SzBxSdRt
                    TextBox16.Text = SzBxVn
                    TextBox15.Text = SzBxVnRt
                    TextBox22.Text = SzSiSd
                    TextBox21.Text = SzSiSdRt
                    TextBox20.Text = SzSiVn
                    TextBox19.Text = SzSiVnRt
                End If
            Loop
            specialzfile.Close()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox1.Text = ""
        Regions.Enabled = False
        WTInput.Enabled = False
        sNameE.Enabled = False
        sNameZ.Enabled = False
        Label1.Enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
        Label4.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        Button1.Enabled = False
        Button3.Enabled = False
        Label23.Enabled = False
        Label24.Enabled = False
        Label25.Enabled = False
        Label5.Enabled = False
        Label6.Enabled = False
        Label7.Enabled = False
        Label10.Enabled = False
        Label11.Enabled = False
        Label12.Enabled = False
        Label13.Enabled = False
        Label8.Enabled = False
        Label9.Enabled = False
        Label14.Enabled = False
        Label15.Enabled = False
        Label16.Enabled = False
        Label17.Enabled = False
        Label18.Enabled = False
        Label19.Enabled = False
        Label20.Enabled = False
        Label21.Enabled = False
        Label22.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SpecialPlace = ComboBox1.SelectedItem()
        Dim loadtxt As String = My.Computer.FileSystem.ReadAllText("specialZone.txt", System.Text.Encoding.Default)
        My.Computer.FileSystem.WriteAllText("specialZone.txt", "", False, System.Text.Encoding.Default)
        Dim readlines() As String = Split(loadtxt, vbCrLf)
        For i As Integer = 0 To UBound(readlines)
            Dim str() As String = Split(readlines(i), ",")
            SZNameE = str(0)
            SZNameZ = str(1)
            SZRegion = str(2)
            SZWaitingTime = str(3)
            SzQSd = str(4)
            SzQSdRt = str(5)
            SzQVn = str(6)
            SzQVnRt = str(7)
            SzBkSd = str(8)
            SzBkSdRt = str(9)
            SzBkVn = str(10)
            SzBkVnRt = str(11)
            SzMSd = str(12)
            SzMSdRt = str(13)
            SzMVn = str(14)
            SzMVnRt = str(15)
            SzBxSd = str(16)
            SzBxSdRt = str(17)
            SzBxVn = str(18)
            SzBxVnRt = str(19)
            SzSiSd = str(20)
            SzSiSdRt = str(21)
            SzSiVn = str(22)
            SzSiVnRt = str(23)
            If SpecialPlace = SZNameE & " (" & SZNameZ & ")" Then
                readlines(i) = readlines(i).Replace(SZNameE & "," & SZNameZ & "," & SZRegion & "," & SZWaitingTime & "," & SzQSd & "," & SzQSdRt & "," & SzQVn & "," & SzQVnRt & "," & SzBkSd & "," & SzBkSdRt & "," & SzBkVn & "," & SzBkVnRt & "," & SzMSd & "," & SzMSdRt & "," & SzMVn & "," & SzMVnRt & "," & SzBxSd & "," & SzBxSdRt & "," & SzBxVn & "," & SzBxVnRt & "," & SzSiSd & "," & SzSiSdRt & "," & SzSiVn & "," & SzSiVnRt,
                                                    SZNameE & "," & SZNameZ & "," & SZRegion & "," & SZWaitingTime & "," & SzQSd & "," & SzQSdRt & "," & SzQVn & "," & SzQVnRt & "," & SzBkSd & "," & SzBkSdRt & "," & SzBkVn & "," & SzBkVnRt & "," & SzMSd & "," & SzMSdRt & "," & SzMVn & "," & SzMVnRt & "," & SzBxSd & "," & SzBxSdRt & "," & SzBxVn & "," & SzBxVnRt & "," & SzSiSd & "," & SzSiSdRt & "," & SzSiVn & "," & SzSiVnRt & "+1")

            End If

        Next
        Dim writefile As IO.StreamWriter = New IO.StreamWriter("SpecialZone.txt")
        For i As Integer = 0 To UBound(readlines)
            WriteLine(readlines(i))
        Next

    End Sub
End Class