<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppiler
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
        Dim Supplier_NumberLabel As System.Windows.Forms.Label
        Dim Suppliers_nameLabel As System.Windows.Forms.Label
        Dim ArdressLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim Fax_numbersLabel As System.Windows.Forms.Label
        Me._wellmeadown_finalDataSet1 = New final_wellmeadown._wellmeadown_finalDataSet1()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.SuppliersTableAdapter()
        Me.TableAdapterManager = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager()
        Me.Supplier_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Suppliers_nameTextBox = New System.Windows.Forms.TextBox()
        Me.ArdressTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.Fax_numbersTextBox = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
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
        Supplier_NumberLabel = New System.Windows.Forms.Label()
        Suppliers_nameLabel = New System.Windows.Forms.Label()
        ArdressLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        Fax_numbersLabel = New System.Windows.Forms.Label()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Supplier_NumberLabel
        '
        Supplier_NumberLabel.AutoSize = True
        Supplier_NumberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Supplier_NumberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_NumberLabel.Location = New System.Drawing.Point(251, 127)
        Supplier_NumberLabel.Name = "Supplier_NumberLabel"
        Supplier_NumberLabel.Size = New System.Drawing.Size(116, 18)
        Supplier_NumberLabel.TabIndex = 1
        Supplier_NumberLabel.Text = "Supplier number:"
        '
        'Suppliers_nameLabel
        '
        Suppliers_nameLabel.AutoSize = True
        Suppliers_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Suppliers_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Suppliers_nameLabel.Location = New System.Drawing.Point(733, 136)
        Suppliers_nameLabel.Name = "Suppliers_nameLabel"
        Suppliers_nameLabel.Size = New System.Drawing.Size(108, 18)
        Suppliers_nameLabel.TabIndex = 3
        Suppliers_nameLabel.Text = "Suppliers name:"
        '
        'ArdressLabel
        '
        ArdressLabel.AutoSize = True
        ArdressLabel.BackColor = System.Drawing.Color.PapayaWhip
        ArdressLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArdressLabel.Location = New System.Drawing.Point(251, 154)
        ArdressLabel.Name = "ArdressLabel"
        ArdressLabel.Size = New System.Drawing.Size(59, 18)
        ArdressLabel.TabIndex = 5
        ArdressLabel.Text = "Ardress:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.BackColor = System.Drawing.Color.PapayaWhip
        TelephoneLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(733, 163)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(78, 18)
        TelephoneLabel.TabIndex = 7
        TelephoneLabel.Text = "Telephone:"
        '
        'Fax_numbersLabel
        '
        Fax_numbersLabel.AutoSize = True
        Fax_numbersLabel.BackColor = System.Drawing.Color.PapayaWhip
        Fax_numbersLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fax_numbersLabel.Location = New System.Drawing.Point(733, 189)
        Fax_numbersLabel.Name = "Fax_numbersLabel"
        Fax_numbersLabel.Size = New System.Drawing.Size(91, 18)
        Fax_numbersLabel.TabIndex = 9
        Fax_numbersLabel.Text = "Fax numbers:"
        '
        '_wellmeadown_finalDataSet1
        '
        Me._wellmeadown_finalDataSet1.DataSetName = "_wellmeadown_finalDataSet1"
        Me._wellmeadown_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me._wellmeadown_finalDataSet1
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.StockTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Me.SuppliersTableAdapter
        Me.TableAdapterManager.UpdateOrder = final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vaccine_orderTableAdapter = Nothing
        Me.TableAdapterManager.vaccine_receivedTableAdapter = Nothing
        Me.TableAdapterManager.vaccineTableAdapter = Nothing
        Me.TableAdapterManager.wardTableAdapter = Nothing
        '
        'Supplier_NumberTextBox
        '
        Me.Supplier_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Supplier_Number", True))
        Me.Supplier_NumberTextBox.Location = New System.Drawing.Point(373, 128)
        Me.Supplier_NumberTextBox.Name = "Supplier_NumberTextBox"
        Me.Supplier_NumberTextBox.Size = New System.Drawing.Size(236, 21)
        Me.Supplier_NumberTextBox.TabIndex = 2
        '
        'Suppliers_nameTextBox
        '
        Me.Suppliers_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Suppliers name", True))
        Me.Suppliers_nameTextBox.Location = New System.Drawing.Point(855, 137)
        Me.Suppliers_nameTextBox.Name = "Suppliers_nameTextBox"
        Me.Suppliers_nameTextBox.Size = New System.Drawing.Size(236, 21)
        Me.Suppliers_nameTextBox.TabIndex = 4
        '
        'ArdressTextBox
        '
        Me.ArdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Ardress", True))
        Me.ArdressTextBox.Location = New System.Drawing.Point(373, 158)
        Me.ArdressTextBox.Multiline = True
        Me.ArdressTextBox.Name = "ArdressTextBox"
        Me.ArdressTextBox.Size = New System.Drawing.Size(236, 95)
        Me.ArdressTextBox.TabIndex = 6
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(855, 164)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(236, 21)
        Me.TelephoneTextBox.TabIndex = 8
        '
        'Fax_numbersTextBox
        '
        Me.Fax_numbersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Fax numbers", True))
        Me.Fax_numbersTextBox.Location = New System.Drawing.Point(855, 190)
        Me.Fax_numbersTextBox.Name = "Fax_numbersTextBox"
        Me.Fax_numbersTextBox.Size = New System.Drawing.Size(236, 21)
        Me.Fax_numbersTextBox.TabIndex = 10
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(854, 230)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 101
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(935, 230)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 100
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Location = New System.Drawing.Point(1016, 230)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 99
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Location = New System.Drawing.Point(1016, 83)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 98
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Black
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search.Location = New System.Drawing.Point(935, 83)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 96
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.Location = New System.Drawing.Point(159, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1025, 574)
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
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
        Me.btn_logout.TabIndex = 163
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
        Me.btn_vaccine_oder.TabIndex = 162
        Me.btn_vaccine_oder.Text = "Vaccine Oder"
        Me.btn_vaccine_oder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vaccine_oder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_vaccine_oder.UseVisualStyleBackColor = False
        '
        'btn_suppiler
        '
        Me.btn_suppiler.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_suppiler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suppiler.FlatAppearance.BorderSize = 0
        Me.btn_suppiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suppiler.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suppiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppiler.Location = New System.Drawing.Point(1, 374)
        Me.btn_suppiler.Name = "btn_suppiler"
        Me.btn_suppiler.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_suppiler.Size = New System.Drawing.Size(158, 36)
        Me.btn_suppiler.TabIndex = 161
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
        Me.btn_patient_medication.TabIndex = 160
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
        Me.btn_patient_appointment.TabIndex = 159
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
        Me.btn_patient_allocation.TabIndex = 158
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
        Me.btnd_staff_allocation.TabIndex = 157
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
        Me.btn_patient.Location = New System.Drawing.Point(1, 230)
        Me.btn_patient.Name = "btn_patient"
        Me.btn_patient.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_patient.Size = New System.Drawing.Size(158, 36)
        Me.btn_patient.TabIndex = 156
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
        Me.btn_staff.TabIndex = 155
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.final_wellmeadown.My.Resources.Resources.Well__1__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 154
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 45)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Suppiler"
        '
        'Suppiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 561)
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
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Supplier_NumberLabel)
        Me.Controls.Add(Me.Supplier_NumberTextBox)
        Me.Controls.Add(Suppliers_nameLabel)
        Me.Controls.Add(Me.Suppliers_nameTextBox)
        Me.Controls.Add(ArdressLabel)
        Me.Controls.Add(Me.ArdressTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(Fax_numbersLabel)
        Me.Controls.Add(Me.Fax_numbersTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Suppiler"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _wellmeadown_finalDataSet1 As _wellmeadown_finalDataSet1
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As _wellmeadown_finalDataSet1TableAdapters.SuppliersTableAdapter
    Friend WithEvents TableAdapterManager As _wellmeadown_finalDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Supplier_NumberTextBox As TextBox
    Friend WithEvents Suppliers_nameTextBox As TextBox
    Friend WithEvents ArdressTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents Fax_numbersTextBox As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_search As Button
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
End Class
