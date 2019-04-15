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
        Me.radJulian = New System.Windows.Forms.RadioButton()
        Me.radCooper = New System.Windows.Forms.RadioButton()
        Me.grpHousingUnit = New System.Windows.Forms.GroupBox()
        Me.radCraig = New System.Windows.Forms.RadioButton()
        Me.lblCosts = New System.Windows.Forms.Label()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnCalcCosts = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbMajor = New System.Windows.Forms.ComboBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.radOnCampus = New System.Windows.Forms.RadioButton()
        Me.radOffCampus = New System.Windows.Forms.RadioButton()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.grpResidence = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpHousingUnit.SuspendLayout()
        Me.grpResidence.SuspendLayout()
        Me.SuspendLayout()
        '
        'radJulian
        '
        Me.radJulian.AutoSize = True
        Me.radJulian.Location = New System.Drawing.Point(9, 81)
        Me.radJulian.Margin = New System.Windows.Forms.Padding(4)
        Me.radJulian.Name = "radJulian"
        Me.radJulian.Size = New System.Drawing.Size(66, 21)
        Me.radJulian.TabIndex = 2
        Me.radJulian.TabStop = True
        Me.radJulian.Text = "Julian"
        Me.radJulian.UseVisualStyleBackColor = True
        '
        'radCooper
        '
        Me.radCooper.AutoSize = True
        Me.radCooper.Location = New System.Drawing.Point(9, 25)
        Me.radCooper.Margin = New System.Windows.Forms.Padding(4)
        Me.radCooper.Name = "radCooper"
        Me.radCooper.Size = New System.Drawing.Size(75, 21)
        Me.radCooper.TabIndex = 0
        Me.radCooper.TabStop = True
        Me.radCooper.Text = "Cooper"
        Me.radCooper.UseVisualStyleBackColor = True
        '
        'grpHousingUnit
        '
        Me.grpHousingUnit.Controls.Add(Me.radJulian)
        Me.grpHousingUnit.Controls.Add(Me.radCraig)
        Me.grpHousingUnit.Controls.Add(Me.radCooper)
        Me.grpHousingUnit.Location = New System.Drawing.Point(37, 288)
        Me.grpHousingUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.grpHousingUnit.Name = "grpHousingUnit"
        Me.grpHousingUnit.Padding = New System.Windows.Forms.Padding(4)
        Me.grpHousingUnit.Size = New System.Drawing.Size(149, 117)
        Me.grpHousingUnit.TabIndex = 24
        Me.grpHousingUnit.TabStop = False
        Me.grpHousingUnit.Text = "Housing Unit"
        '
        'radCraig
        '
        Me.radCraig.AutoSize = True
        Me.radCraig.Location = New System.Drawing.Point(9, 53)
        Me.radCraig.Margin = New System.Windows.Forms.Padding(4)
        Me.radCraig.Name = "radCraig"
        Me.radCraig.Size = New System.Drawing.Size(62, 21)
        Me.radCraig.TabIndex = 1
        Me.radCraig.TabStop = True
        Me.radCraig.Text = "Craig"
        Me.radCraig.UseVisualStyleBackColor = True
        '
        'lblCosts
        '
        Me.lblCosts.AutoSize = True
        Me.lblCosts.Location = New System.Drawing.Point(236, 275)
        Me.lblCosts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(244, 17)
        Me.lblCosts.TabIndex = 26
        Me.lblCosts.Text = "Total semester costs are: $18,888.88"
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(356, 196)
        Me.btnClearForm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(124, 28)
        Me.btnClearForm.TabIndex = 23
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnCalcCosts
        '
        Me.btnCalcCosts.Location = New System.Drawing.Point(356, 232)
        Me.btnCalcCosts.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcCosts.Name = "btnCalcCosts"
        Me.btnCalcCosts.Size = New System.Drawing.Size(124, 28)
        Me.btnCalcCosts.TabIndex = 22
        Me.btnCalcCosts.Text = "Calculate Costs"
        Me.btnCalcCosts.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Major:"
        '
        'cbbMajor
        '
        Me.cbbMajor.FormattingEnabled = True
        Me.cbbMajor.Items.AddRange(New Object() {"computer science"})
        Me.cbbMajor.Location = New System.Drawing.Point(353, 82)
        Me.cbbMajor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbMajor.Name = "cbbMajor"
        Me.cbbMajor.Size = New System.Drawing.Size(127, 24)
        Me.cbbMajor.TabIndex = 21
        Me.cbbMajor.Text = "Select a Major"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(181, 149)
        Me.txtUnits.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(43, 22)
        Me.txtUnits.TabIndex = 18
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(181, 85)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(132, 22)
        Me.txtStudentID.TabIndex = 14
        '
        'radOnCampus
        '
        Me.radOnCampus.AutoSize = True
        Me.radOnCampus.Location = New System.Drawing.Point(9, 53)
        Me.radOnCampus.Margin = New System.Windows.Forms.Padding(4)
        Me.radOnCampus.Name = "radOnCampus"
        Me.radOnCampus.Size = New System.Drawing.Size(104, 21)
        Me.radOnCampus.TabIndex = 1
        Me.radOnCampus.TabStop = True
        Me.radOnCampus.Text = "On-Campus"
        Me.radOnCampus.UseVisualStyleBackColor = True
        '
        'radOffCampus
        '
        Me.radOffCampus.AutoSize = True
        Me.radOffCampus.Location = New System.Drawing.Point(9, 25)
        Me.radOffCampus.Margin = New System.Windows.Forms.Padding(4)
        Me.radOffCampus.Name = "radOffCampus"
        Me.radOffCampus.Size = New System.Drawing.Size(104, 21)
        Me.radOffCampus.TabIndex = 0
        Me.radOffCampus.TabStop = True
        Me.radOffCampus.Text = "Off-Campus"
        Me.radOffCampus.UseVisualStyleBackColor = True
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(181, 117)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(299, 22)
        Me.txtStudentName.TabIndex = 16
        '
        'grpResidence
        '
        Me.grpResidence.Controls.Add(Me.radOnCampus)
        Me.grpResidence.Controls.Add(Me.radOffCampus)
        Me.grpResidence.Location = New System.Drawing.Point(37, 196)
        Me.grpResidence.Margin = New System.Windows.Forms.Padding(4)
        Me.grpResidence.Name = "grpResidence"
        Me.grpResidence.Padding = New System.Windows.Forms.Padding(4)
        Me.grpResidence.Size = New System.Drawing.Size(149, 84)
        Me.grpResidence.TabIndex = 20
        Me.grpResidence.TabStop = False
        Me.grpResidence.Text = "Residence"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Number of Units:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Student Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Student ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 36)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Register for Classes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 545)
        Me.Controls.Add(Me.grpHousingUnit)
        Me.Controls.Add(Me.lblCosts)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalcCosts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbbMajor)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.grpResidence)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpHousingUnit.ResumeLayout(False)
        Me.grpHousingUnit.PerformLayout()
        Me.grpResidence.ResumeLayout(False)
        Me.grpResidence.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radJulian As RadioButton
    Friend WithEvents radCooper As RadioButton
    Friend WithEvents grpHousingUnit As GroupBox
    Friend WithEvents radCraig As RadioButton
    Friend WithEvents lblCosts As Label
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnCalcCosts As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbbMajor As ComboBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents radOnCampus As RadioButton
    Friend WithEvents radOffCampus As RadioButton
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents grpResidence As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
