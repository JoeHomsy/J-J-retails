<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._J_JDataSet = New pos._J_JDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EmployeeTableAdapter = New pos._J_JDataSetTableAdapters.employeeTableAdapter()
        Me.TableAdapterManager = New pos._J_JDataSetTableAdapters.TableAdapterManager()
        Me.ClientBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Client_idLabel1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.comboGender = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.DateTimePicker()
        Me.ComboxPosition = New System.Windows.Forms.TextBox()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me._J_JDataSet
        '
        '_J_JDataSet
        '
        Me._J_JDataSet.DataSetName = "_J_JDataSet"
        Me._J_JDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fisrt Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(261, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(263, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(263, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Date Of Birth"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(124, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "CLient ID"
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.currencyTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.inv_contentTableAdapter = Nothing
        Me.TableAdapterManager.invoice_headerTableAdapter = Nothing
        Me.TableAdapterManager.Item_StockTableAdapter = Nothing
        Me.TableAdapterManager.jjusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pos._J_JDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'ClientBindingNavigator
        '
        Me.ClientBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientBindingNavigatorSaveItem})
        Me.ClientBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientBindingNavigator.Name = "ClientBindingNavigator"
        Me.ClientBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientBindingNavigator.Size = New System.Drawing.Size(698, 25)
        Me.ClientBindingNavigator.TabIndex = 50
        Me.ClientBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ClientBindingNavigatorSaveItem
        '
        Me.ClientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientBindingNavigatorSaveItem.Name = "ClientBindingNavigatorSaveItem"
        Me.ClientBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 49
        '
        'Client_idLabel1
        '
        Me.Client_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "client_id", True))
        Me.Client_idLabel1.Location = New System.Drawing.Point(127, 37)
        Me.Client_idLabel1.Name = "Client_idLabel1"
        Me.Client_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Client_idLabel1.TabIndex = 51
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "client_fn", True))
        Me.txtFirstName.Location = New System.Drawing.Point(127, 65)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 52
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "client_ln", True))
        Me.txtLastName.Location = New System.Drawing.Point(127, 93)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 53
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "client_number", True))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(127, 125)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 55
        '
        'txtaddress
        '
        Me.txtaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "client_Address", True))
        Me.txtaddress.Location = New System.Drawing.Point(356, 33)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(100, 20)
        Me.txtaddress.TabIndex = 56
        '
        'comboGender
        '
        Me.comboGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "client_Gender", True))
        Me.comboGender.Location = New System.Drawing.Point(356, 63)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(100, 20)
        Me.comboGender.TabIndex = 57
        '
        'txtdob
        '
        Me.txtdob.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "client_dob", True))
        Me.txtdob.Location = New System.Drawing.Point(356, 95)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(100, 20)
        Me.txtdob.TabIndex = 58
        '
        'ComboxPosition
        '
        Me.ComboxPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "client_position", True))
        Me.ComboxPosition.Location = New System.Drawing.Point(356, 125)
        Me.ComboxPosition.Name = "ComboxPosition"
        Me.ComboxPosition.Size = New System.Drawing.Size(100, 20)
        Me.ComboxPosition.TabIndex = 59
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 271)
        Me.Controls.Add(Me.ComboxPosition)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.comboGender)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Client_idLabel1)
        Me.Controls.Add(Me.ClientBindingNavigator)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientBindingNavigator.ResumeLayout(False)
        Me.ClientBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents _J_JDataSet As _J_JDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As _J_JDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents TableAdapterManager As _J_JDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClientBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Client_idLabel1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents comboGender As TextBox
    Friend WithEvents txtdob As DateTimePicker
    Friend WithEvents ComboxPosition As TextBox
End Class
