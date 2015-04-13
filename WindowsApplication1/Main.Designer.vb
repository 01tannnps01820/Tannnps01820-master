<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mniHethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDangxuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniKhachhang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSanpham = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThongtin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLienhe = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.tải_xuống
        Me.PictureBox1.Location = New System.Drawing.Point(132, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 221)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHethong, Me.mniQuanly, Me.mniThongtin})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(481, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mniHethong
        '
        Me.mniHethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDangxuat, Me.mniThoat})
        Me.mniHethong.Name = "mniHethong"
        Me.mniHethong.Size = New System.Drawing.Size(75, 20)
        Me.mniHethong.Text = "Trang Chủ"
        '
        'mniDangxuat
        '
        Me.mniDangxuat.Name = "mniDangxuat"
        Me.mniDangxuat.Size = New System.Drawing.Size(152, 22)
        Me.mniDangxuat.Text = "Đăng Xuất"
        '
        'mniThoat
        '
        Me.mniThoat.Name = "mniThoat"
        Me.mniThoat.Size = New System.Drawing.Size(152, 22)
        Me.mniThoat.Text = "Thoát"
        '
        'mniQuanly
        '
        Me.mniQuanly.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniKhachhang, Me.mniSanpham})
        Me.mniQuanly.Name = "mniQuanly"
        Me.mniQuanly.Size = New System.Drawing.Size(63, 20)
        Me.mniQuanly.Text = "Quản Lý"
        '
        'mniKhachhang
        '
        Me.mniKhachhang.Name = "mniKhachhang"
        Me.mniKhachhang.Size = New System.Drawing.Size(152, 22)
        Me.mniKhachhang.Text = "Khách Hàng"
        '
        'mniSanpham
        '
        Me.mniSanpham.Name = "mniSanpham"
        Me.mniSanpham.Size = New System.Drawing.Size(152, 22)
        Me.mniSanpham.Text = "Loại Sản Phẩm"
        '
        'mniThongtin
        '
        Me.mniThongtin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLienhe})
        Me.mniThongtin.Name = "mniThongtin"
        Me.mniThongtin.Size = New System.Drawing.Size(71, 20)
        Me.mniThongtin.Text = "Thông tin"
        '
        'mniLienhe
        '
        Me.mniLienhe.Name = "mniLienhe"
        Me.mniLienhe.Size = New System.Drawing.Size(114, 22)
        Me.mniLienhe.Text = "Liên Hệ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome NT Software"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 337)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mniHethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDangxuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniKhachhang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSanpham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThongtin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniLienhe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
