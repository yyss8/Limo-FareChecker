Public Class Maps
    Private GoogleControl1 As GoogleControl

    Sub New()
        InitializeComponent()
        GoogleControl1 = New GoogleControl
        GoogleControl1.Dock = DockStyle.Fill
        Me.Controls.Add(GoogleControl1)
    End Sub
End Class
<System.Runtime.InteropServices.ComVisibleAttribute(True)> _
Public Class GoogleControl : Inherits UserControl

    Private WebBrowser1 As WebBrowser
    Private StatusStrip1 As StatusStrip
    Private StatusButtonDelete As ToolStripButton
    Private StatusLabelLatLng As ToolStripStatusLabel

    Private InitialZoom As Integer
    Private InitialLatitude As Double
    Private InitialLongitude As Double
    Private InitialMapType As GoogleMapType

    Public Enum GoogleMapType
        None
        RoadMap
        Terrain
        Hybrid
        Satellite
    End Enum

    Sub New()
        MyBase.New()

        WebBrowser1 = New WebBrowser
        StatusStrip1 = New StatusStrip
        StatusButtonDelete = New ToolStripButton
        StatusLabelLatLng = New ToolStripStatusLabel

        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.AllowWebBrowserDrop = False
        WebBrowser1.IsWebBrowserContextMenuEnabled = False
        WebBrowser1.WebBrowserShortcutsEnabled = False
        WebBrowser1.ObjectForScripting = Me
        WebBrowser1.ScriptErrorsSuppressed = True

        Me.Controls.Add(WebBrowser1)


    End Sub

    Private Sub GoogleControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        WebBrowser1.DocumentText = My.Computer.FileSystem.ReadAllText("GoogleMap.htm")
        Dim ObjArr(2) As Object
        Dim goingto As String = "11355"
        Dim goingfrom As String = MainForm.zipcodebox.Text
        ObjArr(0) = CObj(New String(goingfrom))
        ObjArr(1) = CObj(New String(goingto))
        WebBrowser1.Document.InvokeScript("test", ObjArr)
    End Sub
 

End Class
