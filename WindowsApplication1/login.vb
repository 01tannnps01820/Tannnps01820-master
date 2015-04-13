Imports System.Data.SqlClient
Public Class frmDangnhap

    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Dim chuoiketnoi As String = "workstation id=tannnps01820.mssql.somee.com;packet size=4096;user id=tannnps01820_SQLLogin_1;pwd=hlf67lgczs;data source=tannnps01820.mssql.somee.com;persist security info=False;initial catalog=tannnps01820"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NHANVIEN where MaNV='" & txtDangnhap.Text & "' and Password='" & txtMatkhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết Nối Thành Công")
                frmMain.Show()
                Me.Hide()

            Else
                MessageBox.Show("Kết Nối Thất Bại Vui Lòng Kiểm Tra Lại Tài Khoản Hoặc Mật Khẩu")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim dialog As DialogResult = MessageBox.Show(" Kết thúc ứng dụng ",
                                    "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dialog = DialogResult.Yes) Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub frmDangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtMatkhau_TextChanged(sender As Object, e As EventArgs) Handles txtMatkhau.TextChanged

    End Sub

    Private Sub lblMatkhau_Click(sender As Object, e As EventArgs) Handles lblMatkhau.Click

    End Sub

    Private Sub lblTaikhoan_Click(sender As Object, e As EventArgs) Handles lblTaikhoan.Click

    End Sub
End Class
