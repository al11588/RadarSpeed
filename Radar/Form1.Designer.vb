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
        Me.btnEnterSpeed = New System.Windows.Forms.Button()
        Me.lblHighwayRadarCheckpoint = New System.Windows.Forms.Label()
        Me.lblPostedSpeedLimit = New System.Windows.Forms.Label()
        Me.lblAveragespeed = New System.Windows.Forms.Label()
        Me.lstRadarSpeed = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnterSpeed
        '
        Me.btnEnterSpeed.Location = New System.Drawing.Point(93, 114)
        Me.btnEnterSpeed.Name = "btnEnterSpeed"
        Me.btnEnterSpeed.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterSpeed.TabIndex = 0
        Me.btnEnterSpeed.Text = "Enter Speed"
        Me.btnEnterSpeed.UseVisualStyleBackColor = True
        '
        'lblHighwayRadarCheckpoint
        '
        Me.lblHighwayRadarCheckpoint.AutoSize = True
        Me.lblHighwayRadarCheckpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighwayRadarCheckpoint.Location = New System.Drawing.Point(89, 43)
        Me.lblHighwayRadarCheckpoint.Name = "lblHighwayRadarCheckpoint"
        Me.lblHighwayRadarCheckpoint.Size = New System.Drawing.Size(262, 24)
        Me.lblHighwayRadarCheckpoint.TabIndex = 1
        Me.lblHighwayRadarCheckpoint.Text = "Highway Radar Checkpoint"
        '
        'lblPostedSpeedLimit
        '
        Me.lblPostedSpeedLimit.AutoSize = True
        Me.lblPostedSpeedLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostedSpeedLimit.Location = New System.Drawing.Point(164, 84)
        Me.lblPostedSpeedLimit.Name = "lblPostedSpeedLimit"
        Me.lblPostedSpeedLimit.Size = New System.Drawing.Size(225, 18)
        Me.lblPostedSpeedLimit.TabIndex = 2
        Me.lblPostedSpeedLimit.Text = "Posted Speed Limit - 60 mph"
        '
        'lblAveragespeed
        '
        Me.lblAveragespeed.AutoSize = True
        Me.lblAveragespeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveragespeed.Location = New System.Drawing.Point(47, 329)
        Me.lblAveragespeed.Name = "lblAveragespeed"
        Me.lblAveragespeed.Size = New System.Drawing.Size(407, 24)
        Me.lblAveragespeed.TabIndex = 3
        Me.lblAveragespeed.Text = "Average speed at checkpoint is X.XX mph"
        '
        'lstRadarSpeed
        '
        Me.lstRadarSpeed.FormattingEnabled = True
        Me.lstRadarSpeed.Location = New System.Drawing.Point(93, 143)
        Me.lstRadarSpeed.Name = "lstRadarSpeed"
        Me.lstRadarSpeed.Size = New System.Drawing.Size(120, 173)
        Me.lstRadarSpeed.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(496, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(99, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(99, 22)
        Me.mnuExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 362)
        Me.Controls.Add(Me.lstRadarSpeed)
        Me.Controls.Add(Me.lblAveragespeed)
        Me.Controls.Add(Me.lblPostedSpeedLimit)
        Me.Controls.Add(Me.lblHighwayRadarCheckpoint)
        Me.Controls.Add(Me.btnEnterSpeed)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Radar Speed"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnterSpeed As System.Windows.Forms.Button
    Friend WithEvents lblHighwayRadarCheckpoint As System.Windows.Forms.Label
    Friend WithEvents lblPostedSpeedLimit As System.Windows.Forms.Label
    Friend WithEvents lblAveragespeed As System.Windows.Forms.Label
    Friend WithEvents lstRadarSpeed As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
