<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGravar = New System.Windows.Forms.ToolStripButton()
        Me.btnConsulta = New System.Windows.Forms.ToolStripButton()
        Me.cmbTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.txtBusca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tabGerenciaClientes = New System.Windows.Forms.TabControl()
        Me.tabDadosCliente = New System.Windows.Forms.TabPage()
        Me.txtDataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFone = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUf = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgUser = New System.Windows.Forms.PictureBox()
        Me.tabListaCadastro = New System.Windows.Forms.TabPage()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.tabGerenciaClientes.SuspendLayout()
        Me.tabDadosCliente.SuspendLayout()
        CType(Me.imgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabListaCadastro.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGravar, Me.btnConsulta, Me.cmbTipo, Me.txtBusca, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(12, 8, 12, 8)
        Me.ToolStrip1.Size = New System.Drawing.Size(585, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGravar
        '
        Me.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.btnGravar.Size = New System.Drawing.Size(40, 20)
        Me.btnGravar.Text = "ToolStripButton1"
        Me.btnGravar.ToolTipText = "Salvar"
        '
        'btnConsulta
        '
        Me.btnConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), System.Drawing.Image)
        Me.btnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.btnConsulta.Size = New System.Drawing.Size(40, 20)
        Me.btnConsulta.Text = "ToolStripButton2"
        Me.btnConsulta.ToolTipText = "Consultar"
        '
        'cmbTipo
        '
        Me.cmbTipo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 23)
        '
        'txtBusca
        '
        Me.txtBusca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtBusca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripLabel1.Size = New System.Drawing.Size(188, 20)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de pesquisa: "
        '
        'tabGerenciaClientes
        '
        Me.tabGerenciaClientes.AccessibleName = "Listagem de Cadastros"
        Me.tabGerenciaClientes.Controls.Add(Me.tabDadosCliente)
        Me.tabGerenciaClientes.Controls.Add(Me.tabListaCadastro)
        Me.tabGerenciaClientes.Location = New System.Drawing.Point(0, 42)
        Me.tabGerenciaClientes.Name = "tabGerenciaClientes"
        Me.tabGerenciaClientes.SelectedIndex = 0
        Me.tabGerenciaClientes.Size = New System.Drawing.Size(589, 372)
        Me.tabGerenciaClientes.TabIndex = 1
        Me.tabGerenciaClientes.Tag = ""
        '
        'tabDadosCliente
        '
        Me.tabDadosCliente.Controls.Add(Me.txtDataNascimento)
        Me.tabDadosCliente.Controls.Add(Me.txtEmail)
        Me.tabDadosCliente.Controls.Add(Me.Label9)
        Me.tabDadosCliente.Controls.Add(Me.txtFone)
        Me.tabDadosCliente.Controls.Add(Me.Label10)
        Me.tabDadosCliente.Controls.Add(Me.txtUf)
        Me.tabDadosCliente.Controls.Add(Me.Label8)
        Me.tabDadosCliente.Controls.Add(Me.txtCidade)
        Me.tabDadosCliente.Controls.Add(Me.Label6)
        Me.tabDadosCliente.Controls.Add(Me.txtBairro)
        Me.tabDadosCliente.Controls.Add(Me.Label7)
        Me.tabDadosCliente.Controls.Add(Me.txtEndereco)
        Me.tabDadosCliente.Controls.Add(Me.Label4)
        Me.tabDadosCliente.Controls.Add(Me.txtCep)
        Me.tabDadosCliente.Controls.Add(Me.Label5)
        Me.tabDadosCliente.Controls.Add(Me.txtNome)
        Me.tabDadosCliente.Controls.Add(Me.Label3)
        Me.tabDadosCliente.Controls.Add(Me.Label2)
        Me.tabDadosCliente.Controls.Add(Me.txtCpf)
        Me.tabDadosCliente.Controls.Add(Me.Label1)
        Me.tabDadosCliente.Controls.Add(Me.imgUser)
        Me.tabDadosCliente.Location = New System.Drawing.Point(4, 22)
        Me.tabDadosCliente.Name = "tabDadosCliente"
        Me.tabDadosCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDadosCliente.Size = New System.Drawing.Size(581, 346)
        Me.tabDadosCliente.TabIndex = 0
        Me.tabDadosCliente.Text = "Dados do Cliente"
        Me.tabDadosCliente.UseVisualStyleBackColor = True
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNascimento.Location = New System.Drawing.Point(231, 47)
        Me.txtDataNascimento.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.txtDataNascimento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(163, 20)
        Me.txtDataNascimento.TabIndex = 2
        Me.txtDataNascimento.Value = New Date(2022, 9, 8, 0, 0, 0, 0)
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(231, 282)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(321, 20)
        Me.txtEmail.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(228, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Email"
        '
        'txtFone
        '
        Me.txtFone.Location = New System.Drawing.Point(29, 282)
        Me.txtFone.Mask = "(11) \99999-9999"
        Me.txtFone.Name = "txtFone"
        Me.txtFone.Size = New System.Drawing.Size(163, 20)
        Me.txtFone.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Telefone"
        '
        'txtUf
        '
        Me.txtUf.Location = New System.Drawing.Point(435, 225)
        Me.txtUf.Mask = "aa"
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(117, 20)
        Me.txtUf.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(429, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Unidade Federativa (UF)"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(231, 225)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(163, 20)
        Me.txtCidade.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cidade"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(29, 225)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(163, 20)
        Me.txtBairro.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Bairro"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(231, 164)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(321, 20)
        Me.txtEndereco.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Endereço"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(29, 164)
        Me.txtCep.Mask = "99999-999"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(163, 20)
        Me.txtCep.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CEP"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(29, 104)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(365, 20)
        Me.txtNome.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome Completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data de Nascimento"
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(29, 48)
        Me.txtCpf.Mask = "999.999.999-99"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(163, 20)
        Me.txtCpf.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPF (Cadastro de Pessoa Física)"
        '
        'imgUser
        '
        Me.imgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgUser.Image = CType(resources.GetObject("imgUser.Image"), System.Drawing.Image)
        Me.imgUser.Location = New System.Drawing.Point(424, 20)
        Me.imgUser.Name = "imgUser"
        Me.imgUser.Size = New System.Drawing.Size(128, 128)
        Me.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUser.TabIndex = 0
        Me.imgUser.TabStop = False
        '
        'tabListaCadastro
        '
        Me.tabListaCadastro.Controls.Add(Me.dgvDados)
        Me.tabListaCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tabListaCadastro.Name = "tabListaCadastro"
        Me.tabListaCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabListaCadastro.Size = New System.Drawing.Size(581, 346)
        Me.tabListaCadastro.TabIndex = 1
        Me.tabListaCadastro.Text = "Listagem de Cadastros"
        Me.tabListaCadastro.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvDados.Location = New System.Drawing.Point(9, 7)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(560, 333)
        Me.dgvDados.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N.º"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "CPF do Cliente"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Editar"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Excluir"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(585, 409)
        Me.Controls.Add(Me.tabGerenciaClientes)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Clientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tabGerenciaClientes.ResumeLayout(False)
        Me.tabDadosCliente.ResumeLayout(False)
        Me.tabDadosCliente.PerformLayout()
        CType(Me.imgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabListaCadastro.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGravar As ToolStripButton
    Friend WithEvents btnConsulta As ToolStripButton
    Friend WithEvents tabGerenciaClientes As TabControl
    Friend WithEvents tabDadosCliente As TabPage
    Friend WithEvents txtCidade As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBairro As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEndereco As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNome As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents imgUser As PictureBox
    Friend WithEvents tabListaCadastro As TabPage
    Friend WithEvents txtDataNascimento As DateTimePicker
    Friend WithEvents txtEmail As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFone As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUf As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmbTipo As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtBusca As ToolStripTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
