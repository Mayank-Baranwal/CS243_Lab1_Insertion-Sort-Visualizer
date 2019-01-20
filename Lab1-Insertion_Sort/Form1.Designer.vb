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
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblArr = New System.Windows.Forms.Label()
        Me.txtArr = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnNxt = New System.Windows.Forms.Button()
        Me.lblDone = New System.Windows.Forms.Label()
        Me.txtSorted = New System.Windows.Forms.TextBox()
        Me.txtCmp1 = New System.Windows.Forms.TextBox()
        Me.txtCmp2 = New System.Windows.Forms.TextBox()
        Me.txtUnSorted = New System.Windows.Forms.TextBox()
        Me.lblLegend = New System.Windows.Forms.Label()
        Me.txtCmpRes = New System.Windows.Forms.TextBox()
        Me.lblCmpWith = New System.Windows.Forms.Label()
        Me.txtOutput1 = New System.Windows.Forms.RichTextBox()
        Me.pan_header = New System.Windows.Forms.Panel()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.pan_header.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSort.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.ForeColor = System.Drawing.Color.Coral
        Me.btnSort.Location = New System.Drawing.Point(533, 268)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(136, 64)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "&Start Insertion Sort"
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'lblArr
        '
        Me.lblArr.AutoSize = True
        Me.lblArr.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArr.Location = New System.Drawing.Point(78, 123)
        Me.lblArr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArr.Name = "lblArr"
        Me.lblArr.Size = New System.Drawing.Size(116, 27)
        Me.lblArr.TabIndex = 3
        Me.lblArr.Text = "Enter Array"
        '
        'txtArr
        '
        Me.txtArr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArr.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArr.Location = New System.Drawing.Point(228, 109)
        Me.txtArr.Multiline = True
        Me.txtArr.Name = "txtArr"
        Me.txtArr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArr.Size = New System.Drawing.Size(714, 58)
        Me.txtArr.TabIndex = 4
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(78, 356)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(78, 27)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "Output"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Coral
        Me.btnExit.Location = New System.Drawing.Point(763, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 64)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.Maroon
        Me.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClr.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.ForeColor = System.Drawing.Color.White
        Me.btnClr.Location = New System.Drawing.Point(306, 268)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(136, 64)
        Me.btnClr.TabIndex = 8
        Me.btnClr.Text = "&Clear"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'btnNxt
        '
        Me.btnNxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNxt.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNxt.ForeColor = System.Drawing.Color.Coral
        Me.btnNxt.Location = New System.Drawing.Point(533, 268)
        Me.btnNxt.Name = "btnNxt"
        Me.btnNxt.Size = New System.Drawing.Size(136, 64)
        Me.btnNxt.TabIndex = 9
        Me.btnNxt.Text = "Next &Step"
        Me.btnNxt.UseVisualStyleBackColor = False
        Me.btnNxt.Visible = False
        '
        'lblDone
        '
        Me.lblDone.AutoSize = True
        Me.lblDone.Location = New System.Drawing.Point(709, 216)
        Me.lblDone.Name = "lblDone"
        Me.lblDone.Size = New System.Drawing.Size(0, 27)
        Me.lblDone.TabIndex = 10
        '
        'txtSorted
        '
        Me.txtSorted.BackColor = System.Drawing.Color.Lime
        Me.txtSorted.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSorted.ForeColor = System.Drawing.Color.Black
        Me.txtSorted.Location = New System.Drawing.Point(991, 244)
        Me.txtSorted.Name = "txtSorted"
        Me.txtSorted.Size = New System.Drawing.Size(119, 34)
        Me.txtSorted.TabIndex = 12
        Me.txtSorted.Text = "Sorted"
        Me.txtSorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCmp1
        '
        Me.txtCmp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCmp1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmp1.ForeColor = System.Drawing.Color.Purple
        Me.txtCmp1.Location = New System.Drawing.Point(306, 203)
        Me.txtCmp1.Name = "txtCmp1"
        Me.txtCmp1.ReadOnly = True
        Me.txtCmp1.Size = New System.Drawing.Size(256, 34)
        Me.txtCmp1.TabIndex = 13
        Me.txtCmp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCmp2
        '
        Me.txtCmp2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCmp2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmp2.ForeColor = System.Drawing.Color.Purple
        Me.txtCmp2.Location = New System.Drawing.Point(695, 203)
        Me.txtCmp2.Name = "txtCmp2"
        Me.txtCmp2.ReadOnly = True
        Me.txtCmp2.Size = New System.Drawing.Size(241, 34)
        Me.txtCmp2.TabIndex = 14
        Me.txtCmp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnSorted
        '
        Me.txtUnSorted.BackColor = System.Drawing.Color.Red
        Me.txtUnSorted.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnSorted.ForeColor = System.Drawing.Color.Black
        Me.txtUnSorted.Location = New System.Drawing.Point(991, 298)
        Me.txtUnSorted.Name = "txtUnSorted"
        Me.txtUnSorted.Size = New System.Drawing.Size(119, 34)
        Me.txtUnSorted.TabIndex = 15
        Me.txtUnSorted.Text = "Unsorted"
        Me.txtUnSorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLegend
        '
        Me.lblLegend.AutoSize = True
        Me.lblLegend.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblLegend.Location = New System.Drawing.Point(1009, 195)
        Me.lblLegend.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegend.Name = "lblLegend"
        Me.lblLegend.Size = New System.Drawing.Size(86, 32)
        Me.lblLegend.TabIndex = 17
        Me.lblLegend.Text = "Colour"
        '
        'txtCmpRes
        '
        Me.txtCmpRes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCmpRes.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmpRes.Location = New System.Drawing.Point(605, 203)
        Me.txtCmpRes.Name = "txtCmpRes"
        Me.txtCmpRes.ReadOnly = True
        Me.txtCmpRes.Size = New System.Drawing.Size(48, 27)
        Me.txtCmpRes.TabIndex = 18
        Me.txtCmpRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCmpWith
        '
        Me.lblCmpWith.AutoSize = True
        Me.lblCmpWith.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmpWith.Location = New System.Drawing.Point(78, 203)
        Me.lblCmpWith.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCmpWith.Name = "lblCmpWith"
        Me.lblCmpWith.Size = New System.Drawing.Size(200, 27)
        Me.lblCmpWith.TabIndex = 19
        Me.lblCmpWith.Text = "Current Comparision"
        '
        'txtOutput1
        '
        Me.txtOutput1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOutput1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput1.Location = New System.Drawing.Point(228, 356)
        Me.txtOutput1.Name = "txtOutput1"
        Me.txtOutput1.ReadOnly = True
        Me.txtOutput1.Size = New System.Drawing.Size(714, 26)
        Me.txtOutput1.TabIndex = 11
        Me.txtOutput1.Text = ""
        '
        'pan_header
        '
        Me.pan_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pan_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pan_header.Controls.Add(Me.lbl_header)
        Me.pan_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_header.Location = New System.Drawing.Point(0, 0)
        Me.pan_header.Name = "pan_header"
        Me.pan_header.Size = New System.Drawing.Size(1209, 73)
        Me.pan_header.TabIndex = 20
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.Font = New System.Drawing.Font("Palatino Linotype", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_header.Location = New System.Drawing.Point(448, 8)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(281, 49)
        Me.lbl_header.TabIndex = 0
        Me.lbl_header.Text = "Visual Learning"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(1209, 653)
        Me.Controls.Add(Me.pan_header)
        Me.Controls.Add(Me.lblCmpWith)
        Me.Controls.Add(Me.txtCmpRes)
        Me.Controls.Add(Me.lblLegend)
        Me.Controls.Add(Me.txtUnSorted)
        Me.Controls.Add(Me.txtCmp2)
        Me.Controls.Add(Me.txtCmp1)
        Me.Controls.Add(Me.txtSorted)
        Me.Controls.Add(Me.txtOutput1)
        Me.Controls.Add(Me.lblDone)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnNxt)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtArr)
        Me.Controls.Add(Me.lblArr)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Visual Learning"
        Me.pan_header.ResumeLayout(False)
        Me.pan_header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lblArr As System.Windows.Forms.Label
    Friend WithEvents txtArr As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnNxt As System.Windows.Forms.Button
    Friend WithEvents lblDone As System.Windows.Forms.Label
    Friend WithEvents txtSorted As System.Windows.Forms.TextBox
    Friend WithEvents txtCmp1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCmp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtUnSorted As System.Windows.Forms.TextBox
    Friend WithEvents lblLegend As System.Windows.Forms.Label
    Friend WithEvents txtCmpRes As System.Windows.Forms.TextBox
    Friend WithEvents lblCmpWith As System.Windows.Forms.Label
    Friend WithEvents txtOutput1 As System.Windows.Forms.RichTextBox
    Friend WithEvents pan_header As System.Windows.Forms.Panel
    Friend WithEvents lbl_header As System.Windows.Forms.Label

End Class
