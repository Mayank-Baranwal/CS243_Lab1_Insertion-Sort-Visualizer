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
        Me.SuspendLayout()
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(504, 101)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(136, 59)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "&Start Insertion Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblArr
        '
        Me.lblArr.AutoSize = True
        Me.lblArr.Location = New System.Drawing.Point(78, 37)
        Me.lblArr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArr.Name = "lblArr"
        Me.lblArr.Size = New System.Drawing.Size(110, 25)
        Me.lblArr.TabIndex = 3
        Me.lblArr.Text = "Enter Array"
        '
        'txtArr
        '
        Me.txtArr.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtArr.Location = New System.Drawing.Point(228, 25)
        Me.txtArr.Multiline = True
        Me.txtArr.Name = "txtArr"
        Me.txtArr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArr.Size = New System.Drawing.Size(714, 54)
        Me.txtArr.TabIndex = 4
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(78, 253)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(71, 25)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "Output"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(714, 101)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 59)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(331, 101)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(92, 59)
        Me.btnClr.TabIndex = 8
        Me.btnClr.Text = "&Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnNxt
        '
        Me.btnNxt.Location = New System.Drawing.Point(504, 101)
        Me.btnNxt.Name = "btnNxt"
        Me.btnNxt.Size = New System.Drawing.Size(136, 59)
        Me.btnNxt.TabIndex = 9
        Me.btnNxt.Text = "Next &Step"
        Me.btnNxt.UseVisualStyleBackColor = True
        '
        'lblDone
        '
        Me.lblDone.AutoSize = True
        Me.lblDone.Location = New System.Drawing.Point(709, 200)
        Me.lblDone.Name = "lblDone"
        Me.lblDone.Size = New System.Drawing.Size(0, 25)
        Me.lblDone.TabIndex = 10
        '
        'txtSorted
        '
        Me.txtSorted.BackColor = System.Drawing.Color.LightGreen
        Me.txtSorted.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.txtSorted.Location = New System.Drawing.Point(991, 226)
        Me.txtSorted.Name = "txtSorted"
        Me.txtSorted.Size = New System.Drawing.Size(119, 30)
        Me.txtSorted.TabIndex = 12
        Me.txtSorted.Text = "Sorted"
        Me.txtSorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCmp1
        '
        Me.txtCmp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txtCmp1.Location = New System.Drawing.Point(306, 188)
        Me.txtCmp1.Name = "txtCmp1"
        Me.txtCmp1.ReadOnly = True
        Me.txtCmp1.Size = New System.Drawing.Size(256, 30)
        Me.txtCmp1.TabIndex = 13
        Me.txtCmp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCmp2
        '
        Me.txtCmp2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txtCmp2.Location = New System.Drawing.Point(695, 188)
        Me.txtCmp2.Name = "txtCmp2"
        Me.txtCmp2.ReadOnly = True
        Me.txtCmp2.Size = New System.Drawing.Size(241, 30)
        Me.txtCmp2.TabIndex = 14
        Me.txtCmp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnSorted
        '
        Me.txtUnSorted.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.txtUnSorted.ForeColor = System.Drawing.Color.DarkRed
        Me.txtUnSorted.Location = New System.Drawing.Point(991, 276)
        Me.txtUnSorted.Name = "txtUnSorted"
        Me.txtUnSorted.Size = New System.Drawing.Size(119, 30)
        Me.txtUnSorted.TabIndex = 15
        Me.txtUnSorted.Text = "Unsorted"
        Me.txtUnSorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLegend
        '
        Me.lblLegend.AutoSize = True
        Me.lblLegend.Location = New System.Drawing.Point(1009, 181)
        Me.lblLegend.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegend.Name = "lblLegend"
        Me.lblLegend.Size = New System.Drawing.Size(78, 25)
        Me.lblLegend.TabIndex = 17
        Me.lblLegend.Text = "Legend"
        '
        'txtCmpRes
        '
        Me.txtCmpRes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCmpRes.Location = New System.Drawing.Point(605, 188)
        Me.txtCmpRes.Name = "txtCmpRes"
        Me.txtCmpRes.ReadOnly = True
        Me.txtCmpRes.Size = New System.Drawing.Size(48, 23)
        Me.txtCmpRes.TabIndex = 18
        Me.txtCmpRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCmpWith
        '
        Me.lblCmpWith.AutoSize = True
        Me.lblCmpWith.Location = New System.Drawing.Point(78, 188)
        Me.lblCmpWith.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCmpWith.Name = "lblCmpWith"
        Me.lblCmpWith.Size = New System.Drawing.Size(192, 25)
        Me.lblCmpWith.TabIndex = 19
        Me.lblCmpWith.Text = "Current Comparision"
        '
        'txtOutput1
        '
        Me.txtOutput1.Location = New System.Drawing.Point(228, 253)
        Me.txtOutput1.Name = "txtOutput1"
        Me.txtOutput1.ReadOnly = True
        Me.txtOutput1.Size = New System.Drawing.Size(714, 25)
        Me.txtOutput1.TabIndex = 11
        Me.txtOutput1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1197, 584)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
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

End Class
