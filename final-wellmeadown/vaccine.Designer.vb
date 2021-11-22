<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vaccine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Order_idLabel As System.Windows.Forms.Label
        Dim Id_cardLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim Vaccine_nameLabel As System.Windows.Forms.Label
        Dim DosesLabel As System.Windows.Forms.Label
        Dim Date_of_birthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me._wellmeadown_finalDataSet = New final_wellmeadown._wellmeadown_finalDataSet()
        Me.OrdererBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdererTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.OrdererTableAdapter()
        Me.TableAdapterManager = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager()
        Me.Order_idTextBox = New System.Windows.Forms.TextBox()
        Me.Id_cardTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.DosesTextBox = New System.Windows.Forms.TextBox()
        Me._wellmeadown_finalDataSet1 = New final_wellmeadown._wellmeadown_finalDataSet1()
        Me.OrdererBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdererTableAdapter1 = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.OrdererTableAdapter()
        Me.TableAdapterManager1 = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager()
        Me.Date_of_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.VaccineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VaccineTableAdapter = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.vaccineTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Order_idLabel = New System.Windows.Forms.Label()
        Id_cardLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        Vaccine_nameLabel = New System.Windows.Forms.Label()
        DosesLabel = New System.Windows.Forms.Label()
        Date_of_birthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdererBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdererBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VaccineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_idLabel
        '
        Order_idLabel.AutoSize = True
        Order_idLabel.BackColor = System.Drawing.Color.White
        Order_idLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_idLabel.Location = New System.Drawing.Point(258, 188)
        Order_idLabel.Name = "Order_idLabel"
        Order_idLabel.Size = New System.Drawing.Size(100, 18)
        Order_idLabel.TabIndex = 1
        Order_idLabel.Text = "Order number:"
        '
        'Id_cardLabel
        '
        Id_cardLabel.AutoSize = True
        Id_cardLabel.BackColor = System.Drawing.Color.White
        Id_cardLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_cardLabel.Location = New System.Drawing.Point(637, 188)
        Id_cardLabel.Name = "Id_cardLabel"
        Id_cardLabel.Size = New System.Drawing.Size(53, 18)
        Id_cardLabel.TabIndex = 3
        Id_cardLabel.Text = "Id card:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.BackColor = System.Drawing.Color.White
        First_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(258, 217)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(77, 18)
        First_nameLabel.TabIndex = 5
        First_nameLabel.Text = "First name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.BackColor = System.Drawing.Color.White
        Last_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(637, 217)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(74, 18)
        Last_nameLabel.TabIndex = 7
        Last_nameLabel.Text = "Last name:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.BackColor = System.Drawing.Color.White
        TelephoneLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(637, 269)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(78, 18)
        TelephoneLabel.TabIndex = 9
        TelephoneLabel.Text = "Telephone:"
        '
        'Vaccine_nameLabel
        '
        Vaccine_nameLabel.AutoSize = True
        Vaccine_nameLabel.BackColor = System.Drawing.Color.White
        Vaccine_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vaccine_nameLabel.Location = New System.Drawing.Point(258, 328)
        Vaccine_nameLabel.Name = "Vaccine_nameLabel"
        Vaccine_nameLabel.Size = New System.Drawing.Size(97, 18)
        Vaccine_nameLabel.TabIndex = 11
        Vaccine_nameLabel.Text = "Vaccine name:"
        '
        'DosesLabel
        '
        DosesLabel.AutoSize = True
        DosesLabel.BackColor = System.Drawing.Color.White
        DosesLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DosesLabel.Location = New System.Drawing.Point(640, 325)
        DosesLabel.Name = "DosesLabel"
        DosesLabel.Size = New System.Drawing.Size(49, 18)
        DosesLabel.TabIndex = 13
        DosesLabel.Text = "Doses:"
        '
        'Date_of_birthLabel
        '
        Date_of_birthLabel.AutoSize = True
        Date_of_birthLabel.BackColor = System.Drawing.Color.White
        Date_of_birthLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_birthLabel.Location = New System.Drawing.Point(260, 244)
        Date_of_birthLabel.Name = "Date_of_birthLabel"
        Date_of_birthLabel.Size = New System.Drawing.Size(90, 18)
        Date_of_birthLabel.TabIndex = 15
        Date_of_birthLabel.Text = "Date of birth:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.White
        GenderLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(637, 246)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(58, 18)
        GenderLabel.TabIndex = 17
        GenderLabel.Text = "Gender:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.White
        AddressLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(260, 269)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 18)
        AddressLabel.TabIndex = 19
        AddressLabel.Text = "Address:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.PapayaWhip
        Label1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(477, 72)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(289, 45)
        Label1.TabIndex = 123
        Label1.Text = "Vaccination Order"
        '
        '_wellmeadown_finalDataSet
        '
        Me._wellmeadown_finalDataSet.DataSetName = "_wellmeadown_finalDataSet"
        Me._wellmeadown_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdererBindingSource
        '
        Me.OrdererBindingSource.DataMember = "Orderer"
        Me.OrdererBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'OrdererTableAdapter
        '
        Me.OrdererTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bedTableAdapter = Nothing
        Me.TableAdapterManager.d_patient_allocationTableAdapter = Nothing
        Me.TableAdapterManager.d_patient_medicationTableAdapter = Nothing
        Me.TableAdapterManager.d_requisitionTableAdapter = Nothing
        Me.TableAdapterManager.d_ward_staff_allocationTableAdapter = Nothing
        Me.TableAdapterManager.inventoryTableAdapter = Nothing
        Me.TableAdapterManager.local_doctorTableAdapter = Nothing
        Me.TableAdapterManager.m_patient_allocationTableAdapter = Nothing
        Me.TableAdapterManager.m_patient_medicationTableAdapter = Nothing
        Me.TableAdapterManager.m_requisitionTableAdapter = Nothing
        Me.TableAdapterManager.m_ward_staff_allocationTableAdapter = Nothing
        Me.TableAdapterManager.OrdererTableAdapter = Me.OrdererTableAdapter
        Me.TableAdapterManager.orderTableAdapter = Nothing
        Me.TableAdapterManager.patient_appointmentTableAdapter = Nothing
        Me.TableAdapterManager.patientTableAdapter = Nothing
        Me.TableAdapterManager.receivedTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.StockTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vaccine_orderTableAdapter = Nothing
        Me.TableAdapterManager.vaccine_receivedTableAdapter = Nothing
        Me.TableAdapterManager.vaccineTableAdapter = Nothing
        Me.TableAdapterManager.wardTableAdapter = Nothing
        '
        'Order_idTextBox
        '
        Me.Order_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdererBindingSource, "order_id", True))
        Me.Order_idTextBox.Location = New System.Drawing.Point(364, 188)
        Me.Order_idTextBox.Name = "Order_idTextBox"
        Me.Order_idTextBox.Size = New System.Drawing.Size(235, 21)
        Me.Order_idTextBox.TabIndex = 2
        '
        'Id_cardTextBox
        '
        Me.Id_cardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdererBindingSource, "id_card", True))
        Me.Id_cardTextBox.Location = New System.Drawing.Point(721, 188)
        Me.Id_cardTextBox.Name = "Id_cardTextBox"
        Me.Id_cardTextBox.Size = New System.Drawing.Size(235, 21)
        Me.Id_cardTextBox.TabIndex = 4
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdererBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(364, 218)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(235, 21)
        Me.First_nameTextBox.TabIndex = 6
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdererBindingSource, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(721, 218)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(235, 21)
        Me.Last_nameTextBox.TabIndex = 8
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdererBindingSource, "telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(721, 270)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(235, 21)
        Me.TelephoneTextBox.TabIndex = 10
        '
        'DosesTextBox
        '
        Me.DosesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdererBindingSource, "doses", True))
        Me.DosesTextBox.Location = New System.Drawing.Point(721, 325)
        Me.DosesTextBox.Name = "DosesTextBox"
        Me.DosesTextBox.Size = New System.Drawing.Size(235, 21)
        Me.DosesTextBox.TabIndex = 14
        '
        '_wellmeadown_finalDataSet1
        '
        Me._wellmeadown_finalDataSet1.DataSetName = "_wellmeadown_finalDataSet1"
        Me._wellmeadown_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdererBindingSource1
        '
        Me.OrdererBindingSource1.DataMember = "Orderer"
        Me.OrdererBindingSource1.DataSource = Me._wellmeadown_finalDataSet1
        '
        'OrdererTableAdapter1
        '
        Me.OrdererTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.bedTableAdapter = Nothing
        Me.TableAdapterManager1.d_patient_allocationTableAdapter = Nothing
        Me.TableAdapterManager1.d_patient_medicationTableAdapter = Nothing
        Me.TableAdapterManager1.d_requisitionTableAdapter = Nothing
        Me.TableAdapterManager1.d_ward_staff_allocationTableAdapter = Nothing
        Me.TableAdapterManager1.inventoryTableAdapter = Nothing
        Me.TableAdapterManager1.local_doctorTableAdapter = Nothing
        Me.TableAdapterManager1.m_patient_allocationTableAdapter = Nothing
        Me.TableAdapterManager1.m_patient_medicationTableAdapter = Nothing
        Me.TableAdapterManager1.m_requisitionTableAdapter = Nothing
        Me.TableAdapterManager1.m_ward_staff_allocationTableAdapter = Nothing
        Me.TableAdapterManager1.OrdererTableAdapter = Me.OrdererTableAdapter1
        Me.TableAdapterManager1.orderTableAdapter = Nothing
        Me.TableAdapterManager1.patient_appointmentTableAdapter = Nothing
        Me.TableAdapterManager1.patientTableAdapter = Nothing
        Me.TableAdapterManager1.receivedTableAdapter = Nothing
        Me.TableAdapterManager1.staffTableAdapter = Nothing
        Me.TableAdapterManager1.StockTableAdapter = Nothing
        Me.TableAdapterManager1.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.vaccine_orderTableAdapter = Nothing
        Me.TableAdapterManager1.vaccine_receivedTableAdapter = Nothing
        Me.TableAdapterManager1.vaccineTableAdapter = Nothing
        Me.TableAdapterManager1.wardTableAdapter = Nothing
        '
        'Date_of_birthDateTimePicker
        '
        Me.Date_of_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdererBindingSource1, "date_of_birth", True))
        Me.Date_of_birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_of_birthDateTimePicker.Location = New System.Drawing.Point(364, 244)
        Me.Date_of_birthDateTimePicker.Name = "Date_of_birthDateTimePicker"
        Me.Date_of_birthDateTimePicker.Size = New System.Drawing.Size(235, 21)
        Me.Date_of_birthDateTimePicker.TabIndex = 16
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdererBindingSource1, "gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(721, 245)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(235, 21)
        Me.GenderTextBox.TabIndex = 18
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdererBindingSource1, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(364, 270)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(235, 21)
        Me.AddressTextBox.TabIndex = 20
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(469, 413)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 22
        Me.btn_save.Text = "save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_back.Location = New System.Drawing.Point(550, 413)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 23
        Me.btn_back.Text = "back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_check
        '
        Me.btn_check.BackColor = System.Drawing.Color.White
        Me.btn_check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_check.Location = New System.Drawing.Point(631, 413)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(156, 23)
        Me.btn_check.TabIndex = 24
        Me.btn_check.Text = "check status"
        Me.btn_check.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PictureBox2.Location = New System.Drawing.Point(0, 271)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1194, 300)
        Me.PictureBox2.TabIndex = 121
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.VaccineBindingSource, "vaccine_name", True))
        Me.PictureBox3.Location = New System.Drawing.Point(239, 94)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(741, 379)
        Me.PictureBox3.TabIndex = 122
        Me.PictureBox3.TabStop = False
        '
        'VaccineBindingSource
        '
        Me.VaccineBindingSource.DataMember = "vaccine"
        Me.VaccineBindingSource.DataSource = Me._wellmeadown_finalDataSet1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(451, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 76)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'VaccineTableAdapter
        '
        Me.VaccineTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(86, 21)
        Me.DateTimePicker1.TabIndex = 127
        Me.DateTimePicker1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 128
        Me.TextBox1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(364, 325)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox1.TabIndex = 129
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(0, 31)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(86, 21)
        Me.DateTimePicker2.TabIndex = 130
        Me.DateTimePicker2.Visible = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(0, 58)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(86, 21)
        Me.DateTimePicker3.TabIndex = 131
        Me.DateTimePicker3.Visible = False
        '
        'vaccine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Date_of_birthLabel)
        Me.Controls.Add(Me.Date_of_birthDateTimePicker)
        Me.Controls.Add(Order_idLabel)
        Me.Controls.Add(Me.Order_idTextBox)
        Me.Controls.Add(Id_cardLabel)
        Me.Controls.Add(Me.Id_cardTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(Vaccine_nameLabel)
        Me.Controls.Add(DosesLabel)
        Me.Controls.Add(Me.DosesTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "vaccine"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdererBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdererBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VaccineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _wellmeadown_finalDataSet As _wellmeadown_finalDataSet
    Friend WithEvents OrdererBindingSource As BindingSource
    Friend WithEvents OrdererTableAdapter As _wellmeadown_finalDataSetTableAdapters.OrdererTableAdapter
    Friend WithEvents TableAdapterManager As _wellmeadown_finalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_idTextBox As TextBox
    Friend WithEvents Id_cardTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents DosesTextBox As TextBox
    Friend WithEvents _wellmeadown_finalDataSet1 As _wellmeadown_finalDataSet1
    Friend WithEvents OrdererBindingSource1 As BindingSource
    Friend WithEvents OrdererTableAdapter1 As _wellmeadown_finalDataSet1TableAdapters.OrdererTableAdapter
    Friend WithEvents TableAdapterManager1 As _wellmeadown_finalDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Date_of_birthDateTimePicker As DateTimePicker
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_check As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VaccineBindingSource As BindingSource
    Friend WithEvents VaccineTableAdapter As _wellmeadown_finalDataSet1TableAdapters.vaccineTableAdapter
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
End Class
