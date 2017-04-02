<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.backRadioButton = New System.Windows.Forms.RadioButton()
        Me.layRadioButton = New System.Windows.Forms.RadioButton()
        Me.sizeTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.fillOrKillTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.returnSizeTextBox = New System.Windows.Forms.TextBox()
        Me.returnPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.backCheckBox = New System.Windows.Forms.CheckBox()
        Me.layCheckBox = New System.Windows.Forms.CheckBox()
        Me.backStopTextBox = New System.Windows.Forms.TextBox()
        Me.layStopTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.backedLabel = New System.Windows.Forms.Label()
        Me.laidLabel = New System.Windows.Forms.Label()
        Me.hedgeValueLabel = New System.Windows.Forms.Label()
        Me.betButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.hedgeButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "side"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "fill/kill"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "match"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "avg"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "betid"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(374, 183)
        Me.DataGridView1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.returnPriceTextBox)
        Me.GroupBox1.Controls.Add(Me.returnSizeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.fillOrKillTextBox)
        Me.GroupBox1.Controls.Add(Me.priceTextBox)
        Me.GroupBox1.Controls.Add(Me.sizeTextBox)
        Me.GroupBox1.Controls.Add(Me.layRadioButton)
        Me.GroupBox1.Controls.Add(Me.backRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 77)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "side"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.layStopTextBox)
        Me.GroupBox2.Controls.Add(Me.backStopTextBox)
        Me.GroupBox2.Controls.Add(Me.layCheckBox)
        Me.GroupBox2.Controls.Add(Me.backCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 306)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 72)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "stop when"
        '
        'backRadioButton
        '
        Me.backRadioButton.AutoSize = True
        Me.backRadioButton.Checked = True
        Me.backRadioButton.Location = New System.Drawing.Point(7, 22)
        Me.backRadioButton.Name = "backRadioButton"
        Me.backRadioButton.Size = New System.Drawing.Size(65, 21)
        Me.backRadioButton.TabIndex = 0
        Me.backRadioButton.TabStop = True
        Me.backRadioButton.Text = "BACK"
        Me.backRadioButton.UseVisualStyleBackColor = True
        '
        'layRadioButton
        '
        Me.layRadioButton.AutoSize = True
        Me.layRadioButton.Location = New System.Drawing.Point(7, 49)
        Me.layRadioButton.Name = "layRadioButton"
        Me.layRadioButton.Size = New System.Drawing.Size(55, 21)
        Me.layRadioButton.TabIndex = 1
        Me.layRadioButton.Text = "LAY"
        Me.layRadioButton.UseVisualStyleBackColor = True
        '
        'sizeTextBox
        '
        Me.sizeTextBox.Location = New System.Drawing.Point(116, 21)
        Me.sizeTextBox.Name = "sizeTextBox"
        Me.sizeTextBox.Size = New System.Drawing.Size(40, 22)
        Me.sizeTextBox.TabIndex = 2
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(212, 21)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(43, 22)
        Me.priceTextBox.TabIndex = 3
        '
        'fillOrKillTextBox
        '
        Me.fillOrKillTextBox.Location = New System.Drawing.Point(328, 20)
        Me.fillOrKillTextBox.Name = "fillOrKillTextBox"
        Me.fillOrKillTextBox.Size = New System.Drawing.Size(40, 22)
        Me.fillOrKillTextBox.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "size"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "fill or kill"
        '
        'returnSizeTextBox
        '
        Me.returnSizeTextBox.Location = New System.Drawing.Point(212, 49)
        Me.returnSizeTextBox.Name = "returnSizeTextBox"
        Me.returnSizeTextBox.Size = New System.Drawing.Size(43, 22)
        Me.returnSizeTextBox.TabIndex = 8
        '
        'returnPriceTextBox
        '
        Me.returnPriceTextBox.Location = New System.Drawing.Point(328, 49)
        Me.returnPriceTextBox.Name = "returnPriceTextBox"
        Me.returnPriceTextBox.Size = New System.Drawing.Size(40, 22)
        Me.returnPriceTextBox.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(170, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "size"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(274, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "price"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(78, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "return leg @"
        '
        'backCheckBox
        '
        Me.backCheckBox.AutoSize = True
        Me.backCheckBox.Location = New System.Drawing.Point(7, 21)
        Me.backCheckBox.Name = "backCheckBox"
        Me.backCheckBox.Size = New System.Drawing.Size(123, 21)
        Me.backCheckBox.TabIndex = 0
        Me.backCheckBox.Text = "BACK price @ "
        Me.backCheckBox.UseVisualStyleBackColor = True
        '
        'layCheckBox
        '
        Me.layCheckBox.AutoSize = True
        Me.layCheckBox.Location = New System.Drawing.Point(6, 45)
        Me.layCheckBox.Name = "layCheckBox"
        Me.layCheckBox.Size = New System.Drawing.Size(113, 21)
        Me.layCheckBox.TabIndex = 1
        Me.layCheckBox.Text = "LAY price @ "
        Me.layCheckBox.UseVisualStyleBackColor = True
        '
        'backStopTextBox
        '
        Me.backStopTextBox.Location = New System.Drawing.Point(135, 20)
        Me.backStopTextBox.Name = "backStopTextBox"
        Me.backStopTextBox.Size = New System.Drawing.Size(47, 22)
        Me.backStopTextBox.TabIndex = 2
        '
        'layStopTextBox
        '
        Me.layStopTextBox.Location = New System.Drawing.Point(135, 45)
        Me.layStopTextBox.Name = "layStopTextBox"
        Me.layStopTextBox.Size = New System.Drawing.Size(47, 22)
        Me.layStopTextBox.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(222, 323)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Backed"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(222, 340)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Laid"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(222, 357)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 17)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Hedge Value "
        '
        'backedLabel
        '
        Me.backedLabel.AutoSize = True
        Me.backedLabel.Location = New System.Drawing.Point(319, 323)
        Me.backedLabel.Name = "backedLabel"
        Me.backedLabel.Size = New System.Drawing.Size(16, 17)
        Me.backedLabel.TabIndex = 13
        Me.backedLabel.Text = "£"
        '
        'laidLabel
        '
        Me.laidLabel.AutoSize = True
        Me.laidLabel.Location = New System.Drawing.Point(319, 340)
        Me.laidLabel.Name = "laidLabel"
        Me.laidLabel.Size = New System.Drawing.Size(16, 17)
        Me.laidLabel.TabIndex = 14
        Me.laidLabel.Text = "£"
        '
        'hedgeValueLabel
        '
        Me.hedgeValueLabel.AutoSize = True
        Me.hedgeValueLabel.Location = New System.Drawing.Point(319, 357)
        Me.hedgeValueLabel.Name = "hedgeValueLabel"
        Me.hedgeValueLabel.Size = New System.Drawing.Size(16, 17)
        Me.hedgeValueLabel.TabIndex = 15
        Me.hedgeValueLabel.Text = "£"
        '
        'betButton
        '
        Me.betButton.Location = New System.Drawing.Point(19, 385)
        Me.betButton.Name = "betButton"
        Me.betButton.Size = New System.Drawing.Size(75, 23)
        Me.betButton.TabIndex = 16
        Me.betButton.Text = "Bet"
        Me.betButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(103, 385)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 17
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'hedgeButton
        '
        Me.hedgeButton.Location = New System.Drawing.Point(225, 385)
        Me.hedgeButton.Name = "hedgeButton"
        Me.hedgeButton.Size = New System.Drawing.Size(75, 23)
        Me.hedgeButton.TabIndex = 18
        Me.hedgeButton.Text = "Hedge"
        Me.hedgeButton.UseVisualStyleBackColor = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.hedgeButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.betButton)
        Me.Controls.Add(Me.hedgeValueLabel)
        Me.Controls.Add(Me.laidLabel)
        Me.Controls.Add(Me.backedLabel)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(400, 420)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents returnPriceTextBox As TextBox
    Friend WithEvents returnSizeTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents fillOrKillTextBox As TextBox
    Friend WithEvents priceTextBox As TextBox
    Friend WithEvents sizeTextBox As TextBox
    Friend WithEvents layRadioButton As RadioButton
    Friend WithEvents backRadioButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents layCheckBox As CheckBox
    Friend WithEvents backCheckBox As CheckBox
    Friend WithEvents layStopTextBox As TextBox
    Friend WithEvents backStopTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents backedLabel As Label
    Friend WithEvents laidLabel As Label
    Friend WithEvents hedgeValueLabel As Label
    Friend WithEvents betButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents hedgeButton As Button
End Class
