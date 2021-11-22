<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vaccine_order
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
        Me._wellmeadown_finalDataSet1 = New final_wellmeadown._wellmeadown_finalDataSet1()
        Me.VaccineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VaccineTableAdapter = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.vaccineTableAdapter()
        Me.TableAdapterManager = New final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VaccineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_wellmeadown_finalDataSet1
        '
        Me._wellmeadown_finalDataSet1.DataSetName = "_wellmeadown_finalDataSet1"
        Me._wellmeadown_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VaccineBindingSource
        '
        Me.VaccineBindingSource.DataMember = "vaccine"
        Me.VaccineBindingSource.DataSource = Me._wellmeadown_finalDataSet1
        '
        'VaccineTableAdapter
        '
        Me.VaccineTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = final_wellmeadown._wellmeadown_finalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vaccine_orderTableAdapter = Nothing
        Me.TableAdapterManager.vaccine_receivedTableAdapter = Nothing
        Me.TableAdapterManager.vaccineTableAdapter = Me.VaccineTableAdapter
        Me.TableAdapterManager.wardTableAdapter = Nothing
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(0, 524)
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
        Me.btn_vaccine_oder.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_vaccine_oder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_vaccine_oder.FlatAppearance.BorderSize = 0
        Me.btn_vaccine_oder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vaccine_oder.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vaccine_oder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vaccine_oder.Location = New System.Drawing.Point(0, 409)
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
        Me.btn_suppiler.Location = New System.Drawing.Point(0, 373)
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
        Me.btn_patient_medication.Location = New System.Drawing.Point(0, 337)
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
        Me.btn_patient_appointment.Location = New System.Drawing.Point(0, 265)
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
        Me.btn_patient_allocation.Location = New System.Drawing.Point(0, 301)
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
        Me.btnd_staff_allocation.Location = New System.Drawing.Point(0, 193)
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
        Me.btn_patient.Location = New System.Drawing.Point(0, 229)
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
        Me.btn_staff.Location = New System.Drawing.Point(0, 157)
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
        Me.PictureBox2.Location = New System.Drawing.Point(8, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 164
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(164, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1008, 493)
        Me.DataGridView1.TabIndex = 174
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(164, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(346, 21)
        Me.TextBox1.TabIndex = 176
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(516, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 175
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'vaccine_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "vaccine_order"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._wellmeadown_finalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VaccineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _wellmeadown_finalDataSet1 As _wellmeadown_finalDataSet1
    Friend WithEvents VaccineBindingSource As BindingSource
    Friend WithEvents VaccineTableAdapter As _wellmeadown_finalDataSet1TableAdapters.vaccineTableAdapter
    Friend WithEvents TableAdapterManager As _wellmeadown_finalDataSet1TableAdapters.TableAdapterManager
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
