Public Class AirLineChk

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Air Canada")
        ComboBox1.Items.Add("Air China")
        ComboBox1.Items.Add("Air India")
        ComboBox1.Items.Add("Air Train Airways")
        ComboBox1.Items.Add("Alaska Airlines")
        ComboBox1.Items.Add("American Airlines")
        ComboBox1.Items.Add("American Eagle")
        ComboBox1.Items.Add("Asiana")
        ComboBox1.Items.Add("British Airways")
        ComboBox1.Items.Add("Cathay Pacific")
        ComboBox1.Items.Add("China Airlines")
        ComboBox1.Items.Add("Delta")
        ComboBox1.Items.Add("Delta Shuttle")
        ComboBox1.Items.Add("Eva Airlines")
        ComboBox1.Items.Add("Japan Airlines")
        ComboBox1.Items.Add("Jet Airways")
        ComboBox1.Items.Add("Jet Blue Airways")
        ComboBox1.Items.Add("Korean Air")
        ComboBox1.Items.Add("North American")
        ComboBox1.Items.Add("Royal Air Maroc")
        ComboBox1.Items.Add("Royal Air Maroc")
        ComboBox1.Items.Add("Royal Jordanian")
        ComboBox1.Items.Add("Singapore Airlines")
        ComboBox1.Items.Add("Southwest Airlines")
        ComboBox1.Items.Add("Sprint")
        ComboBox1.Items.Add("Swiss")
        ComboBox1.Items.Add("United Airlines")
        ComboBox1.Items.Add("United Express")
        ComboBox1.Items.Add("US Airways")
        ComboBox1.Items.Add("US Airways Express")
        ComboBox1.Items.Add("US Airways Shuttle")
        ComboBox1.Items.Add("Virgin America")
        ComboBox1.Items.Add("Virgin Atlantic")
        ComboBox1.Items.Add("WestJet")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("请选择航空公司")
        ElseIf ComboBox1.Text = "Air Canada" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 7", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Air China" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 1", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Air India" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Air Train Airways" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Alaska Airlines" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "American Airlines" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 8", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "American Eagle" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 8", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Asiana" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "British Airways" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 7", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Cathay Pacific" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 7", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "China Airlines" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "China Eastern" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 1", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Delta" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 2,3,4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal C,D", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Delta Shuttle" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Eva Airways" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 1", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Hawaiian Airlines" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 5", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Japan Airlines" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 1", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Jet Airways" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Jet Blue Airways" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4-5", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Korean Air" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 1", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "North American" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Royal Air Maroc" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 1", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Royal Jordanian" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 8", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Singapore Airlines" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Southwest Airlines" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Sprint" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Swiss" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "United Airlines" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 7", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "United Express" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "US Airways" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 8", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal C", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "US Airways Express" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal C", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Virgin America" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "Virgin Atlantic" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Terminal 4", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal B", "Airline Check")
            End If
        ElseIf ComboBox1.Text = "WestJet" Then
            If RadioButton1.Checked = True Then
                MessageBox.Show("Un-Found", "Airline Check")
            ElseIf RadioButton2.Checked = True Then
                MessageBox.Show("Terminal C", "Airline Check")
            ElseIf RadioButton3.Checked = True Then
                MessageBox.Show("Terminal A", "Airline Check")
            End If
        End If
        MainForm.Show()
        Me.Close()

    End Sub
End Class