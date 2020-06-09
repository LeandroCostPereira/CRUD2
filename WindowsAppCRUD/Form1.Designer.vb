<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LbIed = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.LblUtilizador = New System.Windows.Forms.Label()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.LblNivel = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtUtilizador = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Cbnivel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgLista = New System.Windows.Forms.DataGridView()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Dbusers1DataSet = New WindowsAppCRUD.Dbusers1DataSet()
        Me.Dbusers1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizadoresTableAdapter = New WindowsAppCRUD.Dbusers1DataSetTableAdapters.utilizadoresTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilizadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenhaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbusers1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbusers1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbIed
        '
        Me.LbIed.AutoSize = True
        Me.LbIed.Location = New System.Drawing.Point(81, 16)
        Me.LbIed.Name = "LbIed"
        Me.LbIed.Size = New System.Drawing.Size(15, 13)
        Me.LbIed.TabIndex = 0
        Me.LbIed.Text = "id"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Location = New System.Drawing.Point(63, 52)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(33, 13)
        Me.LblNome.TabIndex = 1
        Me.LblNome.Text = "nome"
        '
        'LblUtilizador
        '
        Me.LblUtilizador.AutoSize = True
        Me.LblUtilizador.Location = New System.Drawing.Point(48, 104)
        Me.LblUtilizador.Name = "LblUtilizador"
        Me.LblUtilizador.Size = New System.Drawing.Size(48, 13)
        Me.LblUtilizador.TabIndex = 2
        Me.LblUtilizador.Text = "utilizador"
        '
        'LblSenha
        '
        Me.LblSenha.AutoSize = True
        Me.LblSenha.Location = New System.Drawing.Point(60, 144)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(36, 13)
        Me.LblSenha.TabIndex = 3
        Me.LblSenha.Text = "senha"
        '
        'LblNivel
        '
        Me.LblNivel.AutoSize = True
        Me.LblNivel.Location = New System.Drawing.Point(13, 190)
        Me.LblNivel.Name = "LblNivel"
        Me.LblNivel.Size = New System.Drawing.Size(83, 13)
        Me.LblNivel.TabIndex = 4
        Me.LblNivel.Text = "Nivel de acesso"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(102, 49)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(174, 20)
        Me.TxtNome.TabIndex = 5
        Me.TxtNome.Text = "ndr"
        '
        'TxtUtilizador
        '
        Me.TxtUtilizador.Location = New System.Drawing.Point(102, 97)
        Me.TxtUtilizador.Name = "TxtUtilizador"
        Me.TxtUtilizador.Size = New System.Drawing.Size(174, 20)
        Me.TxtUtilizador.TabIndex = 6
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(102, 137)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(174, 20)
        Me.TxtSenha.TabIndex = 7
        '
        'Cbnivel
        '
        Me.Cbnivel.FormattingEnabled = True
        Me.Cbnivel.Items.AddRange(New Object() {"Equipe", "Administrador"})
        Me.Cbnivel.Location = New System.Drawing.Point(102, 187)
        Me.Cbnivel.Name = "Cbnivel"
        Me.Cbnivel.Size = New System.Drawing.Size(174, 21)
        Me.Cbnivel.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbIed)
        Me.GroupBox1.Controls.Add(Me.Cbnivel)
        Me.GroupBox1.Controls.Add(Me.LblNome)
        Me.GroupBox1.Controls.Add(Me.TxtSenha)
        Me.GroupBox1.Controls.Add(Me.LblUtilizador)
        Me.GroupBox1.Controls.Add(Me.TxtUtilizador)
        Me.GroupBox1.Controls.Add(Me.LblSenha)
        Me.GroupBox1.Controls.Add(Me.TxtNome)
        Me.GroupBox1.Controls.Add(Me.LblNivel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 232)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DgLista
        '
        Me.DgLista.AutoGenerateColumns = False
        Me.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.UtilizadorDataGridViewTextBoxColumn, Me.SenhaDataGridViewTextBoxColumn, Me.NivelDataGridViewCheckBoxColumn})
        Me.DgLista.DataSource = Me.UtilizadoresBindingSource
        Me.DgLista.Location = New System.Drawing.Point(30, 274)
        Me.DgLista.Name = "DgLista"
        Me.DgLista.Size = New System.Drawing.Size(786, 205)
        Me.DgLista.TabIndex = 10
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(385, 28)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(395, 41)
        Me.BtnCreate.TabIndex = 11
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnReload
        '
        Me.BtnReload.Location = New System.Drawing.Point(385, 86)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(395, 41)
        Me.BtnReload.TabIndex = 12
        Me.BtnReload.Text = "reload"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(385, 144)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(395, 41)
        Me.BtnUpdate.TabIndex = 13
        Me.BtnUpdate.Text = "update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(385, 200)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(395, 41)
        Me.BtnDelete.TabIndex = 14
        Me.BtnDelete.Text = "delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
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
        'UtilizadoresBindingSource
        '
        Me.UtilizadoresBindingSource.DataMember = "utilizadores"
        Me.UtilizadoresBindingSource.DataSource = Me.Dbusers1DataSetBindingSource
        '
        'UtilizadoresTableAdapter
        '
        Me.UtilizadoresTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'UtilizadorDataGridViewTextBoxColumn
        '
        Me.UtilizadorDataGridViewTextBoxColumn.DataPropertyName = "utilizador"
        Me.UtilizadorDataGridViewTextBoxColumn.HeaderText = "utilizador"
        Me.UtilizadorDataGridViewTextBoxColumn.Name = "UtilizadorDataGridViewTextBoxColumn"
        '
        'SenhaDataGridViewTextBoxColumn
        '
        Me.SenhaDataGridViewTextBoxColumn.DataPropertyName = "senha"
        Me.SenhaDataGridViewTextBoxColumn.HeaderText = "senha"
        Me.SenhaDataGridViewTextBoxColumn.Name = "SenhaDataGridViewTextBoxColumn"
        '
        'NivelDataGridViewCheckBoxColumn
        '
        Me.NivelDataGridViewCheckBoxColumn.DataPropertyName = "nivel"
        Me.NivelDataGridViewCheckBoxColumn.HeaderText = "nivel"
        Me.NivelDataGridViewCheckBoxColumn.Name = "NivelDataGridViewCheckBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 501)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.DgLista)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbusers1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbusers1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LbIed As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents LblUtilizador As Label
    Friend WithEvents LblSenha As Label
    Friend WithEvents LblNivel As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtUtilizador As TextBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents Cbnivel As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgLista As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Dbusers1DataSetBindingSource As BindingSource
    Friend WithEvents Dbusers1DataSet As Dbusers1DataSet
    Friend WithEvents UtilizadoresBindingSource As BindingSource
    Friend WithEvents UtilizadoresTableAdapter As Dbusers1DataSetTableAdapters.utilizadoresTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UtilizadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SenhaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NivelDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
