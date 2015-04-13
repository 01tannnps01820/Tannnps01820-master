Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmSanpham
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tannnps01820.mssql.somee.com;packet size=4096;user id=tannnps01820_SQLLogin_1;pwd=hlf67lgczs;data source=tannnps01820.mssql.somee.com;persist security info=False;initial catalog=tannnps01820"
    Private Sub LOAISANPHAM_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from LOAISANPHAM", KetNoi)
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
        txtMaloai.Text = DataGridView1.Item(0, index).Value
        txtTenloai.Text = DataGridView1.Item(1, index).Value
       
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LOAISANPHAM_Load()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO LOAISANPHAM (MaLoai,TenLoai)"
        query &= "Values(@MaLoai,@TenLoai)"
        Using conn As New SqlConnection("workstation id=tannnps01820.mssql.somee.com;packet size=4096;user id=tannnps01820_SQLLogin_1;pwd=hlf67lgczs;data source=tannnps01820.mssql.somee.com;persist security info=False;initial catalog=tannnps01820")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoai", txtMaloai.Text)
                    .Parameters.AddWithValue("@TenLoai", txtTenloai.Text)
                    
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
                LOAISANPHAM_Load()
            End Using
        End Using

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = " update LOAISANPHAM set TenLOAI = @TenLoai where MaLoai = @MaLoai "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaLoai", txtMaloai.Text)
            com.Parameters.AddWithValue("@TenLoai", txtTenloai.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LOAISANPHAM_Load()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  LOAISANPHAM where MaLoai = @MaLoai"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaLoai", txtMaloai.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LOAISANPHAM_Load()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class
