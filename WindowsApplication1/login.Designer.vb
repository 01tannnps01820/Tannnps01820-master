<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lblTaikhoan = New System.Windows.Forms.Label()
        Me.lblMatkhau = New System.Windows.Forms.Label()
        Me.txtDangnhap = New System.Windows.Forms.TextBox()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDangnhap
        '
        Me.btnDangnhap.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangnhap.Location = New System.Drawing.Point(148, 170)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(111, 23)
        Me.btnDangnhap.TabIndex = 0
        Me.btnDangnhap.Text = "Đăng Nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(315, 170)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(109, 23)
        Me.btnThoat.TabIndex = 1
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'lblTaikhoan
        '
        Me.lblTaikhoan.AutoSize = True
        Me.lblTaikhoan.BackColor = System.Drawing.SystemColors.Window
        Me.lblTaikhoan.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaikhoan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTaikhoan.Location = New System.Drawing.Point(146, 47)
        Me.lblTaikhoan.Name = "lblTaikhoan"
        Me.lblTaikhoan.Size = New System.Drawing.Size(77, 18)
        Me.lblTaikhoan.TabIndex = 2
        Me.lblTaikhoan.Text = "Tài Khoản"
        '
        'lblMatkhau
        '
        Me.lblMatkhau.AutoSize = True
        Me.lblMatkhau.BackColor = System.Drawing.SystemColors.Window
        Me.lblMatkhau.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatkhau.Location = New System.Drawing.Point(145, 99)
        Me.lblMatkhau.Name = "lblMatkhau"
        Me.lblMatkhau.Size = New System.Drawing.Size(78, 18)
        Me.lblMatkhau.TabIndex = 3
        Me.lblMatkhau.Text = "Mật Khẩu"
        '
        'txtDangnhap
        '
        Me.txtDangnhap.Location = New System.Drawing.Point(237, 45)
        Me.txtDangnhap.Name = "txtDangnhap"
        Me.txtDangnhap.Size = New System.Drawing.Size(253, 20)
        Me.txtDangnhap.TabIndex = 4
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(237, 99)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.Size = New System.Drawing.Size(253, 20)
        Me.txtMatkhau.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(29, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 72)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmDangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(556, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtMatkhau)
        Me.Controls.Add(Me.txtDangnhap)
        Me.Controls.Add(Me.lblMatkhau)
        Me.Controls.Add(Me.lblTaikhoan)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangnhap)
        Me.Name = "frmDangnhap"
        Me.Text = "Đăng Nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDangnhap As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents lblTaikhoan As System.Windows.Forms.Label
    Friend WithEvents lblMatkhau As System.Windows.Forms.Label
    Friend WithEvents txtDangnhap As System.Windows.Forms.TextBox
    Friend WithEvents txtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
