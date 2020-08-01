<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cars
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
        Me.dgvCars = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxStatus = New System.Windows.Forms.TextBox()
        Me.tbxColor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxModelName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxYear = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxRegistration = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.btnUpdateCar = New System.Windows.Forms.Button()
        Me.btnDeleteCar = New System.Windows.Forms.Button()
        Me.lblTotalCars = New System.Windows.Forms.Label()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dgvCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCars
        '
        Me.dgvCars.AllowUserToAddRows = False
        Me.dgvCars.AllowUserToDeleteRows = False
        Me.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCars.Location = New System.Drawing.Point(12, 54)
        Me.dgvCars.Name = "dgvCars"
        Me.dgvCars.RowTemplate.Height = 24
        Me.dgvCars.Size = New System.Drawing.Size(750, 520)
        Me.dgvCars.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbxStatus)
        Me.GroupBox1.Controls.Add(Me.tbxColor)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbxModelName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbxType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbxYear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbxRegistration)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbxID)
        Me.GroupBox1.Location = New System.Drawing.Point(804, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 400)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'tbxStatus
        '
        Me.tbxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxStatus.Location = New System.Drawing.Point(151, 344)
        Me.tbxStatus.Name = "tbxStatus"
        Me.tbxStatus.Size = New System.Drawing.Size(168, 27)
        Me.tbxStatus.TabIndex = 17
        '
        'tbxColor
        '
        Me.tbxColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxColor.Location = New System.Drawing.Point(151, 297)
        Me.tbxColor.Name = "tbxColor"
        Me.tbxColor.Size = New System.Drawing.Size(168, 27)
        Me.tbxColor.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Status :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Model Name :"
        '
        'tbxModelName
        '
        Me.tbxModelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxModelName.Location = New System.Drawing.Point(151, 80)
        Me.tbxModelName.Name = "tbxModelName"
        Me.tbxModelName.Size = New System.Drawing.Size(161, 27)
        Me.tbxModelName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Type :"
        '
        'tbxType
        '
        Me.tbxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxType.Location = New System.Drawing.Point(151, 136)
        Me.tbxType.Name = "tbxType"
        Me.tbxType.Size = New System.Drawing.Size(168, 27)
        Me.tbxType.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Year :"
        '
        'tbxYear
        '
        Me.tbxYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxYear.Location = New System.Drawing.Point(151, 185)
        Me.tbxYear.Name = "tbxYear"
        Me.tbxYear.Size = New System.Drawing.Size(168, 27)
        Me.tbxYear.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Registration :"
        '
        'tbxRegistration
        '
        Me.tbxRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRegistration.Location = New System.Drawing.Point(151, 240)
        Me.tbxRegistration.Name = "tbxRegistration"
        Me.tbxRegistration.Size = New System.Drawing.Size(168, 27)
        Me.tbxRegistration.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Colour :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID :"
        '
        'tbxID
        '
        Me.tbxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxID.Location = New System.Drawing.Point(151, 21)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.ReadOnly = True
        Me.tbxID.Size = New System.Drawing.Size(100, 27)
        Me.tbxID.TabIndex = 0
        '
        'btnAddCar
        '
        Me.btnAddCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddCar.Location = New System.Drawing.Point(784, 476)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(93, 40)
        Me.btnAddCar.TabIndex = 2
        Me.btnAddCar.Text = "Add"
        Me.btnAddCar.UseVisualStyleBackColor = False
        '
        'btnUpdateCar
        '
        Me.btnUpdateCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnUpdateCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateCar.Location = New System.Drawing.Point(896, 476)
        Me.btnUpdateCar.Name = "btnUpdateCar"
        Me.btnUpdateCar.Size = New System.Drawing.Size(99, 40)
        Me.btnUpdateCar.TabIndex = 3
        Me.btnUpdateCar.Text = "Update"
        Me.btnUpdateCar.UseVisualStyleBackColor = False
        '
        'btnDeleteCar
        '
        Me.btnDeleteCar.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnDeleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeleteCar.Location = New System.Drawing.Point(1010, 476)
        Me.btnDeleteCar.Name = "btnDeleteCar"
        Me.btnDeleteCar.Size = New System.Drawing.Size(106, 40)
        Me.btnDeleteCar.TabIndex = 4
        Me.btnDeleteCar.Text = "Remove"
        Me.btnDeleteCar.UseVisualStyleBackColor = False
        '
        'lblTotalCars
        '
        Me.lblTotalCars.AutoSize = True
        Me.lblTotalCars.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTotalCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCars.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalCars.Location = New System.Drawing.Point(12, 577)
        Me.lblTotalCars.Name = "lblTotalCars"
        Me.lblTotalCars.Size = New System.Drawing.Size(66, 24)
        Me.lblTotalCars.TabIndex = 16
        Me.lblTotalCars.Text = "Total : "
        '
        'tbxSearch
        '
        Me.tbxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSearch.Location = New System.Drawing.Point(495, 19)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(168, 27)
        Me.tbxSearch.TabIndex = 18
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(669, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 32)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1141, 692)
        Me.Controls.Add(Me.tbxSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblTotalCars)
        Me.Controls.Add(Me.btnDeleteCar)
        Me.Controls.Add(Me.btnUpdateCar)
        Me.Controls.Add(Me.btnAddCar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvCars)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "cars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Cars"
        CType(Me.dgvCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCars As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxModelName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxType As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxYear As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxRegistration As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddCar As Button
    Friend WithEvents btnUpdateCar As Button
    Friend WithEvents btnDeleteCar As Button
    Friend WithEvents lblTotalCars As Label
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents tbxStatus As TextBox
    Friend WithEvents tbxColor As TextBox
End Class
