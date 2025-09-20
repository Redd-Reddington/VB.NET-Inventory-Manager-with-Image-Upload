<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblProductName = New Label()
        txtProductName = New TextBox()
        lblCategory = New Label()
        cmbCategory = New ComboBox()
        lblPrice = New Label()
        txtPrice = New TextBox()
        PictureBox1 = New PictureBox()
        lblQuantity = New Label()
        txtQuantity = New TextBox()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        dgvDisplay = New DataGridView()
        btnBrowse = New Button()
        Label5 = New Label()
        ofd = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDisplay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblProductName
        ' 
        lblProductName.AutoSize = True
        lblProductName.Font = New Font("Segoe UI", 12F)
        lblProductName.Location = New Point(138, 153)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(138, 28)
        lblProductName.TabIndex = 0
        lblProductName.Text = "Product Name"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(302, 153)
        txtProductName.Multiline = True
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(294, 37)
        txtProductName.TabIndex = 1
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 12F)
        lblCategory.Location = New Point(138, 225)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(92, 28)
        lblCategory.TabIndex = 2
        lblCategory.Text = "Category"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Shirt", "Bag", "Wallet"})
        cmbCategory.Location = New Point(302, 229)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(294, 28)
        cmbCategory.TabIndex = 4
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI", 12F)
        lblPrice.Location = New Point(138, 298)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(54, 28)
        lblPrice.TabIndex = 5
        lblPrice.Text = "Price"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(302, 298)
        txtPrice.Multiline = True
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(294, 37)
        txtPrice.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(302, 444)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(325, 178)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI", 12F)
        lblQuantity.Location = New Point(138, 379)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(88, 28)
        lblQuantity.TabIndex = 8
        lblQuantity.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(302, 383)
        txtQuantity.Multiline = True
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(294, 37)
        txtQuantity.TabIndex = 9
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(236, 709)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 49)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(379, 709)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(99, 49)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(530, 709)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(97, 49)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvDisplay
        ' 
        dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDisplay.Location = New Point(698, 153)
        dgvDisplay.Name = "dgvDisplay"
        dgvDisplay.RowHeadersWidth = 51
        dgvDisplay.Size = New Size(660, 433)
        dgvDisplay.TabIndex = 13
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(302, 644)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(294, 49)
        btnBrowse.TabIndex = 14
        btnBrowse.Text = "Browse..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 30F, FontStyle.Bold)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(419, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(514, 94)
        Label5.TabIndex = 15
        Label5.Text = "PRODUCT LIST"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ofd
        ' 
        ofd.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1409, 804)
        Controls.Add(Label5)
        Controls.Add(btnBrowse)
        Controls.Add(dgvDisplay)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(txtQuantity)
        Controls.Add(lblQuantity)
        Controls.Add(PictureBox1)
        Controls.Add(txtPrice)
        Controls.Add(lblPrice)
        Controls.Add(cmbCategory)
        Controls.Add(lblCategory)
        Controls.Add(txtProductName)
        Controls.Add(lblProductName)
        ForeColor = Color.Black
        Name = "Form1"
        Text = "Product List"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDisplay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblProductName As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvDisplay As DataGridView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ofd As OpenFileDialog

End Class
