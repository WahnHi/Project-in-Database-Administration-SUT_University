<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staff
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
        Dim Staff_numberLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Date_of_birthLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim NinLabel As System.Windows.Forms.Label
        Dim Current_salaryLabel As System.Windows.Forms.Label
        Dim Salary_scaleLabel As System.Windows.Forms.Label
        Dim Painweekly_or_monthlyLabel As System.Windows.Forms.Label
        Dim Permanent_or_temporaryLabel As System.Windows.Forms.Label
        Dim Qft_typeLabel As System.Windows.Forms.Label
        Dim Qft_dateLabel As System.Windows.Forms.Label
        Dim Qft_institutionLabel As System.Windows.Forms.Label
        Dim Wex_positionLabel As System.Windows.Forms.Label
        Dim Wex_start_dateLabel As System.Windows.Forms.Label
        Dim Wex_finish_dateLabel As System.Windows.Forms.Label
        Dim Wex_organization_Label As System.Windows.Forms.Label
        Me._wellmeadown_finalDataSet = New final_wellmeadown._wellmeadown_finalDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.staffTableAdapter()
        Me.TableAdapterManager = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager()
        Me.Staff_numberTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.NinTextBox = New System.Windows.Forms.TextBox()
        Me.Current_salaryTextBox = New System.Windows.Forms.TextBox()
        Me.Salary_scaleTextBox = New System.Windows.Forms.TextBox()
        Me.Painweekly_or_monthlyTextBox = New System.Windows.Forms.TextBox()
        Me.Permanent_or_temporaryTextBox = New System.Windows.Forms.TextBox()
        Me.Qft_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Qft_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Qft_institutionTextBox = New System.Windows.Forms.TextBox()
        Me.Wex_positionTextBox = New System.Windows.Forms.TextBox()
        Me.Wex_start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Wex_finish_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Wex_organization_TextBox = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.btn_patient = New System.Windows.Forms.Button()
        Me.btnd_staff_allocation = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_patient_appointment = New System.Windows.Forms.Button()
        Me.btn_patient_medication = New System.Windows.Forms.Button()
        Me.btn_suppiler = New System.Windows.Forms.Button()
        Me.btn_vaccine_oder = New System.Windows.Forms.Button()
        Me.btn_patient_allocation = New System.Windows.Forms.Button()
        Staff_numberLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Date_of_birthLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        NinLabel = New System.Windows.Forms.Label()
        Current_salaryLabel = New System.Windows.Forms.Label()
        Salary_scaleLabel = New System.Windows.Forms.Label()
        Painweekly_or_monthlyLabel = New System.Windows.Forms.Label()
        Permanent_or_temporaryLabel = New System.Windows.Forms.Label()
        Qft_typeLabel = New System.Windows.Forms.Label()
        Qft_dateLabel = New System.Windows.Forms.Label()
        Qft_institutionLabel = New System.Windows.Forms.Label()
        Wex_positionLabel = New System.Windows.Forms.Label()
        Wex_start_dateLabel = New System.Windows.Forms.Label()
        Wex_finish_dateLabel = New System.Windows.Forms.Label()
        Wex_organization_Label = New System.Windows.Forms.Label()
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_numberLabel
        '
        Staff_numberLabel.AutoSize = True
        Staff_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Staff_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_numberLabel.Location = New System.Drawing.Point(232, 104)
        Staff_numberLabel.Name = "Staff_numberLabel"
        Staff_numberLabel.Size = New System.Drawing.Size(94, 18)
        Staff_numberLabel.TabIndex = 1
        Staff_numberLabel.Text = "Staff Number:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        First_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(232, 130)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(79, 18)
        First_nameLabel.TabIndex = 3
        First_nameLabel.Text = "First Name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Last_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(778, 125)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(76, 18)
        Last_nameLabel.TabIndex = 5
        Last_nameLabel.Text = "Last Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.PapayaWhip
        GenderLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(232, 156)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(58, 18)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.BackColor = System.Drawing.Color.PapayaWhip
        TelephoneLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(778, 151)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(78, 18)
        TelephoneLabel.TabIndex = 9
        TelephoneLabel.Text = "Telephone:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.PapayaWhip
        AddressLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(232, 182)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 18)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'Date_of_birthLabel
        '
        Date_of_birthLabel.AutoSize = True
        Date_of_birthLabel.BackColor = System.Drawing.Color.PapayaWhip
        Date_of_birthLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_birthLabel.Location = New System.Drawing.Point(778, 178)
        Date_of_birthLabel.Name = "Date_of_birthLabel"
        Date_of_birthLabel.Size = New System.Drawing.Size(90, 18)
        Date_of_birthLabel.TabIndex = 13
        Date_of_birthLabel.Text = "Date of birth:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.BackColor = System.Drawing.Color.PapayaWhip
        PositionLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.Location = New System.Drawing.Point(232, 208)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(62, 18)
        PositionLabel.TabIndex = 15
        PositionLabel.Text = "Position:"
        '
        'NinLabel
        '
        NinLabel.AutoSize = True
        NinLabel.BackColor = System.Drawing.Color.PapayaWhip
        NinLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NinLabel.Location = New System.Drawing.Point(778, 203)
        NinLabel.Name = "NinLabel"
        NinLabel.Size = New System.Drawing.Size(36, 18)
        NinLabel.TabIndex = 17
        NinLabel.Text = "NIN:"
        '
        'Current_salaryLabel
        '
        Current_salaryLabel.AutoSize = True
        Current_salaryLabel.BackColor = System.Drawing.Color.PapayaWhip
        Current_salaryLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Current_salaryLabel.Location = New System.Drawing.Point(232, 234)
        Current_salaryLabel.Name = "Current_salaryLabel"
        Current_salaryLabel.Size = New System.Drawing.Size(98, 18)
        Current_salaryLabel.TabIndex = 19
        Current_salaryLabel.Text = "Current salary:"
        '
        'Salary_scaleLabel
        '
        Salary_scaleLabel.AutoSize = True
        Salary_scaleLabel.BackColor = System.Drawing.Color.PapayaWhip
        Salary_scaleLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Salary_scaleLabel.Location = New System.Drawing.Point(778, 232)
        Salary_scaleLabel.Name = "Salary_scaleLabel"
        Salary_scaleLabel.Size = New System.Drawing.Size(83, 18)
        Salary_scaleLabel.TabIndex = 21
        Salary_scaleLabel.Text = "Salary scale:"
        '
        'Painweekly_or_monthlyLabel
        '
        Painweekly_or_monthlyLabel.AutoSize = True
        Painweekly_or_monthlyLabel.BackColor = System.Drawing.Color.PapayaWhip
        Painweekly_or_monthlyLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Painweekly_or_monthlyLabel.Location = New System.Drawing.Point(232, 260)
        Painweekly_or_monthlyLabel.Name = "Painweekly_or_monthlyLabel"
        Painweekly_or_monthlyLabel.Size = New System.Drawing.Size(155, 18)
        Painweekly_or_monthlyLabel.TabIndex = 23
        Painweekly_or_monthlyLabel.Text = "Painweekly or Monthly:"
        '
        'Permanent_or_temporaryLabel
        '
        Permanent_or_temporaryLabel.AutoSize = True
        Permanent_or_temporaryLabel.BackColor = System.Drawing.Color.PapayaWhip
        Permanent_or_temporaryLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Permanent_or_temporaryLabel.Location = New System.Drawing.Point(778, 257)
        Permanent_or_temporaryLabel.Name = "Permanent_or_temporaryLabel"
        Permanent_or_temporaryLabel.Size = New System.Drawing.Size(166, 18)
        Permanent_or_temporaryLabel.TabIndex = 25
        Permanent_or_temporaryLabel.Text = "Permanent or Temporary:"
        '
        'Qft_typeLabel
        '
        Qft_typeLabel.AutoSize = True
        Qft_typeLabel.BackColor = System.Drawing.Color.PapayaWhip
        Qft_typeLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Qft_typeLabel.Location = New System.Drawing.Point(232, 398)
        Qft_typeLabel.Name = "Qft_typeLabel"
        Qft_typeLabel.Size = New System.Drawing.Size(41, 18)
        Qft_typeLabel.TabIndex = 27
        Qft_typeLabel.Text = "Type:"
        '
        'Qft_dateLabel
        '
        Qft_dateLabel.AutoSize = True
        Qft_dateLabel.BackColor = System.Drawing.Color.PapayaWhip
        Qft_dateLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Qft_dateLabel.Location = New System.Drawing.Point(232, 452)
        Qft_dateLabel.Name = "Qft_dateLabel"
        Qft_dateLabel.Size = New System.Drawing.Size(41, 18)
        Qft_dateLabel.TabIndex = 29
        Qft_dateLabel.Text = "Date:"
        '
        'Qft_institutionLabel
        '
        Qft_institutionLabel.AutoSize = True
        Qft_institutionLabel.BackColor = System.Drawing.Color.PapayaWhip
        Qft_institutionLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Qft_institutionLabel.Location = New System.Drawing.Point(232, 424)
        Qft_institutionLabel.Name = "Qft_institutionLabel"
        Qft_institutionLabel.Size = New System.Drawing.Size(75, 18)
        Qft_institutionLabel.TabIndex = 31
        Qft_institutionLabel.Text = "Institution:"
        '
        'Wex_positionLabel
        '
        Wex_positionLabel.AutoSize = True
        Wex_positionLabel.BackColor = System.Drawing.Color.PapayaWhip
        Wex_positionLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wex_positionLabel.Location = New System.Drawing.Point(778, 394)
        Wex_positionLabel.Name = "Wex_positionLabel"
        Wex_positionLabel.Size = New System.Drawing.Size(62, 18)
        Wex_positionLabel.TabIndex = 33
        Wex_positionLabel.Text = "Position:"
        '
        'Wex_start_dateLabel
        '
        Wex_start_dateLabel.AutoSize = True
        Wex_start_dateLabel.BackColor = System.Drawing.Color.PapayaWhip
        Wex_start_dateLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wex_start_dateLabel.Location = New System.Drawing.Point(778, 421)
        Wex_start_dateLabel.Name = "Wex_start_dateLabel"
        Wex_start_dateLabel.Size = New System.Drawing.Size(72, 18)
        Wex_start_dateLabel.TabIndex = 35
        Wex_start_dateLabel.Text = "Start date:"
        '
        'Wex_finish_dateLabel
        '
        Wex_finish_dateLabel.AutoSize = True
        Wex_finish_dateLabel.BackColor = System.Drawing.Color.PapayaWhip
        Wex_finish_dateLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wex_finish_dateLabel.Location = New System.Drawing.Point(778, 445)
        Wex_finish_dateLabel.Name = "Wex_finish_dateLabel"
        Wex_finish_dateLabel.Size = New System.Drawing.Size(80, 18)
        Wex_finish_dateLabel.TabIndex = 37
        Wex_finish_dateLabel.Text = "Finish date:"
        '
        'Wex_organization_Label
        '
        Wex_organization_Label.AutoSize = True
        Wex_organization_Label.BackColor = System.Drawing.Color.PapayaWhip
        Wex_organization_Label.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wex_organization_Label.Location = New System.Drawing.Point(778, 473)
        Wex_organization_Label.Name = "Wex_organization_Label"
        Wex_organization_Label.Size = New System.Drawing.Size(93, 18)
        Wex_organization_Label.TabIndex = 39
        Wex_organization_Label.Text = "Organization :"
        '
        '_wellmeadown_finalDataSet
        '
        Me._wellmeadown_finalDataSet.DataSetName = "_wellmeadown_finalDataSet"
        Me._wellmeadown_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.OrdererTableAdapter = Nothing
        Me.TableAdapterManager.orderTableAdapter = Nothing
        Me.TableAdapterManager.patient_appointmentTableAdapter = Nothing
        Me.TableAdapterManager.patientTableAdapter = Nothing
        Me.TableAdapterManager.receivedTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.StockTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vaccine_orderTableAdapter = Nothing
        Me.TableAdapterManager.vaccine_receivedTableAdapter = Nothing
        Me.TableAdapterManager.vaccineTableAdapter = Nothing
        Me.TableAdapterManager.wardTableAdapter = Nothing
        '
        'Staff_numberTextBox
        '
        Me.Staff_numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Staff_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "staff_number", True))
        Me.Staff_numberTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_numberTextBox.Location = New System.Drawing.Point(359, 101)
        Me.Staff_numberTextBox.Name = "Staff_numberTextBox"
        Me.Staff_numberTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Staff_numberTextBox.TabIndex = 2
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "first_name", True))
        Me.First_nameTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_nameTextBox.Location = New System.Drawing.Point(359, 127)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.First_nameTextBox.TabIndex = 4
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "last_name", True))
        Me.Last_nameTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(905, 122)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Last_nameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(359, 153)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 23)
        Me.GenderTextBox.TabIndex = 8
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "telephone", True))
        Me.TelephoneTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(905, 148)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(200, 23)
        Me.TelephoneTextBox.TabIndex = 10
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(359, 179)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 23)
        Me.AddressTextBox.TabIndex = 12
        '
        'Date_of_birthDateTimePicker
        '
        Me.Date_of_birthDateTimePicker.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "date_of_birth", True))
        Me.Date_of_birthDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_of_birthDateTimePicker.Location = New System.Drawing.Point(905, 174)
        Me.Date_of_birthDateTimePicker.Name = "Date_of_birthDateTimePicker"
        Me.Date_of_birthDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Date_of_birthDateTimePicker.TabIndex = 14
        '
        'PositionTextBox
        '
        Me.PositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(359, 205)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 23)
        Me.PositionTextBox.TabIndex = 16
        '
        'NinTextBox
        '
        Me.NinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "nin", True))
        Me.NinTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NinTextBox.Location = New System.Drawing.Point(905, 200)
        Me.NinTextBox.Name = "NinTextBox"
        Me.NinTextBox.Size = New System.Drawing.Size(200, 23)
        Me.NinTextBox.TabIndex = 18
        '
        'Current_salaryTextBox
        '
        Me.Current_salaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Current_salaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "current_salary", True))
        Me.Current_salaryTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_salaryTextBox.Location = New System.Drawing.Point(359, 231)
        Me.Current_salaryTextBox.Name = "Current_salaryTextBox"
        Me.Current_salaryTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Current_salaryTextBox.TabIndex = 20
        '
        'Salary_scaleTextBox
        '
        Me.Salary_scaleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Salary_scaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "salary_scale", True))
        Me.Salary_scaleTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salary_scaleTextBox.Location = New System.Drawing.Point(905, 227)
        Me.Salary_scaleTextBox.Name = "Salary_scaleTextBox"
        Me.Salary_scaleTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Salary_scaleTextBox.TabIndex = 22
        '
        'Painweekly_or_monthlyTextBox
        '
        Me.Painweekly_or_monthlyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Painweekly_or_monthlyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "painweekly_or_monthly", True))
        Me.Painweekly_or_monthlyTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Painweekly_or_monthlyTextBox.Location = New System.Drawing.Point(393, 257)
        Me.Painweekly_or_monthlyTextBox.Name = "Painweekly_or_monthlyTextBox"
        Me.Painweekly_or_monthlyTextBox.Size = New System.Drawing.Size(166, 23)
        Me.Painweekly_or_monthlyTextBox.TabIndex = 24
        '
        'Permanent_or_temporaryTextBox
        '
        Me.Permanent_or_temporaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Permanent_or_temporaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "permanent_or_temporary", True))
        Me.Permanent_or_temporaryTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Permanent_or_temporaryTextBox.Location = New System.Drawing.Point(949, 255)
        Me.Permanent_or_temporaryTextBox.Name = "Permanent_or_temporaryTextBox"
        Me.Permanent_or_temporaryTextBox.Size = New System.Drawing.Size(156, 23)
        Me.Permanent_or_temporaryTextBox.TabIndex = 26
        '
        'Qft_typeTextBox
        '
        Me.Qft_typeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Qft_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "qft_type", True))
        Me.Qft_typeTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qft_typeTextBox.Location = New System.Drawing.Point(359, 395)
        Me.Qft_typeTextBox.Name = "Qft_typeTextBox"
        Me.Qft_typeTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Qft_typeTextBox.TabIndex = 28
        '
        'Qft_dateDateTimePicker
        '
        Me.Qft_dateDateTimePicker.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qft_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "qft_date", True))
        Me.Qft_dateDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qft_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Qft_dateDateTimePicker.Location = New System.Drawing.Point(359, 448)
        Me.Qft_dateDateTimePicker.Name = "Qft_dateDateTimePicker"
        Me.Qft_dateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Qft_dateDateTimePicker.TabIndex = 30
        '
        'Qft_institutionTextBox
        '
        Me.Qft_institutionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Qft_institutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "qft_institution", True))
        Me.Qft_institutionTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qft_institutionTextBox.Location = New System.Drawing.Point(359, 421)
        Me.Qft_institutionTextBox.Name = "Qft_institutionTextBox"
        Me.Qft_institutionTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Qft_institutionTextBox.TabIndex = 32
        '
        'Wex_positionTextBox
        '
        Me.Wex_positionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Wex_positionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "wex_position", True))
        Me.Wex_positionTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wex_positionTextBox.Location = New System.Drawing.Point(905, 391)
        Me.Wex_positionTextBox.Name = "Wex_positionTextBox"
        Me.Wex_positionTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Wex_positionTextBox.TabIndex = 34
        '
        'Wex_start_dateDateTimePicker
        '
        Me.Wex_start_dateDateTimePicker.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wex_start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "wex_start_date", True))
        Me.Wex_start_dateDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wex_start_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Wex_start_dateDateTimePicker.Location = New System.Drawing.Point(905, 417)
        Me.Wex_start_dateDateTimePicker.Name = "Wex_start_dateDateTimePicker"
        Me.Wex_start_dateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Wex_start_dateDateTimePicker.TabIndex = 36
        '
        'Wex_finish_dateDateTimePicker
        '
        Me.Wex_finish_dateDateTimePicker.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wex_finish_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "wex_finish_date", True))
        Me.Wex_finish_dateDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wex_finish_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Wex_finish_dateDateTimePicker.Location = New System.Drawing.Point(905, 441)
        Me.Wex_finish_dateDateTimePicker.Name = "Wex_finish_dateDateTimePicker"
        Me.Wex_finish_dateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Wex_finish_dateDateTimePicker.TabIndex = 38
        '
        'Wex_organization_TextBox
        '
        Me.Wex_organization_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Wex_organization_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "wex_organization ", True))
        Me.Wex_organization_TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wex_organization_TextBox.Location = New System.Drawing.Point(905, 470)
        Me.Wex_organization_TextBox.Name = "Wex_organization_TextBox"
        Me.Wex_organization_TextBox.Size = New System.Drawing.Size(200, 23)
        Me.Wex_organization_TextBox.TabIndex = 40
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add.Location = New System.Drawing.Point(1011, 28)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(94, 28)
        Me.btn_add.TabIndex = 45
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(1011, 519)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(94, 26)
        Me.btn_delete.TabIndex = 47
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(911, 519)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(94, 26)
        Me.btn_edit.TabIndex = 48
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(811, 519)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 26)
        Me.btn_save.TabIndex = 66
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(0, 519)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_logout.Size = New System.Drawing.Size(158, 36)
        Me.btn_logout.TabIndex = 121
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 25)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Personnal Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 25)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Qualification(s) Detail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(775, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 25)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Work Experience Detail"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.final_wellmeadown.My.Resources.Resources.Well__1__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(9, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.Location = New System.Drawing.Point(158, -11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1040, 661)
        Me.PictureBox1.TabIndex = 125
        Me.PictureBox1.TabStop = False
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_select.Location = New System.Drawing.Point(911, 28)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(94, 28)
        Me.btn_select.TabIndex = 126
        Me.btn_select.Text = "Search"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'btn_patient
        '
        Me.btn_patient.BackColor = System.Drawing.Color.White
        Me.btn_patient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient.FlatAppearance.BorderSize = 0
        Me.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.Location = New System.Drawing.Point(0, 224)
        Me.btn_patient.Name = "btn_patient"
        Me.btn_patient.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient.TabIndex = 51
        Me.btn_patient.Text = "Patient"
        Me.btn_patient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient.UseVisualStyleBackColor = False
        '
        'btnd_staff_allocation
        '
        Me.btnd_staff_allocation.BackColor = System.Drawing.Color.White
        Me.btnd_staff_allocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnd_staff_allocation.FlatAppearance.BorderSize = 0
        Me.btnd_staff_allocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnd_staff_allocation.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnd_staff_allocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnd_staff_allocation.Location = New System.Drawing.Point(0, 188)
        Me.btnd_staff_allocation.Name = "btnd_staff_allocation"
        Me.btnd_staff_allocation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnd_staff_allocation.Size = New System.Drawing.Size(158, 36)
        Me.btnd_staff_allocation.TabIndex = 52
        Me.btnd_staff_allocation.Text = "Staff Allocation"
        Me.btnd_staff_allocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnd_staff_allocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnd_staff_allocation.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_staff.FlatAppearance.BorderSize = 0
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_staff.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.Location = New System.Drawing.Point(0, 152)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_staff.Size = New System.Drawing.Size(158, 36)
        Me.btn_staff.TabIndex = 50
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_patient_appointment
        '
        Me.btn_patient_appointment.BackColor = System.Drawing.Color.White
        Me.btn_patient_appointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_appointment.FlatAppearance.BorderSize = 0
        Me.btn_patient_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_appointment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_appointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_appointment.Location = New System.Drawing.Point(0, 260)
        Me.btn_patient_appointment.Name = "btn_patient_appointment"
        Me.btn_patient_appointment.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_appointment.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_appointment.TabIndex = 70
        Me.btn_patient_appointment.Text = "Patient Appointment"
        Me.btn_patient_appointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_appointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient_appointment.UseVisualStyleBackColor = False
        '
        'btn_patient_medication
        '
        Me.btn_patient_medication.BackColor = System.Drawing.Color.White
        Me.btn_patient_medication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_medication.FlatAppearance.BorderSize = 0
        Me.btn_patient_medication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_medication.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_medication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_medication.Location = New System.Drawing.Point(0, 332)
        Me.btn_patient_medication.Name = "btn_patient_medication"
        Me.btn_patient_medication.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_medication.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_medication.TabIndex = 71
        Me.btn_patient_medication.Text = "Patient Medication"
        Me.btn_patient_medication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_medication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient_medication.UseVisualStyleBackColor = False
        '
        'btn_suppiler
        '
        Me.btn_suppiler.BackColor = System.Drawing.Color.White
        Me.btn_suppiler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suppiler.FlatAppearance.BorderSize = 0
        Me.btn_suppiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suppiler.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suppiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppiler.Location = New System.Drawing.Point(0, 368)
        Me.btn_suppiler.Name = "btn_suppiler"
        Me.btn_suppiler.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_suppiler.Size = New System.Drawing.Size(158, 36)
        Me.btn_suppiler.TabIndex = 72
        Me.btn_suppiler.Text = "Suppiler"
        Me.btn_suppiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_suppiler.UseVisualStyleBackColor = False
        '
        'btn_vaccine_oder
        '
        Me.btn_vaccine_oder.BackColor = System.Drawing.Color.White
        Me.btn_vaccine_oder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_vaccine_oder.FlatAppearance.BorderSize = 0
        Me.btn_vaccine_oder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vaccine_oder.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vaccine_oder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vaccine_oder.Location = New System.Drawing.Point(0, 404)
        Me.btn_vaccine_oder.Name = "btn_vaccine_oder"
        Me.btn_vaccine_oder.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_vaccine_oder.Size = New System.Drawing.Size(158, 36)
        Me.btn_vaccine_oder.TabIndex = 73
        Me.btn_vaccine_oder.Text = "Vaccine Oder"
        Me.btn_vaccine_oder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vaccine_oder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_vaccine_oder.UseVisualStyleBackColor = False
        '
        'btn_patient_allocation
        '
        Me.btn_patient_allocation.BackColor = System.Drawing.Color.White
        Me.btn_patient_allocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_allocation.FlatAppearance.BorderSize = 0
        Me.btn_patient_allocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_allocation.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_allocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_allocation.Location = New System.Drawing.Point(0, 296)
        Me.btn_patient_allocation.Name = "btn_patient_allocation"
        Me.btn_patient_allocation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_allocation.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_allocation.TabIndex = 69
        Me.btn_patient_allocation.Text = "Patient Allocation"
        Me.btn_patient_allocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_allocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient_allocation.UseVisualStyleBackColor = False
        '
        'staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_vaccine_oder)
        Me.Controls.Add(Me.btn_suppiler)
        Me.Controls.Add(Me.btn_patient_medication)
        Me.Controls.Add(Me.btn_patient_appointment)
        Me.Controls.Add(Me.btn_patient_allocation)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btnd_staff_allocation)
        Me.Controls.Add(Me.btn_patient)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Staff_numberLabel)
        Me.Controls.Add(Me.Staff_numberTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Date_of_birthLabel)
        Me.Controls.Add(Me.Date_of_birthDateTimePicker)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(NinLabel)
        Me.Controls.Add(Me.NinTextBox)
        Me.Controls.Add(Current_salaryLabel)
        Me.Controls.Add(Me.Current_salaryTextBox)
        Me.Controls.Add(Salary_scaleLabel)
        Me.Controls.Add(Me.Salary_scaleTextBox)
        Me.Controls.Add(Painweekly_or_monthlyLabel)
        Me.Controls.Add(Me.Painweekly_or_monthlyTextBox)
        Me.Controls.Add(Permanent_or_temporaryLabel)
        Me.Controls.Add(Me.Permanent_or_temporaryTextBox)
        Me.Controls.Add(Qft_typeLabel)
        Me.Controls.Add(Me.Qft_typeTextBox)
        Me.Controls.Add(Qft_dateLabel)
        Me.Controls.Add(Me.Qft_dateDateTimePicker)
        Me.Controls.Add(Qft_institutionLabel)
        Me.Controls.Add(Me.Qft_institutionTextBox)
        Me.Controls.Add(Wex_positionLabel)
        Me.Controls.Add(Me.Wex_positionTextBox)
        Me.Controls.Add(Wex_start_dateLabel)
        Me.Controls.Add(Me.Wex_start_dateDateTimePicker)
        Me.Controls.Add(Wex_finish_dateLabel)
        Me.Controls.Add(Me.Wex_finish_dateDateTimePicker)
        Me.Controls.Add(Wex_organization_Label)
        Me.Controls.Add(Me.Wex_organization_TextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "staff"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _wellmeadown_finalDataSet As _wellmeadown_finalDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As _wellmeadown_finalDataSetTableAdapters.staffTableAdapter
    Friend WithEvents TableAdapterManager As _wellmeadown_finalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Staff_numberTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Date_of_birthDateTimePicker As DateTimePicker
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents NinTextBox As TextBox
    Friend WithEvents Current_salaryTextBox As TextBox
    Friend WithEvents Salary_scaleTextBox As TextBox
    Friend WithEvents Painweekly_or_monthlyTextBox As TextBox
    Friend WithEvents Permanent_or_temporaryTextBox As TextBox
    Friend WithEvents Qft_typeTextBox As TextBox
    Friend WithEvents Qft_dateDateTimePicker As DateTimePicker
    Friend WithEvents Qft_institutionTextBox As TextBox
    Friend WithEvents Wex_positionTextBox As TextBox
    Friend WithEvents Wex_start_dateDateTimePicker As DateTimePicker
    Friend WithEvents Wex_finish_dateDateTimePicker As DateTimePicker
    Friend WithEvents Wex_organization_TextBox As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_select As Button
    Friend WithEvents btn_patient As Button
    Friend WithEvents btnd_staff_allocation As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_patient_appointment As Button
    Friend WithEvents btn_patient_medication As Button
    Friend WithEvents btn_suppiler As Button
    Friend WithEvents btn_vaccine_oder As Button
    Friend WithEvents btn_patient_allocation As Button
End Class
