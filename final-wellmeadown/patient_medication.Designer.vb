<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patient_medication
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
        Dim Pmedication_numberLabel As System.Windows.Forms.Label
        Dim Patient_NumberLabel As System.Windows.Forms.Label
        Dim Ward_NumberLabel As System.Windows.Forms.Label
        Dim Bed_NumberLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim Ward_nameLabel As System.Windows.Forms.Label
        Me._wellmeadown_finalDataSet = New final_wellmeadown._wellmeadown_finalDataSet()
        Me.M_patient_medicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_patient_medicationTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.m_patient_medicationTableAdapter()
        Me.TableAdapterManager = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.TableAdapterManager()
        Me.Pmedication_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Ward_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Bed_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.patientTableAdapter()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.WardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.wardTableAdapter()
        Me.Ward_nameTextBox = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.D_patient_medicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.D_patient_medicationTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.d_patient_medicationTableAdapter()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New final_wellmeadown._wellmeadown_finalDataSetTableAdapters.inventoryTableAdapter()
        Me.searchp = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_addview = New System.Windows.Forms.Button()
        Pmedication_numberLabel = New System.Windows.Forms.Label()
        Patient_NumberLabel = New System.Windows.Forms.Label()
        Ward_NumberLabel = New System.Windows.Forms.Label()
        Bed_NumberLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        Ward_nameLabel = New System.Windows.Forms.Label()
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M_patient_medicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_patient_medicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pmedication_numberLabel
        '
        Pmedication_numberLabel.AutoSize = True
        Pmedication_numberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Pmedication_numberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pmedication_numberLabel.Location = New System.Drawing.Point(709, 75)
        Pmedication_numberLabel.Name = "Pmedication_numberLabel"
        Pmedication_numberLabel.Size = New System.Drawing.Size(180, 18)
        Pmedication_numberLabel.TabIndex = 1
        Pmedication_numberLabel.Text = "Patient medication number:"
        AddHandler Pmedication_numberLabel.Click, AddressOf Me.Pmedication_numberLabel_Click
        '
        'Patient_NumberLabel
        '
        Patient_NumberLabel.AutoSize = True
        Patient_NumberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Patient_NumberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NumberLabel.Location = New System.Drawing.Point(263, 133)
        Patient_NumberLabel.Name = "Patient_NumberLabel"
        Patient_NumberLabel.Size = New System.Drawing.Size(110, 18)
        Patient_NumberLabel.TabIndex = 3
        Patient_NumberLabel.Text = "Patient Number:"
        '
        'Ward_NumberLabel
        '
        Ward_NumberLabel.AutoSize = True
        Ward_NumberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Ward_NumberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ward_NumberLabel.Location = New System.Drawing.Point(263, 186)
        Ward_NumberLabel.Name = "Ward_NumberLabel"
        Ward_NumberLabel.Size = New System.Drawing.Size(98, 18)
        Ward_NumberLabel.TabIndex = 5
        Ward_NumberLabel.Text = "Ward Number:"
        '
        'Bed_NumberLabel
        '
        Bed_NumberLabel.AutoSize = True
        Bed_NumberLabel.BackColor = System.Drawing.Color.PapayaWhip
        Bed_NumberLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Bed_NumberLabel.Location = New System.Drawing.Point(263, 212)
        Bed_NumberLabel.Name = "Bed_NumberLabel"
        Bed_NumberLabel.Size = New System.Drawing.Size(90, 18)
        Bed_NumberLabel.TabIndex = 7
        Bed_NumberLabel.Text = "Bed Number:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        First_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(263, 159)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(77, 18)
        First_nameLabel.TabIndex = 9
        First_nameLabel.Text = "First name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Last_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(748, 159)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(74, 18)
        Last_nameLabel.TabIndex = 11
        Last_nameLabel.Text = "Last name:"
        '
        'Ward_nameLabel
        '
        Ward_nameLabel.AutoSize = True
        Ward_nameLabel.BackColor = System.Drawing.Color.PapayaWhip
        Ward_nameLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ward_nameLabel.Location = New System.Drawing.Point(748, 186)
        Ward_nameLabel.Name = "Ward_nameLabel"
        Ward_nameLabel.Size = New System.Drawing.Size(82, 18)
        Ward_nameLabel.TabIndex = 13
        Ward_nameLabel.Text = "Ward name:"
        '
        '_wellmeadown_finalDataSet
        '
        Me._wellmeadown_finalDataSet.DataSetName = "_wellmeadown_finalDataSet"
        Me._wellmeadown_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'M_patient_medicationBindingSource
        '
        Me.M_patient_medicationBindingSource.DataMember = "m_patient_medication"
        Me.M_patient_medicationBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'M_patient_medicationTableAdapter
        '
        Me.M_patient_medicationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.m_patient_medicationTableAdapter = Me.M_patient_medicationTableAdapter
        Me.TableAdapterManager.m_requisitionTableAdapter = Nothing
        Me.TableAdapterManager.m_ward_staff_allocationTableAdapter = Nothing
        Me.TableAdapterManager.OrdererTableAdapter = Nothing
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
        'Pmedication_numberTextBox
        '
        Me.Pmedication_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.M_patient_medicationBindingSource, "pmedication_number", True))
        Me.Pmedication_numberTextBox.Location = New System.Drawing.Point(895, 75)
        Me.Pmedication_numberTextBox.Name = "Pmedication_numberTextBox"
        Me.Pmedication_numberTextBox.Size = New System.Drawing.Size(231, 21)
        Me.Pmedication_numberTextBox.TabIndex = 2
        '
        'Patient_NumberTextBox
        '
        Me.Patient_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.M_patient_medicationBindingSource, "Patient_Number", True))
        Me.Patient_NumberTextBox.Location = New System.Drawing.Point(379, 130)
        Me.Patient_NumberTextBox.Name = "Patient_NumberTextBox"
        Me.Patient_NumberTextBox.Size = New System.Drawing.Size(231, 21)
        Me.Patient_NumberTextBox.TabIndex = 4
        '
        'Ward_NumberTextBox
        '
        Me.Ward_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.M_patient_medicationBindingSource, "Ward_Number", True))
        Me.Ward_NumberTextBox.Location = New System.Drawing.Point(379, 183)
        Me.Ward_NumberTextBox.Name = "Ward_NumberTextBox"
        Me.Ward_NumberTextBox.Size = New System.Drawing.Size(231, 21)
        Me.Ward_NumberTextBox.TabIndex = 6
        '
        'Bed_NumberTextBox
        '
        Me.Bed_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.M_patient_medicationBindingSource, "Bed_Number", True))
        Me.Bed_NumberTextBox.Location = New System.Drawing.Point(379, 211)
        Me.Bed_NumberTextBox.Name = "Bed_NumberTextBox"
        Me.Bed_NumberTextBox.Size = New System.Drawing.Size(231, 21)
        Me.Bed_NumberTextBox.TabIndex = 8
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
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(379, 156)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(231, 21)
        Me.First_nameTextBox.TabIndex = 10
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(895, 156)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(231, 21)
        Me.Last_nameTextBox.TabIndex = 12
        '
        'WardBindingSource
        '
        Me.WardBindingSource.DataMember = "ward"
        Me.WardBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'WardTableAdapter
        '
        Me.WardTableAdapter.ClearBeforeFill = True
        '
        'Ward_nameTextBox
        '
        Me.Ward_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "ward_name", True))
        Me.Ward_nameTextBox.Location = New System.Drawing.Point(895, 183)
        Me.Ward_nameTextBox.Name = "Ward_nameTextBox"
        Me.Ward_nameTextBox.Size = New System.Drawing.Size(231, 21)
        Me.Ward_nameTextBox.TabIndex = 14
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(889, 311)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 80
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(970, 311)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 79
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(1051, 311)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 78
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add.Location = New System.Drawing.Point(1051, 34)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 77
        Me.btn_add.Text = "add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_search.Location = New System.Drawing.Point(970, 34)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 75
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'D_patient_medicationBindingSource
        '
        Me.D_patient_medicationBindingSource.DataMember = "d_patient_medication"
        Me.D_patient_medicationBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'D_patient_medicationTableAdapter
        '
        Me.D_patient_medicationTableAdapter.ClearBeforeFill = True
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "inventory"
        Me.InventoryBindingSource.DataSource = Me._wellmeadown_finalDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'searchp
        '
        Me.searchp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.searchp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.searchp.Location = New System.Drawing.Point(607, 129)
        Me.searchp.Name = "searchp"
        Me.searchp.Size = New System.Drawing.Size(75, 23)
        Me.searchp.TabIndex = 100
        Me.searchp.Text = "Search"
        Me.searchp.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(175, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.Location = New System.Drawing.Point(158, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1049, 562)
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
        Me.btn_logout.Location = New System.Drawing.Point(0, 526)
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
        Me.btn_vaccine_oder.Location = New System.Drawing.Point(0, 411)
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
        Me.btn_suppiler.Location = New System.Drawing.Point(0, 375)
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
        Me.btn_patient_medication.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_patient_medication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patient_medication.FlatAppearance.BorderSize = 0
        Me.btn_patient_medication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patient_medication.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient_medication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient_medication.Location = New System.Drawing.Point(0, 339)
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
        Me.btn_patient_appointment.Location = New System.Drawing.Point(0, 267)
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
        Me.btn_patient_allocation.Location = New System.Drawing.Point(0, 303)
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
        Me.btnd_staff_allocation.Location = New System.Drawing.Point(0, 195)
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
        Me.btn_patient.Location = New System.Drawing.Point(0, 231)
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
        Me.btn_staff.Location = New System.Drawing.Point(0, 159)
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
        Me.PictureBox2.Location = New System.Drawing.Point(8, 13)
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
        Me.Label1.Location = New System.Drawing.Point(258, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 45)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Patient Medication"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(175, 361)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(997, 188)
        Me.ListView1.TabIndex = 178
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Drug number"
        Me.ColumnHeader1.Width = 124
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 124
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 124
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Dosage"
        Me.ColumnHeader4.Width = 124
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Method of addmin"
        Me.ColumnHeader5.Width = 124
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Units per day"
        Me.ColumnHeader6.Width = 124
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Start date"
        Me.ColumnHeader7.Width = 124
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Finish date"
        Me.ColumnHeader8.Width = 124
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(175, 361)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 21)
        Me.TextBox1.TabIndex = 180
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(299, 361)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 21)
        Me.TextBox2.TabIndex = 181
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(423, 361)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 21)
        Me.TextBox3.TabIndex = 182
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(547, 361)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(125, 21)
        Me.TextBox4.TabIndex = 183
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(671, 361)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(125, 21)
        Me.TextBox5.TabIndex = 184
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(795, 361)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(125, 21)
        Me.TextBox6.TabIndex = 185
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(919, 361)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 21)
        Me.DateTimePicker1.TabIndex = 186
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(1043, 361)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(129, 21)
        Me.DateTimePicker2.TabIndex = 187
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(175, 341)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 21)
        Me.Panel1.TabIndex = 191
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 194
        Me.Label2.Text = "Drug number"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(299, 341)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(125, 21)
        Me.Panel2.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 195
        Me.Label3.Text = "Name"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(423, 341)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(125, 21)
        Me.Panel3.TabIndex = 192
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 196
        Me.Label4.Text = "Description"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(547, 341)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(125, 21)
        Me.Panel4.TabIndex = 192
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 197
        Me.Label5.Text = "Dosage"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(671, 341)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(125, 21)
        Me.Panel5.TabIndex = 192
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 18)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "Method of admin"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(795, 341)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(125, 21)
        Me.Panel6.TabIndex = 192
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "Unnit per day"
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(1043, 341)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(129, 21)
        Me.Panel9.TabIndex = 193
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 201
        Me.Label9.Text = "Finsish date"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(122, -1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(125, 21)
        Me.Panel8.TabIndex = 192
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(919, 341)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(126, 21)
        Me.Panel7.TabIndex = 192
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "Start daste"
        '
        'btn_addview
        '
        Me.btn_addview.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_addview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addview.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_addview.Location = New System.Drawing.Point(256, 316)
        Me.btn_addview.Name = "btn_addview"
        Me.btn_addview.Size = New System.Drawing.Size(75, 23)
        Me.btn_addview.TabIndex = 194
        Me.btn_addview.Text = "Add"
        Me.btn_addview.UseVisualStyleBackColor = False
        '
        'patient_medication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.btn_addview)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListView1)
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
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.searchp)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Ward_nameLabel)
        Me.Controls.Add(Me.Ward_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Pmedication_numberLabel)
        Me.Controls.Add(Me.Pmedication_numberTextBox)
        Me.Controls.Add(Patient_NumberLabel)
        Me.Controls.Add(Me.Patient_NumberTextBox)
        Me.Controls.Add(Ward_NumberLabel)
        Me.Controls.Add(Me.Ward_NumberTextBox)
        Me.Controls.Add(Bed_NumberLabel)
        Me.Controls.Add(Me.Bed_NumberTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "patient_medication"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._wellmeadown_finalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M_patient_medicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_patient_medicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _wellmeadown_finalDataSet As _wellmeadown_finalDataSet
    Friend WithEvents M_patient_medicationBindingSource As BindingSource
    Friend WithEvents M_patient_medicationTableAdapter As _wellmeadown_finalDataSetTableAdapters.m_patient_medicationTableAdapter
    Friend WithEvents TableAdapterManager As _wellmeadown_finalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Pmedication_numberTextBox As TextBox
    Friend WithEvents Patient_NumberTextBox As TextBox
    Friend WithEvents Ward_NumberTextBox As TextBox
    Friend WithEvents Bed_NumberTextBox As TextBox
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As _wellmeadown_finalDataSetTableAdapters.patientTableAdapter
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents WardBindingSource As BindingSource
    Friend WithEvents WardTableAdapter As _wellmeadown_finalDataSetTableAdapters.wardTableAdapter
    Friend WithEvents Ward_nameTextBox As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents D_patient_medicationBindingSource As BindingSource
    Friend WithEvents D_patient_medicationTableAdapter As _wellmeadown_finalDataSetTableAdapters.d_patient_medicationTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As _wellmeadown_finalDataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents searchp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
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
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_addview As Button
End Class
