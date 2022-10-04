Public Class Form1
    Dim CmdFinal As String
    Dim CMDMainPart As String
    Dim CMDTrack2Part As String
    Dim CMDTrack3Part As String
    Dim CMDTrack4Part As String
    Dim CMDTrack5Part As String
    Dim CMDThreeTracks As String
    Dim CMDFourTracks As String
    Dim CMDFiveTracks As String
    Dim CMDSixTracks As String
    Dim CMDTwoTracks As String
    Dim coverimage As String




    Private Sub MKVMergeLocationSelector_Click(sender As Object, e As EventArgs) Handles MKVMergeLocationSelector.Click
        MKVMergeOpenFileDialog.ShowDialog()
        MKVMergeFileLocation.Text = MKVMergeOpenFileDialog.FileName

    End Sub

    Private Sub SourceVideoSelector_Click(sender As Object, e As EventArgs) Handles SourceVideoSelector.Click
        VideoList.Items.Clear()
        Dim VideoLocation As String

        VideoLocationDialog.ShowDialog()
        VideoLocation = VideoLocationDialog.SelectedPath
        If VideoLocationDialog.SelectedPath = "" Then
            MsgBox("Lütfen Seçim Yapınız")
        Else
            Dim AllFiles As String() = IO.Directory.GetFiles(VideoLocation)
            VideoList.Items.AddRange(AllFiles)

            Dim files() As String = IO.Directory.GetFiles(VideoLocationDialog.SelectedPath)

            OutputFileList.Items.Clear()

            For Each file As String In files

                OutputFileList.Items.Add(IO.Path.GetFileNameWithoutExtension(file))

            Next

        End If



        
    End Sub

    Private Sub OutputFolderLocationSelector_Click(sender As Object, e As EventArgs) Handles OutputFolderLocationSelector.Click
        OutputFolderLocationDialog.ShowDialog()
        OutputFolder.Text = OutputFolderLocationDialog.SelectedPath

    End Sub

    Private Sub SecondAudioTrackSelector_Click(sender As Object, e As EventArgs) Handles SecondAudioTrackSelector.Click
        SecondAudioList.Items.Clear()
        Dim SecondAudioLocation As String

        SecondAudioLocationDialog.ShowDialog()
        SecondAudioLocation = SecondAudioLocationDialog.SelectedPath
        If SecondAudioLocationDialog.SelectedPath = "" Then
            MsgBox("Lütfen Seçim Yapınız")
        Else
            SecondAudioList.Items.Clear()
            Dim AllFiles As String() = IO.Directory.GetFiles(SecondAudioLocation)
            SecondAudioList.Items.AddRange(AllFiles)
        End If
    End Sub

    Private Sub FirstSubtitleTrackSelector_Click(sender As Object, e As EventArgs) Handles FirstSubtitleTrackSelector.Click
        FirstSubtitleList.Items.Clear()
        Dim FirstSubtitleLocation As String

        FirstSubtitleLocationDialog.ShowDialog()
        FirstSubtitleLocation = FirstSubtitleLocationDialog.SelectedPath
        If FirstSubtitleLocationDialog.SelectedPath = "" Then
            MsgBox("Lütfen Seçim Yapınız")
        Else
            FirstSubtitleList.Items.Clear()
            Dim AllFiles As String() = IO.Directory.GetFiles(FirstSubtitleLocation)
            FirstSubtitleList.Items.AddRange(AllFiles)
        End If
    End Sub

    Private Sub SecondSubtitleTrackSelector_Click(sender As Object, e As EventArgs) Handles SecondSubtitleTrackSelector.Click
        SecondSubtitleList.Items.Clear()


        Dim SecondSubtitleLocation As String

        SecondSubtitleLocationDialog.ShowDialog()
        SecondSubtitleLocation = SecondSubtitleLocationDialog.SelectedPath
        If SecondSubtitleLocationDialog.SelectedPath = "" Then
            MsgBox("Lütfen Seçim Yapınız")
        Else
            SecondSubtitleList.Items.Clear()
            Dim AllFiles As String() = IO.Directory.GetFiles(SecondSubtitleLocation)
            SecondSubtitleList.Items.AddRange(AllFiles)
        End If
    End Sub
    Dim a1sit As String
    Dim a2sit As String
    Dim s1sit As String
    Dim s2sit As String
    Dim s3sit As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
        CMDMainPart = CMDMainPartBox.Text
        CMDTrack2Part = CMDTrack2PartBox.Text
        CMDTrack3Part = CMDTrack3PartBox.Text
        CMDTrack4Part = CMDTrack4PartBox.Text
        CMDTrack5Part = CMDTrack5PartBox.Text
        CMDThreeTracks = CMDThreeTracksBox.Text
        CMDFourTracks = CMDFourTracksBox.Text
        CMDFiveTracks = CMDFiveTracksBox.Text
        CMDSixTracks = CMDSixTracksBox.Text
        CMDTwoTracks = CMDTwoTracksBox.Text
        'Scheme type Generating
        If SecondAudioList.Items.Count > 0 And FirstSubtitleList.Items.Count > 0 And SecondSubtitleList.Items.Count > 0 And ForcedSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDTrack3Part & CMDTrack4Part & CMDTrack5Part & CMDSixTracks

        ElseIf SecondAudioList.Items.Count > 0 And FirstSubtitleList.Items.Count > 0 And SecondSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDTrack3Part & CMDTrack4Part & CMDFiveTracks

        ElseIf SecondAudioList.Items.Count > 0 And FirstSubtitleList.Items.Count > 0 And ForcedSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDTrack3Part & CMDTrack5Part & CMDFiveTracks

        ElseIf SecondAudioList.Items.Count > 0 And SecondSubtitleList.Items.Count > 0 And ForcedSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDTrack4Part & CMDTrack5Part & CMDFiveTracks

        ElseIf FirstSubtitleList.Items.Count > 0 And SecondSubtitleList.Items.Count > 0 And ForcedSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDTrack4Part & CMDTrack5Part & CMDFiveTracks

        ElseIf SecondAudioList.Items.Count > 0 And FirstSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDTrack3Part & CMDFourTracks

        ElseIf SecondAudioList.Items.Count > 0 And SecondSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDTrack4Part & CMDFourTracks

        ElseIf SecondAudioList.Items.Count > 0 And ForcedSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDTrack5Part & CMDFourTracks

        ElseIf FirstSubtitleList.Items.Count > 0 And SecondSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack3Part & CMDTrack4Part & CMDFourTracks

        ElseIf FirstSubtitleList.Items.Count > 0 And ForcedSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack3Part & CMDTrack5Part & CMDFourTracks

        ElseIf SecondSubtitleList.Items.Count > 0 And ForcedSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack4Part & CMDTrack5Part & CMDFourTracks

        ElseIf SecondAudioList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack2Part & CMDThreeTracks

        ElseIf FirstSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack3Part & CMDThreeTracks

        ElseIf SecondSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack4Part & CMDThreeTracks

        ElseIf ForcedSubtitleList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTrack5Part & CMDThreeTracks

        ElseIf VideoList.Items.Count > 0 Then
            CMDsample.Text = CMDMainPart & CMDTwoTracks

        End If



        RichTextBox1.Clear()


        'If Statement for forced Audio And Subtitle Track Selection
        ListBox1.Items.Clear()


        If RadioButton1.Checked Then
            a1sit = "yes"
        Else
            a1sit = "no"
        End If

        If RadioButton2.Checked Then
            a2sit = "yes"
        Else
            a2sit = "no"
        End If


        If RadioButton3.Checked Then
            s1sit = "yes"
        Else
            s1sit = "no"
        End If

        If RadioButton4.Checked Then
            s2sit = "yes"
        Else
            s2sit = "no"

        End If

        If RadioButton5.Checked Then
            s3sit = "yes"
        Else
            s3sit = "no"
        End If



        'Replacing strings and Generating codes adding to new listbox.
        Dim a As String
        Dim b As String
        Dim c As String
        Dim d As String
        Dim f As String
        Dim g As String
        Dim h As String
        Dim j As String
        Dim k As String
        Dim l As String
        Dim m As String
        Dim n As String
        Dim o As String
        Dim p As String
        Dim r As String
        Dim s As String
        Dim t As String
        Dim u As String
        Dim v As String
        Dim y As String
        Dim z As String
        Dim aa As String
        Dim bb As String
        
        'setting index to 0 listboxes
        If OutputFileList.SelectedIndex >= 0 Then
            OutputFileList.SelectedIndex = 0
        End If

        If SecondAudioList.SelectedIndex >= 0 Then
            SecondAudioList.SelectedIndex = 0
        End If

        If FirstSubtitleList.SelectedIndex >= 0 Then
            FirstSubtitleList.SelectedIndex = 0
        End If

        If SecondSubtitleList.SelectedIndex >= 0 Then
            SecondSubtitleList.SelectedIndex = 0
        End If

        If ForcedSubtitleList.SelectedIndex >= 0 Then
            ForcedSubtitleList.SelectedIndex = 0
        End If


        For Each i As String In VideoList.Items
            a = CMDsample.Text.Replace("<VideoList.Item>", i)
            b = a.Replace("<MKVMergeFileLocation.Text>", MKVMergeFileLocation.Text)
            c = b.Replace("<OutputFolder.Text>", OutputFolder.Text)
            d = c.Replace("<Track1Language.Text>", Track1Language.Text)
            f = d.Replace("<Track1Name.Text>", Track1Name.Text)
            g = f.Replace("<a1sit>", a1sit)
            h = g.Replace("<Track2Language.Text>", Track2Language.Text)
            j = h.Replace("<Track2Name.Text>", Track2Name.Text)
            k = j.Replace("<a2sit>", a2sit)
            l = k.Replace("<Track3Language.Text>", Track3Language.Text)
            m = l.Replace("<Track3Name.Text>", Track3Name.Text)
            n = m.Replace("<s1sit>", s1sit)
            o = n.Replace("<Track4Language.Text>", Track4Language.Text)
            p = o.Replace("<Track4Name.Text>", Track4Name.Text)
            r = p.Replace("<s2sit>", s1sit)
            s = r.Replace("<OutputFileList.Item>", OutputFileList.SelectedItem)
            t = s.Replace("<SecondAudioList.Item>", SecondAudioList.SelectedItem)
            u = t.Replace("<FirstSubtitleList.Item>", FirstSubtitleList.SelectedItem)
            v = u.Replace("<SecondSubtitleList.Item>", SecondSubtitleList.SelectedItem)
            y = v.Replace("<ForcedSubtitleList.Item>", ForcedSubtitleList.SelectedItem)
            z = y.Replace("<Track5Language>", Track5Language.Text)
            aa = z.Replace("<Track5Name>", Track5Name.Text)
            bb = aa.Replace("<s3sit>", s3sit)

            'OutputFileList Index number change
            If OutputFileList.SelectedIndex = OutputFileList.Items.Count - 1 Then

            Else
                OutputFileList.SelectedIndex = OutputFileList.SelectedIndex + 1
            End If


            'SecondAudioList Index number change
            If SecondAudioList.SelectedIndex = SecondAudioList.Items.Count - 1 Then

            Else
                SecondAudioList.SelectedIndex = SecondAudioList.SelectedIndex + 1
            End If


            'FirstSubtitleList Index number change
            If FirstSubtitleList.SelectedIndex = FirstSubtitleList.Items.Count - 1 Then

            Else
                FirstSubtitleList.SelectedIndex = FirstSubtitleList.SelectedIndex + 1
            End If


            'SecondSubtitleList Index number change
            If SecondSubtitleList.SelectedIndex = SecondSubtitleList.Items.Count - 1 Then

            Else
                SecondSubtitleList.SelectedIndex = SecondSubtitleList.SelectedIndex + 1
            End If

            'ForcedSubtitleList Index number change
            If ForcedSubtitleList.SelectedIndex = ForcedSubtitleList.Items.Count - 1 Then
            Else
                ForcedSubtitleList.SelectedIndex = ForcedSubtitleList.SelectedIndex + 1
            End If

            


            ListBox1.Items.Add(bb)



        Next


        If ListBox1.Items.Count = 0 Then
        Else
            RichTextBox1.Text = "chcp 1254" & Environment.NewLine
        End If

        For x As Integer = 0 To ListBox1.Items.Count - 1

            RichTextBox1.AppendText(ListBox1.Items(x).ToString & Environment.NewLine)


        Next

    End Sub

    Private Sub ForcedSubtitleTrackSelector_Click(sender As Object, e As EventArgs) Handles ForcedSubtitleTrackSelector.Click
        ForcedSubtitleList.Items.Clear()

        Dim ForcedSubtitleLocation As String

        ForcedSubtitleLocationDialog.ShowDialog()
        ForcedSubtitleLocation = ForcedSubtitleLocationDialog.SelectedPath
        If ForcedSubtitleLocationDialog.SelectedPath = "" Then
            MsgBox("Lütfen Seçim Yapınız")
        Else
            ForcedSubtitleList.Items.Clear()
            Dim AllFiles As String() = IO.Directory.GetFiles(ForcedSubtitleLocation)
            ForcedSubtitleList.Items.AddRange(AllFiles)


        End If
    End Sub

    'Procces Kill'
    '        Try
    '            Dim Xcel() As Process = Process.GetProcessesByName("cmd")
    '            For Each Process As Process In Xcel
    '                Process.Kill()
    '           Next
    '       Catch ex As Exception
    '       End Try
    '
    '       Try
    '            Dim Xcel() As Process = Process.GetProcessesByName("mkvmerge")
    '            For Each Process As Process In Xcel
    '               Process.Kill()
    '           Next
    '       Catch ex As Exception
    '       End Try

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.PerformClick()
        Button2.PerformClick()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OutputFolder.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\muxed"

    End Sub

    Private Sub ShelltoCMD_Click(sender As Object, e As EventArgs) Handles ShelltoCMD.Click
        Button1.PerformClick()
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Desktop & "\muxcommand.txt") Then
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Desktop & "\muxcommand.txt")

        End If

        'My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Desktop & "\muxcommand.txt", RichTextBox1.Text, True)

        RichTextBox1.SaveFile(My.Computer.FileSystem.SpecialDirectories.Desktop & "\muxcommand.txt", RichTextBoxStreamType.PlainText)

        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Desktop & "\muxcommand.txt") Then
            If RichTextBox1.Text = "" Then
            Else

                Shell("CMD.exe /K type %UserProfile%\Desktop\muxcommand.txt|cmd chcp 1254")


            End If
        End If


    End Sub

    'VideoList DragAndDrop
    Private Sub VideoList_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles VideoList.DragDrop
        VideoList.Items.Clear()
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            VideoList.Items.Add(IO.Path.GetFullPath(path))
        Next


        If VideoList.Items.Count = 1 And My.Computer.FileSystem.DirectoryExists(VideoList.Items.Item(0).ToString) Then

            Dim AllFiles As String() = IO.Directory.GetFiles(VideoList.Items.Item(0).ToString)

            VideoList.Items.AddRange(AllFiles)
            VideoList.SelectedIndex = "0"
            VideoList.Items.Remove(VideoList.SelectedItem)


        Else

        End If

        OutputFileList.Items.Clear()

        For Each file As String In VideoList.Items

            OutputFileList.Items.Add(IO.Path.GetFileNameWithoutExtension(file))
        Next

    End Sub

    Private Sub VideoList_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles VideoList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    'SecondAudioList DragAndDrop
    Private Sub SecondAudioList_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles SecondAudioList.DragDrop
        SecondAudioList.Items.Clear()
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            SecondAudioList.Items.Add(IO.Path.GetFullPath(path))
        Next


        If SecondAudioList.Items.Count = 1 And My.Computer.FileSystem.DirectoryExists(SecondAudioList.Items.Item(0).ToString) Then

            Dim AllFiles As String() = IO.Directory.GetFiles(SecondAudioList.Items.Item(0).ToString)

            SecondAudioList.Items.AddRange(AllFiles)
            SecondAudioList.SelectedIndex = "0"
            SecondAudioList.Items.Remove(SecondAudioList.SelectedItem)


        Else

        End If

    End Sub

    Private Sub SecondAudioList_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles SecondAudioList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    'FirstSubtitleList DragAndDrop
    Private Sub FirstSubtitleList_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles FirstSubtitleList.DragDrop
        FirstSubtitleList.Items.Clear()
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            FirstSubtitleList.Items.Add(IO.Path.GetFullPath(path))
        Next


        If FirstSubtitleList.Items.Count = 1 And My.Computer.FileSystem.DirectoryExists(FirstSubtitleList.Items.Item(0).ToString) Then

            Dim AllFiles As String() = IO.Directory.GetFiles(FirstSubtitleList.Items.Item(0).ToString)

            FirstSubtitleList.Items.AddRange(AllFiles)
            FirstSubtitleList.SelectedIndex = "0"
            FirstSubtitleList.Items.Remove(FirstSubtitleList.SelectedItem)


        Else

        End If
    End Sub

    Private Sub FirstSubtitleList_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles FirstSubtitleList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    'SecondSubtitleList DragAndDrop
    Private Sub SecondSubtitleList_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles SecondSubtitleList.DragDrop
        SecondSubtitleList.Items.Clear()
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            SecondSubtitleList.Items.Add(IO.Path.GetFullPath(path))
        Next


        If SecondSubtitleList.Items.Count = 1 And My.Computer.FileSystem.DirectoryExists(SecondSubtitleList.Items.Item(0).ToString) Then

            Dim AllFiles As String() = IO.Directory.GetFiles(SecondSubtitleList.Items.Item(0).ToString)

            SecondSubtitleList.Items.AddRange(AllFiles)
            SecondSubtitleList.SelectedIndex = "0"
            SecondSubtitleList.Items.Remove(SecondSubtitleList.SelectedItem)


        Else

        End If

    End Sub

    Private Sub SecondSubtitleList_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles SecondSubtitleList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    'ForcedSubtitleList DragAndDrop
    Private Sub ForcedSubtitleList_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles ForcedSubtitleList.DragDrop
        ForcedSubtitleList.Items.Clear()
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            ForcedSubtitleList.Items.Add(IO.Path.GetFullPath(path))
        Next


        If ForcedSubtitleList.Items.Count = 1 And My.Computer.FileSystem.DirectoryExists(ForcedSubtitleList.Items.Item(0).ToString) Then

            Dim AllFiles As String() = IO.Directory.GetFiles(ForcedSubtitleList.Items.Item(0).ToString)

            ForcedSubtitleList.Items.AddRange(AllFiles)
            ForcedSubtitleList.SelectedIndex = "0"
            ForcedSubtitleList.Items.Remove(ForcedSubtitleList.SelectedItem)


        Else

        End If
    End Sub

    Private Sub ForcedSubtitleList_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles ForcedSubtitleList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub VideoListClear_Click(sender As Object, e As EventArgs) Handles VideoListClear.Click
        VideoList.Items.Clear()
    End Sub

    Private Sub SecondAudioListClear_Click(sender As Object, e As EventArgs) Handles SecondAudioListClear.Click
        SecondAudioList.Items.Clear()
    End Sub

    Private Sub FirstSubtitleListClear_Click(sender As Object, e As EventArgs) Handles FirstSubtitleListClear.Click
        FirstSubtitleList.Items.Clear()
    End Sub

    Private Sub SecondSubtitleListClear_Click(sender As Object, e As EventArgs) Handles SecondSubtitleListClear.Click
        SecondSubtitleList.Items.Clear()
    End Sub

    Private Sub ForcedSubtitleListClear_Click(sender As Object, e As EventArgs) Handles ForcedSubtitleListClear.Click
        ForcedSubtitleList.Items.Clear()
    End Sub

    Private Sub AllListClear_Click(sender As Object, e As EventArgs) Handles AllListClear.Click
        VideoList.Items.Clear()
        SecondAudioList.Items.Clear()
        FirstSubtitleList.Items.Clear()
        SecondSubtitleList.Items.Clear()
        ForcedSubtitleList.Items.Clear()
        OutputFileList.Items.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Xcel() As Process = Process.GetProcessesByName("cmd")
            For Each Process As Process In Xcel
                Process.Kill()
            Next
        Catch ex As Exception
        End Try

        Try
            Dim Xcel() As Process = Process.GetProcessesByName("mkvmerge")
            For Each Process As Process In Xcel
                Process.Kill()
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class
