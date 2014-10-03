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
        Me.TChart1 = New Steema.TeeChart.TChart()
        Me.Line1 = New Steema.TeeChart.Styles.Line()
        Me.TextSource2 = New Steema.TeeChart.Data.TextSource()
        Me.Line2 = New Steema.TeeChart.Styles.Line()
        Me.TextSource3 = New Steema.TeeChart.Data.TextSource()
        Me.TextSource1 = New Steema.TeeChart.Data.TextSource()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Ith_TB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ith_Meas_TB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SeriesRes_Raw_TB = New System.Windows.Forms.TextBox()
        Me.DataFile_TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TestResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RSquared_TB = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LIVFile_Button = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Vth_TB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IphMax_TB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Mirr2Rs_TB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LaPhaRs_TB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Mirr1Rs_TB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GainRs_TB = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GainRsIV_TB = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Slope_TB = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Phase1IV_TB = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Mirr2IV_TB = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Mirr1IV_TB = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.LaPhaIV_TB = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GainIV_TB = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TChart2 = New Steema.TeeChart.TChart()
        Me.Line3 = New Steema.TeeChart.Styles.Line()
        Me.Line4 = New Steema.TeeChart.Styles.Line()
        Me.Line5 = New Steema.TeeChart.Styles.Line()
        Me.Line6 = New Steema.TeeChart.Styles.Line()
        Me.Line7 = New Steema.TeeChart.Styles.Line()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Phase1Rs_TB = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextSource4 = New Steema.TeeChart.Data.TextSource()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog4 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog5 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog6 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PIC_Folder_TB = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TChart1
        '
        Me.TChart1.Location = New System.Drawing.Point(0, 0)
        Me.TChart1.Name = "TChart1"
        Me.TChart1.Series.Add(Me.Line1)
        Me.TChart1.Series.Add(Me.Line2)
        Me.TChart1.Size = New System.Drawing.Size(649, 363)
        Me.TChart1.TabIndex = 0
        '
        'Line1
        '
        '
        '
        '
        Me.Line1.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Line1.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Line1.ColorEach = False
        Me.Line1.DataSource = Me.TextSource2
        '
        '
        '
        Me.Line1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Line1.Title = "IL Curve"
        '
        '
        '
        Me.Line1.XValues.DataMember = "X"
        Me.Line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.Line1.YValues.DataMember = "Y"
        '
        'TextSource2
        '
        Me.TextSource2.DecimalSeparator = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TextSource2.Fields.AddRange(New Steema.TeeChart.Data.TextField() {New Steema.TeeChart.Data.TextField(0, "X"), New Steema.TeeChart.Data.TextField(1, "Y")})
        Me.TextSource2.FileName = "C:\Users\dmcmillan\Documents\Burn In Test\467\1-PIC-467-8152014 80549 PM-LIV - Co" & _
    "py.txt"
        Me.TextSource2.Series = Me.Line1
        '
        'Line2
        '
        '
        '
        '
        Me.Line2.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Line2.Color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Line2.ColorEach = False
        Me.Line2.DataSource = Me.TextSource3
        '
        '
        '
        Me.Line2.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Line2.Title = "IV Curve"
        Me.Line2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right
        '
        '
        '
        Me.Line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.Line2.YValues.DataMember = "Y"
        '
        'TextSource3
        '
        Me.TextSource3.DecimalSeparator = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TextSource3.Fields.AddRange(New Steema.TeeChart.Data.TextField() {New Steema.TeeChart.Data.TextField(0, "X"), New Steema.TeeChart.Data.TextField(1, "Y")})
        Me.TextSource3.Series = Me.Line2
        '
        'TextSource1
        '
        Me.TextSource1.DecimalSeparator = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TextSource1.Fields.AddRange(New Steema.TeeChart.Data.TextField() {New Steema.TeeChart.Data.TextField(0, "Text"), New Steema.TeeChart.Data.TextField(0, "X"), New Steema.TeeChart.Data.TextField(0, "Y")})
        Me.TextSource1.FileName = "C:\Users\dmcmillan\Documents\Burn In Test\467\1-PIC-467-8152014 80549 PM-LIV - Co" & _
    "py.txt"
        Me.TextSource1.HeaderLines = 1
        Me.TextSource1.Series = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(658, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Clear Chart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(658, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Plot"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Ith_TB
        '
        Me.Ith_TB.Location = New System.Drawing.Point(660, 42)
        Me.Ith_TB.Name = "Ith_TB"
        Me.Ith_TB.Size = New System.Drawing.Size(100, 20)
        Me.Ith_TB.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(657, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Threshold Current (A)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(655, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Threshold Current (A)"
        '
        'Ith_Meas_TB
        '
        Me.Ith_Meas_TB.Location = New System.Drawing.Point(658, 239)
        Me.Ith_Meas_TB.Name = "Ith_Meas_TB"
        Me.Ith_Meas_TB.Size = New System.Drawing.Size(100, 20)
        Me.Ith_Meas_TB.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(657, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "IL Curve Analysis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(657, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Raw Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(885, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Rs (Ω)"
        '
        'SeriesRes_Raw_TB
        '
        Me.SeriesRes_Raw_TB.Location = New System.Drawing.Point(888, 42)
        Me.SeriesRes_Raw_TB.Name = "SeriesRes_Raw_TB"
        Me.SeriesRes_Raw_TB.Size = New System.Drawing.Size(100, 20)
        Me.SeriesRes_Raw_TB.TabIndex = 21
        '
        'DataFile_TB
        '
        Me.DataFile_TB.Location = New System.Drawing.Point(797, 279)
        Me.DataFile_TB.Name = "DataFile_TB"
        Me.DataFile_TB.Size = New System.Drawing.Size(233, 20)
        Me.DataFile_TB.TabIndex = 23
        Me.DataFile_TB.Text = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\UID877\DC_Raw_Data\FOC\L" & _
    "IV\UID877_FOC_LIV_Integrating_Sphere_Data2014-08-11_09-52-48.csv"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(739, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Data File:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(883, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Test Result"
        '
        'TestResult
        '
        Me.TestResult.Location = New System.Drawing.Point(886, 239)
        Me.TestResult.Name = "TestResult"
        Me.TestResult.Size = New System.Drawing.Size(144, 20)
        Me.TestResult.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(770, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "R^2 (Correlation)"
        '
        'RSquared_TB
        '
        Me.RSquared_TB.Location = New System.Drawing.Point(773, 239)
        Me.RSquared_TB.Name = "RSquared_TB"
        Me.RSquared_TB.Size = New System.Drawing.Size(100, 20)
        Me.RSquared_TB.TabIndex = 27
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LIVFile_Button
        '
        Me.LIVFile_Button.Location = New System.Drawing.Point(658, 277)
        Me.LIVFile_Button.Name = "LIVFile_Button"
        Me.LIVFile_Button.Size = New System.Drawing.Size(75, 23)
        Me.LIVFile_Button.TabIndex = 29
        Me.LIVFile_Button.Text = "Select File"
        Me.LIVFile_Button.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(770, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Threshold Voltage (V)"
        '
        'Vth_TB
        '
        Me.Vth_TB.Location = New System.Drawing.Point(773, 42)
        Me.Vth_TB.Name = "Vth_TB"
        Me.Vth_TB.Size = New System.Drawing.Size(100, 20)
        Me.Vth_TB.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(657, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Max Photocurrent (mA)"
        '
        'IphMax_TB
        '
        Me.IphMax_TB.Location = New System.Drawing.Point(660, 81)
        Me.IphMax_TB.Name = "IphMax_TB"
        Me.IphMax_TB.Size = New System.Drawing.Size(100, 20)
        Me.IphMax_TB.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(699, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Rs @ 40mA (Ω)"
        '
        'Mirr2Rs_TB
        '
        Me.Mirr2Rs_TB.Location = New System.Drawing.Point(702, 134)
        Me.Mirr2Rs_TB.Name = "Mirr2Rs_TB"
        Me.Mirr2Rs_TB.Size = New System.Drawing.Size(100, 20)
        Me.Mirr2Rs_TB.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(812, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Rs @ 5mA (Ω)"
        '
        'LaPhaRs_TB
        '
        Me.LaPhaRs_TB.Location = New System.Drawing.Point(815, 64)
        Me.LaPhaRs_TB.Name = "LaPhaRs_TB"
        Me.LaPhaRs_TB.Size = New System.Drawing.Size(100, 20)
        Me.LaPhaRs_TB.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(927, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Rs @ 40mA (Ω)"
        '
        'Mirr1Rs_TB
        '
        Me.Mirr1Rs_TB.Location = New System.Drawing.Point(930, 64)
        Me.Mirr1Rs_TB.Name = "Mirr1Rs_TB"
        Me.Mirr1Rs_TB.Size = New System.Drawing.Size(100, 20)
        Me.Mirr1Rs_TB.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(699, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 16)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "IV Curve Analysis"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(699, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Rs @ 100mA (Ω)"
        '
        'GainRs_TB
        '
        Me.GainRs_TB.Location = New System.Drawing.Point(702, 64)
        Me.GainRs_TB.Name = "GainRs_TB"
        Me.GainRs_TB.Size = New System.Drawing.Size(100, 20)
        Me.GainRs_TB.TabIndex = 34
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1041, 389)
        Me.TabControl1.TabIndex = 43
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.GainRsIV_TB)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Slope_TB)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TChart1)
        Me.TabPage1.Controls.Add(Me.Ith_TB)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.SeriesRes_Raw_TB)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Vth_TB)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.LIVFile_Button)
        Me.TabPage1.Controls.Add(Me.IphMax_TB)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DataFile_TB)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.RSquared_TB)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Ith_Meas_TB)
        Me.TabPage1.Controls.Add(Me.TestResult)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1033, 363)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LIV FOC"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(657, 136)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "Gain"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(657, 113)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(129, 16)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "IV Curve Analysis"
        '
        'GainRsIV_TB
        '
        Me.GainRsIV_TB.Location = New System.Drawing.Point(660, 174)
        Me.GainRsIV_TB.Name = "GainRsIV_TB"
        Me.GainRsIV_TB.Size = New System.Drawing.Size(100, 20)
        Me.GainRsIV_TB.TabIndex = 44
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(657, 158)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 13)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Rs @ 100mA (Ω)"
        '
        'Slope_TB
        '
        Me.Slope_TB.Location = New System.Drawing.Point(774, 81)
        Me.Slope_TB.Name = "Slope_TB"
        Me.Slope_TB.Size = New System.Drawing.Size(100, 20)
        Me.Slope_TB.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(771, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Slope Efficiency"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.PIC_Folder_TB)
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Phase1IV_TB)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Mirr2IV_TB)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.Mirr1IV_TB)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.LaPhaIV_TB)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.GainIV_TB)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.TChart2)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Phase1Rs_TB)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.GainRs_TB)
        Me.TabPage2.Controls.Add(Me.Mirr2Rs_TB)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Mirr1Rs_TB)
        Me.TabPage2.Controls.Add(Me.LaPhaRs_TB)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1033, 363)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "IV FOC"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(699, 278)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(91, 23)
        Me.Button10.TabIndex = 63
        Me.Button10.Text = "Phase1 File"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Phase1IV_TB
        '
        Me.Phase1IV_TB.Location = New System.Drawing.Point(796, 280)
        Me.Phase1IV_TB.Name = "Phase1IV_TB"
        Me.Phase1IV_TB.Size = New System.Drawing.Size(233, 20)
        Me.Phase1IV_TB.TabIndex = 62
        Me.Phase1IV_TB.Text = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\UID877\DC_Raw_Data\FOC\I" & _
    "V\UID877_FOC_Phase1_IV-current_2014-08-14_11-25-03.csv"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(699, 255)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 23)
        Me.Button8.TabIndex = 61
        Me.Button8.Text = "Mirror2 File"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Mirr2IV_TB
        '
        Me.Mirr2IV_TB.Location = New System.Drawing.Point(796, 257)
        Me.Mirr2IV_TB.Name = "Mirr2IV_TB"
        Me.Mirr2IV_TB.Size = New System.Drawing.Size(233, 20)
        Me.Mirr2IV_TB.TabIndex = 60
        Me.Mirr2IV_TB.Text = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\UID877\DC_Raw_Data\FOC\I" & _
    "V\UID877_FOC_Mirr2_IV-current_2014-08-14_11-25-01.csv"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(699, 232)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(91, 23)
        Me.Button9.TabIndex = 59
        Me.Button9.Text = "Mirror1 File"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Mirr1IV_TB
        '
        Me.Mirr1IV_TB.Location = New System.Drawing.Point(796, 234)
        Me.Mirr1IV_TB.Name = "Mirr1IV_TB"
        Me.Mirr1IV_TB.Size = New System.Drawing.Size(233, 20)
        Me.Mirr1IV_TB.TabIndex = 58
        Me.Mirr1IV_TB.Text = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\UID877\DC_Raw_Data\FOC\I" & _
    "V\UID877_FOC_Mirr1_IV-current_2014-08-14_11-24-59.csv"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(699, 208)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 23)
        Me.Button7.TabIndex = 57
        Me.Button7.Text = "LaPha File"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'LaPhaIV_TB
        '
        Me.LaPhaIV_TB.Location = New System.Drawing.Point(796, 210)
        Me.LaPhaIV_TB.Name = "LaPhaIV_TB"
        Me.LaPhaIV_TB.Size = New System.Drawing.Size(233, 20)
        Me.LaPhaIV_TB.TabIndex = 56
        Me.LaPhaIV_TB.Text = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\UID877\DC_Raw_Data\FOC\I" & _
    "V\UID877_FOC_LasPha_IV-current_2014-08-14_11-25-10.csv"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(699, 185)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 23)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "Gain File"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GainIV_TB
        '
        Me.GainIV_TB.Location = New System.Drawing.Point(796, 187)
        Me.GainIV_TB.Name = "GainIV_TB"
        Me.GainIV_TB.Size = New System.Drawing.Size(233, 20)
        Me.GainIV_TB.TabIndex = 53
        Me.GainIV_TB.Text = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\UID877\DC_Raw_Data\FOC\I" & _
    "V\UID877_FOC_Gain1_IV-current_2014-08-14_11-24-57.csv"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(699, 307)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 52
        Me.Button5.Text = "Plot"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(699, 336)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(129, 23)
        Me.Button6.TabIndex = 51
        Me.Button6.Text = "Create Excel File"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TChart2
        '
        Me.TChart2.Location = New System.Drawing.Point(-4, 0)
        Me.TChart2.Name = "TChart2"
        Me.TChart2.Series.Add(Me.Line3)
        Me.TChart2.Series.Add(Me.Line4)
        Me.TChart2.Series.Add(Me.Line5)
        Me.TChart2.Series.Add(Me.Line6)
        Me.TChart2.Series.Add(Me.Line7)
        Me.TChart2.Size = New System.Drawing.Size(697, 363)
        Me.TChart2.TabIndex = 50
        '
        'Line3
        '
        '
        '
        '
        Me.Line3.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Line3.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Line3.ColorEach = False
        '
        '
        '
        Me.Line3.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Line3.Title = "GainIV"
        '
        '
        '
        Me.Line3.XValues.DataMember = "X"
        Me.Line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.Line3.YValues.DataMember = "Y"
        '
        'Line4
        '
        '
        '
        '
        Me.Line4.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Line4.Color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Line4.ColorEach = False
        '
        '
        '
        Me.Line4.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Line4.Title = "LaPhaIV"
        '
        '
        '
        Me.Line4.XValues.DataMember = "X"
        Me.Line4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.Line4.YValues.DataMember = "Y"
        '
        'Line5
        '
        '
        '
        '
        Me.Line5.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Line5.Color = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Line5.ColorEach = False
        '
        '
        '
        Me.Line5.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Line5.Title = "Mirror1IV"
        '
        '
        '
        Me.Line5.XValues.DataMember = "X"
        Me.Line5.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.Line5.YValues.DataMember = "Y"
        '
        'Line6
        '
        '
        '
        '
        Me.Line6.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Line6.Color = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Line6.ColorEach = False
        '
        '
        '
        Me.Line6.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Line6.Title = "Mirror2IV"
        '
        '
        '
        Me.Line6.XValues.DataMember = "X"
        Me.Line6.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.Line6.YValues.DataMember = "Y"
        '
        'Line7
        '
        '
        '
        '
        Me.Line7.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Line7.Color = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Line7.ColorEach = False
        Me.Line7.DataSource = Me.TextSource4
        '
        '
        '
        Me.Line7.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Line7.Title = "Phase1IV"
        '
        '
        '
        Me.Line7.XValues.DataMember = "X"
        Me.Line7.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.Line7.YValues.DataMember = "Y"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(816, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Phase 1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(816, 118)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 13)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Rs @ 10mA (Ω)"
        '
        'Phase1Rs_TB
        '
        Me.Phase1Rs_TB.Location = New System.Drawing.Point(819, 134)
        Me.Phase1Rs_TB.Name = "Phase1Rs_TB"
        Me.Phase1Rs_TB.Size = New System.Drawing.Size(100, 20)
        Me.Phase1Rs_TB.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(699, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Mirror 2"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(927, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Mirror 1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(812, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Laser Phase"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(699, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Gain"
        '
        'TextSource4
        '
        Me.TextSource4.DecimalSeparator = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TextSource4.Series = Me.Line7
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog2"
        '
        'OpenFileDialog4
        '
        Me.OpenFileDialog4.FileName = "OpenFileDialog2"
        '
        'OpenFileDialog5
        '
        Me.OpenFileDialog5.FileName = "OpenFileDialog2"
        '
        'OpenFileDialog6
        '
        Me.OpenFileDialog6.FileName = "OpenFileDialog2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(699, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "PIC Folder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PIC_Folder_TB
        '
        Me.PIC_Folder_TB.Location = New System.Drawing.Point(796, 162)
        Me.PIC_Folder_TB.Name = "PIC_Folder_TB"
        Me.PIC_Folder_TB.Size = New System.Drawing.Size(233, 20)
        Me.PIC_Folder_TB.TabIndex = 64
        Me.PIC_Folder_TB.Text = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\UID877\DC_Raw_Data\FOC\I" & _
    "V\UID877_FOC_Gain1_IV-current_2014-08-14_11-24-57.csv"
        '
        'FolderBrowserDialog1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 395)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TChart1 As Steema.TeeChart.TChart
    Friend WithEvents TextSource1 As Steema.TeeChart.Data.TextSource
    Friend WithEvents TextSource2 As Steema.TeeChart.Data.TextSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Ith_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ith_Meas_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SeriesRes_Raw_TB As System.Windows.Forms.TextBox
    Friend WithEvents DataFile_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TestResult As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RSquared_TB As System.Windows.Forms.TextBox
    Friend WithEvents Line1 As Steema.TeeChart.Styles.Line
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LIVFile_Button As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Vth_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IphMax_TB As System.Windows.Forms.TextBox
    Friend WithEvents Line2 As Steema.TeeChart.Styles.Line
    Friend WithEvents TextSource3 As Steema.TeeChart.Data.TextSource
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Mirr2Rs_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LaPhaRs_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Mirr1Rs_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GainRs_TB As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Slope_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Phase1Rs_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TChart2 As Steema.TeeChart.TChart
    Friend WithEvents Line3 As Steema.TeeChart.Styles.Line
    Friend WithEvents Line4 As Steema.TeeChart.Styles.Line
    Friend WithEvents Line5 As Steema.TeeChart.Styles.Line
    Friend WithEvents Line6 As Steema.TeeChart.Styles.Line
    Friend WithEvents Line7 As Steema.TeeChart.Styles.Line
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Phase1IV_TB As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Mirr2IV_TB As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Mirr1IV_TB As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents LaPhaIV_TB As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GainIV_TB As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GainRsIV_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextSource4 As Steema.TeeChart.Data.TextSource
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog4 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog5 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog6 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PIC_Folder_TB As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
