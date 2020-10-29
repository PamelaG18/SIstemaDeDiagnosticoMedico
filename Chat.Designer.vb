<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chat))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Chat = New System.Windows.Forms.Label()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.pic_Cerrar = New System.Windows.Forms.PictureBox()
        Me.pic_Achicar = New System.Windows.Forms.PictureBox()
        Me.pic_Minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.txt_Chat = New System.Windows.Forms.TextBox()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Achicar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_logo)
        Me.Panel1.Controls.Add(Me.pic_Achicar)
        Me.Panel1.Controls.Add(Me.pic_Minimizar)
        Me.Panel1.Controls.Add(Me.lbl_Chat)
        Me.Panel1.Controls.Add(Me.pic_logo)
        Me.Panel1.Controls.Add(Me.pic_Cerrar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 59)
        Me.Panel1.TabIndex = 2
        '
        'lbl_Chat
        '
        Me.lbl_Chat.AutoSize = True
        Me.lbl_Chat.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Chat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_Chat.Location = New System.Drawing.Point(225, 26)
        Me.lbl_Chat.Name = "lbl_Chat"
        Me.lbl_Chat.Size = New System.Drawing.Size(60, 28)
        Me.lbl_Chat.TabIndex = 7
        Me.lbl_Chat.Text = "Chat"
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(3, 0)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(63, 53)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_logo.TabIndex = 6
        Me.pic_logo.TabStop = False
        '
        'pic_Cerrar
        '
        Me.pic_Cerrar.Image = CType(resources.GetObject("pic_Cerrar.Image"), System.Drawing.Image)
        Me.pic_Cerrar.Location = New System.Drawing.Point(462, 5)
        Me.pic_Cerrar.Name = "pic_Cerrar"
        Me.pic_Cerrar.Size = New System.Drawing.Size(24, 20)
        Me.pic_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Cerrar.TabIndex = 5
        Me.pic_Cerrar.TabStop = False
        '
        'pic_Achicar
        '
        Me.pic_Achicar.Image = CType(resources.GetObject("pic_Achicar.Image"), System.Drawing.Image)
        Me.pic_Achicar.Location = New System.Drawing.Point(439, 3)
        Me.pic_Achicar.Name = "pic_Achicar"
        Me.pic_Achicar.Size = New System.Drawing.Size(17, 22)
        Me.pic_Achicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Achicar.TabIndex = 4
        Me.pic_Achicar.TabStop = False
        '
        'pic_Minimizar
        '
        Me.pic_Minimizar.Image = CType(resources.GetObject("pic_Minimizar.Image"), System.Drawing.Image)
        Me.pic_Minimizar.Location = New System.Drawing.Point(410, 5)
        Me.pic_Minimizar.Name = "pic_Minimizar"
        Me.pic_Minimizar.Size = New System.Drawing.Size(23, 20)
        Me.pic_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Minimizar.TabIndex = 3
        Me.pic_Minimizar.TabStop = False
        '
        'btn_Salir
        '
        Me.btn_Salir.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(398, 415)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(91, 23)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'txt_Chat
        '
        Me.txt_Chat.BackColor = System.Drawing.Color.White
        Me.txt_Chat.Location = New System.Drawing.Point(12, 415)
        Me.txt_Chat.Name = "txt_Chat"
        Me.txt_Chat.Size = New System.Drawing.Size(235, 20)
        Me.txt_Chat.TabIndex = 10
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Location = New System.Drawing.Point(301, 415)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(91, 23)
        Me.btn_Aceptar.TabIndex = 12
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Script MT Bold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_logo.Location = New System.Drawing.Point(72, 34)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(48, 18)
        Me.lbl_logo.TabIndex = 9
        Me.lbl_logo.Text = "S.D.M"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(253, 415)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(490, 450)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.txt_Chat)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Chat"
        Me.Text = "Chat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Achicar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_Achicar As PictureBox
    Friend WithEvents pic_Minimizar As PictureBox
    Friend WithEvents lbl_Chat As Label
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents pic_Cerrar As PictureBox
    Friend WithEvents btn_Salir As Button
    Friend WithEvents txt_Chat As TextBox
    Friend WithEvents btn_Aceptar As Button
    Friend WithEvents lbl_logo As Label
    Friend WithEvents PictureBox6 As PictureBox
End Class
