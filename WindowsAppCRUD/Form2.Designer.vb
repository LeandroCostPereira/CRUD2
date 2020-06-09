<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtutilizador = New System.Windows.Forms.TextBox()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.cbnivel = New System.Windows.Forms.ComboBox()
        Me.lblnivel = New System.Windows.Forms.Label()
        Me.lblsenha = New System.Windows.Forms.Label()
        Me.lblutilizador = New System.Windows.Forms.Label()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btnreload = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.dglista = New System.Windows.Forms.DataGridView()
        Me.Dbusers1DataSet = New WindowsAppCRUD.Dbusers1DataSet()
        Me.Dbusers1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dglista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbusers1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbusers1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Controls.Add(Me.txtutilizador)
        Me.GroupBox1.Controls.Add(Me.txtsenha)
        Me.GroupBox1.Controls.Add(Me.cbnivel)
        Me.GroupBox1.Controls.Add(Me.lblnivel)
        Me.GroupBox1.Controls.Add(Me.lblsenha)
        Me.GroupBox1.Controls.Add(Me.lblutilizador)
        Me.GroupBox1.Controls.Add(Me.lblnome)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 236)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Formulario"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(76, 57)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(205, 20)
        Me.txtnome.TabIndex = 9
        '
        'txtutilizador
        '
        Me.txtutilizador.Location = New System.Drawing.Point(76, 92)
        Me.txtutilizador.Name = "txtutilizador"
        Me.txtutilizador.Size = New System.Drawing.Size(205, 20)
        Me.txtutilizador.TabIndex = 8
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(76, 127)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenha.Size = New System.Drawing.Size(205, 20)
        Me.txtsenha.TabIndex = 7
        '
        'cbnivel
        '
        Me.cbnivel.FormattingEnabled = True
        Me.cbnivel.Items.AddRange(New Object() {"Equipa", "Administrador"})
        Me.cbnivel.Location = New System.Drawing.Point(103, 160)
        Me.cbnivel.Name = "cbnivel"
        Me.cbnivel.Size = New System.Drawing.Size(178, 21)
        Me.cbnivel.TabIndex = 6
        '
        'lblnivel
        '
        Me.lblnivel.AutoSize = True
        Me.lblnivel.ForeColor = System.Drawing.Color.DarkRed
        Me.lblnivel.Location = New System.Drawing.Point(6, 163)
        Me.lblnivel.Name = "lblnivel"
        Me.lblnivel.Size = New System.Drawing.Size(86, 13)
        Me.lblnivel.TabIndex = 4
        Me.lblnivel.Text = "Nivel de acesso:"
        '
        'lblsenha
        '
        Me.lblsenha.AutoSize = True
        Me.lblsenha.ForeColor = System.Drawing.Color.DarkRed
        Me.lblsenha.Location = New System.Drawing.Point(31, 130)
        Me.lblsenha.Name = "lblsenha"
        Me.lblsenha.Size = New System.Drawing.Size(41, 13)
        Me.lblsenha.TabIndex = 3
        Me.lblsenha.Text = "Senha:"
        '
        'lblutilizador
        '
        Me.lblutilizador.AutoSize = True
        Me.lblutilizador.ForeColor = System.Drawing.Color.DarkRed
        Me.lblutilizador.Location = New System.Drawing.Point(17, 95)
        Me.lblutilizador.Name = "lblutilizador"
        Me.lblutilizador.Size = New System.Drawing.Size(53, 13)
        Me.lblutilizador.TabIndex = 2
        Me.lblutilizador.Text = "Utilizador:"
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.ForeColor = System.Drawing.Color.DarkRed
        Me.lblnome.Location = New System.Drawing.Point(31, 60)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(38, 13)
        Me.lblnome.TabIndex = 1
        Me.lblnome.Text = "Nome:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.ForeColor = System.Drawing.Color.DarkRed
        Me.lblId.Location = New System.Drawing.Point(31, 34)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(19, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id:"
        '
        'btncreate
        '
        Me.btncreate.BackColor = System.Drawing.Color.Cyan
        Me.btncreate.ForeColor = System.Drawing.Color.DarkRed
        Me.btncreate.Location = New System.Drawing.Point(350, 33)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(429, 39)
        Me.btncreate.TabIndex = 1
        Me.btncreate.Text = "&Create"
        Me.btncreate.UseVisualStyleBackColor = False
        '
        'btnreload
        '
        Me.btnreload.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnreload.ForeColor = System.Drawing.Color.DarkRed
        Me.btnreload.Location = New System.Drawing.Point(350, 85)
        Me.btnreload.Name = "btnreload"
        Me.btnreload.Size = New System.Drawing.Size(429, 39)
        Me.btnreload.TabIndex = 2
        Me.btnreload.Text = "&Reload"
        Me.btnreload.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnupdate.ForeColor = System.Drawing.Color.DarkRed
        Me.btnupdate.Location = New System.Drawing.Point(350, 142)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(429, 39)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btndelete.ForeColor = System.Drawing.Color.DarkRed
        Me.btndelete.Location = New System.Drawing.Point(350, 198)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(429, 39)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'dglista
        '
        Me.dglista.AllowUserToAddRows = False
        Me.dglista.AllowUserToDeleteRows = False
        Me.dglista.AllowUserToResizeColumns = False
        Me.dglista.AllowUserToResizeRows = False
        Me.dglista.AutoGenerateColumns = False
        Me.dglista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglista.DataSource = Me.Dbusers1DataSetBindingSource
        Me.dglista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dglista.Location = New System.Drawing.Point(12, 254)
        Me.dglista.Name = "dglista"
        Me.dglista.RowHeadersVisible = False
        Me.dglista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect
        Me.dglista.Size = New System.Drawing.Size(767, 184)
        Me.dglista.TabIndex = 5
        '
        'Dbusers1DataSet
        '
        Me.Dbusers1DataSet.DataSetName = "Dbusers1DataSet"
        Me.Dbusers1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dbusers1DataSetBindingSource
        '
        Me.Dbusers1DataSetBindingSource.DataSource = Me.Dbusers1DataSet
        Me.Dbusers1DataSetBindingSource.Position = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dglista)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnreload)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "CRUD- App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dglista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbusers1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbusers1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtutilizador As TextBox
    Friend WithEvents txtsenha As TextBox
    Friend WithEvents cbnivel As ComboBox
    Friend WithEvents lblnivel As Label
    Friend WithEvents lblsenha As Label
    Friend WithEvents lblutilizador As Label
    Friend WithEvents lblnome As Label
    Friend WithEvents lblId As Label
    Friend WithEvents btncreate As Button
    Friend WithEvents btnreload As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents dglista As DataGridView
    Friend WithEvents Dbusers1DataSetBindingSource As BindingSource
    Friend WithEvents Dbusers1DataSet As Dbusers1DataSet
End Class
