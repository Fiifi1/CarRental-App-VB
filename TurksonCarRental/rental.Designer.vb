<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvRental = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxId = New System.Windows.Forms.TextBox()
        Me.dateExpiry = New System.Windows.Forms.DateTimePicker()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxIdType = New System.Windows.Forms.TextBox()
        Me.tbxIdNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.dateDue = New System.Windows.Forms.DateTimePicker()
        Me.datePickUp = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxModel = New System.Windows.Forms.TextBox()
        Me.tbxCarType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxNationaliy = New System.Windows.Forms.TextBox()
        Me.tbxSurname = New System.Windows.Forms.TextBox()
        Me.tbxFirstName = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dgvRental, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRental
        '
        Me.dgvRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRental.Location = New System.Drawing.Point(12, 53)
        Me.dgvRental.Name = "dgvRental"
        Me.dgvRental.RowTemplate.Height = 24
        Me.dgvRental.Size = New System.Drawing.Size(989, 695)
        Me.dgvRental.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID : "
        '
        'tbxId
        '
        Me.tbxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxId.Location = New System.Drawing.Point(118, 15)
        Me.tbxId.Name = "tbxId"
        Me.tbxId.ReadOnly = True
        Me.tbxId.Size = New System.Drawing.Size(82, 27)
        Me.tbxId.TabIndex = 2
        '
        'dateExpiry
        '
        Me.dateExpiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateExpiry.Location = New System.Drawing.Point(86, 324)
        Me.dateExpiry.Name = "dateExpiry"
        Me.dateExpiry.Size = New System.Drawing.Size(185, 27)
        Me.dateExpiry.TabIndex = 3
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAddRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRecord.Location = New System.Drawing.Point(1052, 695)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(122, 44)
        Me.btnAddRecord.TabIndex = 4
        Me.btnAddRecord.Text = "Create"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(6, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nationality :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(6, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Surname :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbxIdType)
        Me.GroupBox1.Controls.Add(Me.tbxIdNumber)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.numPrice)
        Me.GroupBox1.Controls.Add(Me.dateDue)
        Me.GroupBox1.Controls.Add(Me.datePickUp)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbxModel)
        Me.GroupBox1.Controls.Add(Me.tbxCarType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dateExpiry)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbxNationaliy)
        Me.GroupBox1.Controls.Add(Me.tbxSurname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbxFirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbxId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(1052, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 584)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'tbxIdType
        '
        Me.tbxIdType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxIdType.Location = New System.Drawing.Point(118, 224)
        Me.tbxIdType.Name = "tbxIdType"
        Me.tbxIdType.Size = New System.Drawing.Size(153, 27)
        Me.tbxIdType.TabIndex = 25
        '
        'tbxIdNumber
        '
        Me.tbxIdNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxIdNumber.Location = New System.Drawing.Point(124, 279)
        Me.tbxIdNumber.Name = "tbxIdNumber"
        Me.tbxIdNumber.Size = New System.Drawing.Size(147, 27)
        Me.tbxIdNumber.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(7, 279)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 24)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "ID Number :"
        '
        'numPrice
        '
        Me.numPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrice.Location = New System.Drawing.Point(86, 542)
        Me.numPrice.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numPrice.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(185, 27)
        Me.numPrice.TabIndex = 22
        Me.numPrice.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'dateDue
        '
        Me.dateDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDue.Location = New System.Drawing.Point(86, 499)
        Me.dateDue.Name = "dateDue"
        Me.dateDue.Size = New System.Drawing.Size(185, 27)
        Me.dateDue.TabIndex = 20
        '
        'datePickUp
        '
        Me.datePickUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickUp.Location = New System.Drawing.Point(86, 460)
        Me.datePickUp.Name = "datePickUp"
        Me.datePickUp.Size = New System.Drawing.Size(185, 27)
        Me.datePickUp.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(7, 460)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Start :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(7, 502)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Due :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(7, 545)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Price :"
        '
        'tbxModel
        '
        Me.tbxModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxModel.Location = New System.Drawing.Point(118, 413)
        Me.tbxModel.Name = "tbxModel"
        Me.tbxModel.Size = New System.Drawing.Size(153, 27)
        Me.tbxModel.TabIndex = 15
        '
        'tbxCarType
        '
        Me.tbxCarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCarType.Location = New System.Drawing.Point(118, 367)
        Me.tbxCarType.Name = "tbxCarType"
        Me.tbxCarType.Size = New System.Drawing.Size(153, 27)
        Me.tbxCarType.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(7, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Car Type :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(7, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Model :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(7, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Expiry :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(7, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ID Type :"
        '
        'tbxNationaliy
        '
        Me.tbxNationaliy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNationaliy.Location = New System.Drawing.Point(118, 172)
        Me.tbxNationaliy.Name = "tbxNationaliy"
        Me.tbxNationaliy.Size = New System.Drawing.Size(153, 27)
        Me.tbxNationaliy.TabIndex = 8
        '
        'tbxSurname
        '
        Me.tbxSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSurname.Location = New System.Drawing.Point(118, 120)
        Me.tbxSurname.Name = "tbxSurname"
        Me.tbxSurname.Size = New System.Drawing.Size(153, 27)
        Me.tbxSurname.TabIndex = 7
        '
        'tbxFirstName
        '
        Me.tbxFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxFirstName.Location = New System.Drawing.Point(118, 68)
        Me.tbxFirstName.Name = "tbxFirstName"
        Me.tbxFirstName.Size = New System.Drawing.Size(153, 27)
        Me.tbxFirstName.TabIndex = 6
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(1211, 695)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(122, 44)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.AutoSize = True
        Me.lblTotalRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblTotalRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecords.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalRecords.Location = New System.Drawing.Point(12, 751)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Size = New System.Drawing.Size(134, 24)
        Me.lblTotalRecords.TabIndex = 23
        Me.lblTotalRecords.Text = "Total Entries :  "
        '
        'tbxSearch
        '
        Me.tbxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSearch.Location = New System.Drawing.Point(741, 12)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(153, 27)
        Me.tbxSearch.TabIndex = 24
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(900, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 35)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1359, 807)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.tbxSearch)
        Me.Controls.Add(Me.lblTotalRecords)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.dgvRental)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "rental"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental"
        CType(Me.dgvRental, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRental As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxId As TextBox
    Friend WithEvents dateExpiry As DateTimePicker
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxModel As TextBox
    Friend WithEvents tbxCarType As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxNationaliy As TextBox
    Friend WithEvents tbxSurname As TextBox
    Friend WithEvents tbxFirstName As TextBox
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents dateDue As DateTimePicker
    Friend WithEvents datePickUp As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblTotalRecords As Label
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents tbxIdNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbxIdType As TextBox
End Class
