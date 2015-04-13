Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKhachhang
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tannnps01820.mssql.somee.com;packet size=4096;user id=tannnps01820_SQLLogin_1;pwd=hlf67lgczs;data source=tannnps01820.mssql.somee.com;persist security info=False;initial catalog=tannnps01820"
    Private Sub Khachhang_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from KHACHHANG", KetNoi)
        Try
            KetNoi.Open()

            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaKH.Text = DataGridView1.Item(0, index).Value
        txtTenKH.Text = DataGridView1.Item(1, index).Value
        txtSodt.Text = DataGridView1.Item(2, index).Value
        txtDiachi.Text = DataGridView1.Item(3, index).Value
        txtGioitinh.Text = DataGridView1.Item(4, index).Value
        txtNgaysinh.Text = DataGridView1.Item(5, index).Value
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_Load()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO KHACHHANG (MaKH,TenKH,SoDT,DiaChi,GioiTinh,Ngaysinh)"
        query &= "Values(@MaKH,@TenKH,@SoDT,@Diachi,@GioiTinh,@Ngaysinh )"
        Using conn As New SqlConnection("workstation id=tannnps01820.mssql.somee.com;packet size=4096;user id=tannnps01820_SQLLogin_1;pwd=hlf67lgczs;data source=tannnps01820.mssql.somee.com;persist security info=False;initial catalog=tannnps01820")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                    .Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                    .Parameters.AddWithValue("@SoDT", txtSodt.Text)
                    .Parameters.AddWithValue("@Diachi", txtDiachi.Text)
                    .Parameters.AddWithValue("@GioiTinh", txtGioitinh.Text)
                    .Parameters.AddWithValue("@Ngaysinh", txtNgaysinh.Text)



                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
                tb.Clear()
                DataGridView1.DataSource = tb
                DataGridView1.DataSource = Nothing
                Khachhang_Load()
            End Using
        End Using

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = " update KHACHHANG set TenKH = @TenKH ,SoDT = @SoDT,DiaChi= @DiaChi,Gioitinh= @Gioitinh,Ngaysinh= @Ngaysinh where MaKH = @MaKH "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            com.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            com.Parameters.AddWithValue("@SoDT", txtSodt.Text)
            com.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            com.Parameters.AddWithValue("@GioiTinh", txtGioitinh.Text)
            com.Parameters.AddWithValue("@Ngaysinh", txtNgaysinh.Text)

            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_Load()
    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  KHACHHANG where MaKH = @MaKH"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_Load()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_Load()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

    End Sub

    Private Sub lblDiachi_Click(sender As Object, e As EventArgs) Handles lblDiachi.Click

    End Sub
End Class
