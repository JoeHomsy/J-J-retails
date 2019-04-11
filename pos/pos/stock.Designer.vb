<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
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
        Dim I_qtyLabel As System.Windows.Forms.Label
        Dim I_priceLabel As System.Windows.Forms.Label
        Dim I_sizeLabel As System.Windows.Forms.Label
        Dim I_colorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stock))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._J_JDataSet = New pos._J_JDataSet()
        Me.Item_StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item_StockTableAdapter = New pos._J_JDataSetTableAdapters.Item_StockTableAdapter()
        Me.TableAdapterManager = New pos._J_JDataSetTableAdapters.TableAdapterManager()
        Me.Item_StockBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Item_StockBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.txt33 = New System.Windows.Forms.TextBox()
        I_qtyLabel = New System.Windows.Forms.Label()
        I_priceLabel = New System.Windows.Forms.Label()
        I_sizeLabel = New System.Windows.Forms.Label()
        I_colorLabel = New System.Windows.Forms.Label()
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Item_StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Item_StockBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Item_StockBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'I_qtyLabel
        '
        I_qtyLabel.AutoSize = True
        I_qtyLabel.Location = New System.Drawing.Point(18, 92)
        I_qtyLabel.Name = "I_qtyLabel"
        I_qtyLabel.Size = New System.Drawing.Size(49, 13)
        I_qtyLabel.TabIndex = 60
        I_qtyLabel.Text = "Quantity:"
        '
        'I_priceLabel
        '
        I_priceLabel.AutoSize = True
        I_priceLabel.Location = New System.Drawing.Point(200, 66)
        I_priceLabel.Name = "I_priceLabel"
        I_priceLabel.Size = New System.Drawing.Size(34, 13)
        I_priceLabel.TabIndex = 62
        I_priceLabel.Text = "Price:"
        '
        'I_sizeLabel
        '
        I_sizeLabel.AutoSize = True
        I_sizeLabel.Location = New System.Drawing.Point(206, 93)
        I_sizeLabel.Name = "I_sizeLabel"
        I_sizeLabel.Size = New System.Drawing.Size(30, 13)
        I_sizeLabel.TabIndex = 63
        I_sizeLabel.Text = "Size:"
        '
        'I_colorLabel
        '
        I_colorLabel.AutoSize = True
        I_colorLabel.Location = New System.Drawing.Point(200, 127)
        I_colorLabel.Name = "I_colorLabel"
        I_colorLabel.Size = New System.Drawing.Size(34, 13)
        I_colorLabel.TabIndex = 64
        I_colorLabel.Text = "Color:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Barcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Style"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SKU"
        '
        '_J_JDataSet
        '
        Me._J_JDataSet.DataSetName = "_J_JDataSet"
        Me._J_JDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Item_StockBindingSource
        '
        Me.Item_StockBindingSource.DataMember = "Item Stock"
        Me.Item_StockBindingSource.DataSource = Me._J_JDataSet
        '
        'Item_StockTableAdapter
        '
        Me.Item_StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.currencyTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.inv_contentTableAdapter = Nothing
        Me.TableAdapterManager.invoice_headerTableAdapter = Nothing
        Me.TableAdapterManager.Item_StockTableAdapter = Me.Item_StockTableAdapter
        Me.TableAdapterManager.jjusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pos._J_JDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Item_StockBindingNavigator
        '
        Me.Item_StockBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Item_StockBindingNavigator.BindingSource = Me.Item_StockBindingSource
        Me.Item_StockBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Item_StockBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Item_StockBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Item_StockBindingNavigatorSaveItem})
        Me.Item_StockBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Item_StockBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Item_StockBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Item_StockBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Item_StockBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Item_StockBindingNavigator.Name = "Item_StockBindingNavigator"
        Me.Item_StockBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Item_StockBindingNavigator.Size = New System.Drawing.Size(808, 25)
        Me.Item_StockBindingNavigator.TabIndex = 58
        Me.Item_StockBindingNavigator.Text = "BindingNavigator1"
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
        'Item_StockBindingNavigatorSaveItem
        '
        Me.Item_StockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Item_StockBindingNavigatorSaveItem.Image = CType(resources.GetObject("Item_StockBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Item_StockBindingNavigatorSaveItem.Name = "Item_StockBindingNavigatorSaveItem"
        Me.Item_StockBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Item_StockBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txt1
        '
        Me.txt1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Item_StockBindingSource, "i_code", True))
        Me.txt1.Location = New System.Drawing.Point(74, 37)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 59
        '
        'txt2
        '
        Me.txt2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Item_StockBindingSource, "i_description", True))
        Me.txt2.Location = New System.Drawing.Point(74, 63)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 60
        '
        'txt4
        '
        Me.txt4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Item_StockBindingSource, "sku", True))
        Me.txt4.Location = New System.Drawing.Point(244, 34)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(100, 20)
        Me.txt4.TabIndex = 62
        '
        'txt5
        '
        Me.txt5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Item_StockBindingSource, "i_price", True))
        Me.txt5.Location = New System.Drawing.Point(244, 63)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(100, 20)
        Me.txt5.TabIndex = 63
        '
        'txt6
        '
        Me.txt6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Item_StockBindingSource, "i_size", True))
        Me.txt6.Location = New System.Drawing.Point(245, 90)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(100, 20)
        Me.txt6.TabIndex = 64
        '
        'txt7
        '
        Me.txt7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Item_StockBindingSource, "i_color", True))
        Me.txt7.Location = New System.Drawing.Point(245, 124)
        Me.txt7.Name = "txt7"
        Me.txt7.Size = New System.Drawing.Size(100, 20)
        Me.txt7.TabIndex = 65
        '
        'txt33
        '
        Me.txt33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Item_StockBindingSource, "i_qty", True))
        Me.txt33.Location = New System.Drawing.Point(74, 89)
        Me.txt33.Name = "txt33"
        Me.txt33.Size = New System.Drawing.Size(100, 20)
        Me.txt33.TabIndex = 61
        '
        'stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 303)
        Me.Controls.Add(I_colorLabel)
        Me.Controls.Add(Me.txt7)
        Me.Controls.Add(I_sizeLabel)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(I_priceLabel)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(I_qtyLabel)
        Me.Controls.Add(Me.txt33)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Item_StockBindingNavigator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "stock"
        Me.Text = "stock"
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Item_StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Item_StockBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Item_StockBindingNavigator.ResumeLayout(False)
        Me.Item_StockBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents _J_JDataSet As _J_JDataSet
    Friend WithEvents Item_StockBindingSource As BindingSource
    Friend WithEvents Item_StockTableAdapter As _J_JDataSetTableAdapters.Item_StockTableAdapter
    Friend WithEvents TableAdapterManager As _J_JDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Item_StockBindingNavigator As BindingNavigator
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
    Friend WithEvents Item_StockBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt6 As TextBox
    Friend WithEvents txt7 As TextBox
    Friend WithEvents txt33 As TextBox
End Class
