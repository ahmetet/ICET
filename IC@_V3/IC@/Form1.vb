Imports System.IO
Public Class Form1



    Private Sub AçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AçToolStripMenuItem.Click
        Try
            OpenFileDialog1.Filter = "JPG Dosyaları (*.jpg)|*.jpg|JPEG Dosyaları (*.jpeg)|*.jpeg|Hepsi (*.*)|*.*"
            If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                Me.Text = OpenFileDialog1.FileName.ToString
                Try
                    PictureBox1.ImageLocation = Me.Text
                    PictureBox2.Image = PictureBox1.Image.Clone

                Catch ex As Exception

                End Try

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try






    End Sub

    Private Sub formtik(sender As Object, e As EventArgs) Handles MyBase.Click
        '   Dim renk As New Color
        '  renk = Color.FromArgb(0, 0, 0, 0)
        Try
            Dim Harita As Bitmap
            Harita = CType(PictureBox1.Image, Bitmap)
            MessageBox.Show(Harita.GetPixel(0, 0).ToString)
            MessageBox.Show(Harita.GetPixel(0, 1).ToString)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Ciz(ByVal Durum As Boolean, ByVal heightt As Integer, ByVal widthh As Integer)
        If (Durum = True) Then
            ' ÜSTÜNE
            Dim x As Bitmap
            x = CType(PictureBox1.Image, Bitmap)
            Dim i As Integer = 0
            Dim k As Integer = 0
            Dim rnd As New Random
            Try
                Try
                    While (k < widthh)
                        i = 0
                        Try
                            While (i < heightt)
                                x.SetPixel(i, k, Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)))
                                i += 1
                            End While
                        Catch ex As Exception
                        End Try
                        k += 1
                    End While
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try


            PictureBox1.Image = x

        Else
            'SIFIRDAN
            Dim x As New Bitmap(Convert.ToInt32(ToolStripTextBox1.Text), Convert.ToInt32(ToolStripTextBox2.Text))
            Dim i As Integer = 0
            Dim k As Integer = 0
            Dim rnd As New Random

            Try
                Try
                    While (k < widthh)
                        i = 0
                        Try
                            While (i < heightt)
                                x.SetPixel(i, k, Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)))
                                i += 1

                            End While

                        Catch ex As Exception
                        End Try
                        k += 1

                    End While
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try


            PictureBox1.Image = x
        End If
    End Sub
    Private Sub ÇizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇizToolStripMenuItem.Click
        Try
            Ciz(False, Convert.ToInt32(ToolStripTextBox1.Text), Convert.ToInt32(ToolStripTextBox2.Text))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Anla()
        Try
            Dim h As Integer = CType(PictureBox1.Image, Bitmap).Size.Height
            Dim w As Integer = CType(PictureBox1.Image, Bitmap).Size.Width
            MessageBox.Show("Yükseklik: " + h.ToString + " , " + "Genişlik: " + w.ToString)

        Catch ex As Exception

        End Try
    End Sub



    Private Sub ÜstüneÇizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜstüneÇizToolStripMenuItem.Click
        Ciz(True, Convert.ToInt32(ToolStripTextBox1.Text), Convert.ToInt32(ToolStripTextBox2.Text))
    End Sub


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        '  Anla()

    End Sub

    Private Sub KaydetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KaydetToolStripMenuItem1.Click
        Try
            SaveFileDialog1.Filter = "JPG Dosyaları (*.jpg)|*.jpg|JPEG Dosyaları (*.jpeg)|*.jpeg"
            SaveFileDialog1.ShowDialog()
            Dim FileToSaveAs As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, SaveFileDialog1.FileName)
            PictureBox2.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch ex As Exception

        End Try
    End Sub







    Private Sub KaplaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KaplaToolStripMenuItem1.Click
        Try

            Dim h As Integer = CType(PictureBox1.Image, Bitmap).Size.Height
            Dim w As Integer = CType(PictureBox1.Image, Bitmap).Size.Width
            Dim k As Integer = 0
            Dim i As Integer = 0
            Dim max As Integer = 0

            Dim r As New Random

            ProgressBar1.Value = 0
            ProgressBar1.Maximum = h
            Try
                Try
                    While (k < h)
                        i = 0
                        Try
                            While (i < w)

                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.FromArgb(255, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)))

                                i += 1
                            End While
                        Catch ex As Exception
                        End Try
                        PictureBox1.Refresh()
                        k += 1
                        ProgressBar1.Value += 1
                    End While
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
        Catch ex As Exception

        End Try
    End Sub



    'Private Sub TahminEtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TahminEtToolStripMenuItem1.Click
    '    RichTextBox1.Text = ""
    '    Dim h As Integer = CType(PictureBox1.Image, Bitmap).Size.Height
    '    Dim w As Integer = CType(PictureBox1.Image, Bitmap).Size.Width
    '    Dim k As Integer = 0
    '    Dim i As Integer = 0
    '    Dim max As Integer = 0
    '    Dim renk As Char
    '    Dim satir_kirmizi As Integer = 0
    '    Dim satir_yesil As Integer = 0
    '    Dim satir_mavi As Integer = 0
    '    Dim Satırbilgisi As String = ""

    '    Try
    '        Try
    '            While (k < h)
    '                i = 0
    '                Try

    '                    While (i < w)


    '                        Dim Anlık = CType(PictureBox1.Image, Bitmap).GetPixel(i, k)
    '                        Dim enbuyuk As Integer = 0
    '                        If (Anlık.R = Anlık.G And Anlık.G = Anlık.B And Anlık.R = Anlık.B) Then
    '                            If (Anlık.R > 100) Then
    '                                'beyaz
    '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.White)

    '                            Else
    '                                'siyah
    '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Black)
    '                            End If
    '                        ElseIf (Anlık.R = Anlık.G) Then
    '                            ' Kırmızı yeşil = Sarı
    '                            CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Yellow)
    '                        ElseIf (Anlık.R = Anlık.B) Then
    '                            ' Kırmızı mavi = magenta
    '                            CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Magenta)
    '                        ElseIf (Anlık.G = Anlık.B) Then
    '                            ' Mavi yeşil = Cyan
    '                            CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Cyan)
    '                        Else

    '                            If (Anlık.R > enbuyuk) Then
    '                                enbuyuk = Anlık.R
    '                                renk = "r"
    '                            End If
    '                            If (Anlık.G > enbuyuk) Then
    '                                enbuyuk = Anlık.G
    '                                renk = "g"
    '                            End If
    '                            If (Anlık.B > enbuyuk) Then
    '                                enbuyuk = Anlık.B
    '                                renk = "b"
    '                            End If
    '                            If (renk = "r") Then
    '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.FromArgb(255, enbuyuk, 0, 0))
    '                                satir_kirmizi += 1
    '                            ElseIf (renk = "g") Then
    '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.FromArgb(255, 0, enbuyuk, 0))
    '                                satir_yesil += 1
    '                            ElseIf (renk = "b") Then
    '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.FromArgb(255, 0, 0, enbuyuk))
    '                                satir_mavi += 1
    '                            End If


    '                        End If




    '                        i += 1
    '                    End While
    '                Catch ex As Exception
    '                End Try
    '                If (satir_kirmizi > satir_yesil And satir_kirmizi > satir_mavi) Then
    '                    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_kirmizi.ToString + " renk ile Kırmızı" + vbNewLine
    '                ElseIf (satir_mavi > satir_yesil And satir_mavi > satir_kirmizi) Then
    '                    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_mavi.ToString + " renk ile Mavi" + vbNewLine
    '                ElseIf (satir_yesil > satir_mavi And satir_yesil > satir_kirmizi) Then
    '                    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_yesil.ToString + " renk ile Yeşil" + vbNewLine
    '                ElseIf (satir_yesil = satir_kirmizi And satir_kirmizi = satir_mavi And satir_yesil = satir_mavi) Then
    '                    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + "??" + " renk ile Beyaz" + vbNewLine
    '                ElseIf (satir_kirmizi = satir_mavi) Then
    '                    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_kirmizi.ToString + " renk ile Magenta" + vbNewLine
    '                ElseIf (satir_kirmizi = satir_yesil) Then
    '                    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_kirmizi.ToString + " renk ile Sarı" + vbNewLine
    '                ElseIf (satir_yesil = satir_mavi) Then
    '                    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_yesil.ToString + " renk ile Cyan" + vbNewLine
    '                Else
    '                    MessageBox.Show("Bir değişiklik var ; MAVİ: " + satir_mavi.ToString + " Kırmızı: " + satir_kirmizi.ToString + " Yeşil: " + satir_yesil.ToString)
    '                End If
    '                satir_yesil = 0
    '                satir_kirmizi = 0
    '                satir_mavi = 0
    '                PictureBox1.Refresh()
    '                k += 1
    '            End While
    '        Catch ex As Exception
    '        End Try
    '    Catch ex As Exception
    '    End Try
    '    RichTextBox1.Text = RichTextBox1.Text + Satırbilgisi + vbNewLine

    '    Dim gecicisatir As Integer = 0
    '    Dim gecicirenk As String = ""
    '    For Each satir In RichTextBox1.Lines
    '        Try
    '            If (Not satir = "") Then
    '                gecicisatir = Convert.ToInt32(satir.Split("Hakim")(0).ToString.Split(":")(1).ToString.Trim)
    '                If (satir.Contains("Yeşil")) Then
    '                    gecicirenk = "Yeşil"
    '                ElseIf (satir.Contains("Mavi")) Then
    '                    gecicirenk = "Mavi"
    '                ElseIf (satir.Contains("Kırmızı")) Then
    '                    gecicirenk = "Kırmızı"
    '                ElseIf (satir.Contains("Beyaz")) Then
    '                    gecicirenk = "Beyaz"
    '                ElseIf (satir.Contains("Cyan")) Then
    '                    gecicirenk = "Cyan"
    '                ElseIf (satir.Contains("Magenta")) Then
    '                    gecicirenk = "Magenta"
    '                ElseIf (satir.Contains("Sarı")) Then
    '                    gecicirenk = "Cyan"
    '                End If


    '                Try
    '                    i = 0
    '                    k = 0
    '                    While (k < h)
    '                        'satır satır
    '                        i = 0
    '                        If (k = gecicisatir) Then
    '                            If (gecicirenk = "Yeşil") Then
    '                                While (i < w)
    '                                    'sütun
    '                                    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Green)
    '                                    i += 1

    '                                End While

    '                            ElseIf (gecicirenk = "Mavi") Then
    '                                While (i < w)
    '                                    'sütun
    '                                    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Blue)
    '                                    i += 1
    '                                End While

    '                            ElseIf (gecicirenk = "Kırmızı") Then
    '                                While (i < w)
    '                                    'sütun
    '                                    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Red)
    '                                    i += 1
    '                                End While

    '                            ElseIf (gecicirenk = "Cyan") Then
    '                                While (i < w)
    '                                    'sütun
    '                                    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Cyan)
    '                                    i += 1
    '                                End While

    '                            ElseIf (gecicirenk = "Magenta") Then
    '                                While (i < w)
    '                                    'sütun
    '                                    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Magenta)
    '                                    i += 1
    '                                End While

    '                            ElseIf (gecicirenk = "Sarı") Then
    '                                While (i < w)
    '                                    'sütun
    '                                    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Yellow)
    '                                    i += 1
    '                                End While

    '                            ElseIf (gecicirenk = "Beyaz") Then
    '                                While (i < w)
    '                                    'sütun
    '                                    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.White)
    '                                    i += 1
    '                                End While
    '                            End If
    '                            'While (i < w)
    '                            '    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Black)
    '                            '    i += 1
    '                            'End While
    '                        End If

    '                        k += 1
    '                    End While
    '                    PictureBox1.Refresh()

    '                    'CType(PictureBox1.Image, Bitmap).SetPixel(0, 0, Color.Black)
    '                Catch ex As Exception

    '                End Try

    '            End If

    '        Catch ex As Exception

    '        End Try
    '    Next

    'End Sub

    Private Sub AnlaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnlaToolStripMenuItem1.Click
        Anla()
    End Sub

    Private Sub KırmızıSüzgeçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KırmızıSüzgeçToolStripMenuItem.Click


        Dim allthings As String = ""
        Dim x As Bitmap
        PictureBox2.Image = PictureBox1.Image.Clone
        x = CType(PictureBox2.Image, Bitmap)

        Dim a, b As Integer
        a = 0
        b = 0
        Dim say As Integer = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = x.Width
        While (a < x.Width)
            b = 0

            While (b < x.Height)
                say += 1
                If (x.GetPixel(a, b).R > x.GetPixel(a, b).B And x.GetPixel(a, b).R > x.GetPixel(a, b).G) Then
                    x.SetPixel(a, b, Color.Red)
                Else
                    x.SetPixel(a, b, x.GetPixel(a, b))
                End If

                b += 1
            End While
            PictureBox2.Refresh()
            ProgressBar1.Value += 1
            a = a + 1

        End While


    End Sub

    Private Sub MaviSkalaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MaviSkalaToolStripMenuItem1.Click

        Dim allthings As String = ""
        Dim x As Bitmap
        PictureBox2.Image = PictureBox1.Image.Clone
        x = CType(PictureBox2.Image, Bitmap)

        Dim a, b As Integer
        a = 0
        b = 0
        Dim say As Integer = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = x.Width
        While (a < x.Width)
            b = 0

            While (b < x.Height)
                say += 1
                If (x.GetPixel(a, b).B > x.GetPixel(a, b).G And x.GetPixel(a, b).B > x.GetPixel(a, b).R) Then
                    x.SetPixel(a, b, Color.Blue)
                Else
                    x.SetPixel(a, b, x.GetPixel(a, b))
                End If

                b += 1
            End While
            PictureBox2.Refresh()
            a = a + 1
            ProgressBar1.Value += 1
        End While


    End Sub

    Private Sub RGBSüzgeçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RGBSüzgeçToolStripMenuItem.Click

        Dim allthings As String = ""
        Dim x As Bitmap
        PictureBox2.Image = PictureBox1.Image.Clone
        x = CType(PictureBox2.Image, Bitmap)

        '   MessageBox.Show("h:" + x.Height.ToString + " w:" + x.Width.ToString)
        Dim a, b As Integer
        a = 0
        b = 0
        Dim say As Integer = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = x.Width
        While (a < x.Width)
            b = 0

            While (b < x.Height)
                say += 1
                If (x.GetPixel(a, b).R > x.GetPixel(a, b).B And x.GetPixel(a, b).R > x.GetPixel(a, b).G) Then
                    x.SetPixel(a, b, Color.Red)
                ElseIf (x.GetPixel(a, b).B > x.GetPixel(a, b).R And x.GetPixel(a, b).B > x.GetPixel(a, b).G) Then
                    x.SetPixel(a, b, Color.Blue)
                ElseIf (x.GetPixel(a, b).G > x.GetPixel(a, b).R And x.GetPixel(a, b).G > x.GetPixel(a, b).B) Then
                    x.SetPixel(a, b, Color.Green)
                Else
                    x.SetPixel(a, b, x.GetPixel(a, b))
                End If

                b += 1
            End While
            PictureBox2.Refresh()
            a = a + 1
            ProgressBar1.Value += 1
        End While

    End Sub

    Private Sub YeşilSüzgeçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeşilSüzgeçToolStripMenuItem.Click

        Dim allthings As String = ""
        Dim x As Bitmap
        PictureBox2.Image = PictureBox1.Image.Clone
        x = CType(PictureBox2.Image, Bitmap)

        Dim a, b As Integer
        a = 0
        b = 0
        Dim say As Integer = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = x.Width
        While (a < x.Width)
            b = 0

            While (b < x.Height)
                say += 1
                If (x.GetPixel(a, b).G > x.GetPixel(a, b).B And x.GetPixel(a, b).G > x.GetPixel(a, b).R) Then
                    x.SetPixel(a, b, Color.Green)
                Else
                    x.SetPixel(a, b, x.GetPixel(a, b))
                End If

                b += 1
            End While
            PictureBox2.Refresh()
            a = a + 1
            ProgressBar1.Value += 1

        End While



    End Sub

    Private Sub TahminEtYarımToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TahminEtYarımToolStripMenuItem.Click

        Dim h As Integer = CType(PictureBox1.Image, Bitmap).Size.Height
        Dim w As Integer = CType(PictureBox1.Image, Bitmap).Size.Width
        PictureBox2.Image = PictureBox1.Image.Clone
        Dim k As Integer = 0
        Dim i As Integer = 0
        Dim max As Integer = 0
        Dim renk As Char
        Dim satir_kirmizi As Integer = 0
        Dim satir_yesil As Integer = 0
        Dim satir_mavi As Integer = 0
        Dim Satırbilgisi As String = ""
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = h
        Try
            Try
                While (k < h)
                    i = 0
                    Try

                        While (i < w)


                            Dim Anlık = CType(PictureBox1.Image, Bitmap).GetPixel(i, k)
                            Dim enbuyuk As Integer = 0
                            If (Anlık.R = Anlık.G And Anlık.G = Anlık.B And Anlık.R = Anlık.B) Then
                                If (Anlık.R > 100) Then
                                    'beyaz
                                    CType(PictureBox2.Image, Bitmap).SetPixel(i, k, Color.White)

                                Else
                                    'siyah
                                    CType(PictureBox2.Image, Bitmap).SetPixel(i, k, Color.Black)
                                End If
                            ElseIf (Anlık.R = Anlık.G) Then
                                ' Kırmızı yeşil = Sarı
                                CType(PictureBox2.Image, Bitmap).SetPixel(i, k, Color.Yellow)
                            ElseIf (Anlık.R = Anlık.B) Then
                                ' Kırmızı mavi = magenta
                                CType(PictureBox2.Image, Bitmap).SetPixel(i, k, Color.Magenta)
                            ElseIf (Anlık.G = Anlık.B) Then
                                ' Mavi yeşil = Cyan
                                CType(PictureBox2.Image, Bitmap).SetPixel(i, k, Color.Cyan)
                            Else

                                If (Anlık.R > enbuyuk) Then
                                    enbuyuk = Anlık.R
                                    renk = "r"
                                End If
                                If (Anlık.G > enbuyuk) Then
                                    enbuyuk = Anlık.G
                                    renk = "g"
                                End If
                                If (Anlık.B > enbuyuk) Then
                                    enbuyuk = Anlık.B
                                    renk = "b"
                                End If
                                If (renk = "r") Then
                                    CType(PictureBox2.Image, Bitmap).SetPixel(i, k, Color.FromArgb(255, enbuyuk, 0, 0))
                                    satir_kirmizi += 1
                                ElseIf (renk = "g") Then
                                    CType(PictureBox2.Image, Bitmap).SetPixel(i, k, Color.FromArgb(255, 0, enbuyuk, 0))
                                    satir_yesil += 1
                                ElseIf (renk = "b") Then
                                    CType(PictureBox2.Image, Bitmap).SetPixel(i, k, Color.FromArgb(255, 0, 0, enbuyuk))
                                    satir_mavi += 1
                                End If


                            End If




                            i += 1

                        End While
                    Catch ex As Exception
                    End Try
                    'If (satir_kirmizi > satir_yesil And satir_kirmizi > satir_mavi) Then
                    '    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_kirmizi.ToString + " renk ile Kırmızı" + vbNewLine
                    'ElseIf (satir_mavi > satir_yesil And satir_mavi > satir_kirmizi) Then
                    '    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_mavi.ToString + " renk ile Mavi" + vbNewLine
                    'ElseIf (satir_yesil > satir_mavi And satir_yesil > satir_kirmizi) Then
                    '    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_yesil.ToString + " renk ile Yeşil" + vbNewLine
                    'ElseIf (satir_yesil = satir_kirmizi And satir_kirmizi = satir_mavi And satir_yesil = satir_mavi) Then
                    '    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + "??" + " renk ile Beyaz" + vbNewLine
                    'ElseIf (satir_kirmizi = satir_mavi) Then
                    '    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_kirmizi.ToString + " renk ile Magenta" + vbNewLine
                    'ElseIf (satir_kirmizi = satir_yesil) Then
                    '    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_kirmizi.ToString + " renk ile Sarı" + vbNewLine
                    'ElseIf (satir_yesil = satir_mavi) Then
                    '    Satırbilgisi = Satırbilgisi + "Satır: " + k.ToString + " Hakim Renk: " + satir_yesil.ToString + " renk ile Cyan" + vbNewLine
                    'Else
                    '    MessageBox.Show("Bir değişiklik var ; MAVİ: " + satir_mavi.ToString + " Kırmızı: " + satir_kirmizi.ToString + " Yeşil: " + satir_yesil.ToString)
                    'End If
                    'satir_yesil = 0
                    'satir_kirmizi = 0
                    'satir_mavi = 0

                    k += 1
                    PictureBox2.Refresh()
                    ProgressBar1.Value += 1
                End While
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
        'RichTextBox1.Text = RichTextBox1.Text + Satırbilgisi + vbNewLine

        'Dim gecicisatir As Integer = 0
        'Dim gecicirenk As String = ""
        'For Each satir In RichTextBox1.Lines
        '    Try
        '        If (Not satir = "") Then
        '            gecicisatir = Convert.ToInt32(satir.Split("Hakim")(0).ToString.Split(":")(1).ToString.Trim)
        '            If (satir.Contains("Yeşil")) Then
        '                gecicirenk = "Yeşil"
        '            ElseIf (satir.Contains("Mavi")) Then
        '                gecicirenk = "Mavi"
        '            ElseIf (satir.Contains("Kırmızı")) Then
        '                gecicirenk = "Kırmızı"
        '            ElseIf (satir.Contains("Beyaz")) Then
        '                gecicirenk = "Beyaz"
        '            ElseIf (satir.Contains("Cyan")) Then
        '                gecicirenk = "Cyan"
        '            ElseIf (satir.Contains("Magenta")) Then
        '                gecicirenk = "Magenta"
        '            ElseIf (satir.Contains("Sarı")) Then
        '                gecicirenk = "Cyan"
        '            End If


        '            Try
        '                i = 0
        '                k = 0
        '                While (k < h)
        '                    'satır satır
        '                    i = 0
        '                    If (k = gecicisatir) Then
        '                        If (gecicirenk = "Yeşil") Then
        '                            While (i < w)
        '                                'sütun
        '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Green)
        '                                i += 1

        '                            End While

        '                        ElseIf (gecicirenk = "Mavi") Then
        '                            While (i < w)
        '                                'sütun
        '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Blue)
        '                                i += 1
        '                            End While

        '                        ElseIf (gecicirenk = "Kırmızı") Then
        '                            While (i < w)
        '                                'sütun
        '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Red)
        '                                i += 1
        '                            End While

        '                        ElseIf (gecicirenk = "Cyan") Then
        '                            While (i < w)
        '                                'sütun
        '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Cyan)
        '                                i += 1
        '                            End While

        '                        ElseIf (gecicirenk = "Magenta") Then
        '                            While (i < w)
        '                                'sütun
        '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Magenta)
        '                                i += 1
        '                            End While

        '                        ElseIf (gecicirenk = "Sarı") Then
        '                            While (i < w)
        '                                'sütun
        '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Yellow)
        '                                i += 1
        '                            End While

        '                        ElseIf (gecicirenk = "Beyaz") Then
        '                            While (i < w)
        '                                'sütun
        '                                CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.White)
        '                                i += 1
        '                            End While
        '                        End If
        '                        'While (i < w)
        '                        '    CType(PictureBox1.Image, Bitmap).SetPixel(i, k, Color.Black)
        '                        '    i += 1
        '                        'End While
        '                    End If

        '                    k += 1
        '                End While
        '                PictureBox1.Refresh()

        '                'CType(PictureBox1.Image, Bitmap).SetPixel(0, 0, Color.Black)
        '            Catch ex As Exception

        '            End Try

        '        End If

        '    Catch ex As Exception

        '    End Try
        'Next

    End Sub
    Private Sub AnalizToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnalizToolStripMenuItem1.Click
        Dim allthings As String = ""
        Dim x As Bitmap
        x = CType(PictureBox1.Image, Bitmap)
        ' MessageBox.Show("h:" + x.Height.ToString + " w:" + x.Width.ToString)
        Dim a, b As Integer
        a = 0
        b = 0
        Dim saygreen As Integer = 0
        Dim sayblue As Integer = 0
        Dim sayred As Integer = 0
        Dim saybeyaz As Integer = 0
        Dim saysiyah As Integer = 0
        Dim say As Integer = 0
        Dim total As Double = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = x.Width
        While (a < x.Width)
            b = 0

            While (b < x.Height)
                say += 1

                If (x.GetPixel(a, b).R > x.GetPixel(a, b).B And x.GetPixel(a, b).R > x.GetPixel(a, b).G) Then
                    sayred += 1
                ElseIf (x.GetPixel(a, b).B > x.GetPixel(a, b).R And x.GetPixel(a, b).B > x.GetPixel(a, b).G) Then
                    sayblue += 1
                ElseIf (x.GetPixel(a, b).G > x.GetPixel(a, b).R And x.GetPixel(a, b).G > x.GetPixel(a, b).B) Then
                    saygreen += 1
                ElseIf (x.GetPixel(a, b).R = 0 And x.GetPixel(a, b).G = 0 And x.GetPixel(a, b).B = 0) Then
                    saysiyah += 1
                ElseIf (x.GetPixel(a, b).R = 255 And x.GetPixel(a, b).G = 255 And x.GetPixel(a, b).B = 255) Then
                    saybeyaz += 1
                End If

                b += 1
            End While

            a = a + 1
            ProgressBar1.Value += 1
        End While

        'RichTextBox1.Text = "Red: " + sayred.ToString + " " + " Green: " + saygreen.ToString + " " + " Blue: " + sayblue.ToString

        MsgBox("Kırmızı: " + sayred.ToString + " " + " Yeşil: " + saygreen.ToString + " " + " Mavi: " + sayblue.ToString + " Beyaz: " + saybeyaz.ToString + " Siyah: " + saysiyah.ToString)

    End Sub




    Private Sub SiyahBeyazTahminiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiyahBeyazTahminiToolStripMenuItem.Click


        Dim x As Bitmap
        PictureBox2.Image = PictureBox1.Image.Clone
        x = CType(PictureBox2.Image, Bitmap)

        Dim a, b As Integer
        a = 0
        b = 0
        Dim islem As Double = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = x.Width
        While (a < x.Width)

            b = 0
            While (b < x.Height)
                islem = (Convert.ToInt32(x.GetPixel(a, b).R) + Convert.ToInt32(x.GetPixel(a, b).G) + Convert.ToInt32(x.GetPixel(a, b).B)) / 3

                If (islem > 128) Then
                    x.SetPixel(a, b, Color.White)
                Else
                    x.SetPixel(a, b, Color.Black)
                End If



                b = b + 1

            End While
            PictureBox2.Refresh()
            ProgressBar1.Value += 1
            a = a + 1
        End While

        PictureBox2.Image = x

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        ÖncekiSonrakiModunuAçToolStripMenuItem.PerformClick()
    End Sub

    Dim onceki_sonraki As Boolean = False
    Private Sub ÖncekiSonrakiModunuAçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖncekiSonrakiModunuAçToolStripMenuItem.Click
        If (ÖncekiSonrakiModunuAçToolStripMenuItem.Text = "Önceki - Sonraki Modunu Aç") Then
            ÖncekiSonrakiModunuAçToolStripMenuItem.Text = "Önceki - Sonraki Modunu Kapat"
            PictureBox2.Visible = True

            PictureBox1.Dock = DockStyle.None
            PictureBox2.Dock = DockStyle.None

            PictureBox1.Size = New Size(Panel1.Width / 2, Panel1.Height)
            PictureBox1.Location = New Point(0, 0)
            PictureBox2.Size = New Size(Panel1.Width / 2, Panel1.Height)
            PictureBox2.Location = New Point(PictureBox1.Width, 0)

            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom

        Else
            ÖncekiSonrakiModunuAçToolStripMenuItem.Text = "Önceki - Sonraki Modunu Aç"
            PictureBox2.Visible = False
            PictureBox1.Dock = DockStyle.Fill
            PictureBox2.Dock = DockStyle.Fill
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub TahminEtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TahminEtToolStripMenuItem1.Click

    End Sub

    Private Sub SonucuKullanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonucuKullanToolStripMenuItem.Click

        PictureBox1.Image = PictureBox2.Image
    End Sub
    Dim pikselsecimmodu As Boolean
    Private Sub PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PToolStripMenuItem.Click
        PictureBox1.Cursor = Cursors.Cross
        pikselsecimmodu = True
    End Sub



    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Try
            If (pikselsecimmodu = True) Then
                Dim Harita As Bitmap
                Harita = CType(PictureBox1.Image, Bitmap)


                Dim ref As New Point(e.X, e.Y)
                Dim refpix = Harita.GetPixel(ref.X, ref.Y)

                'seçtğin nokta merkez olacak şekilde 25 yukarı 25 aşağı 25 sağa 25 sola

                Dim a As Integer = 0
                Dim b As Integer = 0
                Dim c As Integer = 0
                Dim d As Integer = 0
                Dim kareP As Integer = 70

                If (ref.X + kareP >= Harita.Width) Then
                    a = Harita.Width
                Else
                    a = ref.X + kareP
                End If

                If (ref.X - kareP <= 0) Then
                    b = 0
                Else
                    b = ref.X - kareP
                End If

                If (ref.Y + kareP >= Harita.Height) Then
                    c = Harita.Height
                Else
                    c = ref.Y + kareP
                End If

                If (ref.Y - kareP <= 0) Then
                    d = 0
                Else
                    d = ref.Y - kareP
                End If



                'While (b <= a)
                '    Harita.SetPixel(b, ref.Y, Color.Red)
                '    b += 1
                'End While
                'While (d <= c)
                '    Harita.SetPixel(ref.X, d, Color.Red)
                '    d += 1
                'End While

                evx = e.X
                evy = e.Y
                hafiza = Harita.GetPixel(evx, evy)
                rekursif_gez(e.X, e.Y, Color.Red)

                'While (d <= c)

                '    If (ref.X - kareP <= 0) Then
                '        b = 0
                '    Else
                '        b = ref.X - kareP
                '    End If

                '    While (b <= a)

                '        If (Harita.GetPixel(b, d) = refpix) Then
                '            Harita.SetPixel(b, d, Color.Green)
                '        End If


                '        b += 1
                '    End While

                '    d += 1
                'End While





                PictureBox1.Image = Harita
                PictureBox1.Refresh()
                PictureBox1.Cursor = Cursors.Default
                pikselsecimmodu = False
            End If


        Catch ex As Exception
            PictureBox1.Cursor = Cursors.Default
            pikselsecimmodu = False
        End Try

    End Sub
    Dim evx As Integer = 0
    Dim evy As Integer = 0
    Dim hafiza As Color
    Dim sınırsag, sınırsol, sınıryukarı, sınırasagı As Integer

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Gri2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri2ToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception

        End Try

        Dim ahmet As New Bitmap(PictureBox1.Image)

        Dim a As Integer = 0
        Dim b As Integer = 0

        Dim gri As Double = 0
        ProgressBar1.Value = 0

        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)


                gri = Convert.ToInt32(ahmet.GetPixel(a, b).R) * 0.3 + Convert.ToInt32(ahmet.GetPixel(a, b).G) * 0.59 + Convert.ToInt32(ahmet.GetPixel(a, b).B) * 0.11


                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While






        PictureBox2.Image = ahmet
        PictureBox1.Refresh()

    End Sub

    Private Sub Gri4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri4ToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception

        End Try

        Dim ahmet As New Bitmap(PictureBox1.Image)

        Dim a As Integer = 0
        Dim b As Integer = 0

        Dim gri As Double = 0
        ProgressBar1.Value = 0

        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)


                gri = Convert.ToInt32(ahmet.GetPixel(a, b).R) * 0.299 + Convert.ToInt32(ahmet.GetPixel(a, b).G) * 0.587 + Convert.ToInt32(ahmet.GetPixel(a, b).B) * 0.114

                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While






        PictureBox2.Image = ahmet
        PictureBox1.Refresh()

    End Sub

    Private Sub Gri3LUMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri3LUMAToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception

        End Try

        Dim ahmet As New Bitmap(PictureBox1.Image)

        Dim a As Integer = 0
        Dim b As Integer = 0

        Dim gri As Double = 0
        ProgressBar1.Value = 0

        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)


                gri = Convert.ToInt32(ahmet.GetPixel(a, b).R) * 0.2126 + Convert.ToInt32(ahmet.GetPixel(a, b).G) * 0.7152 + Convert.ToInt32(ahmet.GetPixel(a, b).B) * 0.0722


                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While






        PictureBox2.Image = ahmet
        PictureBox1.Refresh()

    End Sub

    Private Sub Gri5DesaturationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri5DesaturationToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception

        End Try

        Dim ahmet As New Bitmap(PictureBox1.Image)

        Dim a As Integer = 0
        Dim b As Integer = 0

        Dim gri As Double = 0
        ProgressBar1.Value = 0

        Dim enbuyuk As Double = 0
        Dim enkucuk As Double = 0

        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)

                If (Convert.ToInt32(ahmet.GetPixel(a, b).R) > Convert.ToInt32(ahmet.GetPixel(a, b).G)) Then
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).R)
                Else
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).G)
                End If

                If (Convert.ToInt32(ahmet.GetPixel(a, b).B) > enbuyuk) Then
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).B)
                End If
                'kucuk
                If (Convert.ToInt32(ahmet.GetPixel(a, b).R) > Convert.ToInt32(ahmet.GetPixel(a, b).G)) Then
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).G)
                Else
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).R)
                End If

                If (Convert.ToInt32(ahmet.GetPixel(a, b).B) < enkucuk) Then
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).B)
                End If


                gri = (enkucuk + enbuyuk) / 2
                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While






        PictureBox2.Image = ahmet
        PictureBox1.Refresh()

    End Sub

    Private Sub Gri6DecompositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri6DecompositionToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception

        End Try

        Dim ahmet As New Bitmap(PictureBox1.Image)

        Dim a As Integer = 0
        Dim b As Integer = 0

        Dim gri As Double = 0
        ProgressBar1.Value = 0

        Dim enbuyuk As Double = 0
        Dim enkucuk As Double = 0

        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)

                If (Convert.ToInt32(ahmet.GetPixel(a, b).R) > Convert.ToInt32(ahmet.GetPixel(a, b).G)) Then
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).R)
                Else
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).G)
                End If

                If (Convert.ToInt32(ahmet.GetPixel(a, b).B) > enbuyuk) Then
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).B)
                End If



                gri = enbuyuk
                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While






        PictureBox2.Image = ahmet
        PictureBox1.Refresh()
    End Sub

    Private Sub Gri62MinDecompositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri62MinDecompositionToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception

        End Try

        Dim ahmet As New Bitmap(PictureBox1.Image)

        Dim a As Integer = 0
        Dim b As Integer = 0

        Dim gri As Double = 0
        ProgressBar1.Value = 0


        Dim enkucuk As Double = 0

        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)


                'kucuk
                If (Convert.ToInt32(ahmet.GetPixel(a, b).R) > Convert.ToInt32(ahmet.GetPixel(a, b).G)) Then
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).G)
                Else
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).R)
                End If

                If (Convert.ToInt32(ahmet.GetPixel(a, b).B) < enkucuk) Then
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).B)
                End If


                gri = enkucuk
                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While






        PictureBox2.Image = ahmet
        PictureBox1.Refresh()
    End Sub

    Private Sub Gri71RedChannelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri71RedChannelToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception
        End Try
        Dim ahmet As New Bitmap(PictureBox1.Image)
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim gri As Double = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)
                gri = Convert.ToInt32(ahmet.GetPixel(a, b).G)
                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))
                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While
        PictureBox2.Image = ahmet
        PictureBox1.Refresh()
    End Sub

    Private Sub Gri72GreenChannelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri72GreenChannelToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception
        End Try
        Dim ahmet As New Bitmap(PictureBox1.Image)
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim gri As Double = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)
                gri = Convert.ToInt32(ahmet.GetPixel(a, b).R)
                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))
                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While
        PictureBox2.Image = ahmet
        PictureBox1.Refresh()
    End Sub

    Private Sub Gri73BlueChannelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri73BlueChannelToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception
        End Try
        Dim ahmet As New Bitmap(PictureBox1.Image)
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim gri As Double = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)
                gri = Convert.ToInt32(ahmet.GetPixel(a, b).B)
                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))
                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While
        PictureBox2.Image = ahmet
        PictureBox1.Refresh()
    End Sub

    Private Sub SB1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SB1ToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception
        End Try
        Dim ahmet As New Bitmap(PictureBox1.Image)
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim sb As Double = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)
                sb = Convert.ToInt32(ahmet.GetPixel(a, b).R) + Convert.ToInt32(ahmet.GetPixel(a, b).G) + Convert.ToInt32(ahmet.GetPixel(a, b).B)
                If (sb / 3 <= 127.5) Then
                    ahmet.SetPixel(a, b, Color.Black)
                Else
                    ahmet.SetPixel(a, b, Color.White)
                End If
                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While
        PictureBox2.Image = ahmet
        PictureBox1.Refresh()
    End Sub

    Private Sub SB2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SB2ToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception
        End Try
        Dim ahmet As New Bitmap(PictureBox1.Image)
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim sb As Double = 0
        Dim enbuyuk As Double = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)

                If (Convert.ToInt32(ahmet.GetPixel(a, b).R) > Convert.ToInt32(ahmet.GetPixel(a, b).G)) Then
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).R)
                Else
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).G)
                End If

                If (Convert.ToInt32(ahmet.GetPixel(a, b).B) > enbuyuk) Then
                    enbuyuk = Convert.ToInt32(ahmet.GetPixel(a, b).B)
                End If

                If (enbuyuk <= 127.5) Then
                    ahmet.SetPixel(a, b, Color.Black)
                Else
                    ahmet.SetPixel(a, b, Color.White)
                End If



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While
        PictureBox2.Image = ahmet
        PictureBox1.Refresh()
    End Sub

    Private Sub SBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SBToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception
        End Try
        Dim ahmet As New Bitmap(PictureBox1.Image)
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim sb As Double = 0
        Dim enkucuk As Double = 0
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)

                If (Convert.ToInt32(ahmet.GetPixel(a, b).R) > Convert.ToInt32(ahmet.GetPixel(a, b).G)) Then
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).G)
                Else
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).R)
                End If

                If (Convert.ToInt32(ahmet.GetPixel(a, b).B) < enkucuk) Then
                    enkucuk = Convert.ToInt32(ahmet.GetPixel(a, b).B)
                End If


                If (enkucuk <= 127.5) Then
                    ahmet.SetPixel(a, b, Color.Black)
                Else
                    ahmet.SetPixel(a, b, Color.White)
                End If



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While
        PictureBox2.Image = ahmet
        PictureBox1.Refresh()
    End Sub

    Dim ops As Integer = 0
    Private Function rekursif_gez(x As Integer, y As Integer, renk As Color)
        Dim Harita As Bitmap
        Harita = CType(PictureBox1.Image, Bitmap)
        If (x >= Harita.Width) Then
            x = Harita.Width
            ops = 0
        End If
        If (y >= Harita.Height) Then
            y = Harita.Height
        End If

        If ((Harita.GetPixel(x, y) = hafiza)) Then
            Harita.SetPixel(x, y, renk)
        Else
            If (ops = 0) Then
                sınırsag = x
                x = evx
                y = evx
                ops = 1
            ElseIf (ops = 1) Then
                sınırsol = x
                x = evx
                y = evx
                ops = 2
            ElseIf (ops = 2) Then
                sınıryukarı = y

                ops = 3
            ElseIf (ops = 3) Then
                sınırasagı = y

                ops = 4
                GoTo bitir
            End If




        End If


        PictureBox1.Image = Harita
        PictureBox1.Refresh()
        If (ops = 0) Then
            Return rekursif_gez(x + 1, y, renk)
        ElseIf (ops = 1) Then
            Return rekursif_gez(x - 1, y, renk)
        ElseIf (ops = 2) Then
            Return rekursif_gez(x, y - 1, renk)
        ElseIf (ops = 3) Then
            Return rekursif_gez(x, y + 1, renk)
        End If


