<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.tbFirst = New System.Windows.Forms.TextBox()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.tbLast = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.listboxNames = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(27, 66)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(76, 16)
        Me.lblFirst.TabIndex = 10
        Me.lblFirst.Text = "First Name:"
        '
        'tbFirst
        '
        Me.tbFirst.Location = New System.Drawing.Point(30, 86)
        Me.tbFirst.Name = "tbFirst"
        Me.tbFirst.Size = New System.Drawing.Size(119, 22)
        Me.tbFirst.TabIndex = 0
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(30, 130)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(76, 16)
        Me.lblLast.TabIndex = 11
        Me.lblLast.Text = "Last Name:"
        '
        'tbLast
        '
        Me.tbLast.Location = New System.Drawing.Point(33, 150)
        Me.tbLast.Name = "tbLast"
        Me.tbLast.Size = New System.Drawing.Size(116, 22)
        Me.tbLast.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(47, 212)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Person"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(30, 361)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(376, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Location = New System.Drawing.Point(342, 22)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(52, 16)
        Me.lblPeople.TabIndex = 15
        Me.lblPeople.Text = "People"
        '
        'listboxNames
        '
        Me.listboxNames.FormattingEnabled = True
        Me.listboxNames.ItemHeight = 16
        Me.listboxNames.Location = New System.Drawing.Point(212, 55)
        Me.listboxNames.Name = "listboxNames"
        Me.listboxNames.Size = New System.Drawing.Size(239, 292)
        Me.listboxNames.Sorted = True
        Me.listboxNames.TabIndex = 16
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(212, 361)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 396)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.listboxNames)
        Me.Controls.Add(Me.lblPeople)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbLast)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.tbFirst)
        Me.Controls.Add(Me.lblFirst)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmList"
        Me.Text = "People List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirst As Label
    Friend WithEvents tbFirst As TextBox
    Friend WithEvents lblLast As Label
    Friend WithEvents tbLast As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPeople As Label
    Friend WithEvents listboxNames As ListBox
    Friend WithEvents btnDelete As Button
End Class
