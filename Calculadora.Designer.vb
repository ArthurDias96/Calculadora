<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.btnNum0 = New System.Windows.Forms.Button()
        Me.btnNum1 = New System.Windows.Forms.Button()
        Me.btnNum2 = New System.Windows.Forms.Button()
        Me.btnNum3 = New System.Windows.Forms.Button()
        Me.btnNum9 = New System.Windows.Forms.Button()
        Me.btnNum4 = New System.Windows.Forms.Button()
        Me.btnNum5 = New System.Windows.Forms.Button()
        Me.btnNum6 = New System.Windows.Forms.Button()
        Me.btnNum7 = New System.Windows.Forms.Button()
        Me.btnNum8 = New System.Windows.Forms.Button()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.btnSubstracao = New System.Windows.Forms.Button()
        Me.btnDivisao = New System.Windows.Forms.Button()
        Me.btnMultiplicacao = New System.Windows.Forms.Button()
        Me.btnVirgula = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.labelganso = New System.Windows.Forms.Label()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNum0
        '
        Me.btnNum0.Location = New System.Drawing.Point(61, 192)
        Me.btnNum0.Name = "btnNum0"
        Me.btnNum0.Size = New System.Drawing.Size(43, 40)
        Me.btnNum0.TabIndex = 0
        Me.btnNum0.Tag = ""
        Me.btnNum0.Text = "0"
        Me.btnNum0.UseVisualStyleBackColor = True
        '
        'btnNum1
        '
        Me.btnNum1.Location = New System.Drawing.Point(12, 54)
        Me.btnNum1.Name = "btnNum1"
        Me.btnNum1.Size = New System.Drawing.Size(43, 40)
        Me.btnNum1.TabIndex = 1
        Me.btnNum1.Tag = ""
        Me.btnNum1.Text = "1"
        Me.btnNum1.UseVisualStyleBackColor = True
        '
        'btnNum2
        '
        Me.btnNum2.Location = New System.Drawing.Point(61, 54)
        Me.btnNum2.Name = "btnNum2"
        Me.btnNum2.Size = New System.Drawing.Size(43, 40)
        Me.btnNum2.TabIndex = 2
        Me.btnNum2.Text = "2"
        Me.btnNum2.UseVisualStyleBackColor = True
        '
        'btnNum3
        '
        Me.btnNum3.Location = New System.Drawing.Point(110, 54)
        Me.btnNum3.Name = "btnNum3"
        Me.btnNum3.Size = New System.Drawing.Size(43, 40)
        Me.btnNum3.TabIndex = 3
        Me.btnNum3.Text = "3"
        Me.btnNum3.UseVisualStyleBackColor = True
        '
        'btnNum9
        '
        Me.btnNum9.Location = New System.Drawing.Point(110, 146)
        Me.btnNum9.Name = "btnNum9"
        Me.btnNum9.Size = New System.Drawing.Size(43, 40)
        Me.btnNum9.TabIndex = 4
        Me.btnNum9.Text = "9"
        Me.btnNum9.UseVisualStyleBackColor = True
        '
        'btnNum4
        '
        Me.btnNum4.Location = New System.Drawing.Point(12, 100)
        Me.btnNum4.Name = "btnNum4"
        Me.btnNum4.Size = New System.Drawing.Size(43, 40)
        Me.btnNum4.TabIndex = 5
        Me.btnNum4.Text = "4"
        Me.btnNum4.UseVisualStyleBackColor = True
        '
        'btnNum5
        '
        Me.btnNum5.Location = New System.Drawing.Point(61, 100)
        Me.btnNum5.Name = "btnNum5"
        Me.btnNum5.Size = New System.Drawing.Size(43, 40)
        Me.btnNum5.TabIndex = 6
        Me.btnNum5.Text = "5"
        Me.btnNum5.UseVisualStyleBackColor = True
        '
        'btnNum6
        '
        Me.btnNum6.Location = New System.Drawing.Point(110, 100)
        Me.btnNum6.Name = "btnNum6"
        Me.btnNum6.Size = New System.Drawing.Size(43, 40)
        Me.btnNum6.TabIndex = 7
        Me.btnNum6.Text = "6"
        Me.btnNum6.UseVisualStyleBackColor = True
        '
        'btnNum7
        '
        Me.btnNum7.Location = New System.Drawing.Point(12, 146)
        Me.btnNum7.Name = "btnNum7"
        Me.btnNum7.Size = New System.Drawing.Size(43, 40)
        Me.btnNum7.TabIndex = 8
        Me.btnNum7.Text = "7"
        Me.btnNum7.UseVisualStyleBackColor = True
        '
        'btnNum8
        '
        Me.btnNum8.Location = New System.Drawing.Point(61, 146)
        Me.btnNum8.Name = "btnNum8"
        Me.btnNum8.Size = New System.Drawing.Size(43, 40)
        Me.btnNum8.TabIndex = 9
        Me.btnNum8.Text = "8"
        Me.btnNum8.UseVisualStyleBackColor = True
        '
        'btnSoma
        '
        Me.btnSoma.Location = New System.Drawing.Point(159, 146)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(43, 40)
        Me.btnSoma.TabIndex = 10
        Me.btnSoma.Text = "+"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'btnSubstracao
        '
        Me.btnSubstracao.Location = New System.Drawing.Point(159, 192)
        Me.btnSubstracao.Name = "btnSubstracao"
        Me.btnSubstracao.Size = New System.Drawing.Size(43, 40)
        Me.btnSubstracao.TabIndex = 11
        Me.btnSubstracao.Text = "-"
        Me.btnSubstracao.UseVisualStyleBackColor = True
        '
        'btnDivisao
        '
        Me.btnDivisao.Location = New System.Drawing.Point(159, 54)
        Me.btnDivisao.Name = "btnDivisao"
        Me.btnDivisao.Size = New System.Drawing.Size(43, 40)
        Me.btnDivisao.TabIndex = 12
        Me.btnDivisao.Text = "/"
        Me.btnDivisao.UseVisualStyleBackColor = True
        '
        'btnMultiplicacao
        '
        Me.btnMultiplicacao.Location = New System.Drawing.Point(159, 100)
        Me.btnMultiplicacao.Name = "btnMultiplicacao"
        Me.btnMultiplicacao.Size = New System.Drawing.Size(43, 40)
        Me.btnMultiplicacao.TabIndex = 14
        Me.btnMultiplicacao.Text = "x"
        Me.btnMultiplicacao.UseVisualStyleBackColor = True
        '
        'btnVirgula
        '
        Me.btnVirgula.Location = New System.Drawing.Point(110, 192)
        Me.btnVirgula.Name = "btnVirgula"
        Me.btnVirgula.Size = New System.Drawing.Size(43, 40)
        Me.btnVirgula.TabIndex = 15
        Me.btnVirgula.Text = ","
        Me.btnVirgula.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(12, 192)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(43, 40)
        Me.btnLimpar.TabIndex = 16
        Me.btnLimpar.Text = "C"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(12, 12)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(190, 23)
        Me.txtResultado.TabIndex = 17
        Me.txtResultado.Text = "0,00"
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnIgual
        '
        Me.btnIgual.Location = New System.Drawing.Point(110, 238)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(92, 40)
        Me.btnIgual.TabIndex = 18
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'img
        '
        Me.img.BackgroundImage = CType(resources.GetObject("img.BackgroundImage"), System.Drawing.Image)
        Me.img.Location = New System.Drawing.Point(12, 238)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(43, 40)
        Me.img.TabIndex = 19
        Me.img.TabStop = False
        '
        'labelganso
        '
        Me.labelganso.AutoSize = True
        Me.labelganso.Location = New System.Drawing.Point(63, 251)
        Me.labelganso.Name = "labelganso"
        Me.labelganso.Size = New System.Drawing.Size(40, 15)
        Me.labelganso.TabIndex = 20
        Me.labelganso.Text = "Ganso"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(218, 284)
        Me.Controls.Add(Me.labelganso)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnVirgula)
        Me.Controls.Add(Me.btnMultiplicacao)
        Me.Controls.Add(Me.btnDivisao)
        Me.Controls.Add(Me.btnSubstracao)
        Me.Controls.Add(Me.btnSoma)
        Me.Controls.Add(Me.btnNum8)
        Me.Controls.Add(Me.btnNum7)
        Me.Controls.Add(Me.btnNum6)
        Me.Controls.Add(Me.btnNum5)
        Me.Controls.Add(Me.btnNum4)
        Me.Controls.Add(Me.btnNum9)
        Me.Controls.Add(Me.btnNum3)
        Me.Controls.Add(Me.btnNum2)
        Me.Controls.Add(Me.btnNum1)
        Me.Controls.Add(Me.btnNum0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Calculadora"
        Me.Tag = ""
        Me.Text = "Calculadora"
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNum0 As Button
    Friend WithEvents btnNum1 As Button
    Friend WithEvents btnNum2 As Button
    Friend WithEvents btnNum3 As Button
    Friend WithEvents btnNum9 As Button
    Friend WithEvents btnNum4 As Button
    Friend WithEvents btnNum5 As Button
    Friend WithEvents btnNum6 As Button
    Friend WithEvents btnNum7 As Button
    Friend WithEvents btnNum8 As Button
    Friend WithEvents btnSoma As Button
    Friend WithEvents btnSubstracao As Button
    Friend WithEvents btnDivisao As Button
    Friend WithEvents btnMultiplicacao As Button
    Friend WithEvents btnVirgula As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnIgual As Button
    Friend WithEvents img As PictureBox
    Friend WithEvents labelganso As Label
End Class
