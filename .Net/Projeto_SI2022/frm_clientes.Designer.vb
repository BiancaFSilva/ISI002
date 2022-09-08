<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.User = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_nome = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.MaskedTextBox()
        Me.lb_data_nasc = New System.Windows.Forms.Label()
        Me.txt_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.lb_cpf_cliente = New System.Windows.Forms.Label()
        Me.txt_cpf_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Cadastros = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.User.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cadastros.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(687, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Salvar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Consultar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.User)
        Me.TabControl1.Controls.Add(Me.Cadastros)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(687, 420)
        Me.TabControl1.TabIndex = 2
        '
        'User
        '
        Me.User.BackColor = System.Drawing.Color.Transparent
        Me.User.Controls.Add(Me.Label10)
        Me.User.Controls.Add(Me.txt_email)
        Me.User.Controls.Add(Me.Label9)
        Me.User.Controls.Add(Me.txt_fone)
        Me.User.Controls.Add(Me.Label8)
        Me.User.Controls.Add(Me.txt_cidade)
        Me.User.Controls.Add(Me.Label7)
        Me.User.Controls.Add(Me.txt_bairro)
        Me.User.Controls.Add(Me.Label6)
        Me.User.Controls.Add(Me.txt_uf)
        Me.User.Controls.Add(Me.Label5)
        Me.User.Controls.Add(Me.txt_endereco)
        Me.User.Controls.Add(Me.Label4)
        Me.User.Controls.Add(Me.txt_cep)
        Me.User.Controls.Add(Me.Label3)
        Me.User.Controls.Add(Me.Label2)
        Me.User.Controls.Add(Me.Label1)
        Me.User.Controls.Add(Me.lb_nome)
        Me.User.Controls.Add(Me.txt_nome)
        Me.User.Controls.Add(Me.lb_data_nasc)
        Me.User.Controls.Add(Me.txt_data_nasc)
        Me.User.Controls.Add(Me.lb_cpf_cliente)
        Me.User.Controls.Add(Me.txt_cpf_cliente)
        Me.User.Controls.Add(Me.img_foto)
        Me.User.Location = New System.Drawing.Point(4, 22)
        Me.User.Name = "User"
        Me.User.Padding = New System.Windows.Forms.Padding(3)
        Me.User.Size = New System.Drawing.Size(679, 394)
        Me.User.TabIndex = 0
        Me.User.Text = "Dados Pessoais"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Endereço"
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(262, 189)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(194, 20)
        Me.txt_endereco.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CEP do Cliente"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(33, 192)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(194, 20)
        Me.txt_cep.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Data de Nascimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CPF do Cliente"
        '
        'lb_nome
        '
        Me.lb_nome.AutoSize = True
        Me.lb_nome.Location = New System.Drawing.Point(-146, 152)
        Me.lb_nome.Name = "lb_nome"
        Me.lb_nome.Size = New System.Drawing.Size(35, 13)
        Me.lb_nome.TabIndex = 15
        Me.lb_nome.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(30, 128)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(435, 20)
        Me.txt_nome.TabIndex = 3
        '
        'lb_data_nasc
        '
        Me.lb_data_nasc.AutoSize = True
        Me.lb_data_nasc.Location = New System.Drawing.Point(-146, 90)
        Me.lb_data_nasc.Name = "lb_data_nasc"
        Me.lb_data_nasc.Size = New System.Drawing.Size(104, 13)
        Me.lb_data_nasc.TabIndex = 13
        Me.lb_data_nasc.Text = "Data de Nascimento"
        '
        'txt_data_nasc
        '
        Me.txt_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_nasc.Location = New System.Drawing.Point(265, 75)
        Me.txt_data_nasc.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.txt_data_nasc.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txt_data_nasc.Name = "txt_data_nasc"
        Me.txt_data_nasc.Size = New System.Drawing.Size(200, 20)
        Me.txt_data_nasc.TabIndex = 2
        Me.txt_data_nasc.Value = New Date(2022, 9, 8, 0, 0, 0, 0)
        '
        'lb_cpf_cliente
        '
        Me.lb_cpf_cliente.AutoSize = True
        Me.lb_cpf_cliente.Location = New System.Drawing.Point(-146, 39)
        Me.lb_cpf_cliente.Name = "lb_cpf_cliente"
        Me.lb_cpf_cliente.Size = New System.Drawing.Size(77, 13)
        Me.lb_cpf_cliente.TabIndex = 11
        Me.lb_cpf_cliente.Text = "CPF do Cliente"
        '
        'txt_cpf_cliente
        '
        Me.txt_cpf_cliente.Location = New System.Drawing.Point(30, 75)
        Me.txt_cpf_cliente.Mask = "999,999,999-99"
        Me.txt_cpf_cliente.Name = "txt_cpf_cliente"
        Me.txt_cpf_cliente.Size = New System.Drawing.Size(194, 20)
        Me.txt_cpf_cliente.TabIndex = 1
        '
        'img_foto
        '
        Me.img_foto.BackgroundImage = CType(resources.GetObject("img_foto.BackgroundImage"), System.Drawing.Image)
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Location = New System.Drawing.Point(489, 41)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(129, 133)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 9
        Me.img_foto.TabStop = False
        '
        'Cadastros
        '
        Me.Cadastros.Controls.Add(Me.DataGridView1)
        Me.Cadastros.Location = New System.Drawing.Point(4, 22)
        Me.Cadastros.Name = "Cadastros"
        Me.Cadastros.Padding = New System.Windows.Forms.Padding(3)
        Me.Cadastros.Size = New System.Drawing.Size(679, 394)
        Me.Cadastros.TabIndex = 1
        Me.Cadastros.Text = "Listagem de Cadastros"
        Me.Cadastros.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(489, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "UF"
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(489, 244)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(129, 20)
        Me.txt_uf.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Bairro"
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(36, 244)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(194, 20)
        Me.txt_bairro.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(262, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Cidade"
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(262, 244)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(194, 20)
        Me.txt_cidade.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Telefone"
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(36, 309)
        Me.txt_fone.Mask = "+55 (11) \99999-9999"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(194, 20)
        Me.txt_fone.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(262, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(262, 309)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(356, 20)
        Me.txt_email.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(663, 355)
        Me.DataGridView1.TabIndex = 0
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_clientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.User.ResumeLayout(False)
        Me.User.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cadastros.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents User As TabPage
    Friend WithEvents lb_nome As Label
    Friend WithEvents txt_nome As MaskedTextBox
    Friend WithEvents lb_data_nasc As Label
    Friend WithEvents txt_data_nasc As DateTimePicker
    Friend WithEvents lb_cpf_cliente As Label
    Friend WithEvents txt_cpf_cliente As MaskedTextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Cadastros As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_endereco As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_uf As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cidade As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_bairro As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_email As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
