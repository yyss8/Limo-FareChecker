Public Class AddSZone


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If sNameE.Text = "" Then
            MessageBox.Show("Empty Zone Name!")
        Else
            Dim SZNameE, SZNameZ, SZRegion, SZWaitingTime As String
            Dim SzQSd, SzQSdRt, SzQVn, SzQVnRt As Double
            Dim SzBkSd, SzBkSdRt, SzBkVn, SzBkVnRt As Double
            Dim SzMSd, SzMSdRt, SzMVn, SzMVnRt As Double
            Dim SzSiSd, SzSiSdRt, SzSiVn, SzSiVnRt As Double
            Dim SzBxSd, SzBxSdRt, SzBxVn, SzBxVnRt As Double
            Dim loadzonefile As IO.StreamReader = IO.File.OpenText("specialZone.txt")
            Dim Needed As Boolean = False

            Do Until loadzonefile.EndOfStream
                Dim str() As String = Split(loadzonefile.ReadLine, ",")
                SZNameE = str(0)
                SZNameZ = str(1)
                If StrComp(sNameE.Text, SZNameE, CompareMethod.Text) = 0 Or StrComp(sNameZ.Text, SZNameZ, CompareMethod.Text) = 0 Then
                    If MessageBox.Show("地点或注明已存在,是否进入编辑菜单?", "Error", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                        Exit Sub
                    ElseIf Windows.Forms.DialogResult.No Then
                        loadzonefile.Close()
                        Exit Sub
                    End If
                Else
                    Needed = True
                End If
            Loop

            If Needed = True Then
                loadzonefile.Close()
                Dim Writezonefile = IO.File.AppendText("specialZone.txt")
                SZNameE = sNameE.Text
                If SZNameE = "" Then SZNameE = "N/A"
                SZNameZ = sNameZ.Text
                If SZNameZ = "" Then SZNameZ = "N/A"
                SZRegion = Regions.Text
                SZWaitingTime = WTInput.Text
                SzQSd = TextBox1.Text
                SzQSdRt = TextBox2.Text
                SzQVn = TextBox3.Text
                SzQVnRt = TextBox4.Text
                SzBkSd = TextBox10.Text
                SzBkSdRt = TextBox9.Text
                SzBkVn = TextBox8.Text
                SzBkVnRt = TextBox7.Text
                SzMSd = TextBox14.Text
                SzMSdRt = TextBox13.Text
                SzMVn = TextBox12.Text
                SzMVnRt = TextBox11.Text
                SzBxSd = TextBox18.Text
                SzBxSdRt = TextBox17.Text
                SzBxVn = TextBox16.Text
                SzBxVnRt = TextBox15.Text
                SzSiSd = TextBox22.Text
                SzSiSdRt = TextBox21.Text
                SzSiVn = TextBox20.Text
                SzSiVnRt = TextBox19.Text
                Writezonefile.WriteLine(SZNameE & "," & SZNameZ & "," & SZRegion & "," & SZWaitingTime & "," & SzQSd & "," & SzQSdRt & "," & SzQVn & "," & SzQVnRt & "," & SzBkSd & "," & SzBkSdRt & "," & SzBkVn & "," & SzBkVnRt & "," & SzMSd & "," & SzMSdRt & "," & SzMVn & "," & SzMVnRt & "," & SzBxSd & "," & SzBxSdRt & "," & SzBxVn & "," & SzBxVnRt & "," & SzSiSd & "," & SzSiSdRt & "," & SzSiVn & "," & SzSiVnRt)

                Writezonefile.Close()
                MessageBox.Show("添加成功")
                Needed = False
                sNameE.Text = ""
                sNameZ.Text = ""
            End If
        End If



    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        If sNameE.Text = "" Then
            MessageBox.Show("Empty Zone Name!")
        Else
            Dim SZNameE, SZNameZ, SZRegion, SZWaitingTime As String
            Dim SzQSd, SzQSdRt, SzQVn, SzQVnRt As Double
            Dim SzBkSd, SzBkSdRt, SzBkVn, SzBkVnRt As Double
            Dim SzMSd, SzMSdRt, SzMVn, SzMVnRt As Double
            Dim SzSiSd, SzSiSdRt, SzSiVn, SzSiVnRt As Double
            Dim SzBxSd, SzBxSdRt, SzBxVn, SzBxVnRt As Double
            Dim loadzonefile As IO.StreamReader = IO.File.OpenText("specialZone.txt")
            Dim Needed As Boolean = False
            Do Until loadzonefile.EndOfStream
                Dim str() As String = Split(loadzonefile.ReadLine, ",")
                SZNameE = str(0)
                SZNameZ = str(1)
                If StrComp(sNameE.Text, SZNameE, CompareMethod.Text) = 0 Or StrComp(sNameZ.Text, SZNameZ, CompareMethod.Text) = 0 Then
                    If MessageBox.Show("地点或注明已存在,是否进入编辑菜单?", "Error", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                        Exit Sub
                    ElseIf Windows.Forms.DialogResult.No Then
                        loadzonefile.Close()
                        Exit Sub
                    End If
                Else
                    Needed = True
                End If
            Loop

            If Needed = True Then
                loadzonefile.Close()
                Dim Writezonefile = IO.File.AppendText("specialZone.txt")
                SZNameE = sNameE.Text
                If SZNameE = "" Then SZNameE = "N/A"
                SZNameZ = sNameZ.Text
                If SZNameZ = "" Then SZNameZ = "N/A"
                SZRegion = Regions.Text
                SZWaitingTime = WTInput.Text
                SzQSd = TextBox1.Text
                SzQSdRt = TextBox2.Text
                SzQVn = TextBox3.Text
                SzQVnRt = TextBox4.Text
                SzBkSd = TextBox10.Text
                SzBkSdRt = TextBox9.Text
                SzBkVn = TextBox8.Text
                SzBkVnRt = TextBox7.Text
                SzMSd = TextBox14.Text
                SzMSdRt = TextBox13.Text
                SzMVn = TextBox12.Text
                SzMVnRt = TextBox11.Text
                SzBxSd = TextBox18.Text
                SzBxSdRt = TextBox17.Text
                SzBxVn = TextBox16.Text
                SzBxVnRt = TextBox15.Text
                SzSiSd = TextBox22.Text
                SzSiSdRt = TextBox21.Text
                SzSiVn = TextBox20.Text
                SzSiVnRt = TextBox19.Text
                Writezonefile.WriteLine(SZNameE & "," & SZNameZ & "," & SZRegion & "," & SZWaitingTime & "," & SzQSd & "," & SzQSdRt & "," & SzQVn & "," & SzQVnRt & "," & SzBkSd & "," & SzBkSdRt & "," & SzBkVn & "," & SzBkVnRt & "," & SzMSd & "," & SzMSdRt & "," & SzMVn & "," & SzMVnRt & "," & SzBxSd & "," & SzBxSdRt & "," & SzBxVn & "," & SzBxVnRt & "," & SzSiSd & "," & SzSiSdRt & "," & SzSiVn & "," & SzSiVnRt)

                Writezonefile.Close()
                MessageBox.Show("添加成功")
                Needed = False
                If MainForm.Visible = False Then
                    MainForm.Visible = True
                End If

                Me.Visible = False
            End If
        End If




    End Sub
    Private Sub ReturnToMain_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("退出本界面?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If MainForm.Visible = False Then
                MainForm.Show()
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub check_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sNameE.KeyPress, sNameZ.KeyPress, Regions.KeyPress, WTInput.KeyPress, TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress, TextBox11.KeyPress, TextBox12.KeyPress, TextBox13.KeyPress, TextBox14.KeyPress, TextBox15.KeyPress, TextBox16.KeyPress, TextBox17.KeyPress, TextBox18.KeyPress, TextBox19.KeyPress, TextBox20.KeyPress, TextBox21.KeyPress, TextBox22.KeyPress
        If e.KeyChar = "," Then
            e.Handled = True
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SzEdit.Show()
        Me.Visible = False
    End Sub

    Private Sub input_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WTInput.KeyPress, TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress, TextBox11.KeyPress, TextBox12.KeyPress, TextBox13.KeyPress, TextBox14.KeyPress, TextBox15.KeyPress, TextBox16.KeyPress, TextBox17.KeyPress, TextBox18.KeyPress, TextBox19.KeyPress, TextBox20.KeyPress, TextBox21.KeyPress, TextBox22.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

End Class