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
        Me.ErraserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolSizeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.canvasContainer = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenToolStripMenuItem, Me.LineTool, Me.ErraserToolStripMenuItem, Me.ToolSizeColorToolStripMenuItem})
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
        Me.LineTool.Name = "LineTool"
        Me.LineTool.Size = New System.Drawing.Size(76, 24)
        Me.LineTool.Text = "line tool"
        '
        'ErraserToolStripMenuItem
        '
        Me.ErraserToolStripMenuItem.Name = "ErraserToolStripMenuItem"
        Me.ErraserToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.ErraserToolStripMenuItem.Text = "Eraser"
        '
        'ToolSizeColorToolStripMenuItem
        '
        Me.ToolSizeColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizeToolStripMenuItem1, Me.ColourToolStripMenuItem})
        Me.ToolSizeColorToolStripMenuItem.Name = "ToolSizeColorToolStripMenuItem"
        Me.ToolSizeColorToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.ToolSizeColorToolStripMenuItem.Text = "tool size & colour"
        '
        'SizeToolStripMenuItem1
        '
        Me.SizeToolStripMenuItem1.Name = "SizeToolStripMenuItem1"
        Me.SizeToolStripMenuItem1.Size = New System.Drawing.Size(126, 26)
        Me.SizeToolStripMenuItem1.Text = "size"
        '
        'ColourToolStripMenuItem
        '
        Me.ColourToolStripMenuItem.Name = "ColourToolStripMenuItem"
        Me.ColourToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
        Me.ColourToolStripMenuItem.Text = "colour"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.canvasContainer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LineTool As ToolStripMenuItem
    Friend WithEvents ErraserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolSizeColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ColourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents canvasContainer As GroupBox
End Class
