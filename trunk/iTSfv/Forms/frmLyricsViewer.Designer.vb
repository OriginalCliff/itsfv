﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLyricsViewer
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
        Me.components = New System.ComponentModel.Container
        Me.txtLyrics = New System.Windows.Forms.TextBox
        Me.pbArtwork = New System.Windows.Forms.PictureBox
        Me.tmrSecond = New System.Windows.Forms.Timer(Me.components)
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel
        Me.tlpDesc = New System.Windows.Forms.TableLayoutPanel
        Me.pDesc = New System.Windows.Forms.Panel
        Me.txtGenre = New System.Windows.Forms.Label
        Me.txtYear = New System.Windows.Forms.Label
        Me.txtAlbumArtist = New System.Windows.Forms.Label
        Me.txtAlbum = New System.Windows.Forms.Label
        Me.txtArtist = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.pbArtwork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        Me.tlpDesc.SuspendLayout()
        Me.pDesc.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLyrics
        '
        Me.txtLyrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLyrics.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLyrics.Location = New System.Drawing.Point(3, 213)
        Me.txtLyrics.Multiline = True
        Me.txtLyrics.Name = "txtLyrics"
        Me.txtLyrics.ReadOnly = True
        Me.txtLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLyrics.Size = New System.Drawing.Size(578, 350)
        Me.txtLyrics.TabIndex = 2
        Me.txtLyrics.TabStop = False
        Me.txtLyrics.WordWrap = False
        '
        'pbArtwork
        '
        Me.pbArtwork.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbArtwork.Location = New System.Drawing.Point(3, 3)
        Me.pbArtwork.Name = "pbArtwork"
        Me.pbArtwork.Size = New System.Drawing.Size(200, 200)
        Me.pbArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbArtwork.TabIndex = 3
        Me.pbArtwork.TabStop = False
        '
        'tmrSecond
        '
        Me.tmrSecond.Enabled = True
        Me.tmrSecond.Interval = 1000
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpDesc, 0, 0)
        Me.tlpMain.Controls.Add(Me.txtLyrics, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(584, 566)
        Me.tlpMain.TabIndex = 4
        '
        'tlpDesc
        '
        Me.tlpDesc.ColumnCount = 2
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDesc.Controls.Add(Me.pbArtwork, 0, 0)
        Me.tlpDesc.Controls.Add(Me.pDesc, 1, 0)
        Me.tlpDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDesc.Location = New System.Drawing.Point(3, 3)
        Me.tlpDesc.Name = "tlpDesc"
        Me.tlpDesc.RowCount = 1
        Me.tlpDesc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206.0!))
        Me.tlpDesc.Size = New System.Drawing.Size(578, 204)
        Me.tlpDesc.TabIndex = 0
        '
        'pDesc
        '
        Me.pDesc.Controls.Add(Me.txtGenre)
        Me.pDesc.Controls.Add(Me.txtYear)
        Me.pDesc.Controls.Add(Me.txtAlbumArtist)
        Me.pDesc.Controls.Add(Me.txtAlbum)
        Me.pDesc.Controls.Add(Me.txtArtist)
        Me.pDesc.Controls.Add(Me.txtName)
        Me.pDesc.Controls.Add(Me.Label6)
        Me.pDesc.Controls.Add(Me.Label5)
        Me.pDesc.Controls.Add(Me.Label4)
        Me.pDesc.Controls.Add(Me.Label3)
        Me.pDesc.Controls.Add(Me.Label2)
        Me.pDesc.Controls.Add(Me.Label1)
        Me.pDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDesc.Location = New System.Drawing.Point(209, 3)
        Me.pDesc.Name = "pDesc"
        Me.pDesc.Size = New System.Drawing.Size(366, 200)
        Me.pDesc.TabIndex = 4
        '
        'txtGenre
        '
        Me.txtGenre.AutoSize = True
        Me.txtGenre.Location = New System.Drawing.Point(102, 155)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(55, 13)
        Me.txtGenre.TabIndex = 11
        Me.txtGenre.Text = "Pending..."
        '
        'txtYear
        '
        Me.txtYear.AutoSize = True
        Me.txtYear.Location = New System.Drawing.Point(102, 127)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(55, 13)
        Me.txtYear.TabIndex = 10
        Me.txtYear.Text = "Pending..."
        '
        'txtAlbumArtist
        '
        Me.txtAlbumArtist.AutoSize = True
        Me.txtAlbumArtist.Location = New System.Drawing.Point(102, 99)
        Me.txtAlbumArtist.Name = "txtAlbumArtist"
        Me.txtAlbumArtist.Size = New System.Drawing.Size(55, 13)
        Me.txtAlbumArtist.TabIndex = 9
        Me.txtAlbumArtist.Text = "Pending..."
        '
        'txtAlbum
        '
        Me.txtAlbum.AutoSize = True
        Me.txtAlbum.Location = New System.Drawing.Point(102, 71)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(55, 13)
        Me.txtAlbum.TabIndex = 8
        Me.txtAlbum.Text = "Pending..."
        '
        'txtArtist
        '
        Me.txtArtist.AutoSize = True
        Me.txtArtist.Location = New System.Drawing.Point(102, 43)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(55, 13)
        Me.txtArtist.TabIndex = 7
        Me.txtArtist.Text = "Pending..."
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Location = New System.Drawing.Point(102, 15)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(55, 13)
        Me.txtName.TabIndex = 6
        Me.txtName.Text = "Pending..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Genre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Year:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Album Artist:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Album:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Artist:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'frmLyricsViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 566)
        Me.Controls.Add(Me.tlpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmLyricsViewer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmLyricsViewer"
        Me.TopMost = True
        CType(Me.pbArtwork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tlpDesc.ResumeLayout(False)
        Me.pDesc.ResumeLayout(False)
        Me.pDesc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLyrics As System.Windows.Forms.TextBox
    Friend WithEvents pbArtwork As System.Windows.Forms.PictureBox
    Friend WithEvents tmrSecond As System.Windows.Forms.Timer
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpDesc As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pDesc As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGenre As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.Label
    Friend WithEvents txtAlbumArtist As System.Windows.Forms.Label
    Friend WithEvents txtAlbum As System.Windows.Forms.Label
    Friend WithEvents txtArtist As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class