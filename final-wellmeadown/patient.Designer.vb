<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class patient
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
        Dim Patient_numberLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Date_of_birthLabel As System.Windows.Forms.Label
        Dim Marital_statusLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim Registeretion_dateLabel As System.Windows.Forms.Label
        Dim Nok_first_nameLabel As System.Windows.Forms.Label
        Dim Nok_last_nameLabel As System.Windows.Forms.Label
        Dim Nok_relationshipLabel As System.Windows.Forms.Label
        Dim Nok_addressLabel As System.Windows.Forms.Label
        Dim Nok_telephoneLabel As System.Windows.Forms.Label
        Dim Clinic_numberLabel As System.Windows.Forms.Label
        Dim First_nameLabel1 As System.Windows.Forms.Label
        Dim Last_nameLabel1 As System.Windows.Forms.Label
        Dim AddressLabel1 As System.Windows.Forms.Label
        Dim TelephoneLabel1 As System.Windows.Forms.Label
        Me._wellmeadown_finalDataSet = New final_wellmeadown._wellmeadown_finalDataSet()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.patientTableAdapter()
        Me.TableAdapterManager = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager()
        Me.Patient_numberTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Marital_statusTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.Registeretion_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Nok_first_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Nok_last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Nok_relationshipTextBox = New System.Windows.Forms.TextBox()
        Me.Nok_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Nok_telephoneTextBox = New System.Windows.Forms.TextBox()
        Me.Clinic_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Local_doctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._wellmeadown_finalDataSet1 = New final_wellmeadown._wellmeadown_finalDataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Local_doctorTableAdapter = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.local_doctorTableAdapter()
        Me.TableAdapterManager1 = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.First_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_vaccine_oder = New System.Windows.Forms.Button()
        Me.btn_suppiler = New System.Windows.Forms.Button()
        Me.btn_patient_medication = New System.Windows.Forms.Button()
        Me.btn_patient_appointment = New System.Windows.Forms.Button()
        Me.btn_patient_allocation = New System.Windows.Forms.Button()
        Me.btnd_staff_allocation = New System.Windows.Forms.Button()
        Me.btn_patient = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Patient_numberLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Date_of_birthLabel = New System.Windows.Forms.Label()
        Marital_statusLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        Registeretion_dateLabel = New System.Windows.Forms.Label()
        Nok_first_nameLabel = New System.Windows.Forms.Label()
        Nok_last_nameLabel = New System.Windows.Forms.Label()
        Nok_relationshipLabel = New System.Windows.Forms.Label()
        Nok_addressLabel = New System.Windows.Forms.Label()
        Nok_telephoneLabel = New System.Windows.Forms.Label()
        Clinic_numberLabel = New System.Windows.Forms.Label()
        First_nameLabel1 = New System.Windows.Forms.Label()
        Last_nameLabel1 = New System.Windows.Forms.Label()
        AddressLabel1 = New System.Windows.Forms.Label()
        TelephoneLabel1 = New System.Windows.Forms.Label()
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Local_doctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Patient_numberLabel
        '
        Patient_numberLabel.AutoSize = True
        Patient_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Patient_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_numberLabel.Location = New System.Drawing.Point(241, 116)
        Patient_numberLabel.Name = "Patient_numberLabel"
        Patient_numberLabel.Size = New System.Drawing.Size(108, 18)
        Patient_numberLabel.TabIndex = 1
        Patient_numberLabel.Text = "Patient number:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        First_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(241, 146)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(77, 18)
        First_nameLabel.TabIndex = 3
        First_nameLabel.Text = "First name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Last_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(756, 146)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(74, 18)
        Last_nameLabel.TabIndex = 5
        Last_nameLabel.Text = "Last name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.PapayaWhip
        GenderLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(241, 176)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(58, 18)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'Date_of_birthLabel
        '
        Date_of_birthLabel.AutoSize = True
        Date_of_birthLabel.BackColor = System.Drawing.Color.PapayaWhip
        Date_of_birthLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_birthLabel.Location = New System.Drawing.Point(756, 181)
        Date_of_birthLabel.Name = "Date_of_birthLabel"
        Date_of_birthLabel.Size = New System.Drawing.Size(90, 18)
        Date_of_birthLabel.TabIndex = 9
        Date_of_birthLabel.Text = "Date of birth:"
        '
        'Marital_statusLabel
        '
        Marital_statusLabel.AutoSize = True
        Marital_statusLabel.BackColor = System.Drawing.Color.PapayaWhip
        Marital_statusLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Marital_statusLabel.Location = New System.Drawing.Point(241, 206)
        Marital_statusLabel.Name = "Marital_statusLabel"
        Marital_statusLabel.Size = New System.Drawing.Size(96, 18)
        Marital_statusLabel.TabIndex = 11
        Marital_statusLabel.Text = "Marital status:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.PapayaWhip
        AddressLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(756, 210)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 18)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.BackColor = System.Drawing.Color.PapayaWhip
        TelephoneLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(241, 236)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(78, 18)
        TelephoneLabel.TabIndex = 15
        TelephoneLabel.Text = "Telephone:"
        '
        'Registeretion_dateLabel
        '
        Registeretion_dateLabel.AutoSize = True
        Registeretion_dateLabel.BackColor = System.Drawing.Color.PapayaWhip
        Registeretion_dateLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Registeretion_dateLabel.Location = New System.Drawing.Point(756, 116)
        Registeretion_dateLabel.Name = "Registeretion_dateLabel"
        Registeretion_dateLabel.Size = New System.Drawing.Size(126, 18)
        Registeretion_dateLabel.TabIndex = 17
        Registeretion_dateLabel.Text = "Registeretion date:"
        '
        'Nok_first_nameLabel
        '
        Nok_first_nameLabel.AutoSize = True
        Nok_first_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Nok_first_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nok_first_nameLabel.Location = New System.Drawing.Point(241, 352)
        Nok_first_nameLabel.Name = "Nok_first_nameLabel"
        Nok_first_nameLabel.Size = New System.Drawing.Size(77, 18)
        Nok_first_nameLabel.TabIndex = 19
        Nok_first_nameLabel.Text = "First name:"
        '
        'Nok_last_nameLabel
        '
        Nok_last_nameLabel.AutoSize = True
        Nok_last_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Nok_last_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nok_last_nameLabel.Location = New System.Drawing.Point(241, 382)
        Nok_last_nameLabel.Name = "Nok_last_nameLabel"
        Nok_last_nameLabel.Size = New System.Drawing.Size(74, 18)
        Nok_last_nameLabel.TabIndex = 21
        Nok_last_nameLabel.Text = "Last name:"
        '
        'Nok_relationshipLabel
        '
        Nok_relationshipLabel.AutoSize = True
        Nok_relationshipLabel.BackColor = System.Drawing.Color.PapayaWhip
        Nok_relationshipLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nok_relationshipLabel.Location = New System.Drawing.Point(240, 409)
        Nok_relationshipLabel.Name = "Nok_relationshipLabel"
        Nok_relationshipLabel.Size = New System.Drawing.Size(89, 18)
        Nok_relationshipLabel.TabIndex = 23
        Nok_relationshipLabel.Text = "Relationship:"
        '
        'Nok_addressLabel
        '
        Nok_addressLabel.AutoSize = True
        Nok_addressLabel.BackColor = System.Drawing.Color.PapayaWhip
        Nok_addressLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nok_addressLabel.Location = New System.Drawing.Point(241, 464)
        Nok_addressLabel.Name = "Nok_addressLabel"
        Nok_addressLabel.Size = New System.Drawing.Size(62, 18)
        Nok_addressLabel.TabIndex = 25
        Nok_addressLabel.Text = "Address:"
        AddHandler Nok_addressLabel.Click, AddressOf Me.Nok_addressLabel_Click
        '
        'Nok_telephoneLabel
        '
        Nok_telephoneLabel.AutoSize = True
        Nok_telephoneLabel.BackColor = System.Drawing.Color.PapayaWhip
        Nok_telephoneLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nok_telephoneLabel.Location = New System.Drawing.Point(240, 436)
        Nok_telephoneLabel.Name = "Nok_telephoneLabel"
        Nok_telephoneLabel.Size = New System.Drawing.Size(78, 18)
        Nok_telephoneLabel.TabIndex = 27
        Nok_telephoneLabel.Text = "Telephone:"
        '
        'Clinic_numberLabel
        '
        Clinic_numberLabel.AutoSize = True
        Clinic_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Clinic_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Clinic_numberLabel.Location = New System.Drawing.Point(756, 350)
        Clinic_numberLabel.Name = "Clinic_numberLabel"
        Clinic_numberLabel.Size = New System.Drawing.Size(100, 18)
        Clinic_numberLabel.TabIndex = 29
        Clinic_numberLabel.Text = "Clinic Number:"
        '
        'First_nameLabel1
        '
        First_nameLabel1.AutoSize = True
        First_nameLabel1.BackColor = System.Drawing.Color.PapayaWhip
        First_nameLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel1.Location = New System.Drawing.Point(758, 380)
        First_nameLabel1.Name = "First_nameLabel1"
        First_nameLabel1.Size = New System.Drawing.Size(77, 18)
        First_nameLabel1.TabIndex = 136
        First_nameLabel1.Text = "First name:"
        '
        'Last_nameLabel1
        '
        Last_nameLabel1.AutoSize = True
        Last_nameLabel1.BackColor = System.Drawing.Color.PapayaWhip
        Last_nameLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel1.Location = New System.Drawing.Point(758, 409)
        Last_nameLabel1.Name = "Last_nameLabel1"
        Last_nameLabel1.Size = New System.Drawing.Size(74, 18)
        Last_nameLabel1.TabIndex = 138
        Last_nameLabel1.Text = "Last name:"
        '
        'AddressLabel1
        '
        AddressLabel1.AutoSize = True
        AddressLabel1.BackColor = System.Drawing.Color.PapayaWhip
        AddressLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel1.Location = New System.Drawing.Point(758, 438)
        AddressLabel1.Name = "AddressLabel1"
        AddressLabel1.Size = New System.Drawing.Size(62, 18)
        AddressLabel1.TabIndex = 140
        AddressLabel1.Text = "Address:"
        '
        'TelephoneLabel1
        '
        TelephoneLabel1.AutoSize = True
        TelephoneLabel1.BackColor = System.Drawing.Color.PapayaWhip
        TelephoneLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel1.Location = New System.Drawing.Point(758, 467)
        TelephoneLabel1.Name = "TelephoneLabel1"
        TelephoneLabel1.Size = New System.Drawing.Size(78, 18)
        TelephoneLabel1.TabIndex = 142
        TelephoneLabel1.Text = "Telephone:"
        '
        '_wellmeadown_finalDataSet
        '
        Me._wellmeadown_finalDataSet.DataSetName = "_wellmeadown_finalDataSet"
        Me._wellmeadown_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.patientTableAdapter = Me.PatientTableAdapter
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
        'Patient_numberTextBox
        '
        Me.Patient_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patient_number", True))
        Me.Patient_numberTextBox.Location = New System.Drawing.Point(354, 113)
        Me.Patient_numberTextBox.Name = "Patient_numberTextBox"
        Me.Patient_numberTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Patient_numberTextBox.TabIndex = 2
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(354, 143)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(233, 23)
        Me.First_nameTextBox.TabIndex = 4
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(871, 143)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Last_nameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(354, 173)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(233, 23)
        Me.GenderTextBox.TabIndex = 8
        '
        'Date_of_birthDateTimePicker
        '
        Me.Date_of_birthDateTimePicker.CustomFormat = "MM-dd-yyyy"
        Me.Date_of_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "date_of_birth", True))
        Me.Date_of_birthDateTimePicker.Location = New System.Drawing.Point(869, 176)
        Me.Date_of_birthDateTimePicker.Name = "Date_of_birthDateTimePicker"
        Me.Date_of_birthDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.Date_of_birthDateTimePicker.TabIndex = 10
        '
        'Marital_statusTextBox
        '
        Me.Marital_statusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "marital_status", True))
        Me.Marital_statusTextBox.Location = New System.Drawing.Point(354, 203)
        Me.Marital_statusTextBox.Name = "Marital_statusTextBox"
        Me.Marital_statusTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Marital_statusTextBox.TabIndex = 12
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(869, 206)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(233, 23)
        Me.AddressTextBox.TabIndex = 14
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(354, 233)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(233, 23)
        Me.TelephoneTextBox.TabIndex = 16
        '
        'Registeretion_dateDateTimePicker
        '
        Me.Registeretion_dateDateTimePicker.CustomFormat = "MM-dd-yyyy"
        Me.Registeretion_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "registeretion_date", True))
        Me.Registeretion_dateDateTimePicker.Location = New System.Drawing.Point(886, 112)
        Me.Registeretion_dateDateTimePicker.Name = "Registeretion_dateDateTimePicker"
        Me.Registeretion_dateDateTimePicker.Size = New System.Drawing.Size(217, 23)
        Me.Registeretion_dateDateTimePicker.TabIndex = 18
        '
        'Nok_first_nameTextBox
        '
        Me.Nok_first_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "nok_first_name", True))
        Me.Nok_first_nameTextBox.Location = New System.Drawing.Point(354, 348)
        Me.Nok_first_nameTextBox.Name = "Nok_first_nameTextBox"
        Me.Nok_first_nameTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Nok_first_nameTextBox.TabIndex = 20
        '
        'Nok_last_nameTextBox
        '
        Me.Nok_last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "nok_last_name", True))
        Me.Nok_last_nameTextBox.Location = New System.Drawing.Point(354, 377)
        Me.Nok_last_nameTextBox.Name = "Nok_last_nameTextBox"
        Me.Nok_last_nameTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Nok_last_nameTextBox.TabIndex = 22
        '
        'Nok_relationshipTextBox
        '
        Me.Nok_relationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "nok_relationship", True))
        Me.Nok_relationshipTextBox.Location = New System.Drawing.Point(354, 406)
        Me.Nok_relationshipTextBox.Name = "Nok_relationshipTextBox"
        Me.Nok_relationshipTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Nok_relationshipTextBox.TabIndex = 24
        '
        'Nok_addressTextBox
        '
        Me.Nok_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "nok_address", True))
        Me.Nok_addressTextBox.Location = New System.Drawing.Point(354, 464)
        Me.Nok_addressTextBox.Name = "Nok_addressTextBox"
        Me.Nok_addressTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Nok_addressTextBox.TabIndex = 26
        '
        'Nok_telephoneTextBox
        '
        Me.Nok_telephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "nok_telephone", True))
        Me.Nok_telephoneTextBox.Location = New System.Drawing.Point(354, 435)
        Me.Nok_telephoneTextBox.Name = "Nok_telephoneTextBox"
        Me.Nok_telephoneTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Nok_telephoneTextBox.TabIndex = 28
        '
        'Clinic_numberTextBox
        '
        Me.Clinic_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "clinic_number", True))
        Me.Clinic_numberTextBox.Location = New System.Drawing.Point(869, 347)
        Me.Clinic_numberTextBox.Name = "Clinic_numberTextBox"
        Me.Clinic_numberTextBox.Size = New System.Drawing.Size(233, 23)
        Me.Clinic_numberTextBox.TabIndex = 30
        '
        'Local_doctorBindingSource
        '
        Me.Local_doctorBindingSource.DataMember = "local_doctor"
        Me.Local_doctorBindingSource.DataSource = Me._wellmeadown_finalDataSet1
        '
        '_wellmeadown_finalDataSet1
        '
        Me._wellmeadown_finalDataSet1.DataSetName = "_wellmeadown_finalDataSet1"
        Me._wellmeadown_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Patient Detail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 25)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Next-of-kin Detail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(756, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 25)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Local Doctor Detail"
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_select.Location = New System.Drawing.Point(909, 27)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(94, 28)
        Me.btn_select.TabIndex = 131
        Me.btn_select.Text = "Search"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add.Location = New System.Drawing.Point(1009, 27)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(94, 28)
        Me.btn_add.TabIndex = 130
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Local_doctorTableAdapter
        '
        Me.Local_doctorTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager1.local_doctorTableAdapter = Me.Local_doctorTableAdapter
        Me.TableAdapterManager1.m_patient_allocationTableAdapter = Nothing
        Me.TableAdapterManager1.m_patient_medicationTableAdapter = Nothing
        Me.TableAdapterManager1.m_requisitionTableAdapter = Nothing
        Me.TableAdapterManager1.m_ward_staff_allocationTableAdapter = Nothing
        Me.TableAdapterManager1.OrdererTableAdapter = Nothing
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
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(810, 523)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 26)
        Me.btn_save.TabIndex = 134
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(910, 523)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(94, 26)
        Me.btn_edit.TabIndex = 133
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(1010, 523)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(94, 26)
        Me.btn_delete.TabIndex = 132
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'First_nameTextBox1
        '
        Me.First_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_doctorBindingSource, "first_name", True))
        Me.First_nameTextBox1.Location = New System.Drawing.Point(869, 376)
        Me.First_nameTextBox1.Name = "First_nameTextBox1"
        Me.First_nameTextBox1.Size = New System.Drawing.Size(233, 23)
        Me.First_nameTextBox1.TabIndex = 137
        '
        'Last_nameTextBox1
        '
        Me.Last_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_doctorBindingSource, "last_name", True))
        Me.Last_nameTextBox1.Location = New System.Drawing.Point(869, 405)
        Me.Last_nameTextBox1.Name = "Last_nameTextBox1"
        Me.Last_nameTextBox1.Size = New System.Drawing.Size(233, 23)
        Me.Last_nameTextBox1.TabIndex = 139
        '
        'AddressTextBox1
        '
        Me.AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_doctorBindingSource, "address", True))
        Me.AddressTextBox1.Location = New System.Drawing.Point(869, 434)
        Me.AddressTextBox1.Name = "AddressTextBox1"
        Me.AddressTextBox1.Size = New System.Drawing.Size(233, 23)
        Me.AddressTextBox1.TabIndex = 141
        '
        'TelephoneTextBox1
        '
        Me.TelephoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_doctorBindingSource, "telephone", True))
        Me.TelephoneTextBox1.Location = New System.Drawing.Point(869, 463)
        Me.TelephoneTextBox1.Name = "TelephoneTextBox1"
        Me.TelephoneTextBox1.Size = New System.Drawing.Size(233, 23)
        Me.TelephoneTextBox1.TabIndex = 143
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(-1, 590)
        Me.Button13.Name = "Button13"
        Me.Button13.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button13.Size = New System.Drawing.Size(158, 36)
        Me.Button13.TabIndex = 144
        Me.Button13.Text = "Logout"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button13.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(1, 525)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_logout.Size = New System.Drawing.Size(158, 36)
        Me.btn_logout.TabIndex = 153
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_vaccine_oder
        '
        Me.btn_vaccine_oder.BackColor = System.Drawing.Color.White
        Me.btn_vaccine_oder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_vaccine_oder.FlatAppearance.BorderSize = 0
        Me.btn_vaccine_oder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vaccine_oder.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vaccine_oder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vaccine_oder.Location = New System.Drawing.Point(1, 410)
        Me.btn_vaccine_oder.Name = "btn_vaccine_oder"
        Me.btn_vaccine_oder.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_vaccine_oder.Size = New System.Drawing.Size(158, 36)
        Me.btn_vaccine_oder.TabIndex = 152
        Me.btn_vaccine_oder.Text = "Vaccine Oder"
        Me.btn_vaccine_oder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vaccine_oder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_vaccine_oder.UseVisualStyleBackColor = False
        '
        'btn_suppiler
        '
        Me.btn_suppiler.BackColor = System.Drawing.Color.White
        Me.btn_suppiler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suppiler.FlatAppearance.BorderSize = 0
        Me.btn_suppiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suppiler.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suppiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppiler.Location = New System.Drawing.Point(1, 374)
        Me.btn_suppiler.Name = "btn_suppiler"
        Me.btn_suppiler.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_suppiler.Size = New System.Drawing.Size(158, 36)
        Me.btn_suppiler.TabIndex = 151
        Me.btn_suppiler.Text = "Suppiler"
        Me.btn_suppiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_suppiler.UseVisualStyleBackColor = False
        '
        'btn_patient_medication
        '
        Me.btn_patient_medication.BackColor = System.Drawing.Color.White
        Me.btn_patient_medication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_medication.FlatAppearance.BorderSize = 0
        Me.btn_patient_medication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_medication.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_medication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_medication.Location = New System.Drawing.Point(1, 338)
        Me.btn_patient_medication.Name = "btn_patient_medication"
        Me.btn_patient_medication.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_medication.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_medication.TabIndex = 150
        Me.btn_patient_medication.Text = "Patient Medication"
        Me.btn_patient_medication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_medication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient_medication.UseVisualStyleBackColor = False
        '
        'btn_patient_appointment
        '
        Me.btn_patient_appointment.BackColor = System.Drawing.Color.White
        Me.btn_patient_appointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_appointment.FlatAppearance.BorderSize = 0
        Me.btn_patient_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_appointment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_appointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_appointment.Location = New System.Drawing.Point(1, 266)
        Me.btn_patient_appointment.Name = "btn_patient_appointment"
        Me.btn_patient_appointment.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_appointment.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_appointment.TabIndex = 149
        Me.btn_patient_appointment.Text = "Patient Appointment"
        Me.btn_patient_appointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_appointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient_appointment.UseVisualStyleBackColor = False
        '
        'btn_patient_allocation
        '
        Me.btn_patient_allocation.BackColor = System.Drawing.Color.White
        Me.btn_patient_allocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_allocation.FlatAppearance.BorderSize = 0
        Me.btn_patient_allocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_allocation.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_allocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_allocation.Location = New System.Drawing.Point(1, 302)
        Me.btn_patient_allocation.Name = "btn_patient_allocation"
        Me.btn_patient_allocation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_allocation.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_allocation.TabIndex = 148
        Me.btn_patient_allocation.Text = "Patient Allocation"
        Me.btn_patient_allocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_allocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient_allocation.UseVisualStyleBackColor = False
        '
        'btnd_staff_allocation
        '
        Me.btnd_staff_allocation.BackColor = System.Drawing.Color.White
        Me.btnd_staff_allocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnd_staff_allocation.FlatAppearance.BorderSize = 0
        Me.btnd_staff_allocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnd_staff_allocation.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnd_staff_allocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnd_staff_allocation.Location = New System.Drawing.Point(1, 194)
        Me.btnd_staff_allocation.Name = "btnd_staff_allocation"
        Me.btnd_staff_allocation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnd_staff_allocation.Size = New System.Drawing.Size(158, 36)
        Me.btnd_staff_allocation.TabIndex = 147
        Me.btnd_staff_allocation.Text = "Staff Allocation"
        Me.btnd_staff_allocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnd_staff_allocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnd_staff_allocation.UseVisualStyleBackColor = False
        '
        'btn_patient
        '
        Me.btn_patient.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_patient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient.FlatAppearance.BorderSize = 0
        Me.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.Location = New System.Drawing.Point(1, 230)
        Me.btn_patient.Name = "btn_patient"
        Me.btn_patient.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient.TabIndex = 146
        Me.btn_patient.Text = "Patient"
        Me.btn_patient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.White
        Me.btn_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_staff.FlatAppearance.BorderSize = 0
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_staff.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.Location = New System.Drawing.Point(1, 158)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_staff.Size = New System.Drawing.Size(158, 36)
        Me.btn_staff.TabIndex = 145
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1010, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 24)
        Me.Button1.TabIndex = 154
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.final_wellmeadown.My.Resources.Resources.Well__1__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 129
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Local_doctorBindingSource, "last_name", True))
        Me.PictureBox1.Location = New System.Drawing.Point(159, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1038, 628)
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_vaccine_oder)
        Me.Controls.Add(Me.btn_suppiler)
        Me.Controls.Add(Me.btn_patient_medication)
        Me.Controls.Add(Me.btn_patient_appointment)
        Me.Controls.Add(Me.btn_patient_allocation)
        Me.Controls.Add(Me.btnd_staff_allocation)
        Me.Controls.Add(Me.btn_patient)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(First_nameLabel1)
        Me.Controls.Add(Me.First_nameTextBox1)
        Me.Controls.Add(Last_nameLabel1)
        Me.Controls.Add(Me.Last_nameTextBox1)
        Me.Controls.Add(AddressLabel1)
        Me.Controls.Add(Me.AddressTextBox1)
        Me.Controls.Add(TelephoneLabel1)
        Me.Controls.Add(Me.TelephoneTextBox1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Patient_numberLabel)
        Me.Controls.Add(Me.Patient_numberTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Date_of_birthLabel)
        Me.Controls.Add(Me.Date_of_birthDateTimePicker)
        Me.Controls.Add(Marital_statusLabel)
        Me.Controls.Add(Me.Marital_statusTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(Registeretion_dateLabel)
        Me.Controls.Add(Me.Registeretion_dateDateTimePicker)
        Me.Controls.Add(Nok_first_nameLabel)
        Me.Controls.Add(Me.Nok_first_nameTextBox)
        Me.Controls.Add(Nok_last_nameLabel)
        Me.Controls.Add(Me.Nok_last_nameTextBox)
        Me.Controls.Add(Nok_relationshipLabel)
        Me.Controls.Add(Me.Nok_relationshipTextBox)
        Me.Controls.Add(Nok_addressLabel)
        Me.Controls.Add(Me.Nok_addressTextBox)
        Me.Controls.Add(Nok_telephoneLabel)
        Me.Controls.Add(Me.Nok_telephoneTextBox)
        Me.Controls.Add(Clinic_numberLabel)
        Me.Controls.Add(Me.Clinic_numberTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "patient"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Local_doctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _wellmeadown_finalDataSet As _wellmeadown_finalDataSet
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As _wellmeadown_finalDataSetTableAdapters.patientTableAdapter
    Friend WithEvents TableAdapterManager As _wellmeadown_finalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patient_numberTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents Date_of_birthDateTimePicker As DateTimePicker
    Friend WithEvents Marital_statusTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents Registeretion_dateDateTimePicker As DateTimePicker
    Friend WithEvents Nok_first_nameTextBox As TextBox
    Friend WithEvents Nok_last_nameTextBox As TextBox
    Friend WithEvents Nok_relationshipTextBox As TextBox
    Friend WithEvents Nok_addressTextBox As TextBox
    Friend WithEvents Nok_telephoneTextBox As TextBox
    Friend WithEvents Clinic_numberTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_select As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents _wellmeadown_finalDataSet1 As _wellmeadown_finalDataSet1
    Friend WithEvents Local_doctorBindingSource As BindingSource
    Friend WithEvents Local_doctorTableAdapter As _wellmeadown_finalDataSet1TableAdapters.local_doctorTableAdapter
    Friend WithEvents TableAdapterManager1 As _wellmeadown_finalDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents First_nameTextBox1 As TextBox
    Friend WithEvents Last_nameTextBox1 As TextBox
    Friend WithEvents AddressTextBox1 As TextBox
    Friend WithEvents TelephoneTextBox1 As TextBox
    Friend WithEvents Button13 As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_vaccine_oder As Button
    Friend WithEvents btn_suppiler As Button
    Friend WithEvents btn_patient_medication As Button
    Friend WithEvents btn_patient_appointment As Button
    Friend WithEvents btn_patient_allocation As Button
    Friend WithEvents btnd_staff_allocation As Button
    Friend WithEvents btn_patient As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents Button1 As Button
End Class
