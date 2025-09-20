Imports System.Data.SqlClient
Imports System.IO



Public Class Form1

    Dim connString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=ShopDB;Integrated Security=True"
    Dim selectedImageBytes() As Byte

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Insert new records into the database
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand("INSERT INTO Products (ProductName,Category,Price,Quantity,ProductImage) VALUES (@ProductName,@Category,@Price,@Quantity,@ProductImage)", conn)
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Price", Decimal.Parse(txtPrice.Text))
            cmd.Parameters.AddWithValue("@Quantity", Decimal.Parse(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@ProductImage", SqlDbType.VarBinary).Value = If(selectedImageBytes, DBNull.Value)
            conn.Open()
            cmd.ExecuteNonQuery()

        End Using

        MessageBox.Show("Record Inserted Successfully")

        DisplayRecords()

    End Sub

    'Display records on gridview

    Private Sub DisplayRecords()

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand("SELECT * FROM Products", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvDisplay.DataSource = table

        End Using


    End Sub

    'To load image for PC
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Using ofd As New OpenFileDialog
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then

                PictureBox1.Image = Image.FromFile(ofd.FileName)
                selectedImageBytes = File.ReadAllBytes(ofd.FileName)


            End If
        End Using

    End Sub


    'Update record in database
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If dgvDisplay.SelectedRows.Count > 0 Then
            Dim id = Convert.ToInt32(dgvDisplay.SelectedRows(0).Cells("id").Value)
            Using conn As New SqlConnection(connString)
                Dim cmd As New SqlCommand("Update PRODUCTS SET ProductName = @ProductName , Category = @Category , Price = @Price , Quantity = @Quantity , ProductImage = @ProductImage WHERE Id = @id", conn)
                cmd.Connection = conn
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Price", Decimal.Parse(txtPrice.Text))
                cmd.Parameters.AddWithValue("@Quantity", Decimal.Parse(txtQuantity.Text))
                cmd.Parameters.Add("@ProductImage", SqlDbType.VarBinary).Value = If(selectedImageBytes IsNot Nothing, selectedImageBytes, DBNull.Value)
                conn.Open()
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Updated")

                DisplayRecords()

            End Using

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayRecords()

        btnDelete.Enabled = False
        btnUpdate.Enabled = False

    End Sub

    Private Sub dgvDisplay_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisplay.CellClick

        'If header is clicked, no record should display
        If e.RowIndex < 0 OrElse dgvDisplay.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim row As DataGridViewRow = dgvDisplay.Rows(e.RowIndex)

        txtProductName.Text = row.Cells("ProductName").Value.ToString()
        cmbCategory.SelectedItem = row.Cells("Category").Value.ToString()
        txtPrice.Text = row.Cells("Price").Value.ToString()
        txtQuantity.Text = row.Cells("Quantity").Value.ToString()

        btnDelete.Enabled = True
        btnUpdate.Enabled = True

        'display image

        If Not IsDBNull(row.Cells("ProductImage").Value) Then

            Dim imgByte As Byte() = CType((row.Cells("ProductImage").Value), Byte())

            Using ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)

            End Using
        Else
            PictureBox1.Image = Nothing

        End If



    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'delete record from database
        If dgvDisplay.SelectedRows.Count > 0 Then
            Dim id = Convert.ToInt32(dgvDisplay.SelectedRows(0).Cells("id").Value)
            Using conn As New SqlConnection(connString)
                Dim cmd As New SqlCommand("DELETE FROM Products WHERE Id = @id", conn)
                cmd.Connection = conn
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Deleted")

                DisplayRecords()

            End Using


        End If

    End Sub


End Class

