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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.VideoList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MKVMergeOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MKVMergeFileLocation = New System.Windows.Forms.TextBox()
        Me.VideoLocationDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.MKVMergeLocationSelector = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SourceVideoSelector = New System.Windows.Forms.Button()
        Me.SecondAudioList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FirstSubtitleList = New System.Windows.Forms.ListBox()
        Me.SecondSubtitleList = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Track2Name = New System.Windows.Forms.TextBox()
        Me.Track3Name = New System.Windows.Forms.TextBox()
        Me.Track4Name = New System.Windows.Forms.TextBox()
        Me.Track1Name = New System.Windows.Forms.TextBox()
        Me.SecondAudioTrackSelector = New System.Windows.Forms.Button()
        Me.FirstSubtitleTrackSelector = New System.Windows.Forms.Button()
        Me.SecondSubtitleTrackSelector = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OutputFolder = New System.Windows.Forms.TextBox()
        Me.OutputFolderLocationSelector = New System.Windows.Forms.Button()
        Me.Track2Language = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Track3Language = New System.Windows.Forms.ComboBox()
        Me.Track4Language = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Track1Language = New System.Windows.Forms.ComboBox()
        Me.SecondAudioLocationDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.FirstSubtitleLocationDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SecondSubtitleLocationDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OutputFolderLocationDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.OutputFileList = New System.Windows.Forms.ListBox()
        Me.CMDsample = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ForcedSubtitleList = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Track5Name = New System.Windows.Forms.TextBox()
        Me.Track5Language = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ForcedSubtitleTrackSelector = New System.Windows.Forms.Button()
        Me.ForcedSubtitleLocationDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShelltoCMD = New System.Windows.Forms.Button()
        Me.CMDMainPartBox = New System.Windows.Forms.TextBox()
        Me.CMDTrack2PartBox = New System.Windows.Forms.TextBox()
        Me.CMDTrack3PartBox = New System.Windows.Forms.TextBox()
        Me.CMDTrack4PartBox = New System.Windows.Forms.TextBox()
        Me.CMDTrack5PartBox = New System.Windows.Forms.TextBox()
        Me.CMDFiveTracksBox = New System.Windows.Forms.TextBox()
        Me.CMDFourTracksBox = New System.Windows.Forms.TextBox()
        Me.CMDThreeTracksBox = New System.Windows.Forms.TextBox()
        Me.CMDSixTracksBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.VideoListClear = New System.Windows.Forms.Button()
        Me.SecondAudioListClear = New System.Windows.Forms.Button()
        Me.FirstSubtitleListClear = New System.Windows.Forms.Button()
        Me.SecondSubtitleListClear = New System.Windows.Forms.Button()
        Me.ForcedSubtitleListClear = New System.Windows.Forms.Button()
        Me.CMDTwoTracksBox = New System.Windows.Forms.TextBox()
        Me.AllListClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'VideoList
        '
        Me.VideoList.AllowDrop = True
        Me.VideoList.FormattingEnabled = True
        Me.VideoList.HorizontalScrollbar = True
        Me.VideoList.ItemHeight = 16
        Me.VideoList.Location = New System.Drawing.Point(12, 106)
        Me.VideoList.Name = "VideoList"
        Me.VideoList.Size = New System.Drawing.Size(279, 356)
        Me.VideoList.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 534)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MKVMerge.exe Konumu"
        '
        'MKVMergeOpenFileDialog
        '
        Me.MKVMergeOpenFileDialog.FileName = "mkvmerge.exe"
        '
        'MKVMergeFileLocation
        '
        Me.MKVMergeFileLocation.Location = New System.Drawing.Point(641, 534)
        Me.MKVMergeFileLocation.Name = "MKVMergeFileLocation"
        Me.MKVMergeFileLocation.Size = New System.Drawing.Size(292, 22)
        Me.MKVMergeFileLocation.TabIndex = 28
        Me.MKVMergeFileLocation.Text = "C:\Program Files\MKVToolNix\mkvmerge.exe"
        '
        'MKVMergeLocationSelector
        '
        Me.MKVMergeLocationSelector.Location = New System.Drawing.Point(939, 534)
        Me.MKVMergeLocationSelector.Name = "MKVMergeLocationSelector"
        Me.MKVMergeLocationSelector.Size = New System.Drawing.Size(30, 23)
        Me.MKVMergeLocationSelector.TabIndex = 29
        Me.MKVMergeLocationSelector.Text = "..."
        Me.MKVMergeLocationSelector.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Videolar"
        '
        'SourceVideoSelector
        '
        Me.SourceVideoSelector.BackColor = System.Drawing.Color.DarkOrchid
        Me.SourceVideoSelector.Location = New System.Drawing.Point(12, 468)
        Me.SourceVideoSelector.Name = "SourceVideoSelector"
        Me.SourceVideoSelector.Size = New System.Drawing.Size(190, 42)
        Me.SourceVideoSelector.TabIndex = 11
        Me.SourceVideoSelector.Text = "Videoların Bulunduğu Klasörü SEÇ"
        Me.SourceVideoSelector.UseVisualStyleBackColor = False
        '
        'SecondAudioList
        '
        Me.SecondAudioList.AllowDrop = True
        Me.SecondAudioList.FormattingEnabled = True
        Me.SecondAudioList.HorizontalScrollbar = True
        Me.SecondAudioList.ItemHeight = 16
        Me.SecondAudioList.Location = New System.Drawing.Point(297, 106)
        Me.SecondAudioList.Name = "SecondAudioList"
        Me.SecondAudioList.Size = New System.Drawing.Size(279, 356)
        Me.SecondAudioList.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(374, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "İkincil SES Dosyaları"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(672, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Birincil Altyazılar"
        '
        'FirstSubtitleList
        '
        Me.FirstSubtitleList.AllowDrop = True
        Me.FirstSubtitleList.FormattingEnabled = True
        Me.FirstSubtitleList.HorizontalScrollbar = True
        Me.FirstSubtitleList.ItemHeight = 16
        Me.FirstSubtitleList.Location = New System.Drawing.Point(582, 106)
        Me.FirstSubtitleList.Name = "FirstSubtitleList"
        Me.FirstSubtitleList.Size = New System.Drawing.Size(279, 356)
        Me.FirstSubtitleList.TabIndex = 39
        '
        'SecondSubtitleList
        '
        Me.SecondSubtitleList.AllowDrop = True
        Me.SecondSubtitleList.FormattingEnabled = True
        Me.SecondSubtitleList.HorizontalScrollbar = True
        Me.SecondSubtitleList.ItemHeight = 16
        Me.SecondSubtitleList.Location = New System.Drawing.Point(867, 106)
        Me.SecondSubtitleList.Name = "SecondSubtitleList"
        Me.SecondSubtitleList.Size = New System.Drawing.Size(279, 356)
        Me.SecondSubtitleList.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(965, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "İkincil Altyazılar"
        '
        'Track2Name
        '
        Me.Track2Name.Location = New System.Drawing.Point(297, 80)
        Me.Track2Name.Name = "Track2Name"
        Me.Track2Name.Size = New System.Drawing.Size(100, 22)
        Me.Track2Name.TabIndex = 3
        Me.Track2Name.Text = "TR Audio"
        '
        'Track3Name
        '
        Me.Track3Name.Location = New System.Drawing.Point(582, 79)
        Me.Track3Name.Name = "Track3Name"
        Me.Track3Name.Size = New System.Drawing.Size(100, 22)
        Me.Track3Name.TabIndex = 5
        Me.Track3Name.Text = "English Subtitle"
        '
        'Track4Name
        '
        Me.Track4Name.Location = New System.Drawing.Point(867, 79)
        Me.Track4Name.Name = "Track4Name"
        Me.Track4Name.Size = New System.Drawing.Size(100, 22)
        Me.Track4Name.TabIndex = 7
        Me.Track4Name.Text = "Turkish Subtitle"
        '
        'Track1Name
        '
        Me.Track1Name.Location = New System.Drawing.Point(24, 79)
        Me.Track1Name.Name = "Track1Name"
        Me.Track1Name.Size = New System.Drawing.Size(100, 22)
        Me.Track1Name.TabIndex = 1
        Me.Track1Name.Text = "EN Audio"
        '
        'SecondAudioTrackSelector
        '
        Me.SecondAudioTrackSelector.BackColor = System.Drawing.Color.DarkOrchid
        Me.SecondAudioTrackSelector.Location = New System.Drawing.Point(297, 468)
        Me.SecondAudioTrackSelector.Name = "SecondAudioTrackSelector"
        Me.SecondAudioTrackSelector.Size = New System.Drawing.Size(190, 42)
        Me.SecondAudioTrackSelector.TabIndex = 13
        Me.SecondAudioTrackSelector.Text = "Seslerin Bulunduğu Klasörü SEÇ"
        Me.SecondAudioTrackSelector.UseVisualStyleBackColor = False
        '
        'FirstSubtitleTrackSelector
        '
        Me.FirstSubtitleTrackSelector.BackColor = System.Drawing.Color.DarkOrchid
        Me.FirstSubtitleTrackSelector.Location = New System.Drawing.Point(582, 468)
        Me.FirstSubtitleTrackSelector.Name = "FirstSubtitleTrackSelector"
        Me.FirstSubtitleTrackSelector.Size = New System.Drawing.Size(190, 42)
        Me.FirstSubtitleTrackSelector.TabIndex = 15
        Me.FirstSubtitleTrackSelector.Text = "Birincil Altyazıların Bulunduğu Klasörü SEÇ"
        Me.FirstSubtitleTrackSelector.UseVisualStyleBackColor = False
        '
        'SecondSubtitleTrackSelector
        '
        Me.SecondSubtitleTrackSelector.BackColor = System.Drawing.Color.DarkOrchid
        Me.SecondSubtitleTrackSelector.Location = New System.Drawing.Point(867, 468)
        Me.SecondSubtitleTrackSelector.Name = "SecondSubtitleTrackSelector"
        Me.SecondSubtitleTrackSelector.Size = New System.Drawing.Size(190, 42)
        Me.SecondSubtitleTrackSelector.TabIndex = 17
        Me.SecondSubtitleTrackSelector.Text = "İkincil Altyazıların Bulunduğu Klasörü SEÇ"
        Me.SecondSubtitleTrackSelector.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(549, 569)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Çıktı Klasörü"
        '
        'OutputFolder
        '
        Me.OutputFolder.Location = New System.Drawing.Point(641, 569)
        Me.OutputFolder.Name = "OutputFolder"
        Me.OutputFolder.Size = New System.Drawing.Size(292, 22)
        Me.OutputFolder.TabIndex = 30
        '
        'OutputFolderLocationSelector
        '
        Me.OutputFolderLocationSelector.Location = New System.Drawing.Point(939, 568)
        Me.OutputFolderLocationSelector.Name = "OutputFolderLocationSelector"
        Me.OutputFolderLocationSelector.Size = New System.Drawing.Size(30, 23)
        Me.OutputFolderLocationSelector.TabIndex = 31
        Me.OutputFolderLocationSelector.Text = "..."
        Me.OutputFolderLocationSelector.UseVisualStyleBackColor = True
        '
        'Track2Language
        '
        Me.Track2Language.FormattingEnabled = True
        Me.Track2Language.Items.AddRange(New Object() {"aar", "abk", "ace", "ach", "ada", "ady", "afa", "afh", "afr", "ain", "aka", "akk", "alb", "sqi", "ale", "alg", "alt", "amh", "ang", "anp", "apa", "ara", "arc", "arg", "arm", "hye", "arn", "arp", "art", "arw", "asm", "ast", "ath", "aus", "ava", "ave", "awa", "aym", "aze", "bad", "bai", "bak", "bal", "bam", "ban", "baq", "eus", "bas", "bat", "bej", "bel", "bem", "ben", "ber", "bho", "bih", "bik", "bin", "bis", "bla", "bnt", "tib", "bod", "bos", "bra", "bre", "btk", "bua", "bug", "bul", "bur", "mya", "byn", "cad", "cai", "car", "cat", "cau", "ceb", "cel", "cze", "ces", "cha", "chb", "che", "chg", "chi", "zho", "chk", "chm", "chn", "cho", "chp", "chr", "chu", "chv", "chy", "cmc", "cnr", "cop", "cor", "cos", "cpe", "cpf", "cpp", "cre", "crh", "crp", "csb", "cus", "wel", "cym", "cze", "ces", "dak", "dan", "dar", "day", "del", "den", "ger", "deu", "dgr", "din", "div", "doi", "dra", "dsb", "dua", "dum", "dut", "nld", "dyu", "dzo", "efi", "egy", "eka", "gre", "ell", "elx", "eng", "enm", "epo", "est", "baq", "eus", "ewe", "ewo", "fan", "fao", "per", "fas", "fat", "fij", "fil", "fin", "fiu", "fon", "fre", "fra", "fre", "fra", "frm", "fro", "frr", "frs", "fry", "ful", "fur", "gaa", "gay", "gba", "gem", "geo", "kat", "ger", "deu", "gez", "gil", "gla", "gle", "glg", "glv", "gmh", "goh", "gon", "gor", "got", "grb", "grc", "gre", "ell", "grn", "gsw", "guj", "gwi", "hai", "hat", "hau", "haw", "heb", "her", "hil", "him", "hin", "hit", "hmn", "hmo", "hrv", "hsb", "hun", "hup", "arm", "hye", "iba", "ibo", "ice", "isl", "ido", "iii", "ijo", "iku", "ile", "ilo", "ina", "inc", "ind", "ine", "inh", "ipk", "ira", "iro", "ice", "isl", "ita", "jav", "jbo", "jpn", "jpr", "jrb", "kaa", "kab", "kac", "kal", "kam", "kan", "kar", "kas", "geo", "kat", "kau", "kaw", "kaz", "kbd", "kha", "khi", "khm", "kho", "kik", "kin", "kir", "kmb", "kok", "kom", "kon", "kor", "kos", "kpe", "krc", "krl", "kro", "kru", "kua", "kum", "kur", "kut", "lad", "lah", "lam", "lao", "lat", "lav", "lez", "lim", "lin", "lit", "lol", "loz", "ltz", "lua", "lub", "lug", "lui", "lun", "luo", "lus", "mac", "mkd", "mad", "mag", "mah", "mai", "mak", "mal", "man", "mao", "mri", "map", "mar", "mas", "may", "msa", "mdf", "mdr", "men", "mga", "mic", "min", "mis", "mac", "mkd", "mkh", "mlg", "mlt", "mnc", "mni", "mno", "moh", "mon", "mos", "mao", "mri", "may", "msa", "mul", "mun", "mus", "mwl", "mwr", "bur", "mya", "myn", "myv", "nah", "nai", "nap", "nau", "nav", "nbl", "nde", "ndo", "nds", "nep", "new", "nia", "nic", "niu", "dut", "nld", "nno", "nob", "nog", "non", "nor", "nqo", "nso", "nub", "nwc", "nya", "nym", "nyn", "nyo", "nzi", "oci", "oji", "ori", "orm", "osa", "oss", "ota", "oto", "paa", "pag", "pal", "pam", "pan", "pap", "pau", "peo", "per", "fas", "phi", "phn", "pli", "pol", "pon", "por", "pra", "pro", "pus", "qaa-qtz", "que", "raj", "rap", "rar", "roa", "roh", "rom", "rum", "ron", "rum", "ron", "run", "rup", "rus", "sad", "sag", "sah", "sai", "sal", "sam", "san", "sas", "sat", "scn", "sco", "sel", "sem", "sga", "sgn", "shn", "sid", "sin", "sio", "sit", "sla", "slo", "slk", "slo", "slk", "slv", "sma", "sme", "smi", "smj", "smn", "smo", "sms", "sna", "snd", "snk", "sog", "som", "son", "sot", "spa", "alb", "sqi", "srd", "srn", "srp", "srr", "ssa", "ssw", "suk", "sun", "sus", "sux", "swa", "swe", "syc", "syr", "tah", "tai", "tam", "tat", "tel", "tem", "ter", "tet", "tgk", "tgl", "tha", "tib", "bod", "tig", "tir", "tiv", "tkl", "tlh", "tli", "tmh", "tog", "ton", "tpi", "tsi", "tsn", "tso", "tuk", "tum", "tup", "tur", "tut", "tvl", "twi", "tyv", "udm", "uga", "uig", "ukr", "umb", "und", "urd", "uzb", "vai", "ven", "vie", "vol", "vot", "wak", "wal", "war", "was", "wel", "cym", "wen", "wln", "wol", "xal", "xho", "yao", "yap", "yid", "yor", "ypk", "zap", "zbl", "zen", "zgh", "zha", "chi", "zho", "znd", "zul", "zun", "zxx", "zza"})
        Me.Track2Language.Location = New System.Drawing.Point(493, 78)
        Me.Track2Language.Name = "Track2Language"
        Me.Track2Language.Size = New System.Drawing.Size(83, 24)
        Me.Track2Language.TabIndex = 4
        Me.Track2Language.Text = "tur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Dil Kodu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(711, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Dil Kodu"
        '
        'Track3Language
        '
        Me.Track3Language.FormattingEnabled = True
        Me.Track3Language.Items.AddRange(New Object() {"aar", "abk", "ace", "ach", "ada", "ady", "afa", "afh", "afr", "ain", "aka", "akk", "alb", "sqi", "ale", "alg", "alt", "amh", "ang", "anp", "apa", "ara", "arc", "arg", "arm", "hye", "arn", "arp", "art", "arw", "asm", "ast", "ath", "aus", "ava", "ave", "awa", "aym", "aze", "bad", "bai", "bak", "bal", "bam", "ban", "baq", "eus", "bas", "bat", "bej", "bel", "bem", "ben", "ber", "bho", "bih", "bik", "bin", "bis", "bla", "bnt", "tib", "bod", "bos", "bra", "bre", "btk", "bua", "bug", "bul", "bur", "mya", "byn", "cad", "cai", "car", "cat", "cau", "ceb", "cel", "cze", "ces", "cha", "chb", "che", "chg", "chi", "zho", "chk", "chm", "chn", "cho", "chp", "chr", "chu", "chv", "chy", "cmc", "cnr", "cop", "cor", "cos", "cpe", "cpf", "cpp", "cre", "crh", "crp", "csb", "cus", "wel", "cym", "cze", "ces", "dak", "dan", "dar", "day", "del", "den", "ger", "deu", "dgr", "din", "div", "doi", "dra", "dsb", "dua", "dum", "dut", "nld", "dyu", "dzo", "efi", "egy", "eka", "gre", "ell", "elx", "eng", "enm", "epo", "est", "baq", "eus", "ewe", "ewo", "fan", "fao", "per", "fas", "fat", "fij", "fil", "fin", "fiu", "fon", "fre", "fra", "fre", "fra", "frm", "fro", "frr", "frs", "fry", "ful", "fur", "gaa", "gay", "gba", "gem", "geo", "kat", "ger", "deu", "gez", "gil", "gla", "gle", "glg", "glv", "gmh", "goh", "gon", "gor", "got", "grb", "grc", "gre", "ell", "grn", "gsw", "guj", "gwi", "hai", "hat", "hau", "haw", "heb", "her", "hil", "him", "hin", "hit", "hmn", "hmo", "hrv", "hsb", "hun", "hup", "arm", "hye", "iba", "ibo", "ice", "isl", "ido", "iii", "ijo", "iku", "ile", "ilo", "ina", "inc", "ind", "ine", "inh", "ipk", "ira", "iro", "ice", "isl", "ita", "jav", "jbo", "jpn", "jpr", "jrb", "kaa", "kab", "kac", "kal", "kam", "kan", "kar", "kas", "geo", "kat", "kau", "kaw", "kaz", "kbd", "kha", "khi", "khm", "kho", "kik", "kin", "kir", "kmb", "kok", "kom", "kon", "kor", "kos", "kpe", "krc", "krl", "kro", "kru", "kua", "kum", "kur", "kut", "lad", "lah", "lam", "lao", "lat", "lav", "lez", "lim", "lin", "lit", "lol", "loz", "ltz", "lua", "lub", "lug", "lui", "lun", "luo", "lus", "mac", "mkd", "mad", "mag", "mah", "mai", "mak", "mal", "man", "mao", "mri", "map", "mar", "mas", "may", "msa", "mdf", "mdr", "men", "mga", "mic", "min", "mis", "mac", "mkd", "mkh", "mlg", "mlt", "mnc", "mni", "mno", "moh", "mon", "mos", "mao", "mri", "may", "msa", "mul", "mun", "mus", "mwl", "mwr", "bur", "mya", "myn", "myv", "nah", "nai", "nap", "nau", "nav", "nbl", "nde", "ndo", "nds", "nep", "new", "nia", "nic", "niu", "dut", "nld", "nno", "nob", "nog", "non", "nor", "nqo", "nso", "nub", "nwc", "nya", "nym", "nyn", "nyo", "nzi", "oci", "oji", "ori", "orm", "osa", "oss", "ota", "oto", "paa", "pag", "pal", "pam", "pan", "pap", "pau", "peo", "per", "fas", "phi", "phn", "pli", "pol", "pon", "por", "pra", "pro", "pus", "qaa-qtz", "que", "raj", "rap", "rar", "roa", "roh", "rom", "rum", "ron", "rum", "ron", "run", "rup", "rus", "sad", "sag", "sah", "sai", "sal", "sam", "san", "sas", "sat", "scn", "sco", "sel", "sem", "sga", "sgn", "shn", "sid", "sin", "sio", "sit", "sla", "slo", "slk", "slo", "slk", "slv", "sma", "sme", "smi", "smj", "smn", "smo", "sms", "sna", "snd", "snk", "sog", "som", "son", "sot", "spa", "alb", "sqi", "srd", "srn", "srp", "srr", "ssa", "ssw", "suk", "sun", "sus", "sux", "swa", "swe", "syc", "syr", "tah", "tai", "tam", "tat", "tel", "tem", "ter", "tet", "tgk", "tgl", "tha", "tib", "bod", "tig", "tir", "tiv", "tkl", "tlh", "tli", "tmh", "tog", "ton", "tpi", "tsi", "tsn", "tso", "tuk", "tum", "tup", "tur", "tut", "tvl", "twi", "tyv", "udm", "uga", "uig", "ukr", "umb", "und", "urd", "uzb", "vai", "ven", "vie", "vol", "vot", "wak", "wal", "war", "was", "wel", "cym", "wen", "wln", "wol", "xal", "xho", "yao", "yap", "yid", "yor", "ypk", "zap", "zbl", "zen", "zgh", "zha", "chi", "zho", "znd", "zul", "zun", "zxx", "zza"})
        Me.Track3Language.Location = New System.Drawing.Point(778, 78)
        Me.Track3Language.Name = "Track3Language"
        Me.Track3Language.Size = New System.Drawing.Size(83, 24)
        Me.Track3Language.TabIndex = 6
        Me.Track3Language.Text = "eng"
        '
        'Track4Language
        '
        Me.Track4Language.FormattingEnabled = True
        Me.Track4Language.Items.AddRange(New Object() {"aar", "abk", "ace", "ach", "ada", "ady", "afa", "afh", "afr", "ain", "aka", "akk", "alb", "sqi", "ale", "alg", "alt", "amh", "ang", "anp", "apa", "ara", "arc", "arg", "arm", "hye", "arn", "arp", "art", "arw", "asm", "ast", "ath", "aus", "ava", "ave", "awa", "aym", "aze", "bad", "bai", "bak", "bal", "bam", "ban", "baq", "eus", "bas", "bat", "bej", "bel", "bem", "ben", "ber", "bho", "bih", "bik", "bin", "bis", "bla", "bnt", "tib", "bod", "bos", "bra", "bre", "btk", "bua", "bug", "bul", "bur", "mya", "byn", "cad", "cai", "car", "cat", "cau", "ceb", "cel", "cze", "ces", "cha", "chb", "che", "chg", "chi", "zho", "chk", "chm", "chn", "cho", "chp", "chr", "chu", "chv", "chy", "cmc", "cnr", "cop", "cor", "cos", "cpe", "cpf", "cpp", "cre", "crh", "crp", "csb", "cus", "wel", "cym", "cze", "ces", "dak", "dan", "dar", "day", "del", "den", "ger", "deu", "dgr", "din", "div", "doi", "dra", "dsb", "dua", "dum", "dut", "nld", "dyu", "dzo", "efi", "egy", "eka", "gre", "ell", "elx", "eng", "enm", "epo", "est", "baq", "eus", "ewe", "ewo", "fan", "fao", "per", "fas", "fat", "fij", "fil", "fin", "fiu", "fon", "fre", "fra", "fre", "fra", "frm", "fro", "frr", "frs", "fry", "ful", "fur", "gaa", "gay", "gba", "gem", "geo", "kat", "ger", "deu", "gez", "gil", "gla", "gle", "glg", "glv", "gmh", "goh", "gon", "gor", "got", "grb", "grc", "gre", "ell", "grn", "gsw", "guj", "gwi", "hai", "hat", "hau", "haw", "heb", "her", "hil", "him", "hin", "hit", "hmn", "hmo", "hrv", "hsb", "hun", "hup", "arm", "hye", "iba", "ibo", "ice", "isl", "ido", "iii", "ijo", "iku", "ile", "ilo", "ina", "inc", "ind", "ine", "inh", "ipk", "ira", "iro", "ice", "isl", "ita", "jav", "jbo", "jpn", "jpr", "jrb", "kaa", "kab", "kac", "kal", "kam", "kan", "kar", "kas", "geo", "kat", "kau", "kaw", "kaz", "kbd", "kha", "khi", "khm", "kho", "kik", "kin", "kir", "kmb", "kok", "kom", "kon", "kor", "kos", "kpe", "krc", "krl", "kro", "kru", "kua", "kum", "kur", "kut", "lad", "lah", "lam", "lao", "lat", "lav", "lez", "lim", "lin", "lit", "lol", "loz", "ltz", "lua", "lub", "lug", "lui", "lun", "luo", "lus", "mac", "mkd", "mad", "mag", "mah", "mai", "mak", "mal", "man", "mao", "mri", "map", "mar", "mas", "may", "msa", "mdf", "mdr", "men", "mga", "mic", "min", "mis", "mac", "mkd", "mkh", "mlg", "mlt", "mnc", "mni", "mno", "moh", "mon", "mos", "mao", "mri", "may", "msa", "mul", "mun", "mus", "mwl", "mwr", "bur", "mya", "myn", "myv", "nah", "nai", "nap", "nau", "nav", "nbl", "nde", "ndo", "nds", "nep", "new", "nia", "nic", "niu", "dut", "nld", "nno", "nob", "nog", "non", "nor", "nqo", "nso", "nub", "nwc", "nya", "nym", "nyn", "nyo", "nzi", "oci", "oji", "ori", "orm", "osa", "oss", "ota", "oto", "paa", "pag", "pal", "pam", "pan", "pap", "pau", "peo", "per", "fas", "phi", "phn", "pli", "pol", "pon", "por", "pra", "pro", "pus", "qaa-qtz", "que", "raj", "rap", "rar", "roa", "roh", "rom", "rum", "ron", "rum", "ron", "run", "rup", "rus", "sad", "sag", "sah", "sai", "sal", "sam", "san", "sas", "sat", "scn", "sco", "sel", "sem", "sga", "sgn", "shn", "sid", "sin", "sio", "sit", "sla", "slo", "slk", "slo", "slk", "slv", "sma", "sme", "smi", "smj", "smn", "smo", "sms", "sna", "snd", "snk", "sog", "som", "son", "sot", "spa", "alb", "sqi", "srd", "srn", "srp", "srr", "ssa", "ssw", "suk", "sun", "sus", "sux", "swa", "swe", "syc", "syr", "tah", "tai", "tam", "tat", "tel", "tem", "ter", "tet", "tgk", "tgl", "tha", "tib", "bod", "tig", "tir", "tiv", "tkl", "tlh", "tli", "tmh", "tog", "ton", "tpi", "tsi", "tsn", "tso", "tuk", "tum", "tup", "tur", "tut", "tvl", "twi", "tyv", "udm", "uga", "uig", "ukr", "umb", "und", "urd", "uzb", "vai", "ven", "vie", "vol", "vot", "wak", "wal", "war", "was", "wel", "cym", "wen", "wln", "wol", "xal", "xho", "yao", "yap", "yid", "yor", "ypk", "zap", "zbl", "zen", "zgh", "zha", "chi", "zho", "znd", "zul", "zun", "zxx", "zza"})
        Me.Track4Language.Location = New System.Drawing.Point(1063, 78)
        Me.Track4Language.Name = "Track4Language"
        Me.Track4Language.Size = New System.Drawing.Size(83, 24)
        Me.Track4Language.TabIndex = 8
        Me.Track4Language.Text = "tur"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(996, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Dil Kodu"
        '
        'Track1Language
        '
        Me.Track1Language.FormattingEnabled = True
        Me.Track1Language.Items.AddRange(New Object() {"aar", "abk", "ace", "ach", "ada", "ady", "afa", "afh", "afr", "ain", "aka", "akk", "alb", "sqi", "ale", "alg", "alt", "amh", "ang", "anp", "apa", "ara", "arc", "arg", "arm", "hye", "arn", "arp", "art", "arw", "asm", "ast", "ath", "aus", "ava", "ave", "awa", "aym", "aze", "bad", "bai", "bak", "bal", "bam", "ban", "baq", "eus", "bas", "bat", "bej", "bel", "bem", "ben", "ber", "bho", "bih", "bik", "bin", "bis", "bla", "bnt", "tib", "bod", "bos", "bra", "bre", "btk", "bua", "bug", "bul", "bur", "mya", "byn", "cad", "cai", "car", "cat", "cau", "ceb", "cel", "cze", "ces", "cha", "chb", "che", "chg", "chi", "zho", "chk", "chm", "chn", "cho", "chp", "chr", "chu", "chv", "chy", "cmc", "cnr", "cop", "cor", "cos", "cpe", "cpf", "cpp", "cre", "crh", "crp", "csb", "cus", "wel", "cym", "cze", "ces", "dak", "dan", "dar", "day", "del", "den", "ger", "deu", "dgr", "din", "div", "doi", "dra", "dsb", "dua", "dum", "dut", "nld", "dyu", "dzo", "efi", "egy", "eka", "gre", "ell", "elx", "eng", "enm", "epo", "est", "baq", "eus", "ewe", "ewo", "fan", "fao", "per", "fas", "fat", "fij", "fil", "fin", "fiu", "fon", "fre", "fra", "fre", "fra", "frm", "fro", "frr", "frs", "fry", "ful", "fur", "gaa", "gay", "gba", "gem", "geo", "kat", "ger", "deu", "gez", "gil", "gla", "gle", "glg", "glv", "gmh", "goh", "gon", "gor", "got", "grb", "grc", "gre", "ell", "grn", "gsw", "guj", "gwi", "hai", "hat", "hau", "haw", "heb", "her", "hil", "him", "hin", "hit", "hmn", "hmo", "hrv", "hsb", "hun", "hup", "arm", "hye", "iba", "ibo", "ice", "isl", "ido", "iii", "ijo", "iku", "ile", "ilo", "ina", "inc", "ind", "ine", "inh", "ipk", "ira", "iro", "ice", "isl", "ita", "jav", "jbo", "jpn", "jpr", "jrb", "kaa", "kab", "kac", "kal", "kam", "kan", "kar", "kas", "geo", "kat", "kau", "kaw", "kaz", "kbd", "kha", "khi", "khm", "kho", "kik", "kin", "kir", "kmb", "kok", "kom", "kon", "kor", "kos", "kpe", "krc", "krl", "kro", "kru", "kua", "kum", "kur", "kut", "lad", "lah", "lam", "lao", "lat", "lav", "lez", "lim", "lin", "lit", "lol", "loz", "ltz", "lua", "lub", "lug", "lui", "lun", "luo", "lus", "mac", "mkd", "mad", "mag", "mah", "mai", "mak", "mal", "man", "mao", "mri", "map", "mar", "mas", "may", "msa", "mdf", "mdr", "men", "mga", "mic", "min", "mis", "mac", "mkd", "mkh", "mlg", "mlt", "mnc", "mni", "mno", "moh", "mon", "mos", "mao", "mri", "may", "msa", "mul", "mun", "mus", "mwl", "mwr", "bur", "mya", "myn", "myv", "nah", "nai", "nap", "nau", "nav", "nbl", "nde", "ndo", "nds", "nep", "new", "nia", "nic", "niu", "dut", "nld", "nno", "nob", "nog", "non", "nor", "nqo", "nso", "nub", "nwc", "nya", "nym", "nyn", "nyo", "nzi", "oci", "oji", "ori", "orm", "osa", "oss", "ota", "oto", "paa", "pag", "pal", "pam", "pan", "pap", "pau", "peo", "per", "fas", "phi", "phn", "pli", "pol", "pon", "por", "pra", "pro", "pus", "qaa-qtz", "que", "raj", "rap", "rar", "roa", "roh", "rom", "rum", "ron", "rum", "ron", "run", "rup", "rus", "sad", "sag", "sah", "sai", "sal", "sam", "san", "sas", "sat", "scn", "sco", "sel", "sem", "sga", "sgn", "shn", "sid", "sin", "sio", "sit", "sla", "slo", "slk", "slo", "slk", "slv", "sma", "sme", "smi", "smj", "smn", "smo", "sms", "sna", "snd", "snk", "sog", "som", "son", "sot", "spa", "alb", "sqi", "srd", "srn", "srp", "srr", "ssa", "ssw", "suk", "sun", "sus", "sux", "swa", "swe", "syc", "syr", "tah", "tai", "tam", "tat", "tel", "tem", "ter", "tet", "tgk", "tgl", "tha", "tib", "bod", "tig", "tir", "tiv", "tkl", "tlh", "tli", "tmh", "tog", "ton", "tpi", "tsi", "tsn", "tso", "tuk", "tum", "tup", "tur", "tut", "tvl", "twi", "tyv", "udm", "uga", "uig", "ukr", "umb", "und", "urd", "uzb", "vai", "ven", "vie", "vol", "vot", "wak", "wal", "war", "was", "wel", "cym", "wen", "wln", "wol", "xal", "xho", "yao", "yap", "yid", "yor", "ypk", "zap", "zbl", "zen", "zgh", "zha", "chi", "zho", "znd", "zul", "zun", "zxx", "zza"})
        Me.Track1Language.Location = New System.Drawing.Point(208, 78)
        Me.Track1Language.Name = "Track1Language"
        Me.Track1Language.Size = New System.Drawing.Size(83, 24)
        Me.Track1Language.TabIndex = 2
        Me.Track1Language.Text = "eng"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(141, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Dil Kodu"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(169, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 21)
        Me.RadioButton1.TabIndex = 21
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Birinci SES"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(273, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(91, 21)
        Me.RadioButton2.TabIndex = 22
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "İkinci SES"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Varsayılan Altyazı Parçası"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Varsayılan Ses Parçası"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 527)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 59)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SES Dili"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(376, 25)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(68, 21)
        Me.RadioButton6.TabIndex = 23
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Hiçbiri"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(183, 28)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(112, 21)
        Me.RadioButton3.TabIndex = 24
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Birinci Altyazı"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(312, 28)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(105, 21)
        Me.RadioButton4.TabIndex = 25
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "İkinci Altyazı"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 592)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 95)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Altyazı Dili"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(312, 55)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(68, 21)
        Me.RadioButton7.TabIndex = 27
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Hiçbiri"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(183, 55)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(118, 21)
        Me.RadioButton5.TabIndex = 26
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Forced Altyazı"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'OutputFileList
        '
        Me.OutputFileList.FormattingEnabled = True
        Me.OutputFileList.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.OutputFileList.ItemHeight = 16
        Me.OutputFileList.Location = New System.Drawing.Point(823, 621)
        Me.OutputFileList.Name = "OutputFileList"
        Me.OutputFileList.Size = New System.Drawing.Size(103, 20)
        Me.OutputFileList.TabIndex = 37
        Me.OutputFileList.Visible = False
        '
        'CMDsample
        '
        Me.CMDsample.Location = New System.Drawing.Point(730, 620)
        Me.CMDsample.Multiline = True
        Me.CMDsample.Name = "CMDsample"
        Me.CMDsample.Size = New System.Drawing.Size(87, 41)
        Me.CMDsample.TabIndex = 39
        Me.CMDsample.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 17)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Track Adı"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(309, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 17)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Track Adı"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(601, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 17)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Track Adı"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(885, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 17)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Track Adı"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(641, 635)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(176, 52)
        Me.ListBox1.TabIndex = 43
        Me.ListBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cyan
        Me.Button2.Location = New System.Drawing.Point(1421, 781)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(10, 37)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Çağrılan Fonksiyon"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 705)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1419, 113)
        Me.RichTextBox1.TabIndex = 36
        Me.RichTextBox1.Text = ""
        '
        'ForcedSubtitleList
        '
        Me.ForcedSubtitleList.AllowDrop = True
        Me.ForcedSubtitleList.FormattingEnabled = True
        Me.ForcedSubtitleList.HorizontalScrollbar = True
        Me.ForcedSubtitleList.ItemHeight = 16
        Me.ForcedSubtitleList.Location = New System.Drawing.Point(1152, 106)
        Me.ForcedSubtitleList.Name = "ForcedSubtitleList"
        Me.ForcedSubtitleList.Size = New System.Drawing.Size(279, 356)
        Me.ForcedSubtitleList.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1250, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Forced Altyazılar"
        '
        'Track5Name
        '
        Me.Track5Name.Location = New System.Drawing.Point(1152, 79)
        Me.Track5Name.Name = "Track5Name"
        Me.Track5Name.Size = New System.Drawing.Size(126, 22)
        Me.Track5Name.TabIndex = 9
        Me.Track5Name.Text = "Forced Turkish Subtitle"
        '
        'Track5Language
        '
        Me.Track5Language.FormattingEnabled = True
        Me.Track5Language.Items.AddRange(New Object() {"aar", "abk", "ace", "ach", "ada", "ady", "afa", "afh", "afr", "ain", "aka", "akk", "alb", "sqi", "ale", "alg", "alt", "amh", "ang", "anp", "apa", "ara", "arc", "arg", "arm", "hye", "arn", "arp", "art", "arw", "asm", "ast", "ath", "aus", "ava", "ave", "awa", "aym", "aze", "bad", "bai", "bak", "bal", "bam", "ban", "baq", "eus", "bas", "bat", "bej", "bel", "bem", "ben", "ber", "bho", "bih", "bik", "bin", "bis", "bla", "bnt", "tib", "bod", "bos", "bra", "bre", "btk", "bua", "bug", "bul", "bur", "mya", "byn", "cad", "cai", "car", "cat", "cau", "ceb", "cel", "cze", "ces", "cha", "chb", "che", "chg", "chi", "zho", "chk", "chm", "chn", "cho", "chp", "chr", "chu", "chv", "chy", "cmc", "cnr", "cop", "cor", "cos", "cpe", "cpf", "cpp", "cre", "crh", "crp", "csb", "cus", "wel", "cym", "cze", "ces", "dak", "dan", "dar", "day", "del", "den", "ger", "deu", "dgr", "din", "div", "doi", "dra", "dsb", "dua", "dum", "dut", "nld", "dyu", "dzo", "efi", "egy", "eka", "gre", "ell", "elx", "eng", "enm", "epo", "est", "baq", "eus", "ewe", "ewo", "fan", "fao", "per", "fas", "fat", "fij", "fil", "fin", "fiu", "fon", "fre", "fra", "fre", "fra", "frm", "fro", "frr", "frs", "fry", "ful", "fur", "gaa", "gay", "gba", "gem", "geo", "kat", "ger", "deu", "gez", "gil", "gla", "gle", "glg", "glv", "gmh", "goh", "gon", "gor", "got", "grb", "grc", "gre", "ell", "grn", "gsw", "guj", "gwi", "hai", "hat", "hau", "haw", "heb", "her", "hil", "him", "hin", "hit", "hmn", "hmo", "hrv", "hsb", "hun", "hup", "arm", "hye", "iba", "ibo", "ice", "isl", "ido", "iii", "ijo", "iku", "ile", "ilo", "ina", "inc", "ind", "ine", "inh", "ipk", "ira", "iro", "ice", "isl", "ita", "jav", "jbo", "jpn", "jpr", "jrb", "kaa", "kab", "kac", "kal", "kam", "kan", "kar", "kas", "geo", "kat", "kau", "kaw", "kaz", "kbd", "kha", "khi", "khm", "kho", "kik", "kin", "kir", "kmb", "kok", "kom", "kon", "kor", "kos", "kpe", "krc", "krl", "kro", "kru", "kua", "kum", "kur", "kut", "lad", "lah", "lam", "lao", "lat", "lav", "lez", "lim", "lin", "lit", "lol", "loz", "ltz", "lua", "lub", "lug", "lui", "lun", "luo", "lus", "mac", "mkd", "mad", "mag", "mah", "mai", "mak", "mal", "man", "mao", "mri", "map", "mar", "mas", "may", "msa", "mdf", "mdr", "men", "mga", "mic", "min", "mis", "mac", "mkd", "mkh", "mlg", "mlt", "mnc", "mni", "mno", "moh", "mon", "mos", "mao", "mri", "may", "msa", "mul", "mun", "mus", "mwl", "mwr", "bur", "mya", "myn", "myv", "nah", "nai", "nap", "nau", "nav", "nbl", "nde", "ndo", "nds", "nep", "new", "nia", "nic", "niu", "dut", "nld", "nno", "nob", "nog", "non", "nor", "nqo", "nso", "nub", "nwc", "nya", "nym", "nyn", "nyo", "nzi", "oci", "oji", "ori", "orm", "osa", "oss", "ota", "oto", "paa", "pag", "pal", "pam", "pan", "pap", "pau", "peo", "per", "fas", "phi", "phn", "pli", "pol", "pon", "por", "pra", "pro", "pus", "qaa-qtz", "que", "raj", "rap", "rar", "roa", "roh", "rom", "rum", "ron", "rum", "ron", "run", "rup", "rus", "sad", "sag", "sah", "sai", "sal", "sam", "san", "sas", "sat", "scn", "sco", "sel", "sem", "sga", "sgn", "shn", "sid", "sin", "sio", "sit", "sla", "slo", "slk", "slo", "slk", "slv", "sma", "sme", "smi", "smj", "smn", "smo", "sms", "sna", "snd", "snk", "sog", "som", "son", "sot", "spa", "alb", "sqi", "srd", "srn", "srp", "srr", "ssa", "ssw", "suk", "sun", "sus", "sux", "swa", "swe", "syc", "syr", "tah", "tai", "tam", "tat", "tel", "tem", "ter", "tet", "tgk", "tgl", "tha", "tib", "bod", "tig", "tir", "tiv", "tkl", "tlh", "tli", "tmh", "tog", "ton", "tpi", "tsi", "tsn", "tso", "tuk", "tum", "tup", "tur", "tut", "tvl", "twi", "tyv", "udm", "uga", "uig", "ukr", "umb", "und", "urd", "uzb", "vai", "ven", "vie", "vol", "vot", "wak", "wal", "war", "was", "wel", "cym", "wen", "wln", "wol", "xal", "xho", "yao", "yap", "yid", "yor", "ypk", "zap", "zbl", "zen", "zgh", "zha", "chi", "zho", "znd", "zul", "zun", "zxx", "zza"})
        Me.Track5Language.Location = New System.Drawing.Point(1348, 77)
        Me.Track5Language.Name = "Track5Language"
        Me.Track5Language.Size = New System.Drawing.Size(83, 24)
        Me.Track5Language.TabIndex = 10
        Me.Track5Language.Text = "tur"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1281, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 17)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Dil Kodu"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1170, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 17)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Track Adı"
        '
        'ForcedSubtitleTrackSelector
        '
        Me.ForcedSubtitleTrackSelector.BackColor = System.Drawing.Color.DarkOrchid
        Me.ForcedSubtitleTrackSelector.Location = New System.Drawing.Point(1152, 467)
        Me.ForcedSubtitleTrackSelector.Name = "ForcedSubtitleTrackSelector"
        Me.ForcedSubtitleTrackSelector.Size = New System.Drawing.Size(190, 42)
        Me.ForcedSubtitleTrackSelector.TabIndex = 19
        Me.ForcedSubtitleTrackSelector.Text = "Forced Altyazıların Bulunduğu Klasörü SEÇ"
        Me.ForcedSubtitleTrackSelector.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(975, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 103)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Kod Oluştur"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ShelltoCMD
        '
        Me.ShelltoCMD.BackColor = System.Drawing.Color.Lime
        Me.ShelltoCMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ShelltoCMD.Location = New System.Drawing.Point(1155, 534)
        Me.ShelltoCMD.Name = "ShelltoCMD"
        Me.ShelltoCMD.Size = New System.Drawing.Size(276, 77)
        Me.ShelltoCMD.TabIndex = 34
        Me.ShelltoCMD.Text = "Çoklamaya BAŞLA"
        Me.ShelltoCMD.UseVisualStyleBackColor = False
        '
        'CMDMainPartBox
        '
        Me.CMDMainPartBox.Location = New System.Drawing.Point(1369, 176)
        Me.CMDMainPartBox.Multiline = True
        Me.CMDMainPartBox.Name = "CMDMainPartBox"
        Me.CMDMainPartBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDMainPartBox.TabIndex = 54
        Me.CMDMainPartBox.Text = resources.GetString("CMDMainPartBox.Text")
        Me.CMDMainPartBox.Visible = False
        '
        'CMDTrack2PartBox
        '
        Me.CMDTrack2PartBox.Location = New System.Drawing.Point(1369, 205)
        Me.CMDTrack2PartBox.Multiline = True
        Me.CMDTrack2PartBox.Name = "CMDTrack2PartBox"
        Me.CMDTrack2PartBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDTrack2PartBox.TabIndex = 55
        Me.CMDTrack2PartBox.Text = " --language 0:<Track2Language.Text> --track-name ^""0:<Track2Name.Text>^"" --defaul" & _
    "t-track 0:<a2sit> ^""^(^"" ^""<SecondAudioList.Item>^"" ^""^)^"""
        Me.CMDTrack2PartBox.Visible = False
        '
        'CMDTrack3PartBox
        '
        Me.CMDTrack3PartBox.Location = New System.Drawing.Point(1369, 234)
        Me.CMDTrack3PartBox.Multiline = True
        Me.CMDTrack3PartBox.Name = "CMDTrack3PartBox"
        Me.CMDTrack3PartBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDTrack3PartBox.TabIndex = 56
        Me.CMDTrack3PartBox.Text = " --language 0:<Track3Language.Text> --track-name ^""0:<Track3Name.Text>^"" --defaul" & _
    "t-track 0:<s1sit> ^""^(^"" ^""<FirstSubtitleList.Item>^"" ^""^)^"""
        Me.CMDTrack3PartBox.Visible = False
        '
        'CMDTrack4PartBox
        '
        Me.CMDTrack4PartBox.Location = New System.Drawing.Point(1370, 263)
        Me.CMDTrack4PartBox.Multiline = True
        Me.CMDTrack4PartBox.Name = "CMDTrack4PartBox"
        Me.CMDTrack4PartBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDTrack4PartBox.TabIndex = 57
        Me.CMDTrack4PartBox.Text = " --language 0:<Track4Language.Text> --track-name ^""0:<Track4Name.Text>^"" --defaul" & _
    "t-track 0:<s2sit> ^""^(^"" ^""<SecondSubtitleList.Item>^"" ^""^)^"""
        Me.CMDTrack4PartBox.Visible = False
        '
        'CMDTrack5PartBox
        '
        Me.CMDTrack5PartBox.Location = New System.Drawing.Point(1370, 292)
        Me.CMDTrack5PartBox.Multiline = True
        Me.CMDTrack5PartBox.Name = "CMDTrack5PartBox"
        Me.CMDTrack5PartBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDTrack5PartBox.TabIndex = 58
        Me.CMDTrack5PartBox.Text = " --language 0:<Track5Language> --track-name ^""0:<Track5Name>^"" --forced-track 0:<" & _
    "s3sit> ^""^(^"" ^""<ForcedSubtitleList.Item>^"" ^""^)^"""
        Me.CMDTrack5PartBox.Visible = False
        '
        'CMDFiveTracksBox
        '
        Me.CMDFiveTracksBox.Location = New System.Drawing.Point(1370, 402)
        Me.CMDFiveTracksBox.Multiline = True
        Me.CMDFiveTracksBox.Name = "CMDFiveTracksBox"
        Me.CMDFiveTracksBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDFiveTracksBox.TabIndex = 61
        Me.CMDFiveTracksBox.Text = " --track-order 0:0,0:1,1:0,2:0,3:0"
        Me.CMDFiveTracksBox.Visible = False
        '
        'CMDFourTracksBox
        '
        Me.CMDFourTracksBox.Location = New System.Drawing.Point(1370, 373)
        Me.CMDFourTracksBox.Multiline = True
        Me.CMDFourTracksBox.Name = "CMDFourTracksBox"
        Me.CMDFourTracksBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDFourTracksBox.TabIndex = 60
        Me.CMDFourTracksBox.Text = " --track-order 0:0,0:1,1:0,2:0"
        Me.CMDFourTracksBox.Visible = False
        '
        'CMDThreeTracksBox
        '
        Me.CMDThreeTracksBox.Location = New System.Drawing.Point(1370, 350)
        Me.CMDThreeTracksBox.Multiline = True
        Me.CMDThreeTracksBox.Name = "CMDThreeTracksBox"
        Me.CMDThreeTracksBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDThreeTracksBox.TabIndex = 59
        Me.CMDThreeTracksBox.Text = " --track-order 0:0,0:1,1:0"
        Me.CMDThreeTracksBox.Visible = False
        '
        'CMDSixTracksBox
        '
        Me.CMDSixTracksBox.Location = New System.Drawing.Point(1371, 431)
        Me.CMDSixTracksBox.Multiline = True
        Me.CMDSixTracksBox.Name = "CMDSixTracksBox"
        Me.CMDSixTracksBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDSixTracksBox.TabIndex = 62
        Me.CMDSixTracksBox.Text = " --track-order 0:0,0:1,1:0,2:0,3:0,4:0"
        Me.CMDSixTracksBox.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.Location = New System.Drawing.Point(1155, 617)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(276, 78)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "İŞLEMİ İPTAL ET(Tüm CMD ve MKVMerge exe lerini Kapatır!)"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'VideoListClear
        '
        Me.VideoListClear.BackColor = System.Drawing.Color.Tomato
        Me.VideoListClear.Location = New System.Drawing.Point(208, 468)
        Me.VideoListClear.Name = "VideoListClear"
        Me.VideoListClear.Size = New System.Drawing.Size(83, 42)
        Me.VideoListClear.TabIndex = 12
        Me.VideoListClear.Text = "TEMİZLE"
        Me.VideoListClear.UseVisualStyleBackColor = False
        '
        'SecondAudioListClear
        '
        Me.SecondAudioListClear.BackColor = System.Drawing.Color.Tomato
        Me.SecondAudioListClear.Location = New System.Drawing.Point(493, 467)
        Me.SecondAudioListClear.Name = "SecondAudioListClear"
        Me.SecondAudioListClear.Size = New System.Drawing.Size(83, 42)
        Me.SecondAudioListClear.TabIndex = 14
        Me.SecondAudioListClear.Text = "TEMİZLE"
        Me.SecondAudioListClear.UseVisualStyleBackColor = False
        '
        'FirstSubtitleListClear
        '
        Me.FirstSubtitleListClear.BackColor = System.Drawing.Color.Tomato
        Me.FirstSubtitleListClear.Location = New System.Drawing.Point(778, 468)
        Me.FirstSubtitleListClear.Name = "FirstSubtitleListClear"
        Me.FirstSubtitleListClear.Size = New System.Drawing.Size(83, 42)
        Me.FirstSubtitleListClear.TabIndex = 16
        Me.FirstSubtitleListClear.Text = "TEMİZLE"
        Me.FirstSubtitleListClear.UseVisualStyleBackColor = False
        '
        'SecondSubtitleListClear
        '
        Me.SecondSubtitleListClear.BackColor = System.Drawing.Color.Tomato
        Me.SecondSubtitleListClear.Location = New System.Drawing.Point(1063, 468)
        Me.SecondSubtitleListClear.Name = "SecondSubtitleListClear"
        Me.SecondSubtitleListClear.Size = New System.Drawing.Size(83, 42)
        Me.SecondSubtitleListClear.TabIndex = 18
        Me.SecondSubtitleListClear.Text = "TEMİZLE"
        Me.SecondSubtitleListClear.UseVisualStyleBackColor = False
        '
        'ForcedSubtitleListClear
        '
        Me.ForcedSubtitleListClear.BackColor = System.Drawing.Color.Tomato
        Me.ForcedSubtitleListClear.Location = New System.Drawing.Point(1348, 468)
        Me.ForcedSubtitleListClear.Name = "ForcedSubtitleListClear"
        Me.ForcedSubtitleListClear.Size = New System.Drawing.Size(83, 42)
        Me.ForcedSubtitleListClear.TabIndex = 20
        Me.ForcedSubtitleListClear.Text = "TEMİZLE"
        Me.ForcedSubtitleListClear.UseVisualStyleBackColor = False
        '
        'CMDTwoTracksBox
        '
        Me.CMDTwoTracksBox.Location = New System.Drawing.Point(1370, 321)
        Me.CMDTwoTracksBox.Multiline = True
        Me.CMDTwoTracksBox.Name = "CMDTwoTracksBox"
        Me.CMDTwoTracksBox.Size = New System.Drawing.Size(51, 23)
        Me.CMDTwoTracksBox.TabIndex = 69
        Me.CMDTwoTracksBox.Text = " --track-order 0:0,0:1"
        Me.CMDTwoTracksBox.Visible = False
        '
        'AllListClear
        '
        Me.AllListClear.BackColor = System.Drawing.Color.Tomato
        Me.AllListClear.Location = New System.Drawing.Point(975, 643)
        Me.AllListClear.Name = "AllListClear"
        Me.AllListClear.Size = New System.Drawing.Size(171, 54)
        Me.AllListClear.TabIndex = 33
        Me.AllListClear.Text = "TÜM Listeleri TEMİZLE"
        Me.AllListClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 834)
        Me.Controls.Add(Me.AllListClear)
        Me.Controls.Add(Me.CMDTwoTracksBox)
        Me.Controls.Add(Me.ForcedSubtitleListClear)
        Me.Controls.Add(Me.SecondSubtitleListClear)
        Me.Controls.Add(Me.FirstSubtitleListClear)
        Me.Controls.Add(Me.OutputFileList)
        Me.Controls.Add(Me.SecondAudioListClear)
        Me.Controls.Add(Me.VideoListClear)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CMDSixTracksBox)
        Me.Controls.Add(Me.CMDFiveTracksBox)
        Me.Controls.Add(Me.CMDFourTracksBox)
        Me.Controls.Add(Me.CMDThreeTracksBox)
        Me.Controls.Add(Me.CMDTrack5PartBox)
        Me.Controls.Add(Me.CMDTrack4PartBox)
        Me.Controls.Add(Me.CMDTrack3PartBox)
        Me.Controls.Add(Me.CMDTrack2PartBox)
        Me.Controls.Add(Me.CMDMainPartBox)
        Me.Controls.Add(Me.ForcedSubtitleTrackSelector)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Track5Language)
        Me.Controls.Add(Me.Track5Name)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ShelltoCMD)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CMDsample)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Track1Language)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Track4Language)
        Me.Controls.Add(Me.Track3Language)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Track2Language)
        Me.Controls.Add(Me.OutputFolderLocationSelector)
        Me.Controls.Add(Me.OutputFolder)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SecondSubtitleTrackSelector)
        Me.Controls.Add(Me.FirstSubtitleTrackSelector)
        Me.Controls.Add(Me.SecondAudioTrackSelector)
        Me.Controls.Add(Me.Track1Name)
        Me.Controls.Add(Me.Track4Name)
        Me.Controls.Add(Me.Track3Name)
        Me.Controls.Add(Me.Track2Name)
        Me.Controls.Add(Me.SecondSubtitleList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FirstSubtitleList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SecondAudioList)
        Me.Controls.Add(Me.SourceVideoSelector)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MKVMergeLocationSelector)
        Me.Controls.Add(Me.MKVMergeFileLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VideoList)
        Me.Controls.Add(Me.ForcedSubtitleList)
        Me.Name = "Form1"
        Me.Text = "MKVMuxerr Code Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VideoList As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MKVMergeOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MKVMergeFileLocation As System.Windows.Forms.TextBox
    Friend WithEvents VideoLocationDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MKVMergeLocationSelector As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SourceVideoSelector As System.Windows.Forms.Button
    Friend WithEvents SecondAudioList As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FirstSubtitleList As System.Windows.Forms.ListBox
    Friend WithEvents SecondSubtitleList As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Track2Name As System.Windows.Forms.TextBox
    Friend WithEvents Track3Name As System.Windows.Forms.TextBox
    Friend WithEvents Track4Name As System.Windows.Forms.TextBox
    Friend WithEvents Track1Name As System.Windows.Forms.TextBox
    Friend WithEvents SecondAudioTrackSelector As System.Windows.Forms.Button
    Friend WithEvents FirstSubtitleTrackSelector As System.Windows.Forms.Button
    Friend WithEvents SecondSubtitleTrackSelector As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OutputFolder As System.Windows.Forms.TextBox
    Friend WithEvents OutputFolderLocationSelector As System.Windows.Forms.Button
    Friend WithEvents Track2Language As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Track3Language As System.Windows.Forms.ComboBox
    Friend WithEvents Track4Language As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Track1Language As System.Windows.Forms.ComboBox
    Friend WithEvents SecondAudioLocationDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FirstSubtitleLocationDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SecondSubtitleLocationDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OutputFolderLocationDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OutputFileList As System.Windows.Forms.ListBox
    Friend WithEvents CMDsample As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ForcedSubtitleList As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Track5Name As System.Windows.Forms.TextBox
    Friend WithEvents Track5Language As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ForcedSubtitleTrackSelector As System.Windows.Forms.Button
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents ForcedSubtitleLocationDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents ShelltoCMD As System.Windows.Forms.Button
    Friend WithEvents CMDMainPartBox As System.Windows.Forms.TextBox
    Friend WithEvents CMDTrack2PartBox As System.Windows.Forms.TextBox
    Friend WithEvents CMDTrack3PartBox As System.Windows.Forms.TextBox
    Friend WithEvents CMDTrack4PartBox As System.Windows.Forms.TextBox
    Friend WithEvents CMDTrack5PartBox As System.Windows.Forms.TextBox
    Friend WithEvents CMDFiveTracksBox As System.Windows.Forms.TextBox
    Friend WithEvents CMDFourTracksBox As System.Windows.Forms.TextBox
    Friend WithEvents CMDThreeTracksBox As System.Windows.Forms.TextBox
    Friend WithEvents CMDSixTracksBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents VideoListClear As System.Windows.Forms.Button
    Friend WithEvents SecondAudioListClear As System.Windows.Forms.Button
    Friend WithEvents FirstSubtitleListClear As System.Windows.Forms.Button
    Friend WithEvents SecondSubtitleListClear As System.Windows.Forms.Button
    Friend WithEvents ForcedSubtitleListClear As System.Windows.Forms.Button
    Friend WithEvents CMDTwoTracksBox As System.Windows.Forms.TextBox
    Friend WithEvents AllListClear As System.Windows.Forms.Button

End Class
