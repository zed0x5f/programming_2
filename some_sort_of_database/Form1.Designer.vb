<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.tFName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tLName = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tId = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1218, 218)
        Me.DataGridView1.TabIndex = 1
        '
        'tUsername
        '
        Me.tUsername.Location = New System.Drawing.Point(29, 316)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(100, 22)
        Me.tUsername.TabIndex = 2
        '
        'tPassword
        '
        Me.tPassword.Location = New System.Drawing.Point(159, 316)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.Size = New System.Drawing.Size(100, 22)
        Me.tPassword.TabIndex = 3
        '
        'tFName
        '
        Me.tFName.Location = New System.Drawing.Point(276, 316)
        Me.tFName.Name = "tFName"
        Me.tFName.Size = New System.Drawing.Size(100, 22)
        Me.tFName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "First name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Last name"
        '
        'tLName
        '
        Me.tLName.Location = New System.Drawing.Point(391, 316)
        Me.tLName.Name = "tLName"
        Me.tLName.Size = New System.Drawing.Size(100, 22)
        Me.tLName.TabIndex = 8
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(543, 315)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 10
        Me.btnInsert.Text = "insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(244, 393)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "id for deleting"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(374, 393)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "id"
        '
        'tId
        '
        Me.tId.Location = New System.Drawing.Point(29, 391)
        Me.tId.Name = "tId"
        Me.tId.Size = New System.Drawing.Size(100, 22)
        Me.tId.TabIndex = 14
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(150, 391)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 450)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tId)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tLName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tFName)
        Me.Controls.Add(Me.tPassword)
        Me.Controls.Add(Me.tUsername)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tUsername As TextBox
    Friend WithEvents tPassword As TextBox
    Friend WithEvents tFName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tLName As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tId As TextBox
    Friend WithEvents btnUpdate As Button
End Class
