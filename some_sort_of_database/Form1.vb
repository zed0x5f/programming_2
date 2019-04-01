Imports System.Data.OleDb

Public Class Form1
    Dim connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\100\pba\programming_2\some_sort_of_database\thing.accdb;"
    Dim Connection As New OleDbConnection(connectionString)
    Dim adapter = New OleDbDataAdapter()
    Dim ds As New DataSet

    Dim customer = "DimCustomer"
    Dim id = "custom_id"
    Dim username = "username"
    Dim password = "`password`"
    Dim fName = "first_name"
    Dim lName = "last_name"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.Open()
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

    Private Sub Inssert(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim Sql = String.Format("INSERT INTO {0} ({1}, {2}, {3}, {4}) VALUES ('{5}', '{6}', '{7}', '{8}')",
        customer, username, password, fName, lName, tUsername.Text, tPassword.Text, tFName.Text, tLName.Text)
        EXECUTION(Sql)
    End Sub

    Private Sub MyUpdate(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim i = 0
        Dim stick = Function(key, value) If(value = "", "", key & " = '" & value & "',")
        Dim values = stick(password, tPassword.Text)
        values &= stick(username, tUsername.Text)
        values &= stick(fName, tFName.Text)
        values &= stick(lName, tLName.Text).replace(",", "")
        Dim sql = String.Format("UPDATE {0} SET {1} where {2}={3}", customer, values, id, tId.Text)

        EXECUTION(sql)
    End Sub

    Private Sub Delete(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql = String.Format("DELETE FROM {0} where {1}={2};", customer, id, TextBox5.Text)
        TextBox5.Text = ""
        EXECUTION(sql)
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
        Console.WriteLine(String.Format("you asked for this life. dont complain lol{0}", &HFF))

        openUrEyes()
    End Sub
End Class
