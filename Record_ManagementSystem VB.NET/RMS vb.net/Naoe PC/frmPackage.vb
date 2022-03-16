Imports MySql.Data.MySqlClient

Public Class frmPackage


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NaoepcDataSet4.tblpackage' table. You can move, or remove it, as needed.
        Me.TblpackageTableAdapter.Fill(Me.NaoepcDataSet4.tblpackage)
      


      
    End Sub
    Public conn As New MySqlConnection

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = "server=localhost;userid=root;password=;database=naoepc;"
            conn.Open()
        End If

        Dim insert As String = "INSERT INTO tblpackage(`Motherboard`, `Processor`, `HDD`, `RAM`, `Graphic_Card`, `Case`,`Price`) VALUES ('" & ADDtxtMobo.Text & "', '" & ADDtxtProc.Text & "', '" & ADDtxtHdd.Text & "', '" & ADDtxtRam.Text & "', '" & ADDtxtGC.Text & "', '" & ADDtxtCase.Text & "', '" & txtPrice.Text & "' )"
        Dim sqlcom As New MySqlCommand

        With sqlcom
            .CommandText = insert
            .Connection = conn
            .ExecuteNonQuery()
        End With

        MsgBox("Package Added!", vbInformation, "Added")
        conn.Dispose()
        conn.Close()

        Me.Validate()
        Me.TblpackageBindingSource.EndEdit()
        Me.TblpackageTableAdapter.Fill(Me.NaoepcDataSet4.tblpackage)
    End Sub
    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection("Server=localhost;User Id=root;Password='';Database=naoepc")

        Dim delete As String = "DELETE From tblpackage where Package_id='" & txtProd.Text & "'"
        Dim sqlcom As New MySqlCommand
        Dim data As MySqlDataReader
        Dim adapter As New MySqlDataAdapter
        MsgBox("Package Deleted!", vbInformation, "Deleted")

        conn.Open()
        sqlcom.Connection = conn
        sqlcom.CommandText = delete
        adapter.SelectCommand = sqlcom
        data = sqlcom.ExecuteReader
        data.Close()


        conn.Dispose()
        conn.Close()


        Me.Validate()
        Me.TblpackageBindingSource.EndEdit()
        Me.TblpackageTableAdapter.Fill(Me.NaoepcDataSet4.tblpackage)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmNavigator.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

End Class
