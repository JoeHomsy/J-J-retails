<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CURRENCY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CURRENCY))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._J_JDataSet = New pos._J_JDataSet()
        Me.CurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyTableAdapter = New pos._J_JDataSetTableAdapters.currencyTableAdapter()
        Me.TableAdapterManager = New pos._J_JDataSetTableAdapters.TableAdapterManager()
        Me.CurrencyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CurrencyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CurrencyBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Currency ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Currency Description"
        '
        '_J_JDataSet
        '
        Me._J_JDataSet.DataSetName = "_J_JDataSet"
        Me._J_JDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CurrencyBindingSource
        '
        Me.CurrencyBindingSource.DataMember = "currency"
        Me.CurrencyBindingSource.DataSource = Me._J_JDataSet
        '
        'CurrencyTableAdapter
        '
        Me.CurrencyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.currencyTableAdapter = Me.CurrencyTableAdapter
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.inv_contentTableAdapter = Nothing
        Me.TableAdapterManager.invoice_headerTableAdapter = Nothing
        Me.TableAdapterManager.Item_StockTableAdapter = Nothing
        Me.TableAdapterManager.jjusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pos._J_JDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'CurrencyBindingNavigator
        '
        Me.CurrencyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CurrencyBindingNavigator.BindingSource = Me.CurrencyBindingSource
        Me.CurrencyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CurrencyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CurrencyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CurrencyBindingNavigatorSaveItem})
        Me.CurrencyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CurrencyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CurrencyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CurrencyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CurrencyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CurrencyBindingNavigator.Name = "CurrencyBindingNavigator"
        Me.CurrencyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CurrencyBindingNavigator.Size = New System.Drawing.Size(366, 25)
        Me.CurrencyBindingNavigator.TabIndex = 46
        Me.CurrencyBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CurrencyBindingNavigatorSaveItem
        '
        Me.CurrencyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CurrencyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CurrencyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CurrencyBindingNavigatorSaveItem.Name = "CurrencyBindingNavigatorSaveItem"
        Me.CurrencyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CurrencyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrencyBindingSource, "cur_id", True))
        Me.TextBox2.Location = New System.Drawing.Point(167, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 47
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrencyBindingSource, "cur_description", True))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(167, 82)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 48
        '
        'CURRENCY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 162)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CurrencyBindingNavigator)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "CURRENCY"
        Me.Text = "CURRENCY"
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CurrencyBindingNavigator.ResumeLayout(False)
        Me.CurrencyBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents _J_JDataSet As _J_JDataSet
    Friend WithEvents CurrencyBindingSource As BindingSource
    Friend WithEvents CurrencyTableAdapter As _J_JDataSetTableAdapters.currencyTableAdapter
    Friend WithEvents TableAdapterManager As _J_JDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CurrencyBindingNavigator As BindingNavigator
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
    Friend WithEvents CurrencyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
End Class
