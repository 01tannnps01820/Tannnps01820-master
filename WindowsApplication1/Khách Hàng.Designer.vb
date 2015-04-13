<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachhang
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
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.lblSodt = New System.Windows.Forms.Label()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.lblGioitinh = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtSodt = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtGioitinh = New System.Windows.Forms.TextBox()
        Me.txtNgaysinh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.BackColor = System.Drawing.SystemColors.Control
        Me.lblMaKH.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMaKH.Location = New System.Drawing.Point(12, 19)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(114, 18)
        Me.lblMaKH.TabIndex = 0
        Me.lblMaKH.Text = "Mã Khách Hàng"
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.BackColor = System.Drawing.SystemColors.Control
        Me.lblTenKH.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTenKH.Location = New System.Drawing.Point(12, 48)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(117, 18)
        Me.lblTenKH.TabIndex = 1
        Me.lblTenKH.Text = "Tên Khách Hàng"
        '
        'lblSodt
        '
        Me.lblSodt.AutoSize = True
        Me.lblSodt.BackColor = System.Drawing.Color.SeaShell
        Me.lblSodt.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSodt.ForeColor = System.Drawing.Color.Black
        Me.lblSodt.Location = New System.Drawing.Point(12, 80)
        Me.lblSodt.Name = "lblSodt"
        Me.lblSodt.Size = New System.Drawing.Size(104, 18)
        Me.lblSodt.TabIndex = 3
        Me.lblSodt.Text = "Số Điện Thoại"
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.BackColor = System.Drawing.Color.SeaShell
        Me.lblDiachi.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiachi.ForeColor = System.Drawing.Color.Black
        Me.lblDiachi.Location = New System.Drawing.Point(12, 112)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(57, 18)
        Me.lblDiachi.TabIndex = 4
        Me.lblDiachi.Text = "Địa Chỉ"
        '
        'lblGioitinh
        '
        Me.lblGioitinh.AutoSize = True
        Me.lblGioitinh.BackColor = System.Drawing.Color.SeaShell
        Me.lblGioitinh.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGioitinh.ForeColor = System.Drawing.Color.Black
        Me.lblGioitinh.Location = New System.Drawing.Point(12, 147)
        Me.lblGioitinh.Name = "lblGioitinh"
        Me.lblGioitinh.Size = New System.Drawing.Size(72, 18)
        Me.lblGioitinh.TabIndex = 5
        Me.lblGioitinh.Text = "Giới Tính"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.Black
        Me.btnThem.Location = New System.Drawing.Point(114, 226)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.ForeColor = System.Drawing.Color.Black
        Me.btnSua.Location = New System.Drawing.Point(297, 226)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 7
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.Black
        Me.btnXoa.Location = New System.Drawing.Point(479, 226)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Location = New System.Drawing.Point(699, 226)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(368, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(528, 179)
        Me.DataGridView1.TabIndex = 10
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(146, 17)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(181, 20)
        Me.txtMaKH.TabIndex = 11
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(146, 46)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(181, 20)
        Me.txtTenKH.TabIndex = 12
        '
        'txtSodt
        '
        Me.txtSodt.Location = New System.Drawing.Point(146, 78)
        Me.txtSodt.Name = "txtSodt"
        Me.txtSodt.Size = New System.Drawing.Size(181, 20)
        Me.txtSodt.TabIndex = 14
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(146, 110)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(181, 20)
        Me.txtDiachi.TabIndex = 15
        '
        'txtGioitinh
        '
        Me.txtGioitinh.Location = New System.Drawing.Point(146, 145)
        Me.txtGioitinh.Name = "txtGioitinh"
        Me.txtGioitinh.Size = New System.Drawing.Size(181, 20)
        Me.txtGioitinh.TabIndex = 16
        '
        'txtNgaysinh
        '
        Me.txtNgaysinh.Location = New System.Drawing.Point(146, 183)
        Me.txtNgaysinh.Name = "txtNgaysinh"
        Me.txtNgaysinh.Size = New System.Drawing.Size(181, 20)
        Me.txtNgaysinh.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ngày Sinh"
        '
        'frmKhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(908, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNgaysinh)
        Me.Controls.Add(Me.txtGioitinh)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtSodt)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblGioitinh)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.lblSodt)
        Me.Controls.Add(Me.lblTenKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Name = "frmKhachhang"
        Me.Text = "Khách Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents lblTenKH As System.Windows.Forms.Label
    Friend WithEvents lblSodt As System.Windows.Forms.Label
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents lblGioitinh As System.Windows.Forms.Label
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtSodt As System.Windows.Forms.TextBox
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtGioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtNgaysinh As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
