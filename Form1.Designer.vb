<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmbSpider = New System.Windows.Forms.ComboBox()
        Me.picSpider = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbDuende = New System.Windows.Forms.ComboBox()
        Me.picDuende = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picSpider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.picDuende, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(611, 354)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbSpider)
        Me.TabPage1.Controls.Add(Me.picSpider)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(603, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Spider-Man"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbSpider
        '
        Me.cmbSpider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpider.FormattingEnabled = True
        Me.cmbSpider.Items.AddRange(New Object() {"Sonriendo", "Llorando", "Enojado", "Burla"})
        Me.cmbSpider.Location = New System.Drawing.Point(52, 74)
        Me.cmbSpider.Name = "cmbSpider"
        Me.cmbSpider.Size = New System.Drawing.Size(259, 28)
        Me.cmbSpider.TabIndex = 1
        '
        'picSpider
        '
        Me.picSpider.Location = New System.Drawing.Point(341, 33)
        Me.picSpider.Name = "picSpider"
        Me.picSpider.Size = New System.Drawing.Size(229, 266)
        Me.picSpider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpider.TabIndex = 0
        Me.picSpider.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbDuende)
        Me.TabPage2.Controls.Add(Me.picDuende)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(603, 321)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Duende Verde"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbDuende
        '
        Me.cmbDuende.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDuende.FormattingEnabled = True
        Me.cmbDuende.Items.AddRange(New Object() {"Sonriendo", "Llorando", "Enojado", "Burla"})
        Me.cmbDuende.Location = New System.Drawing.Point(52, 74)
        Me.cmbDuende.Name = "cmbDuende"
        Me.cmbDuende.Size = New System.Drawing.Size(259, 28)
        Me.cmbDuende.TabIndex = 3
        '
        'picDuende
        '
        Me.picDuende.Location = New System.Drawing.Point(341, 33)
        Me.picDuende.Name = "picDuende"
        Me.picDuende.Size = New System.Drawing.Size(229, 266)
        Me.picDuende.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDuende.TabIndex = 2
        Me.picDuende.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 354)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spidey y Duende Verde"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.picSpider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.picDuende, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbSpider As ComboBox
    Friend WithEvents picSpider As PictureBox
    Friend WithEvents cmbDuende As ComboBox
    Friend WithEvents picDuende As PictureBox
End Class
