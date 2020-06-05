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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teksNama = New System.Windows.Forms.TextBox()
        Me.tombolTambah = New System.Windows.Forms.Button()
        Me.listTeman = New System.Windows.Forms.ListBox()
        Me.tombolTampil = New System.Windows.Forms.Button()
        Me.tombolCari = New System.Windows.Forms.Button()
        Me.teksCari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukkan Nama Teman"
        '
        'teksNama
        '
        Me.teksNama.Location = New System.Drawing.Point(15, 26)
        Me.teksNama.Name = "teksNama"
        Me.teksNama.Size = New System.Drawing.Size(165, 20)
        Me.teksNama.TabIndex = 1
        '
        'tombolTambah
        '
        Me.tombolTambah.Location = New System.Drawing.Point(47, 66)
        Me.tombolTambah.Name = "tombolTambah"
        Me.tombolTambah.Size = New System.Drawing.Size(89, 27)
        Me.tombolTambah.TabIndex = 2
        Me.tombolTambah.Text = "Tambahkan"
        Me.tombolTambah.UseVisualStyleBackColor = True
        '
        'listTeman
        '
        Me.listTeman.FormattingEnabled = True
        Me.listTeman.Location = New System.Drawing.Point(231, 26)
        Me.listTeman.Name = "listTeman"
        Me.listTeman.Size = New System.Drawing.Size(209, 121)
        Me.listTeman.TabIndex = 3
        '
        'tombolTampil
        '
        Me.tombolTampil.Location = New System.Drawing.Point(231, 162)
        Me.tombolTampil.Name = "tombolTampil"
        Me.tombolTampil.Size = New System.Drawing.Size(209, 27)
        Me.tombolTampil.TabIndex = 4
        Me.tombolTampil.Text = "Tampilkan Semua"
        Me.tombolTampil.UseVisualStyleBackColor = True
        '
        'tombolCari
        '
        Me.tombolCari.Location = New System.Drawing.Point(47, 162)
        Me.tombolCari.Name = "tombolCari"
        Me.tombolCari.Size = New System.Drawing.Size(89, 27)
        Me.tombolCari.TabIndex = 7
        Me.tombolCari.Text = "Cari"
        Me.tombolCari.UseVisualStyleBackColor = True
        '
        'teksCari
        '
        Me.teksCari.Location = New System.Drawing.Point(15, 126)
        Me.teksCari.Name = "teksCari"
        Me.teksCari.Size = New System.Drawing.Size(165, 20)
        Me.teksCari.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cari Teman"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 201)
        Me.Controls.Add(Me.tombolCari)
        Me.Controls.Add(Me.teksCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tombolTampil)
        Me.Controls.Add(Me.listTeman)
        Me.Controls.Add(Me.tombolTambah)
        Me.Controls.Add(Me.teksNama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Daftar Teman 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teksNama As System.Windows.Forms.TextBox
    Friend WithEvents tombolTambah As System.Windows.Forms.Button
    Friend WithEvents listTeman As System.Windows.Forms.ListBox
    Friend WithEvents tombolTampil As System.Windows.Forms.Button
    Friend WithEvents tombolCari As System.Windows.Forms.Button
    Friend WithEvents teksCari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
