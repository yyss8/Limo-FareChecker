Public Class ZcAdd

    Private Sub ReturnToMain_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("退出本界面?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If MainForm.Visible = False Then
                MainForm.Show()
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ZipCodeInput, TownInput, RegionInput As String
        Dim FlPrice, MhPrice, BkPrice, BxPrice, SiPrice As Double
        Dim Needed As Boolean = False
        Dim loadzcfile As IO.StreamReader = IO.File.OpenText("location.txt")
        Do Until loadzcfile.EndOfStream
            Dim str() As String = Split(loadzcfile.ReadLine, ",")
            ZipCodeInput = str(0)
            If StrComp(ZipCodeInput, ZipCode.Text, CompareMethod.Text) = 0 Then
                If MessageBox.Show("邮编已存在,是否进入编辑菜单?", "Error", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Me.Close()
                    Exit Sub
                ElseIf Windows.Forms.DialogResult.No Then
                    loadzcfile.Close()
                    Exit Sub
                End If
            Else
                Needed = True
            End If
        Loop
        If Needed = True Then
            loadzcfile.Close()
            Dim Writezonefile = IO.File.AppendText("location.txt")
            ZipCodeInput = ZipCode.Text
            TownInput = TownName.Text
            RegionInput = Regions.Text
            FlPrice = TextBox3.Text
            MhPrice = TextBox4.Text
            BkPrice = TextBox5.Text
            BxPrice = TextBox6.Text
            SiPrice = TextBox7.Text
            Writezonefile.WriteLine(ZipCodeInput & "," & TownInput & "," & MhPrice & "," & BxPrice & "," & BkPrice & "," & FlPrice & "," & SiPrice & "," & RegionInput)
            Writezonefile.Close()
            MessageBox.Show("添加成功")
            Needed = False
            ZipCode.Text = ""
            TownName.Text = ""
            Regions.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ZipCodeInput, TownInput, RegionInput As String
        Dim FlPrice, MhPrice, BkPrice, BxPrice, SiPrice As Double
        Dim Needed As Boolean = False
        Dim loadzcfile As IO.StreamReader = IO.File.OpenText("location.txt")
        Do Until loadzcfile.EndOfStream
            Dim str() As String = Split(loadzcfile.ReadLine, ",")
            ZipCodeInput = str(0)
            If StrComp(ZipCodeInput, ZipCode.Text, CompareMethod.Text) = 0 Then
                If MessageBox.Show("邮编已存在,是否进入编辑菜单?", "Error", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Me.Close()
                    Exit Sub
                ElseIf Windows.Forms.DialogResult.No Then
                    loadzcfile.Close()
                    Exit Sub
                End If
            Else
                Needed = True
            End If
        Loop
        If Needed = True Then
            loadzcfile.Close()
            Dim Writezonefile = IO.File.AppendText("location.txt")
            ZipCodeInput = ZipCode.Text
            TownInput = TownName.Text
            RegionInput = Regions.Text
            FlPrice = TextBox3.Text
            MhPrice = TextBox4.Text
            BkPrice = TextBox5.Text
            BxPrice = TextBox6.Text
            SiPrice = TextBox7.Text
            Writezonefile.WriteLine(ZipCodeInput & "," & TownInput & "," & MhPrice & "," & BxPrice & "," & BkPrice & "," & FlPrice & "," & SiPrice & "," & RegionInput)

            Writezonefile.Close()
            MessageBox.Show("添加成功")
            Needed = False
            ZipCode.Text = ""
            TownName.Text = ""
            Regions.Text = ""
            If MainForm.Visible = False Then
                MainForm.Visible = True
            End If

            Me.Visible = False
        End If

    End Sub

    Private Sub check_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ZipCode.KeyPress, TownName.KeyPress, Regions.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress
        If e.KeyChar = "," Then
            e.Handled = True
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub input_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ZipCode.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
End Class