<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuHome = New System.Windows.Forms.MenuStrip()
        Me.GerenciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplicativosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairDoSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuHome
        '
        Me.MenuHome.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarToolStripMenuItem, Me.AplicativosToolStripMenuItem, Me.EncerrarToolStripMenuItem})
        Me.MenuHome.Location = New System.Drawing.Point(0, 0)
        Me.MenuHome.Name = "MenuHome"
        Me.MenuHome.Padding = New System.Windows.Forms.Padding(12, 8, 12, 8)
        Me.MenuHome.Size = New System.Drawing.Size(800, 36)
        Me.MenuHome.TabIndex = 0
        Me.MenuHome.Text = "MenuStrip1"
        '
        'GerenciarToolStripMenuItem
        '
        Me.GerenciarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuáriosToolStripMenuItem, Me.ContasToolStripMenuItem})
        Me.GerenciarToolStripMenuItem.Image = CType(resources.GetObject("GerenciarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciarToolStripMenuItem.Name = "GerenciarToolStripMenuItem"
        Me.GerenciarToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.GerenciarToolStripMenuItem.Text = "&Gerenciar"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FornecedoresToolStripMenuItem})
        Me.UsuáriosToolStripMenuItem.Image = CType(resources.GetObject("UsuáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ClientesToolStripMenuItem.Text = "Cadastrar Clientes"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Cadastrar Fornecedores"
        '
        'ContasToolStripMenuItem
        '
        Me.ContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarContasToolStripMenuItem, Me.GerenciarContasToolStripMenuItem})
        Me.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem"
        Me.ContasToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ContasToolStripMenuItem.Text = "Contas"
        '
        'CadastrarContasToolStripMenuItem
        '
        Me.CadastrarContasToolStripMenuItem.Name = "CadastrarContasToolStripMenuItem"
        Me.CadastrarContasToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CadastrarContasToolStripMenuItem.Text = "Cadastrar Contas"
        '
        'GerenciarContasToolStripMenuItem
        '
        Me.GerenciarContasToolStripMenuItem.Name = "GerenciarContasToolStripMenuItem"
        Me.GerenciarContasToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.GerenciarContasToolStripMenuItem.Text = "Gerenciar Contas"
        '
        'AplicativosToolStripMenuItem
        '
        Me.AplicativosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem})
        Me.AplicativosToolStripMenuItem.Image = CType(resources.GetObject("AplicativosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AplicativosToolStripMenuItem.Name = "AplicativosToolStripMenuItem"
        Me.AplicativosToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.AplicativosToolStripMenuItem.Text = "&Aplicativos"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.EncerrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairDoSistemaToolStripMenuItem})
        Me.EncerrarToolStripMenuItem.Image = CType(resources.GetObject("EncerrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EncerrarToolStripMenuItem.Text = "&Encerrar"
        '
        'SairDoSistemaToolStripMenuItem
        '
        Me.SairDoSistemaToolStripMenuItem.Image = CType(resources.GetObject("SairDoSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairDoSistemaToolStripMenuItem.Name = "SairDoSistemaToolStripMenuItem"
        Me.SairDoSistemaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairDoSistemaToolStripMenuItem.Text = "Sair do Sistema"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuHome)
        Me.MainMenuStrip = Me.MenuHome
        Me.Name = "FormMenu"
        Me.Text = "Projeto de Sistemas de Informação"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuHome.ResumeLayout(False)
        Me.MenuHome.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuHome As MenuStrip
    Friend WithEvents GerenciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicativosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairDoSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarContasToolStripMenuItem As ToolStripMenuItem
End Class
