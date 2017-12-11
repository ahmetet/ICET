<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaydetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaternToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜstüneÇizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiğerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalizToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopyalaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaplaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TahminEtYarımToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TahminEtToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnlaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkalalarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KırmızıSüzgeçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeşilSüzgeçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaviSkalaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RGBSüzgeçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenişlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.YükseklikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.TıkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.PaternToolStripMenuItem, Me.GenişlikToolStripMenuItem, Me.ToolStripTextBox1, Me.YükseklikToolStripMenuItem, Me.ToolStripTextBox2, Me.TıkToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(967, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçToolStripMenuItem, Me.KaydetToolStripMenuItem1})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(62, 27)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'AçToolStripMenuItem
        '
        Me.AçToolStripMenuItem.Name = "AçToolStripMenuItem"
        Me.AçToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.AçToolStripMenuItem.Text = "Aç"
        '
        'KaydetToolStripMenuItem1
        '
        Me.KaydetToolStripMenuItem1.Name = "KaydetToolStripMenuItem1"
        Me.KaydetToolStripMenuItem1.Size = New System.Drawing.Size(130, 26)
        Me.KaydetToolStripMenuItem1.Text = "Kaydet"
        '
        'PaternToolStripMenuItem
        '
        Me.PaternToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇizToolStripMenuItem, Me.ÜstüneÇizToolStripMenuItem, Me.DiğerToolStripMenuItem, Me.SkalalarToolStripMenuItem})
        Me.PaternToolStripMenuItem.Name = "PaternToolStripMenuItem"
        Me.PaternToolStripMenuItem.Size = New System.Drawing.Size(62, 27)
        Me.PaternToolStripMenuItem.Text = "Desen"
        '
        'ÇizToolStripMenuItem
        '
        Me.ÇizToolStripMenuItem.Name = "ÇizToolStripMenuItem"
        Me.ÇizToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ÇizToolStripMenuItem.Text = "Sıfırdan Çiz"
        '
        'ÜstüneÇizToolStripMenuItem
        '
        Me.ÜstüneÇizToolStripMenuItem.Name = "ÜstüneÇizToolStripMenuItem"
        Me.ÜstüneÇizToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ÜstüneÇizToolStripMenuItem.Text = "Üstüne Çiz"
        '
        'DiğerToolStripMenuItem
        '
        Me.DiğerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalizToolStripMenuItem1, Me.AnlaToolStripMenuItem1, Me.KopyalaToolStripMenuItem1, Me.KaplaToolStripMenuItem1, Me.TahminEtYarımToolStripMenuItem, Me.TahminEtToolStripMenuItem1})
        Me.DiğerToolStripMenuItem.Name = "DiğerToolStripMenuItem"
        Me.DiğerToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.DiğerToolStripMenuItem.Text = "Diğer"
        '
        'AnalizToolStripMenuItem1
        '
        Me.AnalizToolStripMenuItem1.Name = "AnalizToolStripMenuItem1"
        Me.AnalizToolStripMenuItem1.Size = New System.Drawing.Size(196, 26)
        Me.AnalizToolStripMenuItem1.Text = "KYM Piksel Sayısı"
        '
        'KopyalaToolStripMenuItem1
        '
        Me.KopyalaToolStripMenuItem1.Name = "KopyalaToolStripMenuItem1"
        Me.KopyalaToolStripMenuItem1.Size = New System.Drawing.Size(196, 26)
        Me.KopyalaToolStripMenuItem1.Text = "Kopyala"
        Me.KopyalaToolStripMenuItem1.Visible = False
        '
        'KaplaToolStripMenuItem1
        '
        Me.KaplaToolStripMenuItem1.Name = "KaplaToolStripMenuItem1"
        Me.KaplaToolStripMenuItem1.Size = New System.Drawing.Size(253, 26)
        Me.KaplaToolStripMenuItem1.Text = "Rastgele Piksellerle Kapla"
        '
        'TahminEtYarımToolStripMenuItem
        '
        Me.TahminEtYarımToolStripMenuItem.Name = "TahminEtYarımToolStripMenuItem"
        Me.TahminEtYarımToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.TahminEtYarımToolStripMenuItem.Text = "Piksel Tahmini 1"
        '
        'TahminEtToolStripMenuItem1
        '
        Me.TahminEtToolStripMenuItem1.Name = "TahminEtToolStripMenuItem1"
        Me.TahminEtToolStripMenuItem1.Size = New System.Drawing.Size(253, 26)
        Me.TahminEtToolStripMenuItem1.Text = "Piksel Tahmini 2"
        '
        'AnlaToolStripMenuItem1
        '
        Me.AnlaToolStripMenuItem1.Name = "AnlaToolStripMenuItem1"
        Me.AnlaToolStripMenuItem1.Size = New System.Drawing.Size(253, 26)
        Me.AnlaToolStripMenuItem1.Text = "Yükseklik / Genişlik Öğren"
        '
        'SkalalarToolStripMenuItem
        '
        Me.SkalalarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KırmızıSüzgeçToolStripMenuItem, Me.YeşilSüzgeçToolStripMenuItem, Me.MaviSkalaToolStripMenuItem1, Me.RGBSüzgeçToolStripMenuItem})
        Me.SkalalarToolStripMenuItem.Name = "SkalalarToolStripMenuItem"
        Me.SkalalarToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SkalalarToolStripMenuItem.Text = "Süzgeçler"
        '
        'KırmızıSüzgeçToolStripMenuItem
        '
        Me.KırmızıSüzgeçToolStripMenuItem.Name = "KırmızıSüzgeçToolStripMenuItem"
        Me.KırmızıSüzgeçToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.KırmızıSüzgeçToolStripMenuItem.Text = "Kırmızı Süzgeç"
        '
        'YeşilSüzgeçToolStripMenuItem
        '
        Me.YeşilSüzgeçToolStripMenuItem.Name = "YeşilSüzgeçToolStripMenuItem"
        Me.YeşilSüzgeçToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.YeşilSüzgeçToolStripMenuItem.Text = "Yeşil Süzgeç"
        '
        'MaviSkalaToolStripMenuItem1
        '
        Me.MaviSkalaToolStripMenuItem1.Name = "MaviSkalaToolStripMenuItem1"
        Me.MaviSkalaToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.MaviSkalaToolStripMenuItem1.Text = "Mavi Süzgeç"
        '
        'RGBSüzgeçToolStripMenuItem
        '
        Me.RGBSüzgeçToolStripMenuItem.Name = "RGBSüzgeçToolStripMenuItem"
        Me.RGBSüzgeçToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.RGBSüzgeçToolStripMenuItem.Text = "KYM Süzgeç"
        '
        'GenişlikToolStripMenuItem
        '
        Me.GenişlikToolStripMenuItem.Name = "GenişlikToolStripMenuItem"
        Me.GenişlikToolStripMenuItem.Size = New System.Drawing.Size(75, 27)
        Me.GenişlikToolStripMenuItem.Text = "Genişlik:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        Me.ToolStripTextBox1.Text = "255"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'YükseklikToolStripMenuItem
        '
        Me.YükseklikToolStripMenuItem.Name = "YükseklikToolStripMenuItem"
        Me.YükseklikToolStripMenuItem.Size = New System.Drawing.Size(83, 27)
        Me.YükseklikToolStripMenuItem.Text = "Yükseklik:"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 27)
        Me.ToolStripTextBox2.Text = "255"
        Me.ToolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TıkToolStripMenuItem
        '
        Me.TıkToolStripMenuItem.Name = "TıkToolStripMenuItem"
        Me.TıkToolStripMenuItem.Size = New System.Drawing.Size(141, 27)
        Me.TıkToolStripMenuItem.Text = "Aksiyon Görüntüle"
        Me.TıkToolStripMenuItem.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(967, 611)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(750, 50)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(472, 457)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(967, 611)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 642)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "IC@"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PaternToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ÜstüneÇizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenişlikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YükseklikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaydetToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TıkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DiğerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopyalaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KaplaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TahminEtToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AnlaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SkalalarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KırmızıSüzgeçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YeşilSüzgeçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaviSkalaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RGBSüzgeçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TahminEtYarımToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalizToolStripMenuItem1 As ToolStripMenuItem
End Class
