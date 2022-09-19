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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblCabecalho = New System.Windows.Forms.Label()
        Me.lblAluno = New System.Windows.Forms.Label()
        Me.lblBat = New System.Windows.Forms.Label()
        Me.lblVbs = New System.Windows.Forms.Label()
        Me.btnBatMenu = New System.Windows.Forms.Button()
        Me.btnBatAdivinha = New System.Windows.Forms.Button()
        Me.btnBatJoKenPo = New System.Windows.Forms.Button()
        Me.btnVbsDesafio01 = New System.Windows.Forms.Button()
        Me.btnVbsDesafio02 = New System.Windows.Forms.Button()
        Me.btnVbsDesafio03 = New System.Windows.Forms.Button()
        Me.btnVbsOperadores = New System.Windows.Forms.Button()
        Me.btnVbsSoletrando = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCabecalho
        '
        Me.lblCabecalho.AutoSize = True
        Me.lblCabecalho.BackColor = System.Drawing.Color.Transparent
        Me.lblCabecalho.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabecalho.Location = New System.Drawing.Point(40, 35)
        Me.lblCabecalho.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCabecalho.Name = "lblCabecalho"
        Me.lblCabecalho.Size = New System.Drawing.Size(421, 48)
        Me.lblCabecalho.TabIndex = 0
        Me.lblCabecalho.Text = "Faculdade de Tecnologia de São Caetano do Sul - Antonio Russo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Análise e Desenvol" &
    "vimento de Sistemas, 2º Semestre - Manhã" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ISI002 - Sistemas de Informação"
        Me.lblCabecalho.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAluno
        '
        Me.lblAluno.AutoSize = True
        Me.lblAluno.BackColor = System.Drawing.Color.Transparent
        Me.lblAluno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAluno.Location = New System.Drawing.Point(35, 117)
        Me.lblAluno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAluno.Name = "lblAluno"
        Me.lblAluno.Size = New System.Drawing.Size(188, 32)
        Me.lblAluno.TabIndex = 1
        Me.lblAluno.Text = "Bianca Letícia Floriano da Silva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RA: 1680482211022"
        '
        'lblBat
        '
        Me.lblBat.AutoSize = True
        Me.lblBat.BackColor = System.Drawing.Color.Transparent
        Me.lblBat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat.Location = New System.Drawing.Point(35, 180)
        Me.lblBat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBat.Name = "lblBat"
        Me.lblBat.Size = New System.Drawing.Size(63, 16)
        Me.lblBat.TabIndex = 2
        Me.lblBat.Text = "Batchfile"
        '
        'lblVbs
        '
        Me.lblVbs.AutoSize = True
        Me.lblVbs.BackColor = System.Drawing.Color.Transparent
        Me.lblVbs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVbs.Location = New System.Drawing.Point(280, 180)
        Me.lblVbs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVbs.Name = "lblVbs"
        Me.lblVbs.Size = New System.Drawing.Size(62, 16)
        Me.lblVbs.TabIndex = 3
        Me.lblVbs.Text = "VBScript"
        '
        'btnBatMenu
        '
        Me.btnBatMenu.BackColor = System.Drawing.Color.Lavender
        Me.btnBatMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatMenu.Image = CType(resources.GetObject("btnBatMenu.Image"), System.Drawing.Image)
        Me.btnBatMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatMenu.Location = New System.Drawing.Point(35, 200)
        Me.btnBatMenu.Name = "btnBatMenu"
        Me.btnBatMenu.Size = New System.Drawing.Size(183, 35)
        Me.btnBatMenu.TabIndex = 1
        Me.btnBatMenu.Text = "Menu de Gerenciamento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnBatMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBatMenu.UseVisualStyleBackColor = False
        '
        'btnBatAdivinha
        '
        Me.btnBatAdivinha.BackColor = System.Drawing.Color.Lavender
        Me.btnBatAdivinha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatAdivinha.Image = CType(resources.GetObject("btnBatAdivinha.Image"), System.Drawing.Image)
        Me.btnBatAdivinha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatAdivinha.Location = New System.Drawing.Point(35, 240)
        Me.btnBatAdivinha.Name = "btnBatAdivinha"
        Me.btnBatAdivinha.Size = New System.Drawing.Size(183, 35)
        Me.btnBatAdivinha.TabIndex = 2
        Me.btnBatAdivinha.Text = "Jogo da Adivinhação"
        Me.btnBatAdivinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatAdivinha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBatAdivinha.UseVisualStyleBackColor = False
        '
        'btnBatJoKenPo
        '
        Me.btnBatJoKenPo.BackColor = System.Drawing.Color.Lavender
        Me.btnBatJoKenPo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatJoKenPo.Image = CType(resources.GetObject("btnBatJoKenPo.Image"), System.Drawing.Image)
        Me.btnBatJoKenPo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatJoKenPo.Location = New System.Drawing.Point(35, 280)
        Me.btnBatJoKenPo.Name = "btnBatJoKenPo"
        Me.btnBatJoKenPo.Size = New System.Drawing.Size(183, 35)
        Me.btnBatJoKenPo.TabIndex = 3
        Me.btnBatJoKenPo.Text = "Jogo Jo-Ken-Po"
        Me.btnBatJoKenPo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatJoKenPo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBatJoKenPo.UseVisualStyleBackColor = False
        '
        'btnVbsDesafio01
        '
        Me.btnVbsDesafio01.BackColor = System.Drawing.Color.Lavender
        Me.btnVbsDesafio01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVbsDesafio01.Image = CType(resources.GetObject("btnVbsDesafio01.Image"), System.Drawing.Image)
        Me.btnVbsDesafio01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsDesafio01.Location = New System.Drawing.Point(280, 200)
        Me.btnVbsDesafio01.Name = "btnVbsDesafio01"
        Me.btnVbsDesafio01.Size = New System.Drawing.Size(188, 35)
        Me.btnVbsDesafio01.TabIndex = 4
        Me.btnVbsDesafio01.Text = "Desafio 01 - Áudio"
        Me.btnVbsDesafio01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsDesafio01.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVbsDesafio01.UseVisualStyleBackColor = False
        '
        'btnVbsDesafio02
        '
        Me.btnVbsDesafio02.BackColor = System.Drawing.Color.Lavender
        Me.btnVbsDesafio02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVbsDesafio02.Image = CType(resources.GetObject("btnVbsDesafio02.Image"), System.Drawing.Image)
        Me.btnVbsDesafio02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsDesafio02.Location = New System.Drawing.Point(280, 240)
        Me.btnVbsDesafio02.Name = "btnVbsDesafio02"
        Me.btnVbsDesafio02.Size = New System.Drawing.Size(188, 35)
        Me.btnVbsDesafio02.TabIndex = 5
        Me.btnVbsDesafio02.Text = "Desafio 02 - Números"
        Me.btnVbsDesafio02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsDesafio02.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVbsDesafio02.UseVisualStyleBackColor = False
        '
        'btnVbsDesafio03
        '
        Me.btnVbsDesafio03.BackColor = System.Drawing.Color.Lavender
        Me.btnVbsDesafio03.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVbsDesafio03.Image = CType(resources.GetObject("btnVbsDesafio03.Image"), System.Drawing.Image)
        Me.btnVbsDesafio03.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsDesafio03.Location = New System.Drawing.Point(280, 279)
        Me.btnVbsDesafio03.Name = "btnVbsDesafio03"
        Me.btnVbsDesafio03.Size = New System.Drawing.Size(188, 35)
        Me.btnVbsDesafio03.TabIndex = 6
        Me.btnVbsDesafio03.Text = "Desafio 03 - Fibonacci"
        Me.btnVbsDesafio03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsDesafio03.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVbsDesafio03.UseVisualStyleBackColor = False
        '
        'btnVbsOperadores
        '
        Me.btnVbsOperadores.BackColor = System.Drawing.Color.Lavender
        Me.btnVbsOperadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVbsOperadores.Image = CType(resources.GetObject("btnVbsOperadores.Image"), System.Drawing.Image)
        Me.btnVbsOperadores.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnVbsOperadores.Location = New System.Drawing.Point(280, 320)
        Me.btnVbsOperadores.Name = "btnVbsOperadores"
        Me.btnVbsOperadores.Size = New System.Drawing.Size(188, 34)
        Me.btnVbsOperadores.TabIndex = 7
        Me.btnVbsOperadores.Text = "Operadores Matemáticos"
        Me.btnVbsOperadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsOperadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVbsOperadores.UseVisualStyleBackColor = False
        '
        'btnVbsSoletrando
        '
        Me.btnVbsSoletrando.BackColor = System.Drawing.Color.Lavender
        Me.btnVbsSoletrando.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVbsSoletrando.Image = CType(resources.GetObject("btnVbsSoletrando.Image"), System.Drawing.Image)
        Me.btnVbsSoletrando.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsSoletrando.Location = New System.Drawing.Point(280, 360)
        Me.btnVbsSoletrando.Name = "btnVbsSoletrando"
        Me.btnVbsSoletrando.Size = New System.Drawing.Size(188, 34)
        Me.btnVbsSoletrando.TabIndex = 8
        Me.btnVbsSoletrando.Text = "Jogo de Soletração"
        Me.btnVbsSoletrando.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVbsSoletrando.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVbsSoletrando.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(504, 426)
        Me.Controls.Add(Me.btnVbsSoletrando)
        Me.Controls.Add(Me.btnVbsOperadores)
        Me.Controls.Add(Me.btnVbsDesafio03)
        Me.Controls.Add(Me.btnVbsDesafio02)
        Me.Controls.Add(Me.btnVbsDesafio01)
        Me.Controls.Add(Me.btnBatJoKenPo)
        Me.Controls.Add(Me.btnBatAdivinha)
        Me.Controls.Add(Me.btnBatMenu)
        Me.Controls.Add(Me.lblVbs)
        Me.Controls.Add(Me.lblBat)
        Me.Controls.Add(Me.lblAluno)
        Me.Controls.Add(Me.lblCabecalho)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atividades de Sistemas da Informação, Bianca Silva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCabecalho As Label
    Friend WithEvents lblAluno As Label
    Friend WithEvents lblBat As Label
    Friend WithEvents lblVbs As Label
    Friend WithEvents btnBatMenu As Button
    Friend WithEvents btnBatAdivinha As Button
    Friend WithEvents btnBatJoKenPo As Button
    Friend WithEvents btnVbsDesafio01 As Button
    Friend WithEvents btnVbsDesafio02 As Button
    Friend WithEvents btnVbsDesafio03 As Button
    Friend WithEvents btnVbsOperadores As Button
    Friend WithEvents btnVbsSoletrando As Button
End Class
