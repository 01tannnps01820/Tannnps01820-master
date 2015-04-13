Public Class frmMain

    Private Sub mniDangXuat_Click(sender As Object, e As EventArgs) Handles mniDangxuat.Click
        Dim Dangnhap As New frmDangnhap
        Dangnhap.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub mniKhachHang_Click(sender As Object, e As EventArgs) Handles mniKhachhang.Click
        frmKhachhang.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub



    Private Sub mniSanpham_Click(sender As Object, e As EventArgs) Handles mniSanpham.Click
        frmSanpham.Show()
        Me.Close()

    End Sub


    Private Sub mniLienhe_Click(sender As Object, e As EventArgs) Handles mniLienhe.Click
        frmLienhe.Show()
        Me.Close()


    End Sub
End Class

