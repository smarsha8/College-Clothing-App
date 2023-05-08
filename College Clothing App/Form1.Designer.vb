<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClothingApp
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
        Me.components = New System.ComponentModel.Container()
        Me.picimage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl50percentoff = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtquantityentry = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblforQuantity = New System.Windows.Forms.Label()
        Me.rdbtncap = New System.Windows.Forms.RadioButton()
        Me.rdbtnHoodie = New System.Windows.Forms.RadioButton()
        Me.rdbtnTShirt = New System.Windows.Forms.RadioButton()
        Me.lblThePrice = New System.Windows.Forms.Label()
        CType(Me.picimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picimage
        '
        Me.picimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picimage.Image = Global.College_Clothing_App.My.Resources.Resources.Screenshot_2023_05_06_082814
        Me.picimage.Location = New System.Drawing.Point(-2, 46)
        Me.picimage.Name = "picimage"
        Me.picimage.Size = New System.Drawing.Size(826, 273)
        Me.picimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picimage.TabIndex = 0
        Me.picimage.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Ravie", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CSU College Wear"
        '
        'lbl50percentoff
        '
        Me.lbl50percentoff.BackColor = System.Drawing.Color.Red
        Me.lbl50percentoff.Font = New System.Drawing.Font("Ravie", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50percentoff.Location = New System.Drawing.Point(299, 336)
        Me.lbl50percentoff.Name = "lbl50percentoff"
        Me.lbl50percentoff.Size = New System.Drawing.Size(275, 37)
        Me.lbl50percentoff.TabIndex = 2
        Me.lbl50percentoff.Text = "Up To 50% Off"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'txtquantityentry
        '
        Me.txtquantityentry.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantityentry.Location = New System.Drawing.Point(614, 440)
        Me.txtquantityentry.Name = "txtquantityentry"
        Me.txtquantityentry.Size = New System.Drawing.Size(100, 29)
        Me.txtquantityentry.TabIndex = 3
        Me.txtquantityentry.Text = "k"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.Font = New System.Drawing.Font("Ravie", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(658, 624)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 48)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSubmit.Font = New System.Drawing.Font("Ravie", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(398, 624)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(176, 48)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Calculate"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblforQuantity
        '
        Me.lblforQuantity.AutoSize = True
        Me.lblforQuantity.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblforQuantity.Font = New System.Drawing.Font("Ravie", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforQuantity.Location = New System.Drawing.Point(442, 443)
        Me.lblforQuantity.Name = "lblforQuantity"
        Me.lblforQuantity.Size = New System.Drawing.Size(155, 26)
        Me.lblforQuantity.TabIndex = 6
        Me.lblforQuantity.Text = "Quantity: "
        '
        'rdbtncap
        '
        Me.rdbtncap.AutoSize = True
        Me.rdbtncap.BackColor = System.Drawing.SystemColors.Highlight
        Me.rdbtncap.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtncap.Location = New System.Drawing.Point(411, 485)
        Me.rdbtncap.Name = "rdbtncap"
        Me.rdbtncap.Size = New System.Drawing.Size(185, 26)
        Me.rdbtncap.TabIndex = 7
        Me.rdbtncap.TabStop = True
        Me.rdbtncap.Text = "$10.00 CSU Cap "
        Me.rdbtncap.UseVisualStyleBackColor = False
        '
        'rdbtnHoodie
        '
        Me.rdbtnHoodie.AutoSize = True
        Me.rdbtnHoodie.BackColor = System.Drawing.SystemColors.Highlight
        Me.rdbtnHoodie.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnHoodie.Location = New System.Drawing.Point(412, 517)
        Me.rdbtnHoodie.Name = "rdbtnHoodie"
        Me.rdbtnHoodie.Size = New System.Drawing.Size(215, 26)
        Me.rdbtnHoodie.TabIndex = 8
        Me.rdbtnHoodie.TabStop = True
        Me.rdbtnHoodie.Text = "$30.00 CSU Hoodie"
        Me.rdbtnHoodie.UseVisualStyleBackColor = False
        '
        'rdbtnTShirt
        '
        Me.rdbtnTShirt.AutoSize = True
        Me.rdbtnTShirt.BackColor = System.Drawing.SystemColors.Highlight
        Me.rdbtnTShirt.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnTShirt.Location = New System.Drawing.Point(411, 549)
        Me.rdbtnTShirt.Name = "rdbtnTShirt"
        Me.rdbtnTShirt.Size = New System.Drawing.Size(222, 26)
        Me.rdbtnTShirt.TabIndex = 9
        Me.rdbtnTShirt.TabStop = True
        Me.rdbtnTShirt.Text = "$10.00 CSU T-Shirt"
        Me.rdbtnTShirt.UseVisualStyleBackColor = False
        '
        'lblThePrice
        '
        Me.lblThePrice.AutoSize = True
        Me.lblThePrice.Font = New System.Drawing.Font("Ravie", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThePrice.Location = New System.Drawing.Point(473, 595)
        Me.lblThePrice.Name = "lblThePrice"
        Me.lblThePrice.Size = New System.Drawing.Size(111, 26)
        Me.lblThePrice.TabIndex = 10
        Me.lblThePrice.Text = "lblPrice"
        '
        'FrmClothingApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.College_Clothing_App.My.Resources.Resources.pngtree_dream_starry_sky_beautiful_blue_purple_picture_image_933809
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 671)
        Me.Controls.Add(Me.lblThePrice)
        Me.Controls.Add(Me.rdbtnTShirt)
        Me.Controls.Add(Me.rdbtnHoodie)
        Me.Controls.Add(Me.rdbtncap)
        Me.Controls.Add(Me.lblforQuantity)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtquantityentry)
        Me.Controls.Add(Me.lbl50percentoff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picimage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmClothingApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Clothing "
        CType(Me.picimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picimage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl50percentoff As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtquantityentry As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblforQuantity As Label
    Friend WithEvents rdbtncap As RadioButton
    Friend WithEvents rdbtnHoodie As RadioButton
    Friend WithEvents rdbtnTShirt As RadioButton
    Friend WithEvents lblThePrice As Label
End Class
