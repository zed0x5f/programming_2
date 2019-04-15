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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.Circle = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErraserHead = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStuff = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourPicker = New System.Windows.Forms.ToolStripMenuItem()
        Me.canvasContainer = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SizeUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SizeUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenToolStripMenuItem, Me.LineTool, Me.ErraserHead, Me.toolStuff})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenToolStripMenuItem
        '
        Me.PenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizeToolStripMenuItem})
        Me.PenToolStripMenuItem.Name = "PenToolStripMenuItem"
        Me.PenToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.PenToolStripMenuItem.Text = "Pen"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.SizeToolStripMenuItem.Text = "shape"
        '
        'LineTool
        '
        Me.LineTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Circle, Me.SquareToolStripMenuItem, Me.LineToolStripMenuItem})
        Me.LineTool.Name = "LineTool"
        Me.LineTool.Size = New System.Drawing.Size(76, 24)
        Me.LineTool.Text = "line tool"
        '
        'Circle
        '
        Me.Circle.Name = "Circle"
        Me.Circle.Size = New System.Drawing.Size(216, 26)
        Me.Circle.Text = "circle"
        '
        'SquareToolStripMenuItem
        '
        Me.SquareToolStripMenuItem.Name = "SquareToolStripMenuItem"
        Me.SquareToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.SquareToolStripMenuItem.Text = "square"
        '
        'ErraserHead
        '
        Me.ErraserHead.Name = "ErraserHead"
        Me.ErraserHead.Size = New System.Drawing.Size(61, 24)
        Me.ErraserHead.Text = "Eraser"
        '
        'toolStuff
        '
        Me.toolStuff.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizeToolStripMenuItem1, Me.ColourPicker})
        Me.toolStuff.Name = "toolStuff"
        Me.toolStuff.Size = New System.Drawing.Size(127, 24)
        Me.toolStuff.Text = "tool size & colour"
        '
        'SizeToolStripMenuItem1
        '
        Me.SizeToolStripMenuItem1.Name = "SizeToolStripMenuItem1"
        Me.SizeToolStripMenuItem1.Size = New System.Drawing.Size(126, 26)
        Me.SizeToolStripMenuItem1.Text = "size"
        '
        'ColourPicker
        '
        Me.ColourPicker.Name = "ColourPicker"
        Me.ColourPicker.Size = New System.Drawing.Size(126, 26)
        Me.ColourPicker.Text = "colour"
        '
        'canvasContainer
        '
        Me.canvasContainer.Location = New System.Drawing.Point(54, 52)
        Me.canvasContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.canvasContainer.Name = "canvasContainer"
        Me.canvasContainer.Padding = New System.Windows.Forms.Padding(0)
        Me.canvasContainer.Size = New System.Drawing.Size(505, 286)
        Me.canvasContainer.TabIndex = 3
        Me.canvasContainer.TabStop = False
        '
        'SizeUpDown
        '
        Me.SizeUpDown.Location = New System.Drawing.Point(372, 31)
        Me.SizeUpDown.Name = "SizeUpDown"
        Me.SizeUpDown.Size = New System.Drawing.Size(120, 22)
        Me.SizeUpDown.TabIndex = 4
        Me.SizeUpDown.Value = New Decimal(New Integer() {50, 0, 0, 0})
        Me.SizeUpDown.Visible = False
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.LineToolStripMenuItem.Text = "line"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SizeUpDown)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.canvasContainer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SizeUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LineTool As ToolStripMenuItem
    Friend WithEvents ErraserHead As ToolStripMenuItem
    Friend WithEvents toolStuff As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ColourPicker As ToolStripMenuItem
    Friend WithEvents canvasContainer As GroupBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Circle As ToolStripMenuItem
    Friend WithEvents SquareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeUpDown As NumericUpDown
    Friend WithEvents LineToolStripMenuItem As ToolStripMenuItem
End Class
