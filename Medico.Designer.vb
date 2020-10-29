<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medico))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btn_Chat = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pic_Minimizar = New System.Windows.Forms.PictureBox()
        Me.pic_Achicar = New System.Windows.Forms.PictureBox()
        Me.pic_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Achicar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pic_Cerrar)
        Me.Panel1.Controls.Add(Me.pic_Achicar)
        Me.Panel1.Controls.Add(Me.pic_Minimizar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 63)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(85, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "S.D.M"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(201, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Medico"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.btn_Chat)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Location = New System.Drawing.Point(135, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 319)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(7, 64)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 18)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'btn_Chat
        '
        Me.btn_Chat.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btn_Chat.Location = New System.Drawing.Point(35, 64)
        Me.btn_Chat.Name = "btn_Chat"
        Me.btn_Chat.Size = New System.Drawing.Size(127, 23)
        Me.btn_Chat.TabIndex = 4
        Me.btn_Chat.Text = "Chat"
        Me.btn_Chat.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(163, 69)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'pic_Minimizar
        '
        Me.pic_Minimizar.Image = CType(resources.GetObject("pic_Minimizar.Image"), System.Drawing.Image)
        Me.pic_Minimizar.Location = New System.Drawing.Point(394, 14)
        Me.pic_Minimizar.Name = "pic_Minimizar"
        Me.pic_Minimizar.Size = New System.Drawing.Size(23, 20)
        Me.pic_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Minimizar.TabIndex = 9
        Me.pic_Minimizar.TabStop = False
        '
        'pic_Achicar
        '
        Me.pic_Achicar.Image = CType(resources.GetObject("pic_Achicar.Image"), System.Drawing.Image)
        Me.pic_Achicar.Location = New System.Drawing.Point(418, 14)
        Me.pic_Achicar.Name = "pic_Achicar"
        Me.pic_Achicar.Size = New System.Drawing.Size(17, 22)
        Me.pic_Achicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Achicar.TabIndex = 10
        Me.pic_Achicar.TabStop = False
        '
        'pic_Cerrar
        '
        Me.pic_Cerrar.Image = CType(resources.GetObject("pic_Cerrar.Image"), System.Drawing.Image)
        Me.pic_Cerrar.Location = New System.Drawing.Point(441, 14)
        Me.pic_Cerrar.Name = "pic_Cerrar"
        Me.pic_Cerrar.Size = New System.Drawing.Size(24, 20)
        Me.pic_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Cerrar.TabIndex = 11
        Me.pic_Cerrar.TabStop = False
        '
        'Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(477, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Medico"
        Me.Text = "Medico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Achicar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btn_Chat As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents pic_Minimizar As PictureBox
    Friend WithEvents pic_Achicar As PictureBox
    Friend WithEvents pic_Cerrar As PictureBox
End Class
