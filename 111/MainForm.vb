Imports System.Security.Permissions
Imports System.Data.OleDb


<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> _
<System.Runtime.InteropServices.ComVisibleAttribute(True)> _
Public Class MainForm

    Dim ZipCode, Iftoll, Regions, Townname As String
    Dim localprice, fstprice As Double
    Dim finalprice, DifferPrice, WaitingTime As Double
    Dim GoingLocation As String
    Dim SpecialPlace As String
    Dim SZNameE, SZNameZ, SZRegion As String
    Dim SZWaitingTime, SzQSd, SzQSdRt, SzQVn, SzQVnRt As Double
    Dim SzBkSd, SzBkSdRt, SzBkVn, SzBkVnRt As Double
    Dim SzMSd, SzMSdRt, SzMVn, SzMVnRt As Double
    Dim SzSiSd, SzSiSdRt, SzSiVn, SzSiVnRt As Double
    Dim SzBxSd, SzBxSdRt, SzBxVn, SzBxVnRt As Double
    Dim accessConnection As New OleDbConnection
    Dim loadAccess As New OleDbCommand
    Dim readAccess As OleDbDataReader
    Dim dbUrl As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ” & Application.StartupPath & “\dbprice.accdb"
    Dim depatureZipCode As String

    Private Sub Mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(Application.StartupPath & "\googlemap.htm")
        accessConnection.ConnectionString = dbUrl
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

        Label8.Visible = False
        WTOpt.Visible = False
        Label10.Visible = False
        specialzone.Close()
    End Sub

    Private Sub MultiAreaPrices_Click(sender As Object, e As EventArgs) Handles MultiAreaPrices.Click
        MultiAreaForm.Show()
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceCalBut.Click

        SpecialPlace = ComboBox1.SelectedItem()
        ZipCode = zipcodebox.Text


        If ZipCode = "" And RadioButton1.Checked = True Then
            MessageBox.Show("Zip Code Must Be Entered!", "Error")
        ElseIf RadioButton2.Checked = True And SpecialPlace = "" Then
            MessageBox.Show("A Place Must Be Selected!", "Error")
        ElseIf RadioButton1.Checked = True And ZipCode <> "" Then
            localprice = PriceLoad(ZipCode)
            Call ZipCodeCal(localprice)
        ElseIf RadioButton2.Checked = True Then
            Dim specialzfile As IO.StreamReader = IO.File.OpenText("specialZone.txt")
            Call SpecialZoneCal(SpecialPlace, specialzfile)
            specialzfile.Close()

        End If


    End Sub
    Private Sub CChange_KeyPress() Handles RTcheck.CheckedChanged
        If RTcheck.Checked = True Then
            Label8.Visible = True
            WTOpt.Visible = True
            Label10.Visible = True
        Else
            Label8.Visible = False
            WTOpt.Visible = False
            Label10.Visible = False
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox1.Visible = True
        Label2.Visible = False
        zipcodebox.Visible = False
        SUVRadio.Visible = False
        zipcodebox.Text = String.Empty
        ZipCode = String.Empty
        Label3.Text = "Zone:"
        Label4.Visible = False
        PriceLabel.Visible = False
        LGARadio.Visible = False
        EWRadio.Visible = False
        JFKRadio.Visible = False
        TownLabel.Text = String.Empty
        Label13.Text = String.Empty
        PriceLabel.Text = String.Empty
        PriceOpt.Text = String.Empty
        WTOpt.Text = String.Empty
        TollLabel.Text = "N/A"
        ZipCode = String.Empty
        fstprice = 0

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox1.Visible = False
        Label2.Visible = True
        zipcodebox.Visible = True
        SUVRadio.Visible = True
        ComboBox1.Text = "选择地点"
        SpecialPlace = String.Empty
        Label3.Text = "Town:"
        Label4.Visible = True
        PriceLabel.Visible = True
        LGARadio.Visible = True
        EWRadio.Visible = True
        JFKRadio.Visible = True
        TownLabel.Text = String.Empty
        Label13.Text = String.Empty
        PriceLabel.Text = String.Empty
        PriceOpt.Text = String.Empty
        WTOpt.Text = String.Empty
        TollLabel.Text = "N/A"
        ZipCode = String.Empty
        fstprice = 0
        PriceCalBut.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Maps.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("Calc.exe")
    End Sub
    Private Sub Airport1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FLRadio.CheckedChanged, BKRadio.CheckedChanged, MHRadio.CheckedChanged
        AirportBut.Visible = False
    End Sub
    Private Sub Airport3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIRadio.CheckedChanged, BXRadio.CheckedChanged
        AirportBut.Visible = False
    End Sub
    Private Sub Airport2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JFKRadio.CheckedChanged, LGARadio.CheckedChanged, EWRadio.CheckedChanged
        AirportBut.Visible = True
    End Sub

    Private Sub SwitchRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FLRadio.CheckedChanged, BKRadio.CheckedChanged, SIRadio.CheckedChanged, MHRadio.CheckedChanged, BXRadio.CheckedChanged, JFKRadio.CheckedChanged, LGARadio.CheckedChanged, EWRadio.CheckedChanged, SUVRadio.CheckedChanged, VNRadio.CheckedChanged
        SpecialPlace = ComboBox1.SelectedItem()
        ZipCode = zipcodebox.Text

        If RadioButton1.Checked = True And ZipCode <> "" And CType(sender, RadioButton).Checked = True Then
            localprice = PriceLoad(ZipCode)
            Call ZipCodeCal(localprice)
        ElseIf RadioButton2.Checked = True And SpecialPlace <> "" Then
            Dim specialzfile As IO.StreamReader = IO.File.OpenText("specialZone.txt")
            Call SpecialZoneCal(SpecialPlace, specialzfile)
            specialzfile.Close()
        Else
            PriceLabel.Text = String.Empty
            PriceOpt.Text = String.Empty
            WTOpt.Text = String.Empty
            TollLabel.Text = "N/A"
            ZipCode = String.Empty
            fstprice = 0
        End If

    End Sub
    Private Sub RTSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTcheck.CheckedChanged
        SpecialPlace = ComboBox1.SelectedItem()
        ZipCode = zipcodebox.Text

        If RadioButton1.Checked = True And ZipCode <> "" And CType(sender, CheckBox).Checked = True Then
            localprice = PriceLoad(ZipCode)
            Call ZipCodeCal(localprice)
        ElseIf RadioButton2.Checked = True And SpecialPlace <> "" Then
            Dim specialzfile As IO.StreamReader = IO.File.OpenText("specialZone.txt")
            Call SpecialZoneCal(SpecialPlace, specialzfile)
            specialzfile.Close()

        End If
    End Sub
    Private Sub 特殊地点ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 特殊地点ToolStripMenuItem.Click
        AddSZone.Show()
        Me.Visible = False
    End Sub
    Public Function ZipCodeCal(ByVal priceToCal As Double) As String
        Dim distanceReader As New Xml.XmlDocument
        If DiffPrice.Text = "" Then
            DifferPrice = 0
        Else
            DifferPrice = DiffPrice.Text
        End If
        If Regions = "BX" Or Regions = "SI" Then
            fstprice = priceToCal
        Else
            fstprice = priceToCal * 0.85
        End If

            If JFKRadio.Checked = True Then
            If Regions = "LI" Then
                fstprice = fstprice + 1
            ElseIf Regions = "BX" Then
                fstprice = priceToCal + 15
            ElseIf Regions = "SI" Then
                fstprice = priceToCal + 20
            Else
                fstprice = fstprice + 11
            End If
        End If

        If LGARadio.Checked = True Then
            If Regions = "LI" Then
                fstprice = fstprice - 3
            Else
                fstprice = fstprice + 7
            End If
        End If
        If EWRadio.Checked = True Then
            If Regions = "LI" Then
                fstprice = fstprice - 10
                If fstprice > 52 Then
                    fstprice = fstprice + 26
                Else
                    fstprice = 52 + (fstprice / 2)
                End If
            ElseIf Regions = "NJ" Then
                If fstprice > 42 Then
                    fstprice = 21 + fstprice
                Else
                    fstprice = 42 + (fstprice / 2)
                End If

            End If
        End If

        If LGARadio.Checked = True Then
            If Regions = "BX" Then
                fstprice = priceToCal + 10
            ElseIf Regions = "SI" Then
                fstprice = priceToCal + 20
            End If
        End If
        If EWRadio.Checked = True Then
            If Regions = "BX" Then
                fstprice = 52 + (priceToCal / 2)
            ElseIf Regions = "SI" Then
                Select Case ZipCode
                    Case "10301", "10302", "10303", "10304", "10305", "10310"
                        fstprice = 42 + 5
                    Case "10306", "10308", "10311", "10314"
                        fstprice = 42 + 10
                    Case "10307", "10309", "10312"
                        fstprice = 42 + (priceToCal / 2)
                End Select
            End If
        End If
        If FLRadio.Checked = True And Regions = "LI" Then
            fstprice = fstprice - 10
        End If

        If TownLabel.Text = "" Then
            TownLabel.Text = "Unknown"
        End If
        If VNRadio.Checked = True Then
            If fstprice > 60 Then
                fstprice = fstprice + 30
            Else
                fstprice = fstprice * 1.5
            End If
        ElseIf SUVRadio.Checked = True Then
            fstprice = fstprice + 5
        End If
        If RTcheck.Checked = True Then
            fstprice = fstprice * 1.7
            WaitingTime = fstprice * 0.01
            If WaitingTime < 1 AndAlso WaitingTime > 0.5 Then
                WaitingTime = 0.5
                WTOpt.Text = WaitingTime.ToString("n1")
            ElseIf WaitingTime < 0.5 Then
                WaitingTime = 0.25
                WTOpt.Text = WaitingTime.ToString("n2")
            ElseIf WaitingTime > 1 Then
                WTOpt.Text = WaitingTime.ToString("n1")
            End If
        ElseIf RTcheck.Checked = True And Label13.Text = "SI" Then
            fstprice = fstprice * 1.8
            WaitingTime = fstprice * 0.01
            If WaitingTime < 1 AndAlso WaitingTime > 0.5 Then
                WaitingTime = 0.5
                WTOpt.Text = WaitingTime.ToString("n1")
            ElseIf WaitingTime < 0.5 Then
                WaitingTime = 0.25
                WTOpt.Text = WaitingTime.ToString("n2")
            ElseIf WaitingTime > 1 Then
                WTOpt.Text = WaitingTime.ToString("n1")
            End If
        End If

        If Regions = "LI" And FLRadio.Checked = True Then
            Iftoll = "NO"
        ElseIf Regions = "LI" And JFKRadio.Checked = True Then
            Iftoll = "NO"
        ElseIf Regions = "LI" And LGARadio.Checked = True Then
            Iftoll = "NO"
        Else : Iftoll = "YES"
        End If

        fstprice = fstprice + DifferPrice
        PriceOpt.Text = fstprice.ToString("n2")
        TollLabel.Text = Iftoll
        Try
            distanceReader.Load("https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" & depatureZipCode & "&destinations=" & ZipCode & "&mode=driving&units=imperial&language=en-US&key=AIzaSyCg3O0U1rlie1FQ25XPVLllSAuHSUXcwXo")
            DistanceLabel.Text = distanceReader.SelectSingleNode("DistanceMatrixResponse").SelectSingleNode("row").SelectSingleNode("element").SelectSingleNode("distance").SelectSingleNode("text").InnerText
            TimeLabel.Text = distanceReader.SelectSingleNode("DistanceMatrixResponse").SelectSingleNode("row").SelectSingleNode("element").SelectSingleNode("duration").SelectSingleNode("text").InnerText
            Me.WebBrowser1.Document.InvokeScript("Getmap", New String() ｛ZipCode, depatureZipCode})
        Catch ex As Exception
            MessageBox.Show("找不到邮编!", "错误")
        End Try

        Return fstprice
    End Function

    Public Function SpecialZoneCal(ByVal Specialplaces As String, ByVal specialzfile As IO.StreamReader) As String
        If DiffPrice.Text = "" Then
            DifferPrice = 0
        Else
            DifferPrice = DiffPrice.Text
        End If
        If SDRadio.Checked = True Then

        ElseIf VNRadio.Checked = True Then

        End If
        If RTcheck.Checked = True Then

        ElseIf RTcheck.Checked = False Then

        End If
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
            If Specialplaces = SZNameE & " (" & SZNameZ & ")" Then
                TownLabel.Text = SZNameE & " (" & SZNameZ & ")"
                If SZRegion = "" Then
                    Label13.Text = "N/A"
                Else
                    Label13.Text = SZRegion
                End If
                If FLRadio.Checked = True Then
                    If SDRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzQSdRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzQSd
                        End If
                    ElseIf VNRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzQVnRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzQVn
                        End If
                    End If

                ElseIf MHRadio.Checked = True Then
                    If SDRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzMSdRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzMSd
                        End If
                    ElseIf VNRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzMVnRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzMVn
                        End If
                    End If


                ElseIf BXRadio.Checked = True Then
                    If SDRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzBxSdRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzBxSd
                        End If
                    ElseIf VNRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzBxVnRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzBxVn
                        End If
                    End If
                ElseIf BKRadio.Checked = True Then
                    If SDRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzBkSdRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzBkSd
                        End If
                    ElseIf VNRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzBkVnRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzBkVn
                        End If
                    End If
                ElseIf SIRadio.Checked = True Then
                    If SDRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzSiSdRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzSiSd
                        End If
                    ElseIf VNRadio.Checked = True Then
                        If RTcheck.Checked = True Then
                            fstprice = SzSiVnRt
                        ElseIf RTcheck.Checked = False Then
                            fstprice = SzSiVn
                        End If
                    End If
                End If
                WTOpt.Text = str(3)
            End If


        Loop

        fstprice = fstprice + DifferPrice
        PriceOpt.Text = fstprice.ToString("n2")

        Return fstprice
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        SpecialPlace = ComboBox1.SelectedItem()
        Dim specialzfile As IO.StreamReader = IO.File.OpenText("specialZone.txt")
        Call SpecialZoneCal(SpecialPlace, specialzfile)
        specialzfile.Close()

    End Sub
    Private Sub zipcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles zipcodebox.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub ZipCodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ZipCodeToolStripMenuItem.Click
        ZcAdd.Show()
        Me.Visible = False
    End Sub

    Private Sub findtown_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zipcodebox.TextChanged
        Townname = String.Empty
        Regions = String.Empty
        PriceLabel.Text = ""
        PriceOpt.Text = ""

        If zipcodebox.TextLength = 5 Then
            accessConnection.Open()
            loadAccess.Connection = accessConnection
            ZipCode = zipcodebox.Text
            loadAccess.CommandText = "select P_townname, p_region FROM Prices_t  WHERE P_ZIPCODE=" & ZipCode
            readAccess = loadAccess.ExecuteReader()
            If readAccess.Read() Then
                Townname = readAccess(0)
                Regions = readAccess(1)
            End If
            readAccess.Close()
            accessConnection.Close()
            If Regions = "SI" Or Regions = "BX" Then
                SIRadio.Visible = False
                BXRadio.Visible = False
            Else
                SIRadio.Visible = True
                BXRadio.Visible = True
            End If
            If Regions = "LI" Or Regions = "NJ" Or Regions = "BX" Or Regions = "SI" Then
                JFKRadio.Visible = True
                EWRadio.Visible = True
                LGARadio.Visible = True
            Else
                JFKRadio.Visible = False
                EWRadio.Visible = False
                LGARadio.Visible = False
            End If

            TownLabel.Text = Townname
            Label13.Text = Regions
        End If


    End Sub
    Private Sub ReturnToMain_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("退出系统?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub AirportBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AirportBut.Click
        AirLineChk.Show()
        Me.Visible = False
    End Sub


    Private Sub SpeicalZoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeicalZoneToolStripMenuItem.Click
        SzEdit.Show()
        Me.Visible = False
    End Sub

    Private Sub 帮助ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 帮助ToolStripMenuItem.Click
        About.Show()
        Me.Visible = False
    End Sub
    Private Sub different_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DiffPrice.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
    Public Function PriceLoad(ByVal ZipCode As Double) As Double

        accessConnection.Open()
        loadAccess.Connection = accessConnection
        Dim regionCode As String = "P_toFL"
        If FLRadio.Checked = True Or JFKRadio.Checked = True Or LGARadio.Checked = True Or EWRadio.Checked = True And Label13.Text <> "NJ" Then
            regionCode = "P_toFL"
        ElseIf BKRadio.Checked = True Then
            depatureZipCode = 11220
            regionCode = "P_toBK"
        ElseIf BXRadio.Checked = True Then
            depatureZipCode = InputBox("请输入邮编", "BX or SI 邮编")
            If depatureZipCode <> "" Then
                regionCode = "P_toBX"
            Else
                MsgBox("请输入邮编！")
                depatureZipCode = InputBox("请输入邮编", "BX or SI 邮编")
                regionCode = "P_toBX"
            End If

        ElseIf MHRadio.Checked = True Or EWRadio.Checked = True And Label13.Text = "NJ" Then
            regionCode = "P_toCT"
        ElseIf SIRadio.Checked = True Then
            depatureZipCode = InputBox("请输入邮编", "BX or SI 邮编")
            If depatureZipCode <> "" Then
                regionCode = "P_toSI"
            Else
                MsgBox("请输入邮编！")
                depatureZipCode = InputBox("请输入邮编", "BX or SI 邮编")
                regionCode = "P_toBX"
            End If

        End If
        If JFKRadio.Checked = True Or LGARadio.Checked = True Or EWRadio.Checked = True Then
            If Label13.Text = "BX" Then
                regionCode = "P_toFL"
            ElseIf Label13.Text = "SI" Then
                regionCode = "P_toBK"
            End If
        End If

        If FLRadio.Checked = True Then
            depatureZipCode = 11355
        ElseIf JFKRadio.Checked = True Then
            depatureZipCode = 11430
        ElseIf LGARadio.Checked = True Then
            depatureZipCode = 11371
        ElseIf EWRadio.Checked = True Then
            depatureZipCode = "07114"
        ElseIf MHRadio.Checked = True Then
            depatureZipCode = 10002
        End If


        loadAccess.CommandText = "select " & regionCode & " FROM Prices_t  WHERE P_ZIPCODE=" & ZipCode
        readAccess = loadAccess.ExecuteReader()
        If readAccess.Read() Then
            localprice = readAccess(0)
        End If
        readAccess.Close()
        accessConnection.Close()
        PriceLabel.Text = localprice

        Return localprice

    End Function

End Class
