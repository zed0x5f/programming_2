<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB3 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.BTNCalculate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(927, 501)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(927, 630)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Units:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(927, 563)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1291, 710)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Major:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(825, 710)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 216)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Residence"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 49)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(204, 36)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Off-Campus"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(16, 112)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(204, 36)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "On-Campus"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(1254, 495)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(267, 38)
        Me.TB1.TabIndex = 5
        '
        'TB3
        '
        Me.TB3.Location = New System.Drawing.Point(1254, 627)
        Me.TB3.Name = "TB3"
        Me.TB3.Size = New System.Drawing.Size(100, 38)
        Me.TB3.TabIndex = 6
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(1254, 557)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(267, 38)
        Me.TB2.TabIndex = 7
        '
        'BTNCalculate
        '
        Me.BTNCalculate.Location = New System.Drawing.Point(1011, 1007)
        Me.BTNCalculate.Name = "BTNCalculate"
        Me.BTNCalculate.Size = New System.Drawing.Size(245, 59)
        Me.BTNCalculate.TabIndex = 8
        Me.BTNCalculate.Text = "Calculate Costs"
        Me.BTNCalculate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1336, 1007)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 59)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Clear Form"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1015, 1144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 32)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "LBL1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1083, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(481, 32)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Register for Classes Bedford College"
        '
        'CB1
        '
        Me.CB1.FormattingEnabled = True
        Me.CB1.Items.AddRange(New Object() {"Business"})
        Me.CB1.Location = New System.Drawing.Point(1453, 710)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(221, 39)
        Me.CB1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2661, 1300)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTNCalculate)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.TB3)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TB1 As System.Windows.Forms.TextBox
    Friend WithEvents TB3 As System.Windows.Forms.TextBox
    Friend WithEvents TB2 As System.Windows.Forms.TextBox
    Friend WithEvents BTNCalculate As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CB1 As System.Windows.Forms.ComboBox

End Class
