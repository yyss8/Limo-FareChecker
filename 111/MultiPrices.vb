Imports System.Data.OleDb

Public Class MultiAreaForm
    Dim accessConnection As New OleDbConnection
    Dim loadAccess As New OleDbCommand
    Dim readAccess As OleDbDataReader
    Dim dbUrl As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ” & Application.StartupPath & “\dbprice.accdb"


    Private Sub AreaChkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles AreaChkBox1.CheckedChanged
        If CType(sender, CheckBox).Checked = False Then
            TextBox1.Visible = False
            DestBox1.Visible = False
            CarSize1.Visible = False
            RTBox1.Visible = False
            DifferentBox1.Visible = False
        Else
            TextBox1.Visible = True
            DestBox1.Visible = True
            CarSize1.Visible = True
            RTBox1.Visible = True
            DifferentBox1.Visible = True
        End If
    End Sub

    Private Sub AreaChkBox2_CheckedChanged(sender As Object, e As EventArgs) Handles AreaChkBox2.CheckedChanged
        If CType(sender, CheckBox).Checked = False Then
            TextBox2.Visible = False
            DestBox2.Visible = False
            CarSize2.Visible = False
            RTBox2.Visible = False
            DifferentBox2.Visible = False
        Else
            TextBox2.Visible = True
            DestBox2.Visible = True
            CarSize2.Visible = True
            RTBox2.Visible = True
            DifferentBox2.Visible = True
        End If
    End Sub

    Private Sub AreaChkBox3_CheckedChanged(sender As Object, e As EventArgs) Handles AreaChkBox3.CheckedChanged
        If CType(sender, CheckBox).Checked = False Then
            TextBox3.Visible = False
            DestBox3.Visible = False
            CarSize3.Visible = False
            RTBox3.Visible = False
            DifferentBox3.Visible = False
        Else
            TextBox3.Visible = True
            DestBox3.Visible = True
            CarSize3.Visible = True
            RTBox3.Visible = True
            DifferentBox3.Visible = True
        End If
    End Sub
    Private Sub AreaChkBox4_CheckedChanged(sender As Object, e As EventArgs) Handles AreaChkBox4.CheckedChanged
        If CType(sender, CheckBox).Checked = False Then
            TextBox4.Visible = False
            DestBox4.Visible = False
            CarSize4.Visible = False
            RTBox4.Visible = False
            DifferentBox4.Visible = False
        Else
            TextBox4.Visible = True
            DestBox4.Visible = True
            CarSize4.Visible = True
            RTBox4.Visible = True
            DifferentBox4.Visible = True
        End If
    End Sub
    Private Sub AreaChkBox5_CheckedChanged(sender As Object, e As EventArgs) Handles AreaChkBox5.CheckedChanged
        If CType(sender, CheckBox).Checked = False Then
            TextBox5.Visible = False
            DestBox5.Visible = False
            CarSize5.Visible = False
            RTBox5.Visible = False
            DifferentBox5.Visible = False
        Else
            TextBox5.Visible = True
            DestBox5.Visible = True
            CarSize5.Visible = True
            RTBox5.Visible = True
            DifferentBox5.Visible = True
        End If
    End Sub
    Private Sub AreaChkBox6_CheckedChanged(sender As Object, e As EventArgs) Handles AreaChkBox6.CheckedChanged
        If CType(sender, CheckBox).Checked = False Then
            TextBox6.Visible = False
            DestBox6.Visible = False
            CarSize6.Visible = False
            RTBox6.Visible = False
            DifferentBox6.Visible = False
        Else
            TextBox6.Visible = True
            DestBox6.Visible = True
            CarSize6.Visible = True
            RTBox6.Visible = True
            DifferentBox6.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub MultiAreaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accessConnection.ConnectionString = dbUrl
        DestBox1.Items.Add("FL")
        DestBox1.Items.Add("CT")
        DestBox1.Items.Add("BK")
        DestBox1.Items.Add("BX")
        DestBox1.Items.Add("SI")
        DestBox1.Text = "FL"
        CarSize1.Text = "SD"
        CarSize1.Items.Add("SD")
        CarSize1.Items.Add("SUV")
        CarSize1.Items.Add("VN")


        DestBox2.Items.Add("FL")
        DestBox2.Items.Add("CT")
        DestBox2.Items.Add("BK")
        DestBox2.Items.Add("BX")
        DestBox2.Items.Add("SI")
        CarSize2.Items.Add("SD")
        CarSize2.Items.Add("SUV")
        CarSize2.Items.Add("VN")

        DestBox3.Items.Add("FL")
        DestBox3.Items.Add("CT")
        DestBox3.Items.Add("BK")
        DestBox3.Items.Add("BX")
        DestBox3.Items.Add("SI")
        CarSize3.Items.Add("SD")
        CarSize3.Items.Add("SUV")
        CarSize3.Items.Add("VN")

        DestBox4.Items.Add("FL")
        DestBox4.Items.Add("CT")
        DestBox4.Items.Add("BK")
        DestBox4.Items.Add("BX")
        DestBox4.Items.Add("SI")
        CarSize4.Items.Add("SD")
        CarSize4.Items.Add("SUV")
        CarSize4.Items.Add("VN")

        DestBox5.Items.Add("FL")
        DestBox5.Items.Add("CT")
        DestBox5.Items.Add("BK")
        DestBox5.Items.Add("BX")
        DestBox5.Items.Add("SI")
        CarSize5.Items.Add("SD")
        CarSize5.Items.Add("SUV")
        CarSize5.Items.Add("VN")

        DestBox6.Items.Add("FL")
        DestBox6.Items.Add("CT")
        DestBox6.Items.Add("BK")
        DestBox6.Items.Add("BX")
        DestBox6.Items.Add("SI")
        CarSize6.Items.Add("SD")
        CarSize6.Items.Add("SUV")
        CarSize6.Items.Add("VN")

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

    Private Sub PriceChkBtn_Click(sender As Object, e As EventArgs) Handles PriceChkBtn.Click
        If AreaChkBox1.Checked = True Or AreaChkBox2.Checked = True Or
            AreaChkBox3.Checked = True Or AreaChkBox4.Checked = True Or
            AreaChkBox5.Checked = True Or AreaChkBox6.Checked = True Then
            Call ChkBoxNeeded()
        Else
            MsgBox("error")
        End If
    End Sub

    Private Sub ChkBoxNeeded()
        For chkBoxNum = 1 To 6
            If CType(Controls("AreaChkBox" & chkBoxNum), CheckBox).Checked = True Then
                If CType(Controls("TextBox" & chkBoxNum), TextBox).TextLength = 5 And
                    CType(Controls("DestBox" & chkBoxNum), ComboBox).Text <> "" And
                  CType(Controls("CarSize" & chkBoxNum), ComboBox).Text <> "" Then
                    Call PriceCal(CType(Controls("TextBox" & chkBoxNum), TextBox).Text, CType(Controls("DestBox" & chkBoxNum), ComboBox).Text, CType(Controls("CarSize" & chkBoxNum), ComboBox).Text, chkBoxNum)

                ElseIf CType(Controls("TextBox" & chkBoxNum), TextBox).TextLength <> 5 Then
                    MsgBox("邮编错误")
                    Exit Sub
                ElseIf CType(Controls("DestBox" & chkBoxNum), ComboBox).Text = "" Then
                    MsgBox("目的地不能为空")
                    Exit Sub
                ElseIf CType(Controls("CarSize" & chkBoxNum), ComboBox).Text = "" Then
                    MsgBox("车型不能为空")
                    Exit Sub
                End If

            End If
        Next

    End Sub

    Private Sub PriceCal(ByVal Zipcode As String, ByVal destn As String, ByVal carSize As String, ByVal boxNum As Integer)
        Dim localprice As Double
        Dim discountprice As Double
        Dim Townname = String.Empty
        Dim Regions = String.Empty
        Dim regionCode As String = "P_toFL"
        Dim RTorNot As String = ""

        accessConnection.Open()
        loadAccess.Connection = accessConnection
        loadAccess.CommandText = "select P_townname, p_region FROM Prices_t  WHERE P_ZIPCODE=" & Zipcode
        readAccess = loadAccess.ExecuteReader()
        If readAccess.Read() Then
            Townname = readAccess(0)
            Regions = readAccess(1)
        End If
        readAccess.Close()
        If Regions <> "SI" AndAlso Regions <> "BX" Then
            If destn = "FL" Then
                regionCode = "P_toFL"
            ElseIf destn = "CT" Then
                regionCode = "P_toCT"
            ElseIf destn = "BK" Then
                regionCode = "P_toBK"
            ElseIf destn = "BX" Then
                regionCode = "P_toBX"
            ElseIf destn = "SI" Then
                regionCode = "P_toSI"
            End If
            loadAccess.CommandText = "select " & regionCode & " FROM Prices_t  WHERE P_ZIPCODE=" & Zipcode
            readAccess = loadAccess.ExecuteReader()
            If readAccess.Read() Then
                localprice = readAccess(0)
            End If
            discountprice = localprice * 0.85
            If Regions = "LI" And destn = "FL" Then
                discountprice = discountprice - 10
            End If
            If carSize = "VN" Then
                If discountprice > 60 Then
                    discountprice = discountprice + 30
                Else
                    discountprice = discountprice * 1.5
                End If
            ElseIf carSize = "SUV" Then
                discountprice = discountprice + 5
            End If
            discountprice = CType(Controls("DifferentBox" & boxNum), TextBox).Text + discountprice

            If CType(Controls("RTBox" & boxNum), CheckBox).Checked = True Then
                discountprice = discountprice * 1.7
                RTorNot = "往还"
            Else
                RTorNot = "单程"
            End If

            ListBox1.Items.Add("邮编:" & Zipcode & " 地区: " & Townname & " 目的地:" & destn & " 车型:" & carSize)
            ListBox1.Items.Add("RT:" & RTorNot & " 原价: $" & localprice & " 折后价: $" & discountprice)
            ListBox1.Items.Add("")

        ElseIf Regions = "" Then
            ListBox1.Items.Add("此错误邮编")

        ElseIf Regions = "SI" Or Regions = "BX" Then
            If destn = "BX" Or destn = "SI" Then
                ListBox1.Items.Add(Regions & "邮编不支持查询")
                ListBox1.Items.Add("")
            Else
                If destn = "FL" Then
                    regionCode = "P_toFL"
                ElseIf destn = "CT" Then
                    regionCode = "P_toCT"
                ElseIf destn = "BK" Then
                    regionCode = "P_toBK"
                End If
                loadAccess.CommandText = "select " & regionCode & " FROM Prices_t  WHERE P_ZIPCODE=" & Zipcode
                readAccess = loadAccess.ExecuteReader()
                If readAccess.Read() Then
                    localprice = readAccess(0)
                End If
                discountprice = localprice
                If carSize = "VN" Then
                    If discountprice > 60 Then
                        discountprice = discountprice + 30
                    Else
                        discountprice = discountprice * 1.5
                    End If
                ElseIf carSize = "SUV" Then
                    discountprice = discountprice + 5
                End If

                If CType(Controls("RTBox" & boxNum), CheckBox).Checked = True Then
                    discountprice = discountprice * 1.7
                    RTorNot = "往还"
                ElseIf CType(Controls("RTBox" & boxNum), CheckBox).Checked = True And Regions = "SI" Then
                    discountprice = discountprice * 1.8
                Else
                    RTorNot = "单程"
                End If
                ListBox1.Items.Add("邮编:" & Zipcode & " 地区: " & Townname & " 目的地:" & destn & " 车型:" & carSize)
                ListBox1.Items.Add("RT:" & RTorNot & " 价钱: $" & discountprice)
                ListBox1.Items.Add("")

            End If
        End If
        readAccess.Close()
        accessConnection.Close()


    End Sub
    Private Sub zipcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub HistoryBtn_Click(sender As Object, e As EventArgs) Handles HistoryBtn.Click
        ListBox1.Items.Clear()
    End Sub
End Class