<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auth
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
        Me.grbFormGroup = New System.Windows.Forms.GroupBox()
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.mskTxtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.grbFormGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbFormGroup
        '
        Me.grbFormGroup.BackColor = System.Drawing.Color.Transparent
        Me.grbFormGroup.Controls.Add(Me.lblLogIn)
        Me.grbFormGroup.Controls.Add(Me.mskTxtPassword)
        Me.grbFormGroup.Controls.Add(Me.txtUsername)
        Me.grbFormGroup.Controls.Add(Me.btnLogin)
        Me.grbFormGroup.Controls.Add(Me.lblPassword)
        Me.grbFormGroup.Controls.Add(Me.lblUsername)
        Me.grbFormGroup.Location = New System.Drawing.Point(415, 180)
        Me.grbFormGroup.Name = "grbFormGroup"
        Me.grbFormGroup.Size = New System.Drawing.Size(391, 183)
        Me.grbFormGroup.TabIndex = 0
        Me.grbFormGroup.TabStop = False
        '
        'lblLogIn
        '
        Me.lblLogIn.AutoSize = True
        Me.lblLogIn.BackColor = System.Drawing.Color.Tan
        Me.lblLogIn.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.Location = New System.Drawing.Point(181, 16)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(57, 21)
        Me.lblLogIn.TabIndex = 7
        Me.lblLogIn.Text = "Log In"
        '
        'mskTxtPassword
        '
        Me.mskTxtPassword.Location = New System.Drawing.Point(142, 110)
        Me.mskTxtPassword.Name = "mskTxtPassword"
        Me.mskTxtPassword.Size = New System.Drawing.Size(203, 20)
        Me.mskTxtPassword.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(142, 59)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(203, 20)
        Me.txtUsername.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Tan
        Me.btnLogin.Location = New System.Drawing.Point(163, 154)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Tan
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblPassword.Location = New System.Drawing.Point(25, 110)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(66, 16)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Tan
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(25, 66)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(69, 16)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'Auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BnB_Booking_Management.My.Resources.Resources.visualsofdana_T5pL6ciEn_I_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1075, 559)
        Me.Controls.Add(Me.grbFormGroup)
        Me.Name = "Auth"
        Me.Text = "Auth"
        Me.grbFormGroup.ResumeLayout(False)
        Me.grbFormGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbFormGroup As System.Windows.Forms.GroupBox
    Friend WithEvents lblLogIn As System.Windows.Forms.Label
    Friend WithEvents mskTxtPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label

End Class
