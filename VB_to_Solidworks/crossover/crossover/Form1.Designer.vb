<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tbx_float = New System.Windows.Forms.TextBox()
        Me.lbl_types_title = New System.Windows.Forms.Label()
        Me.lbl_read_values = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_quit
        '
        Me.btn_quit.Location = New System.Drawing.Point(152, 226)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(75, 23)
        Me.btn_quit.TabIndex = 0
        Me.btn_quit.Text = "Quit"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(37, 226)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bool"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Int"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Float"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "String"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(94, 136)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 9
        '
        'tbx_float
        '
        Me.tbx_float.Location = New System.Drawing.Point(94, 107)
        Me.tbx_float.Name = "tbx_float"
        Me.tbx_float.Size = New System.Drawing.Size(100, 23)
        Me.tbx_float.TabIndex = 10
        '
        'lbl_types_title
        '
        Me.lbl_types_title.AutoSize = True
        Me.lbl_types_title.Location = New System.Drawing.Point(37, 22)
        Me.lbl_types_title.Name = "lbl_types_title"
        Me.lbl_types_title.Size = New System.Drawing.Size(36, 15)
        Me.lbl_types_title.TabIndex = 11
        Me.lbl_types_title.Text = "Types"
        '
        'lbl_read_values
        '
        Me.lbl_read_values.AutoSize = True
        Me.lbl_read_values.Location = New System.Drawing.Point(94, 22)
        Me.lbl_read_values.Name = "lbl_read_values"
        Me.lbl_read_values.Size = New System.Drawing.Size(69, 15)
        Me.lbl_read_values.TabIndex = 12
        Me.lbl_read_values.Text = "Read Values"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 305)
        Me.Controls.Add(Me.lbl_read_values)
        Me.Controls.Add(Me.lbl_types_title)
        Me.Controls.Add(Me.tbx_float)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_quit)
        Me.Name = "Form1"
        Me.Text = "DataGrabber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_quit As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents tbx_float As TextBox
    Friend WithEvents lbl_types_title As Label
    Friend WithEvents lbl_read_values As Label
End Class
