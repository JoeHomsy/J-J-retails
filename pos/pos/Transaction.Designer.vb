<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaction
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInvoice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(825, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(106, 84)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(100, 20)
        Me.txtClient.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "INVOICE#"
        '
        'txtInvoice
        '
        Me.txtInvoice.Enabled = False
        Me.txtInvoice.Location = New System.Drawing.Point(106, 53)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoice.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(257, 54)
        Me.DateTimePicker1.MinDate = New Date(2019, 4, 4, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(700, 124)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(103, 31)
        Me.btnNew.TabIndex = 21
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClient
        '
        Me.btnClient.Location = New System.Drawing.Point(700, 241)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(103, 32)
        Me.btnClient.TabIndex = 22
        Me.btnClient.Text = "Client"
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(700, 198)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 37)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(671, 163)
        Me.DataGridView1.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 20)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 20)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(341, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 20)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(491, 293)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 20)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(700, 161)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 31)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Currency"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(700, 279)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(103, 32)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(257, 86)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 20)
        Me.Button7.TabIndex = 31
        Me.Button7.Text = "RETURN"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 337)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClient)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Transaction"
        Me.Text = "Transaction"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtClient As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInvoice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNew As Button
    Friend WithEvents btnClient As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
