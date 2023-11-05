<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleksiKamar
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnStandar = New System.Windows.Forms.Button()
        Me.btnKonfirmasi = New System.Windows.Forms.Button()
        Me.btnDeluxe = New System.Windows.Forms.Button()
        Me.lblInstruksi = New System.Windows.Forms.Label()
        Me.picDeluxe = New System.Windows.Forms.PictureBox()
        Me.picStandar = New System.Windows.Forms.PictureBox()
        CType(Me.picDeluxe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStandar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(116, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(203, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Seleksi Tipe Kamar"
        '
        'btnStandar
        '
        Me.btnStandar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStandar.ForeColor = System.Drawing.Color.Blue
        Me.btnStandar.Location = New System.Drawing.Point(49, 226)
        Me.btnStandar.Name = "btnStandar"
        Me.btnStandar.Size = New System.Drawing.Size(75, 25)
        Me.btnStandar.TabIndex = 3
        Me.btnStandar.Text = "Standar"
        Me.btnStandar.UseVisualStyleBackColor = True
        '
        'btnKonfirmasi
        '
        Me.btnKonfirmasi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonfirmasi.ForeColor = System.Drawing.Color.Blue
        Me.btnKonfirmasi.Location = New System.Drawing.Point(180, 226)
        Me.btnKonfirmasi.Name = "btnKonfirmasi"
        Me.btnKonfirmasi.Size = New System.Drawing.Size(75, 25)
        Me.btnKonfirmasi.TabIndex = 4
        Me.btnKonfirmasi.Text = "Konfirmasi"
        Me.btnKonfirmasi.UseVisualStyleBackColor = True
        '
        'btnDeluxe
        '
        Me.btnDeluxe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeluxe.ForeColor = System.Drawing.Color.Blue
        Me.btnDeluxe.Location = New System.Drawing.Point(311, 226)
        Me.btnDeluxe.Name = "btnDeluxe"
        Me.btnDeluxe.Size = New System.Drawing.Size(75, 25)
        Me.btnDeluxe.TabIndex = 5
        Me.btnDeluxe.Text = "Deluxe"
        Me.btnDeluxe.UseVisualStyleBackColor = True
        '
        'lblInstruksi
        '
        Me.lblInstruksi.AutoSize = True
        Me.lblInstruksi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruksi.ForeColor = System.Drawing.Color.Blue
        Me.lblInstruksi.Location = New System.Drawing.Point(50, 263)
        Me.lblInstruksi.Name = "lblInstruksi"
        Me.lblInstruksi.Size = New System.Drawing.Size(335, 14)
        Me.lblInstruksi.TabIndex = 6
        Me.lblInstruksi.Text = "Pilih tipe kamar yang diinginkan laku klik tombol Konfirmasi"
        '
        'picDeluxe
        '
        Me.picDeluxe.Image = Global.WindowsApplication1.My.Resources.Resources.DeluxeRoom
        Me.picDeluxe.Location = New System.Drawing.Point(225, 59)
        Me.picDeluxe.Name = "picDeluxe"
        Me.picDeluxe.Size = New System.Drawing.Size(185, 150)
        Me.picDeluxe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeluxe.TabIndex = 2
        Me.picDeluxe.TabStop = False
        Me.picDeluxe.Visible = False
        '
        'picStandar
        '
        Me.picStandar.Image = Global.WindowsApplication1.My.Resources.Resources.StandardRoom
        Me.picStandar.Location = New System.Drawing.Point(24, 59)
        Me.picStandar.Name = "picStandar"
        Me.picStandar.Size = New System.Drawing.Size(185, 150)
        Me.picStandar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStandar.TabIndex = 1
        Me.picStandar.TabStop = False
        Me.picStandar.Visible = False
        '
        'frmSeleksiKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(434, 291)
        Me.Controls.Add(Me.lblInstruksi)
        Me.Controls.Add(Me.btnDeluxe)
        Me.Controls.Add(Me.btnKonfirmasi)
        Me.Controls.Add(Me.btnStandar)
        Me.Controls.Add(Me.picDeluxe)
        Me.Controls.Add(Me.picStandar)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmSeleksiKamar"
        Me.Text = "Seleksi Kamar"
        CType(Me.picDeluxe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStandar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picStandar As System.Windows.Forms.PictureBox
    Friend WithEvents picDeluxe As System.Windows.Forms.PictureBox
    Friend WithEvents btnStandar As System.Windows.Forms.Button
    Friend WithEvents btnKonfirmasi As System.Windows.Forms.Button
    Friend WithEvents btnDeluxe As System.Windows.Forms.Button
    Friend WithEvents lblInstruksi As System.Windows.Forms.Label

End Class
