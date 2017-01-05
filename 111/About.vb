Public Class About
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Panel4.Visible = True
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Panel2.Visible = True
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False

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

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Panel3.Visible = True
        Panel1.Visible = False
        Panel2.Visible = False
        Panel4.Visible = False
    End Sub
End Class