Imports System.Data.OleDb

Public Class Form1
    Dim connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\100\pba\programming_2\some_sort_of_database\thing.accdb;"
    Dim Connection As New OleDbConnection(connectionString)
    Dim adapter = New OleDbDataAdapter()
    Dim ds As New DataSet

    Dim customer = "DimCustomer"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.open()
        openUrEyes()
    End Sub

    Private Sub openUrEyes()
        Dim sql = "SELECT * FROM " & customer
        Try
            'Connection.open()
            Dim myAdapter = New OleDbDataAdapter(New OleDbCommand(sql, Connection))
            ds = New DataSet()
            myAdapter.Fill(ds)

            DataGridView1.DataSource = ds
            DataGridView1.DataMember = ds.Tables(0).TableName

            'Connection.close()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clean = Function(elm) "'" & elm & "'"
        Dim comma = Function(elm) clean(elm) & ","
        Dim values = comma(TextBox1.Text)
        values &= comma(TextBox2.Text)
        values &= comma(TextBox3.Text) &
           clean(TextBox4.Text)

        Dim sql = "INSERT INTO " & customer & " (username, `password`, first_name, last_name) VALUES (" & values & ")"

        EXECUTION(sql)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id = "custom_id"
        Dim sql = "DELETE FROM " & customer & " where " & id & "=" & TextBox5.Text & ";"
        TextBox5.Text = ""
        EXECUTION(sql)
        sql = "SELECT MAX(" & id & ") FROM " & customer
        sql = "(" & sql & ")"
        ' sql = "3"
        'sql = "ALTER TABLE " & customer & " MODIFY " & id & " INT AUTO_INCREMENT=(" & sql & ");"
        sql = "ALTER TABLE " & customer & " AUTO_INCREMENT = " & sql & ";"
        ' EXECUTION(sql)
    End Sub

    Private Sub EXECUTION(sql As String)
        Try
            'Connection.open()
            Dim comm = New OleDbCommand(sql, Connection)
            Dim myAdapter = New OleDbDataAdapter(comm)
            'Connection.open()
            comm.ExecuteNonQuery()
            Connection.close()
            Connection.Open()
        Catch ex As Exception
            Console.WriteLine(sql)
            Console.WriteLine(ex)
        End Try
        Console.WriteLine("my eyes are crusty")
        openUrEyes()
    End Sub
End Class