bitir:
        If (ops = 4) Then
            MsgBox("sınırsol:" + sınırsol.ToString + "," + "sınırsag:" + sınırsag.ToString + "," + "sınıryukarı:" + sınıryukarı.ToString + "," + "sınırasagı:" + sınırasagı.ToString)
            ops = 0

        End If

        Return 0
    End Function

    Private Sub Gri1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gri1ToolStripMenuItem.Click
        Try
            PictureBox2.Image = PictureBox1.Image.Clone
        Catch ex As Exception

        End Try

        Dim ahmet As New Bitmap(PictureBox1.Image)

        Dim a As Integer = 0
        Dim b As Integer = 0

        Dim gri As Integer = 0
        ProgressBar1.Value = 0

        ProgressBar1.Maximum = ahmet.Width
        While (a < ahmet.Width)
            b = 0
            While (b < ahmet.Height)


                gri = Convert.ToInt32(ahmet.GetPixel(a, b).R) + Convert.ToInt32(ahmet.GetPixel(a, b).G) + Convert.ToInt32(ahmet.GetPixel(a, b).B)
                gri /= 3

                ahmet.SetPixel(a, b, Color.FromArgb(gri, gri, gri))



                b = b + 1
            End While
            ProgressBar1.Value += 1
            a = a + 1
        End While






        PictureBox2.Image = ahmet
        PictureBox1.Refresh()




    End Sub

End Class
