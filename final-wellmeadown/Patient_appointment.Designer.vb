<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_appointment
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
        Me.components = New System.ComponentModel.Container()
        Dim Appointment_numberLabel As System.Windows.Forms.Label
        Dim Cause_of_appointmentLabel As System.Windows.Forms.Label
        Dim Patient_numberLabel As System.Windows.Forms.Label
        Dim Staff_numberLabel As System.Windows.Forms.Label
        Dim Ward_numberLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Date_of_birthLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Ward_nameLabel As System.Windows.Forms.Label
        Me._wellmeadown_finalDataSet = New final_wellmeadown._wellmeadown_finalDataSet()
        Me.Patient_appointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_appointmentTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.patient_appointmentTableAdapter()
        Me.TableAdapterManager = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager()
        Me.PatientTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.patientTableAdapter()
        Me.WardTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.wardTableAdapter()
        Me.Appointment_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Cause_of_appointmentTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Ward_numberTextBox = New System.Windows.Forms.TextBox()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.textsearchp = New System.Windows.Forms.Button()
        Me.textsearchw = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_vaccine_oder = New System.Windows.Forms.Button()
        Me.btn_suppiler = New System.Windows.Forms.Button()
        Me.btn_patient_medication = New System.Windows.Forms.Button()
        Me.btn_patient_appointment = New System.Windows.Forms.Button()
        Me.btn_patient_allocation = New System.Windows.Forms.Button()
        Me.btnd_staff_allocation = New System.Windows.Forms.Button()
        Me.btn_patient = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._wellmeadown_finalDataSet1 = New final_wellmeadown._wellmeadown_finalDataSet1()
        Me.WardBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardTableAdapter1 = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.wardTableAdapter()
        Me.TableAdapterManager1 = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager()
        Me.Ward_nameTextBox = New System.Windows.Forms.TextBox()
        Appointment_numberLabel = New System.Windows.Forms.Label()
        Cause_of_appointmentLabel = New System.Windows.Forms.Label()
        Patient_numberLabel = New System.Windows.Forms.Label()
        Staff_numberLabel = New System.Windows.Forms.Label()
        Ward_numberLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Date_of_birthLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Ward_nameLabel = New System.Windows.Forms.Label()
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_appointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Appointment_numberLabel
        '
        Appointment_numberLabel.AutoSize = True
        Appointment_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Appointment_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appointment_numberLabel.Location = New System.Drawing.Point(733, 117)
        Appointment_numberLabel.Name = "Appointment_numberLabel"
        Appointment_numberLabel.Size = New System.Drawing.Size(147, 18)
        Appointment_numberLabel.TabIndex = 1
        Appointment_numberLabel.Text = "Appointment number:"
        '
        'Cause_of_appointmentLabel
        '
        Cause_of_appointmentLabel.AutoSize = True
        Cause_of_appointmentLabel.BackColor = System.Drawing.Color.PapayaWhip
        Cause_of_appointmentLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cause_of_appointmentLabel.Location = New System.Drawing.Point(189, 302)
        Cause_of_appointmentLabel.Name = "Cause_of_appointmentLabel"
        Cause_of_appointmentLabel.Size = New System.Drawing.Size(149, 18)
        Cause_of_appointmentLabel.TabIndex = 3
        Cause_of_appointmentLabel.Text = "Cause of appointment:"
        '
        'Patient_numberLabel
        '
        Patient_numberLabel.AutoSize = True
        Patient_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Patient_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_numberLabel.Location = New System.Drawing.Point(189, 161)
        Patient_numberLabel.Name = "Patient_numberLabel"
        Patient_numberLabel.Size = New System.Drawing.Size(108, 18)
        Patient_numberLabel.TabIndex = 5
        Patient_numberLabel.Text = "Patient number:"
        '
        'Staff_numberLabel
        '
        Staff_numberLabel.AutoSize = True
        Staff_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Staff_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_numberLabel.Location = New System.Drawing.Point(829, 481)
        Staff_numberLabel.Name = "Staff_numberLabel"
        Staff_numberLabel.Size = New System.Drawing.Size(49, 18)
        Staff_numberLabel.TabIndex = 7
        Staff_numberLabel.Text = "Issuer:"
        '
        'Ward_numberLabel
        '
        Ward_numberLabel.AutoSize = True
        Ward_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Ward_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ward_numberLabel.Location = New System.Drawing.Point(189, 240)
        Ward_numberLabel.Name = "Ward_numberLabel"
        Ward_numberLabel.Size = New System.Drawing.Size(96, 18)
        Ward_numberLabel.TabIndex = 9
        Ward_numberLabel.Text = "Ward number:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        First_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(189, 187)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(77, 18)
        First_nameLabel.TabIndex = 11
        First_nameLabel.Text = "First name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Last_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(797, 186)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(74, 18)
        Last_nameLabel.TabIndex = 13
        Last_nameLabel.Text = "Last name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.PapayaWhip
        GenderLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(797, 212)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(58, 18)
        GenderLabel.TabIndex = 15
        GenderLabel.Text = "Gender:"
        '
        'Date_of_birthLabel
        '
        Date_of_birthLabel.AutoSize = True
        Date_of_birthLabel.BackColor = System.Drawing.Color.PapayaWhip
        Date_of_birthLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_birthLabel.Location = New System.Drawing.Point(189, 215)
        Date_of_birthLabel.Name = "Date_of_birthLabel"
        Date_of_birthLabel.Size = New System.Drawing.Size(90, 18)
        Date_of_birthLabel.TabIndex = 17
        Date_of_birthLabel.Text = "Date of birth:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.PapayaWhip
        LocationLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(189, 266)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(63, 18)
        LocationLabel.TabIndex = 19
        LocationLabel.Text = "Location:"
        '
        '_wellmeadown_finalDataSet
        '
        Me._wellmeadown_finalDataSet.DataSetName = "_wellmeadown_finalDataSet"
        Me._wellmeadown_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Patient_appointmentBindingSource
        '
        Me.Patient_appointmentBindingSource.DataMember = "patient_appointment"
        Me.Patient_appointmentBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'Patient_appointmentTableAdapter
        '
        Me.Patient_appointmentTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.patient_appointmentTableAdapter = Me.Patient_appointmentTableAdapter
        Me.TableAdapterManager.patientTableAdapter = Me.PatientTableAdapter
        Me.TableAdapterManager.receivedTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.StockTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vaccine_orderTableAdapter = Nothing
        Me.TableAdapterManager.vaccine_receivedTableAdapter = Nothing
        Me.TableAdapterManager.vaccineTableAdapter = Nothing
        Me.TableAdapterManager.wardTableAdapter = Me.WardTableAdapter
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'WardTableAdapter
        '
        Me.WardTableAdapter.ClearBeforeFill = True
        '
        'Appointment_numberTextBox
        '
        Me.Appointment_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_appointmentBindingSource, "appointment_number", True))
        Me.Appointment_numberTextBox.Location = New System.Drawing.Point(884, 117)
        Me.Appointment_numberTextBox.Name = "Appointment_numberTextBox"
        Me.Appointment_numberTextBox.Size = New System.Drawing.Size(248, 21)
        Me.Appointment_numberTextBox.TabIndex = 2
        '
        'Cause_of_appointmentTextBox
        '
        Me.Cause_of_appointmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_appointmentBindingSource, "cause_of_appointment", True))
        Me.Cause_of_appointmentTextBox.Location = New System.Drawing.Point(338, 302)
        Me.Cause_of_appointmentTextBox.Multiline = True
        Me.Cause_of_appointmentTextBox.Name = "Cause_of_appointmentTextBox"
        Me.Cause_of_appointmentTextBox.Size = New System.Drawing.Size(794, 173)
        Me.Cause_of_appointmentTextBox.TabIndex = 4
        '
        'Patient_numberTextBox
        '
        Me.Patient_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_appointmentBindingSource, "patient_number", True))
        Me.Patient_numberTextBox.Location = New System.Drawing.Point(303, 161)
        Me.Patient_numberTextBox.Name = "Patient_numberTextBox"
        Me.Patient_numberTextBox.Size = New System.Drawing.Size(248, 21)
        Me.Patient_numberTextBox.TabIndex = 6
        '
        'Staff_numberTextBox
        '
        Me.Staff_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_appointmentBindingSource, "staff_number", True))
        Me.Staff_numberTextBox.Location = New System.Drawing.Point(884, 481)
        Me.Staff_numberTextBox.Name = "Staff_numberTextBox"
        Me.Staff_numberTextBox.Size = New System.Drawing.Size(248, 21)
        Me.Staff_numberTextBox.TabIndex = 8
        '
        'Ward_numberTextBox
        '
        Me.Ward_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_appointmentBindingSource, "ward_number", True))
        Me.Ward_numberTextBox.Location = New System.Drawing.Point(303, 239)
        Me.Ward_numberTextBox.Name = "Ward_numberTextBox"
        Me.Ward_numberTextBox.Size = New System.Drawing.Size(248, 21)
        Me.Ward_numberTextBox.TabIndex = 10
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(303, 187)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(248, 21)
        Me.First_nameTextBox.TabIndex = 12
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(884, 184)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(248, 21)
        Me.Last_nameTextBox.TabIndex = 14
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(884, 212)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(248, 21)
        Me.GenderTextBox.TabIndex = 16
        '
        'Date_of_birthDateTimePicker
        '
        Me.Date_of_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "date_of_birth", True))
        Me.Date_of_birthDateTimePicker.Location = New System.Drawing.Point(303, 213)
        Me.Date_of_birthDateTimePicker.Name = "Date_of_birthDateTimePicker"
        Me.Date_of_birthDateTimePicker.Size = New System.Drawing.Size(248, 21)
        Me.Date_of_birthDateTimePicker.TabIndex = 18
        '
        'WardBindingSource
        '
        Me.WardBindingSource.DataMember = "ward"
        Me.WardBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(303, 266)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(248, 21)
        Me.LocationTextBox.TabIndex = 20
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.Transparent
        Me.btn_search.Location = New System.Drawing.Point(976, 62)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 56
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_edit.Location = New System.Drawing.Point(976, 525)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 60
        Me.btn_edit.Text = "edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Location = New System.Drawing.Point(1057, 525)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 59
        Me.btn_delete.Text = "delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.Location = New System.Drawing.Point(1057, 62)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 58
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'textsearchp
        '
        Me.textsearchp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textsearchp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textsearchp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.textsearchp.ForeColor = System.Drawing.Color.Transparent
        Me.textsearchp.Location = New System.Drawing.Point(557, 159)
        Me.textsearchp.Name = "textsearchp"
        Me.textsearchp.Size = New System.Drawing.Size(75, 23)
        Me.textsearchp.TabIndex = 62
        Me.textsearchp.Text = "Search"
        Me.textsearchp.UseVisualStyleBackColor = False
        '
        'textsearchw
        '
        Me.textsearchw.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textsearchw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textsearchw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.textsearchw.ForeColor = System.Drawing.Color.Transparent
        Me.textsearchw.Location = New System.Drawing.Point(557, 237)
        Me.textsearchw.Name = "textsearchw"
        Me.textsearchw.Size = New System.Drawing.Size(75, 23)
        Me.textsearchw.TabIndex = 63
        Me.textsearchw.Text = "Search"
        Me.textsearchw.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save.Location = New System.Drawing.Point(895, 525)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 64
        Me.btn_save.Text = "save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.Location = New System.Drawing.Point(159, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1032, 579)
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(0, 525)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_logout.Size = New System.Drawing.Size(158, 36)
        Me.btn_logout.TabIndex = 173
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
        Me.btn_vaccine_oder.Location = New System.Drawing.Point(0, 410)
        Me.btn_vaccine_oder.Name = "btn_vaccine_oder"
        Me.btn_vaccine_oder.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_vaccine_oder.Size = New System.Drawing.Size(158, 36)
        Me.btn_vaccine_oder.TabIndex = 172
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
        Me.btn_suppiler.Location = New System.Drawing.Point(0, 374)
        Me.btn_suppiler.Name = "btn_suppiler"
        Me.btn_suppiler.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_suppiler.Size = New System.Drawing.Size(158, 36)
        Me.btn_suppiler.TabIndex = 171
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
        Me.btn_patient_medication.Location = New System.Drawing.Point(0, 338)
        Me.btn_patient_medication.Name = "btn_patient_medication"
        Me.btn_patient_medication.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_medication.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_medication.TabIndex = 170
        Me.btn_patient_medication.Text = "Patient Medication"
        Me.btn_patient_medication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_medication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_patient_medication.UseVisualStyleBackColor = False
        '
        'btn_patient_appointment
        '
        Me.btn_patient_appointment.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_patient_appointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_appointment.FlatAppearance.BorderSize = 0
        Me.btn_patient_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_appointment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_appointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_appointment.Location = New System.Drawing.Point(0, 266)
        Me.btn_patient_appointment.Name = "btn_patient_appointment"
        Me.btn_patient_appointment.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_appointment.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_appointment.TabIndex = 169
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
        Me.btn_patient_allocation.Location = New System.Drawing.Point(0, 302)
        Me.btn_patient_allocation.Name = "btn_patient_allocation"
        Me.btn_patient_allocation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient_allocation.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient_allocation.TabIndex = 168
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
        Me.btnd_staff_allocation.Location = New System.Drawing.Point(0, 194)
        Me.btnd_staff_allocation.Name = "btnd_staff_allocation"
        Me.btnd_staff_allocation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnd_staff_allocation.Size = New System.Drawing.Size(158, 36)
        Me.btnd_staff_allocation.TabIndex = 167
        Me.btnd_staff_allocation.Text = "Staff Allocation"
        Me.btnd_staff_allocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnd_staff_allocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnd_staff_allocation.UseVisualStyleBackColor = False
        '
        'btn_patient
        '
        Me.btn_patient.BackColor = System.Drawing.Color.White
        Me.btn_patient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient.FlatAppearance.BorderSize = 0
        Me.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.Location = New System.Drawing.Point(0, 230)
        Me.btn_patient.Name = "btn_patient"
        Me.btn_patient.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient.TabIndex = 166
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
        Me.btn_staff.Location = New System.Drawing.Point(0, 158)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_staff.Size = New System.Drawing.Size(158, 36)
        Me.btn_staff.TabIndex = 165
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.final_wellmeadown.My.Resources.Resources.Well__1__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 164
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 45)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Patient Appointment"
        '
        '_wellmeadown_finalDataSet1
        '
        Me._wellmeadown_finalDataSet1.DataSetName = "_wellmeadown_finalDataSet1"
        Me._wellmeadown_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WardBindingSource1
        '
        Me.WardBindingSource1.DataMember = "ward"
        Me.WardBindingSource1.DataSource = Me._wellmeadown_finalDataSet1
        '
        'WardTableAdapter1
        '
        Me.WardTableAdapter1.ClearBeforeFill = True
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
        Me.TableAdapterManager1.wardTableAdapter = Me.WardTableAdapter1
        '
        'Ward_nameLabel
        '
        Ward_nameLabel.AutoSize = True
        Ward_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Ward_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ward_nameLabel.Location = New System.Drawing.Point(797, 240)
        Ward_nameLabel.Name = "Ward_nameLabel"
        Ward_nameLabel.Size = New System.Drawing.Size(82, 18)
        Ward_nameLabel.TabIndex = 177
        Ward_nameLabel.Text = "Ward name:"
        '
        'Ward_nameTextBox
        '
        Me.Ward_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource1, "ward_name", True))
        Me.Ward_nameTextBox.Location = New System.Drawing.Point(884, 239)
        Me.Ward_nameTextBox.Name = "Ward_nameTextBox"
        Me.Ward_nameTextBox.Size = New System.Drawing.Size(248, 21)
        Me.Ward_nameTextBox.TabIndex = 178
        '
        'Patient_appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Ward_nameLabel)
        Me.Controls.Add(Me.Ward_nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_vaccine_oder)
        Me.Controls.Add(Me.btn_suppiler)
        Me.Controls.Add(Me.btn_patient_medication)
        Me.Controls.Add(Me.btn_patient_appointment)
        Me.Controls.Add(Me.btn_patient_allocation)
        Me.Controls.Add(Me.btnd_staff_allocation)
        Me.Controls.Add(Me.btn_patient)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.textsearchw)
        Me.Controls.Add(Me.textsearchp)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Date_of_birthLabel)
        Me.Controls.Add(Me.Date_of_birthDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Appointment_numberLabel)
        Me.Controls.Add(Me.Appointment_numberTextBox)
        Me.Controls.Add(Cause_of_appointmentLabel)
        Me.Controls.Add(Me.Cause_of_appointmentTextBox)
        Me.Controls.Add(Patient_numberLabel)
        Me.Controls.Add(Me.Patient_numberTextBox)
        Me.Controls.Add(Staff_numberLabel)
        Me.Controls.Add(Me.Staff_numberTextBox)
        Me.Controls.Add(Ward_numberLabel)
        Me.Controls.Add(Me.Ward_numberTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Patient_appointment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_appointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _wellmeadown_finalDataSet As _wellmeadown_finalDataSet
    Friend WithEvents Patient_appointmentBindingSource As BindingSource
    Friend WithEvents Patient_appointmentTableAdapter As _wellmeadown_finalDataSetTableAdapters.patient_appointmentTableAdapter
    Friend WithEvents TableAdapterManager As _wellmeadown_finalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Appointment_numberTextBox As TextBox
    Friend WithEvents Cause_of_appointmentTextBox As TextBox
    Friend WithEvents Patient_numberTextBox As TextBox
    Friend WithEvents Staff_numberTextBox As TextBox
    Friend WithEvents Ward_numberTextBox As TextBox
    Friend WithEvents PatientTableAdapter As _wellmeadown_finalDataSetTableAdapters.patientTableAdapter
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents WardTableAdapter As _wellmeadown_finalDataSetTableAdapters.wardTableAdapter
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents Date_of_birthDateTimePicker As DateTimePicker
    Friend WithEvents WardBindingSource As BindingSource
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents textsearchp As Button
    Friend WithEvents textsearchw As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_vaccine_oder As Button
    Friend WithEvents btn_suppiler As Button
    Friend WithEvents btn_patient_medication As Button
    Friend WithEvents btn_patient_appointment As Button
    Friend WithEvents btn_patient_allocation As Button
    Friend WithEvents btnd_staff_allocation As Button
    Friend WithEvents btn_patient As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents _wellmeadown_finalDataSet1 As _wellmeadown_finalDataSet1
    Friend WithEvents WardBindingSource1 As BindingSource
    Friend WithEvents WardTableAdapter1 As _wellmeadown_finalDataSet1TableAdapters.wardTableAdapter
    Friend WithEvents TableAdapterManager1 As _wellmeadown_finalDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Ward_nameTextBox As TextBox
End Class
