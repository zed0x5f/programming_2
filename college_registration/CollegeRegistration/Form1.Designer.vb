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
        Me.grpResidence = New System.Windows.Forms.GroupBox()
        Me.radOnCampus = New System.Windows.Forms.RadioButton()
        Me.radOffCampus = New System.Windows.Forms.RadioButton()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.cbbMajor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcCosts = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.lblCosts = New System.Windows.Forms.Label()
        Me.grpHousingUnit = New System.Windows.Forms.GroupBox()
        Me.radCraig = New System.Windows.Forms.RadioButton()
        Me.radCooper = New System.Windows.Forms.RadioButton()
        Me.radJulian = New System.Windows.Forms.RadioButton()
        Me.grpResidence.SuspendLayout()
        Me.grpHousingUnit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register for Classes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of Units:"
        '
        'grpResidence
        '
        Me.grpResidence.Controls.Add(Me.radOnCampus)
        Me.grpResidence.Controls.Add(Me.radOffCampus)
        Me.grpResidence.Location = New System.Drawing.Point(31, 170)
        Me.grpResidence.Name = "grpResidence"
        Me.grpResidence.Size = New System.Drawing.Size(112, 68)
        Me.grpResidence.TabIndex = 4
        Me.grpResidence.TabStop = False
        Me.grpResidence.Text = "Residence"
        '
        'radOnCampus
        '
        Me.radOnCampus.AutoSize = True
        Me.radOnCampus.Location = New System.Drawing.Point(7, 43)
        Me.radOnCampus.Name = "radOnCampus"
        Me.radOnCampus.Size = New System.Drawing.Size(80, 17)
        Me.radOnCampus.TabIndex = 1
        Me.radOnCampus.TabStop = True
        Me.radOnCampus.Text = "On-Campus"
        Me.radOnCampus.UseVisualStyleBackColor = True
        '
        'radOffCampus
        '
        Me.radOffCampus.AutoSize = True
        Me.radOffCampus.Location = New System.Drawing.Point(7, 20)
        Me.radOffCampus.Name = "radOffCampus"
        Me.radOffCampus.Size = New System.Drawing.Size(80, 17)
        Me.radOffCampus.TabIndex = 0
        Me.radOffCampus.TabStop = True
        Me.radOffCampus.Text = "Off-Campus"
        Me.radOffCampus.UseVisualStyleBackColor = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(139, 80)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentID.TabIndex = 1
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(139, 106)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(225, 20)
        Me.txtStudentName.TabIndex = 2
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(139, 132)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(33, 20)
        Me.txtUnits.TabIndex = 3
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbbMajor
        '
        Me.cbbMajor.FormattingEnabled = True
        Me.cbbMajor.Location = New System.Drawing.Point(268, 170)
        Me.cbbMajor.Name = "cbbMajor"
        Me.cbbMajor.Size = New System.Drawing.Size(96, 21)
        Me.cbbMajor.TabIndex = 5
        Me.cbbMajor.Text = "Select a Major"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Major:"
        '
        'btnCalcCosts
        '
        Me.btnCalcCosts.Location = New System.Drawing.Point(100, 282)
        Me.btnCalcCosts.Name = "btnCalcCosts"
        Me.btnCalcCosts.Size = New System.Drawing.Size(93, 23)
        Me.btnCalcCosts.TabIndex = 6
        Me.btnCalcCosts.Text = "Calculate Costs"
        Me.btnCalcCosts.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(205, 282)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(93, 23)
        Me.btnClearForm.TabIndex = 7
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'lblCosts
        '
        Me.lblCosts.AutoSize = True
        Me.lblCosts.Location = New System.Drawing.Point(108, 344)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(182, 13)
        Me.lblCosts.TabIndex = 12
        Me.lblCosts.Text = "Total semester costs are: $18,888.88"
        '
        'grpHousingUnit
        '
        Me.grpHousingUnit.Controls.Add(Me.radJulian)
        Me.grpHousingUnit.Controls.Add(Me.radCraig)
        Me.grpHousingUnit.Controls.Add(Me.radCooper)
        Me.grpHousingUnit.Location = New System.Drawing.Point(149, 170)
        Me.grpHousingUnit.Name = "grpHousingUnit"
        Me.grpHousingUnit.Size = New System.Drawing.Size(112, 95)
        Me.grpHousingUnit.TabIndex = 8
        Me.grpHousingUnit.TabStop = False
        Me.grpHousingUnit.Text = "Housing Unit"
        '
        'radCraig
        '
        Me.radCraig.AutoSize = True
        Me.radCraig.Location = New System.Drawing.Point(7, 43)
        Me.radCraig.Name = "radCraig"
        Me.radCraig.Size = New System.Drawing.Size(49, 17)
        Me.radCraig.TabIndex = 1
        Me.radCraig.TabStop = True
        Me.radCraig.Text = "Craig"
        Me.radCraig.UseVisualStyleBackColor = True
        '
        'radCooper
        '
        Me.radCooper.AutoSize = True
        Me.radCooper.Location = New System.Drawing.Point(7, 20)
        Me.radCooper.Name = "radCooper"
        Me.radCooper.Size = New System.Drawing.Size(59, 17)
        Me.radCooper.TabIndex = 0
        Me.radCooper.TabStop = True
        Me.radCooper.Text = "Cooper"
        Me.radCooper.UseVisualStyleBackColor = True
        '
        'radJulian
        '
        Me.radJulian.AutoSize = True
        Me.radJulian.Location = New System.Drawing.Point(7, 66)
        Me.radJulian.Name = "radJulian"
        Me.radJulian.Size = New System.Drawing.Size(52, 17)
        Me.radJulian.TabIndex = 2
        Me.radJulian.TabStop = True
        Me.radJulian.Text = "Julian"
        Me.radJulian.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 397)
        Me.Controls.Add(Me.grpHousingUnit)
        Me.Controls.Add(Me.lblCosts)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalcCosts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbbMajor)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.grpResidence)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpResidence.ResumeLayout(False)
        Me.grpResidence.PerformLayout()
        Me.grpHousingUnit.ResumeLayout(False)
        Me.grpHousingUnit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpResidence As System.Windows.Forms.GroupBox
    Friend WithEvents radOnCampus As System.Windows.Forms.RadioButton
    Friend WithEvents radOffCampus As System.Windows.Forms.RadioButton
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents cbbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCalcCosts As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents lblCosts As System.Windows.Forms.Label
    Friend WithEvents grpHousingUnit As System.Windows.Forms.GroupBox
    Friend WithEvents radJulian As System.Windows.Forms.RadioButton
    Friend WithEvents radCraig As System.Windows.Forms.RadioButton
    Friend WithEvents radCooper As System.Windows.Forms.RadioButton

End Class
