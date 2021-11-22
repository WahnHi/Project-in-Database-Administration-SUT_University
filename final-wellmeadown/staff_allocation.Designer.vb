<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staff_allocation
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
        Dim Ward_nameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Tel_extnLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Staff_allocation_numberLabel As System.Windows.Forms.Label
        Dim Staff_numberLabel As System.Windows.Forms.Label
        Dim Ward_numberLabel As System.Windows.Forms.Label
        Me._wellmeadown_finalDataSet = New final_wellmeadown._wellmeadown_finalDataSet()
        Me.M_patient_allocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_patient_allocationTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.m_patient_allocationTableAdapter()
        Me.TableAdapterManager = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager()
        Me.StaffTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.staffTableAdapter()
        Me.WardTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.wardTableAdapter()
        Me.WardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ward_nameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_extnTextBox = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.M_ward_staff_allocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_ward_staff_allocationTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.m_ward_staff_allocationTableAdapter()
        Me.Staff_allocation_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Ward_numberTextBox = New System.Windows.Forms.TextBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.D_ward_staff_allocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.D_ward_staff_allocationTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.d_ward_staff_allocationTableAdapter()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_vaccine_oder = New System.Windows.Forms.Button()
        Me.btn_suppiler = New System.Windows.Forms.Button()
        Me.btn_patient_medication = New System.Windows.Forms.Button()
        Me.btn_patient_appointment = New System.Windows.Forms.Button()
        Me.btn_patient_allocation = New System.Windows.Forms.Button()
        Me.btnd_staff_allocation = New System.Windows.Forms.Button()
        Me.btn_patient = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me._wellmeadown_finalDataSet1 = New final_wellmeadown._wellmeadown_finalDataSet1()
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter1 = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.staffTableAdapter()
        Me.TableAdapterManager1 = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btn_addview = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Ward_nameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Tel_extnLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Staff_allocation_numberLabel = New System.Windows.Forms.Label()
        Staff_numberLabel = New System.Windows.Forms.Label()
        Ward_numberLabel = New System.Windows.Forms.Label()
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M_patient_allocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M_ward_staff_allocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_ward_staff_allocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ward_nameLabel
        '
        Ward_nameLabel.AutoSize = True
        Ward_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Ward_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ward_nameLabel.Location = New System.Drawing.Point(762, 169)
        Ward_nameLabel.Name = "Ward_nameLabel"
        Ward_nameLabel.Size = New System.Drawing.Size(82, 18)
        Ward_nameLabel.TabIndex = 7
        Ward_nameLabel.Text = "Ward name:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.PapayaWhip
        LocationLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(248, 223)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(63, 18)
        LocationLabel.TabIndex = 9
        LocationLabel.Text = "Location:"
        '
        'Tel_extnLabel
        '
        Tel_extnLabel.AutoSize = True
        Tel_extnLabel.BackColor = System.Drawing.Color.PapayaWhip
        Tel_extnLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tel_extnLabel.Location = New System.Drawing.Point(762, 224)
        Tel_extnLabel.Name = "Tel_extnLabel"
        Tel_extnLabel.Size = New System.Drawing.Size(61, 18)
        Tel_extnLabel.TabIndex = 11
        Tel_extnLabel.Text = "Tel extn:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        First_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(762, 195)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(93, 18)
        First_nameLabel.TabIndex = 13
        First_nameLabel.Text = "Charge nurse:"
        '
        'Staff_allocation_numberLabel
        '
        Staff_allocation_numberLabel.AutoSize = True
        Staff_allocation_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Staff_allocation_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_allocation_numberLabel.Location = New System.Drawing.Point(700, 122)
        Staff_allocation_numberLabel.Name = "Staff_allocation_numberLabel"
        Staff_allocation_numberLabel.Size = New System.Drawing.Size(155, 18)
        Staff_allocation_numberLabel.TabIndex = 14
        Staff_allocation_numberLabel.Text = "Staff allocation number:"
        '
        'Staff_numberLabel
        '
        Staff_numberLabel.AutoSize = True
        Staff_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Staff_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_numberLabel.Location = New System.Drawing.Point(248, 195)
        Staff_numberLabel.Name = "Staff_numberLabel"
        Staff_numberLabel.Size = New System.Drawing.Size(92, 18)
        Staff_numberLabel.TabIndex = 16
        Staff_numberLabel.Text = "Staff number:"
        '
        'Ward_numberLabel
        '
        Ward_numberLabel.AutoSize = True
        Ward_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Ward_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ward_numberLabel.Location = New System.Drawing.Point(248, 169)
        Ward_numberLabel.Name = "Ward_numberLabel"
        Ward_numberLabel.Size = New System.Drawing.Size(96, 18)
        Ward_numberLabel.TabIndex = 18
        Ward_numberLabel.Text = "Ward number:"
        AddHandler Ward_numberLabel.Click, AddressOf Me.Ward_numberLabel_Click
        '
        '_wellmeadown_finalDataSet
        '
        Me._wellmeadown_finalDataSet.DataSetName = "_wellmeadown_finalDataSet"
        Me._wellmeadown_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'M_patient_allocationBindingSource
        '
        Me.M_patient_allocationBindingSource.DataMember = "m_patient_allocation"
        Me.M_patient_allocationBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'M_patient_allocationTableAdapter
        '
        Me.M_patient_allocationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.m_patient_allocationTableAdapter = Me.M_patient_allocationTableAdapter
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
        Me.TableAdapterManager.wardTableAdapter = Me.WardTableAdapter
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'WardTableAdapter
        '
        Me.WardTableAdapter.ClearBeforeFill = True
        '
        'WardBindingSource
        '
        Me.WardBindingSource.DataMember = "ward"
        Me.WardBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'Ward_nameTextBox
        '
        Me.Ward_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "ward_name", True))
        Me.Ward_nameTextBox.Location = New System.Drawing.Point(860, 166)
        Me.Ward_nameTextBox.Name = "Ward_nameTextBox"
        Me.Ward_nameTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Ward_nameTextBox.TabIndex = 8
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(349, 220)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(233, 21)
        Me.LocationTextBox.TabIndex = 10
        '
        'Tel_extnTextBox
        '
        Me.Tel_extnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "tel extn", True))
        Me.Tel_extnTextBox.Location = New System.Drawing.Point(860, 221)
        Me.Tel_extnTextBox.Name = "Tel_extnTextBox"
        Me.Tel_extnTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Tel_extnTextBox.TabIndex = 12
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(860, 192)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(120, 21)
        Me.First_nameTextBox.TabIndex = 14
        '
        'M_ward_staff_allocationBindingSource
        '
        Me.M_ward_staff_allocationBindingSource.DataMember = "m_ward_staff_allocation"
        Me.M_ward_staff_allocationBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'M_ward_staff_allocationTableAdapter
        '
        Me.M_ward_staff_allocationTableAdapter.ClearBeforeFill = True
        '
        'Staff_allocation_numberTextBox
        '
        Me.Staff_allocation_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.M_ward_staff_allocationBindingSource, "staff_allocation_number", True))
        Me.Staff_allocation_numberTextBox.Location = New System.Drawing.Point(860, 122)
        Me.Staff_allocation_numberTextBox.Name = "Staff_allocation_numberTextBox"
        Me.Staff_allocation_numberTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Staff_allocation_numberTextBox.TabIndex = 15
        '
        'Staff_numberTextBox
        '
        Me.Staff_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.M_ward_staff_allocationBindingSource, "staff_number", True))
        Me.Staff_numberTextBox.Location = New System.Drawing.Point(349, 194)
        Me.Staff_numberTextBox.Name = "Staff_numberTextBox"
        Me.Staff_numberTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Staff_numberTextBox.TabIndex = 17
        '
        'Ward_numberTextBox
        '
        Me.Ward_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.M_ward_staff_allocationBindingSource, "ward_number", True))
        Me.Ward_numberTextBox.Location = New System.Drawing.Point(349, 168)
        Me.Ward_numberTextBox.Name = "Ward_numberTextBox"
        Me.Ward_numberTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Ward_numberTextBox.TabIndex = 19
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_edit.Location = New System.Drawing.Point(937, 266)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 54
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Location = New System.Drawing.Point(1018, 265)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 53
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.Location = New System.Drawing.Point(1018, 62)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 52
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'D_ward_staff_allocationBindingSource
        '
        Me.D_ward_staff_allocationBindingSource.DataMember = "d_ward_staff_allocation"
        Me.D_ward_staff_allocationBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'D_ward_staff_allocationTableAdapter
        '
        Me.D_ward_staff_allocationTableAdapter.ClearBeforeFill = True
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_logout.Location = New System.Drawing.Point(0, 577)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(158, 36)
        Me.btn_logout.TabIndex = 121
        Me.btn_logout.Text = "logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(158, 36)
        Me.Button1.TabIndex = 173
        Me.Button1.Text = "Logout"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_vaccine_oder
        '
        Me.btn_vaccine_oder.BackColor = System.Drawing.Color.White
        Me.btn_vaccine_oder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_vaccine_oder.FlatAppearance.BorderSize = 0
        Me.btn_vaccine_oder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vaccine_oder.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vaccine_oder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vaccine_oder.Location = New System.Drawing.Point(1, 409)
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
        Me.btn_suppiler.Location = New System.Drawing.Point(1, 373)
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
        Me.btn_patient_medication.Location = New System.Drawing.Point(1, 337)
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
        Me.btn_patient_appointment.BackColor = System.Drawing.Color.White
        Me.btn_patient_appointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_appointment.FlatAppearance.BorderSize = 0
        Me.btn_patient_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_appointment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_appointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_appointment.Location = New System.Drawing.Point(1, 265)
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
        Me.btn_patient_allocation.Location = New System.Drawing.Point(1, 301)
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
        Me.btnd_staff_allocation.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnd_staff_allocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnd_staff_allocation.FlatAppearance.BorderSize = 0
        Me.btnd_staff_allocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnd_staff_allocation.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnd_staff_allocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnd_staff_allocation.Location = New System.Drawing.Point(1, 193)
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
        Me.btn_patient.Location = New System.Drawing.Point(1, 229)
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
        Me.btn_staff.Location = New System.Drawing.Point(1, 157)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_staff.Size = New System.Drawing.Size(158, 36)
        Me.btn_staff.TabIndex = 165
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(165, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 175
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(860, 265)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 176
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 45)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Staff Allocation"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_search.Location = New System.Drawing.Point(937, 62)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 50
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(588, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 178
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(588, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 179
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = False
        '
        '_wellmeadown_finalDataSet1
        '
        Me._wellmeadown_finalDataSet1.DataSetName = "_wellmeadown_finalDataSet1"
        Me._wellmeadown_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource1
        '
        Me.StaffBindingSource1.DataMember = "staff"
        Me.StaffBindingSource1.DataSource = Me._wellmeadown_finalDataSet1
        '
        'StaffTableAdapter1
        '
        Me.StaffTableAdapter1.ClearBeforeFill = True
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
        Me.TableAdapterManager1.staffTableAdapter = Me.StaffTableAdapter1
        Me.TableAdapterManager1.StockTableAdapter = Nothing
        Me.TableAdapterManager1.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.vaccine_orderTableAdapter = Nothing
        Me.TableAdapterManager1.vaccine_receivedTableAdapter = Nothing
        Me.TableAdapterManager1.vaccineTableAdapter = Nothing
        Me.TableAdapterManager1.wardTableAdapter = Nothing
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource1, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(977, 192)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(116, 21)
        Me.Last_nameTextBox.TabIndex = 180
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.final_wellmeadown.My.Resources.Resources.Well__1__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(9, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 164
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StaffBindingSource1, "last_name", True))
        Me.PictureBox1.Location = New System.Drawing.Point(159, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1047, 615)
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(165, 337)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1013, 189)
        Me.ListView1.TabIndex = 181
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Staff number"
        Me.ColumnHeader1.Width = 145
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First name"
        Me.ColumnHeader2.Width = 145
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last name"
        Me.ColumnHeader3.Width = 145
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 145
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Telephone"
        Me.ColumnHeader5.Width = 145
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Position"
        Me.ColumnHeader6.Width = 145
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Shift"
        Me.ColumnHeader7.Width = 145
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.RemoveToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DeleteToolStripMenuItem.Text = "Clear"
        '
        'RemoveToolStripMenuItem1
        '
        Me.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1"
        Me.RemoveToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem1.Text = "Remove"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(310, 338)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 21)
        Me.TextBox1.TabIndex = 182
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(455, 338)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(153, 21)
        Me.TextBox2.TabIndex = 183
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(601, 338)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(145, 21)
        Me.TextBox3.TabIndex = 184
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(745, 338)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(152, 21)
        Me.TextBox4.TabIndex = 185
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(890, 338)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(145, 21)
        Me.TextBox5.TabIndex = 186
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1033, 338)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(145, 21)
        Me.TextBox6.TabIndex = 187
        '
        'btn_addview
        '
        Me.btn_addview.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_addview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addview.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_addview.Location = New System.Drawing.Point(246, 289)
        Me.btn_addview.Name = "btn_addview"
        Me.btn_addview.Size = New System.Drawing.Size(75, 23)
        Me.btn_addview.TabIndex = 188
        Me.btn_addview.Text = "Add"
        Me.btn_addview.UseVisualStyleBackColor = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(165, 338)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(146, 21)
        Me.TextBox7.TabIndex = 189
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(165, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 21)
        Me.Panel1.TabIndex = 190
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 194
        Me.Label2.Text = "Staff number"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(601, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 21)
        Me.Panel2.TabIndex = 191
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 197
        Me.Label5.Text = "Address"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(455, 318)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(153, 21)
        Me.Panel3.TabIndex = 191
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 196
        Me.Label4.Text = "Last name"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(310, 318)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(149, 21)
        Me.Panel4.TabIndex = 191
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 195
        Me.Label3.Text = "First name"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(745, 318)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(146, 21)
        Me.Panel5.TabIndex = 192
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "Telephone"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(890, 318)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(146, 21)
        Me.Panel6.TabIndex = 193
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 18)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "Position"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Location = New System.Drawing.Point(1033, 318)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(145, 21)
        Me.Panel7.TabIndex = 193
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 18)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "Shift"
        '
        'staff_allocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.btn_addview)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_vaccine_oder)
        Me.Controls.Add(Me.btn_suppiler)
        Me.Controls.Add(Me.btn_patient_medication)
        Me.Controls.Add(Me.btn_patient_appointment)
        Me.Controls.Add(Me.btn_patient_allocation)
        Me.Controls.Add(Me.btnd_staff_allocation)
        Me.Controls.Add(Me.btn_patient)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Staff_allocation_numberLabel)
        Me.Controls.Add(Me.Staff_allocation_numberTextBox)
        Me.Controls.Add(Staff_numberLabel)
        Me.Controls.Add(Me.Staff_numberTextBox)
        Me.Controls.Add(Ward_numberLabel)
        Me.Controls.Add(Me.Ward_numberTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Tel_extnLabel)
        Me.Controls.Add(Me.Tel_extnTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Ward_nameLabel)
        Me.Controls.Add(Me.Ward_nameTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "staff_allocation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M_patient_allocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M_ward_staff_allocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_ward_staff_allocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _wellmeadown_finalDataSet As _wellmeadown_finalDataSet
    Friend WithEvents M_patient_allocationBindingSource As BindingSource
    Friend WithEvents M_patient_allocationTableAdapter As _wellmeadown_finalDataSetTableAdapters.m_patient_allocationTableAdapter
    Friend WithEvents TableAdapterManager As _wellmeadown_finalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WardTableAdapter As _wellmeadown_finalDataSetTableAdapters.wardTableAdapter
    Friend WithEvents WardBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As _wellmeadown_finalDataSetTableAdapters.staffTableAdapter
    Friend WithEvents Ward_nameTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents Tel_extnTextBox As TextBox
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents M_ward_staff_allocationBindingSource As BindingSource
    Friend WithEvents M_ward_staff_allocationTableAdapter As _wellmeadown_finalDataSetTableAdapters.m_ward_staff_allocationTableAdapter
    Friend WithEvents Staff_allocation_numberTextBox As TextBox
    Friend WithEvents Staff_numberTextBox As TextBox
    Friend WithEvents Ward_numberTextBox As TextBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents D_ward_staff_allocationBindingSource As BindingSource
    Friend WithEvents D_ward_staff_allocationTableAdapter As _wellmeadown_finalDataSetTableAdapters.d_ward_staff_allocationTableAdapter
    Friend WithEvents btn_logout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_vaccine_oder As Button
    Friend WithEvents btn_suppiler As Button
    Friend WithEvents btn_patient_medication As Button
    Friend WithEvents btn_patient_appointment As Button
    Friend WithEvents btn_patient_allocation As Button
    Friend WithEvents btnd_staff_allocation As Button
    Friend WithEvents btn_patient As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents _wellmeadown_finalDataSet1 As _wellmeadown_finalDataSet1
    Friend WithEvents StaffBindingSource1 As BindingSource
    Friend WithEvents StaffTableAdapter1 As _wellmeadown_finalDataSet1TableAdapters.staffTableAdapter
    Friend WithEvents TableAdapterManager1 As _wellmeadown_finalDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btn_addview As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem1 As ToolStripMenuItem
End Class
