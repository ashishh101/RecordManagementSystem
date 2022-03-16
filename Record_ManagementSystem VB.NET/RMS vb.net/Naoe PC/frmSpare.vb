Imports MySql.Data.MySqlClient

Public Class frmSpare


    Private Sub frmSpare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TblspareTableAdapter.Fill(Me.NaoepcDataSet1.tblspare)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmNavigator.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection("Server=localhost;User Id=root;Password='';Database=naoepc")

        Dim delete As String = "DELETE From tblspare where Product_id='" & txtProd.Text & "'"
        Dim sqlcom As New MySqlCommand
        Dim data As MySqlDataReader
        Dim adapter As New MySqlDataAdapter
        MsgBox("Product Deleted!", vbInformation, "Deleted")

        conn.Open()
        sqlcom.Connection = conn
        sqlcom.CommandText = delete
        adapter.SelectCommand = sqlcom
        data = sqlcom.ExecuteReader
        data.Close()


        conn.Dispose()
        conn.Close()


        Me.Validate()
        Me.TblspareBindingSource.EndEdit()
        Me.TblspareTableAdapter.Fill(Me.NaoepcDataSet1.tblspare)
    End Sub
    Public conn As New MySqlConnection
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = "server=localhost;userid=root;password=;database=naoepc;"
            conn.Open()
        End If

        Dim insert As String = "INSERT INTO tblspare(`Product_type`, `Product_name`, `Manufacturer`, `Price`) VALUES ('" & txtProdtype.Text & "', '" & txtProdname.Text & "', '" & txtManufacturer.Text & "', '" & txtPrice.Text & "')"
        Dim sqlcom As New MySqlCommand

        With sqlcom
            .CommandText = insert
            .Connection = conn
            .ExecuteNonQuery()
        End With

        MsgBox("Product Added!", vbInformation, "Added")
        conn.Dispose()
        conn.Close()

        Me.Validate()
        Me.TblspareBindingSource.EndEdit()
        Me.TblspareTableAdapter.Fill(Me.NaoepcDataSet1.tblspare)
    End Sub

End Class