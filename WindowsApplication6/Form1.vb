Imports Steema.TeeChart.Functions.PolyFitting
Imports Steema.TeeChart.Functions.TrendFunction
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Texts
Imports Steema.TeeChart.Legend
Imports Steema.TeeChart.Functions.Poly
Imports Microsoft.Office.Interop.Excel


Public Class Form1
    Private Sub TChart1_Click(sender As Object, e As EventArgs) Handles TChart1.Click
        'Dim IV_Curve As New Steema.TeeChart.Styles.FastLine
        'Try
        '    ''TChart1.Series.Clear()
        '    'IV_Curve.Add(0, 0)
        '    'IV_Curve.Add(1, 2)
        '    'IV_Curve.Add(2, 5)
        '    'IV_Curve.Add(3, 12)
        '    'IV_Curve.Add(4, 25)
        '    'IV_Curve.Add(5, 102)
        '    'IV_Curve.Add(6, 255)
        '    'IV_Curve.LinePen.Width = 3
        '    TChart1.Legend.Visible = False

        '    'TChart1.Series.Add(IV_Curve) ' Draw data on plot

        '    'Read Text Files
        '    'Steema.TeeChart. Data.TextSource = new Steema.TeeChart.WPF.Data.TextSource(@"G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\Burn In\467\1-PIC-467-8152014 80549 PM-LIV.txt")
        '    'Dim ts As New TeeChart.Data.TextSource(textBox2.Text)
        '    Dim ts As New Steema.TeeChart.Data.TextSource("G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\Burn In\467\1-PIC-467-8152014 80549 PM-LIV - Copy.txt")
        '    'Steema.TeeChart.WPF.Data.TextSource ts1 = new Steema.TeeChart.WPF.Data.TextSource(@"G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\Burn In\467\Test1.csv") 
        '    ts.HeaderLines = 0
        '    ts.DecimalSeparator = "."
        '    ts.Separator = ","
        '    ts.Fields.Add(0, "X")
        '    ts.Fields.Add(1, "Y")

        '    IV_Curve.XValues.DateTime = True
        '    ' Assign Text File to Series1
        '    IV_Curve.DataSource = ts
        '    IV_Curve.XValues.DataMember = "X"
        '    IV_Curve.YValues.DataMember = "Y"

        '    Dim polyfit As New Steema.TeeChart.Styles.FastLine(TChart1.Chart)
        '    Dim polyfitFunc As New Steema.TeeChart.Functions.PolyFitting

        '    polyfit.Title = "Fitted Data"

        '    polyfit.Function = polyfitFunc
        '    polyfitFunc.PolyDegree = Polyfit_Order_CB.Text
        '    polyfit.DataSource = IV_Curve ' Graph fit
        '    TChart1.Series.Add(polyfit)
        '    TChart1.Series.Add(IV_Curve)
        '    TChart1.Refresh()
        '    TChart1.Draw()

        '    polyfit.CheckDataSource()
        '    Dim MaxPower As Double
        '    Dim Degree As Double = polyfitFunc.PolyDegree
        '    Dim C1 As String = polyfitFunc.Coefficient(0)
        '    Dim C2 As String = polyfitFunc.Coefficient(1)
        '    Dim C3 As String = polyfitFunc.Coefficient(2)
        '    Dim C4 As String = polyfitFunc.Coefficient(3)
        '    Dim C5 As String = polyfitFunc.Coefficient(4)

        '    Dim CurveFit_Eq As String = "C1:" + C1 + ", C2:" + C2 + ", C3:" + C3 + ", C4:" + C4 + ", C5:" + C5
        '    MaxPower = polyfit.MaxYValue

        '    ' Calculate threshold using 10% of maximum
        '    Dim Ith As Double = 0
        '    Dim Power As Double = 0
        '    Dim Current As Double = 0
        '    Do Until Power >= MaxPower / 10 ' 10% target
        '        Power = polyfitFunc.GetCurveYValue(polyfit, Current)
        '        Current += Current + 0.0001
        '    Loop
        '    Ith = Current
        '    Power = Power
        '    Dim C6 As Double = 0
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK)
        'End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TChart1.Series.Clear()
        TChart1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IV_Curve As New Steema.TeeChart.Styles.Line
        Dim IL_Curve As New Steema.TeeChart.Styles.Line
        Try
            'TChart1.Series.Clear()
            TChart1.Legend.Visible = True
            TChart1.Axes.Right.Title.Visible = True
            TChart1.Text = "LIV Graph"
            TChart1.Axes.Left.Title.Text = "Power(mW)"
            'TChart1.Axes.Left.RelativePosition = 0
            TChart1.Axes.Bottom.Title.Text = "Current(A)"
            TChart1.Axes.Right.Title.Text = "Voltage(V)"
            'TChart1.Axes.Right.RelativePosition = 0
            'TChart1.Axes.Custom.Add(New Steema.TeeChart.Axis(TChart1.Chart))

            Dim ts As New Steema.TeeChart.Data.TextSource(DataFile_TB.Text)
            ts.HeaderLines = 1
            ts.DecimalSeparator = "."
            ts.Separator = ","
            ts.Fields.Add(0, "X")
            ts.Fields.Add(1, "Y") ' 
            ' Assign Text File to Series1
            IV_Curve.DataSource = ts
            IV_Curve.XValues.DataMember = "X"
            IV_Curve.YValues.DataMember = "Y"
            Line1.Title = "IL Curve"
            Line2.Title = "IV Curve"
            Line2.DataSource = IV_Curve

            Dim ts2 As New Steema.TeeChart.Data.TextSource(DataFile_TB.Text)
            ts2.HeaderLines = 1
            ts2.DecimalSeparator = "."
            ts2.Separator = ","
            ts2.Fields.Add(0, "X")
            ts2.Fields.Add(2, "Y")
            ' Assign Text File to Series2
            IL_Curve.DataSource = ts2
            IL_Curve.XValues.DataMember = "X"
            IL_Curve.YValues.DataMember = "Y"
            ' Assign IV_Curve and IL_Curve to Line1 of TChart
            Line1.DataSource = IL_Curve
            TChart1.Refresh()
            TChart1.Draw()

            Dim ts3 As New Steema.TeeChart.Data.TextSource(DataFile_TB.Text)
            ts2.HeaderLines = 1
            ts2.DecimalSeparator = "."
            ts2.Separator = ","
            ts2.Fields.Add(0, "X")
            ts2.Fields.Add(3, "Y")
            ' Assign Text File to Series2
            IL_Curve.DataSource = ts2
            IL_Curve.XValues.DataMember = "X"
            IL_Curve.YValues.DataMember = "Y"
            IphMax_TB.Text = IL_Curve.YValues.Maximum
            ' Calculate threshold using 10% of maximum on curve fit
            Dim Ith As Double = 0
            Dim Vth As Double = 0
            Dim Rs As Double = 0

            Dim Power As Double = 0
            Dim MaxPower As Double = IL_Curve.YValues.Maximum
            Dim PowerIth As Double = MaxPower / 10
            Dim Counter As Integer = 0
            ' Calculate current at 10% of maximum on raw data
            Ith = 0
            Power = 0
            PowerIth = MaxPower / 5
            Counter = 0
            Dim TenPercentCounter As Integer = 0
            Dim ITenPercent As Double = 0
            Dim VTenPercent As Double = 0
            Do Until Power > PowerIth ' Acquire 10% LI target for Δm sweep
                Power = IL_Curve.YValues.Value(TenPercentCounter)
                TenPercentCounter += 1
            Loop
            VTenPercent = IV_Curve.YValues(TenPercentCounter) ' Set V 20% values
            ITenPercent = IV_Curve.XValues(TenPercentCounter) ' Set I 20% values

            Dim CounterRange As Integer = TenPercentCounter
            Dim Slope1 As Double = 0
            Dim Slope2 As Double = 0
            Dim DeltaSlope As Double = 0
            Dim MaxDeltaSlope As Double = 0
            Dim ThresholdCounter As Integer
            Counter = 1

            Do Until Counter > CounterRange - 2 ' 20% LI range for Δm sweep
                Slope1 = (IL_Curve.YValues.Value(Counter) - IL_Curve.YValues.Value(Counter + 1)) / (IL_Curve.XValues.Value(Counter) - IL_Curve.XValues.Value(Counter + 1))
                Slope2 = (IL_Curve.YValues.Value(Counter + 1) - IL_Curve.YValues.Value(Counter + 2)) / (IL_Curve.XValues.Value(Counter + 1) - IL_Curve.XValues.Value(Counter + 2))
                DeltaSlope = Slope2 - Slope1
                If DeltaSlope > MaxDeltaSlope Then
                    MaxDeltaSlope = DeltaSlope
                    If Counter > 3 Then
                        Ith = IV_Curve.XValues.Value(Counter + 1)
                        Vth = IV_Curve.YValues.Value(Counter + 1)
                        ThresholdCounter = Counter
                    End If
                End If
                Counter += 1
            Loop
            Ith_Meas_TB.Text = Ith
            Ith_Meas_TB.Refresh()

            Rs = (Vth - VTenPercent) / (Ith - ITenPercent)
            SeriesRes_Raw_TB.Text = Rs
            SeriesRes_Raw_TB.Refresh()
            Vth_TB.Text = Vth
            Vth_TB.Refresh()
            'IphMax_TB.Text = IL_Curve.MaxYValue
            'IphMax_TB.Refresh()

            ' Dim polyfit As New Steema.TeeChart.Styles.Line(TChart1.Chart)
            Dim polyfitFunc As New Steema.TeeChart.Functions.TrendFunction

            Dim polyfit3 As New Steema.TeeChart.Styles.Line(TChart1.Chart)
            Dim polyfitFunc3 As New Steema.TeeChart.Functions.TrendFunction

            Dim IL_Curve_Fit As New Steema.TeeChart.Styles.FastLine
            polyfit3.Title = "10% Fit"

            ' Trim IL Curve data for linear trend fit
            Do Until ThresholdCounter > TenPercentCounter
                If IV_Curve.YValues(ThresholdCounter) = 0 Then Exit Do
                IL_Curve_Fit.Add(IL_Curve.XValues(ThresholdCounter), IL_Curve.YValues(ThresholdCounter))
                ThresholdCounter += 1
            Loop

            ' Add trimmed data to series and add to chart
            polyfit3.Function = polyfitFunc3
            polyfit3.DataSource = IL_Curve_Fit ' Graph fit using measured data
            Dim RSquared As Double = polyfitFunc3.RSquared
            RSquared_TB.Text = RSquared
            RSquared_TB.Refresh()

            '****************
            Dim Y2 As Double = IL_Curve_Fit.YValues.Maximum
            Dim Y1 As Double = IL_Curve_Fit.YValues.Minimum
            Dim X2 As Double = IL_Curve_Fit.XValues.Maximum
            Dim X1 As Double = IL_Curve_Fit.XValues.Minimum
            ' y=mx+c
            Dim SlopeLI As Double = (Y1 - Y2) / (X1 - X2)
            Slope_TB.Text = SlopeLI
            Slope_TB.Refresh()
            Dim c As Double = Y2 - SlopeLI * X2
            ' Get intercept y=mx+c; c=mx-y
            Dim Intercept As Double = 0
            Intercept = -c / SlopeLI
            Ith_TB.Text = Intercept
            Ith_TB.Refresh()
            Dim Test1 As Double = Math.Abs(Ith - Intercept)
            If Test1 < (Ith * 0.1) And Convert.ToDouble(RSquared_TB.Text) > 0.9 Then
                TestResult.Text = "Test Data is good"
            Else
                TestResult.Text = "Test Data is bad"
            End If

            ' Calculate Rs at 100mA on Gain IV - take 100mA as X2, Y2 and 90mA as Y1, X1
            Dim mACounter As Integer = 0
            Dim RsCurrent As Double = 0.1
            Dim Current As Double = 0
            Dim Voltage1 As Double = 0
            Dim Current1 As Double = 0
            Dim Current2 As Double = 0
            Dim Voltage2 As Double = 0
            Do Until Current1 > RsCurrent ' Acquire Rs current location from data
                Current1 = Line2.XValues.Value(mACounter)
                mACounter += 1
            Loop
            'Current1 = Line2.XValues(mACounter) ' Set I at RsCurrent values
            Voltage1 = Line2.YValues(mACounter) ' Set V at RsCurrent values
            mACounter = 0
            Current = 0
            Do Until Current2 > RsCurrent - RsCurrent / 10 ' Acquire Rs current location from data
                Current2 = Line2.XValues.Value(mACounter)
                mACounter += 1
            Loop
            'Current2 = Line2.XValues.Value(mACounter) ' Set I at RsCurrent values
            Voltage2 = Line2.YValues.Value(mACounter) ' Set V at RsCurrent values
            Rs = ((Voltage1 - Voltage2) / (Current1 - Current2)) ' IV Rs @100mA (Derivative of line 90-100%)
            GainRsIV_TB.Text = Rs

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles LIVFile_Button.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        DataFile_TB.Text = OpenFileDialog1.FileName.ToString()
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Gain_Curve As New Steema.TeeChart.Styles.Line
        Dim LaPha_Curve As New Steema.TeeChart.Styles.Line
        Dim Mirr1_Curve As New Steema.TeeChart.Styles.Line
        Dim Mirr2_Curve As New Steema.TeeChart.Styles.Line
        Dim Phase1_Curve As New Steema.TeeChart.Styles.Line

        Dim Gain As New Steema.TeeChart.Data.TextSource(GainIV_TB.Text)
        Gain.HeaderLines = 1
        Gain.DecimalSeparator = "."
        Gain.Separator = ","
        Gain.Fields.Add(0, "X") ' Current
        Gain.Fields.Add(1, "Y") ' Voltage
        Gain_Curve.DataSource = Gain
        ' Assign Text File to Series1
        Line3.DataSource = Gain_Curve
        Line3.XValues.DataMember = "X" ' Current
        Line3.YValues.DataMember = "Y" ' Voltage

        Dim LaPha As New Steema.TeeChart.Data.TextSource(LaPhaIV_TB.Text)
        LaPha.HeaderLines = 0
        LaPha.DecimalSeparator = "."
        LaPha.Separator = ","
        LaPha.Fields.Add(0, "X")
        LaPha.Fields.Add(1, "Y")
        LaPha_Curve.DataSource = LaPha

        ' Assign Text File to Series2
        Line4.DataSource = LaPha_Curve
        Line4.XValues.DataMember = "X"
        Line4.YValues.DataMember = "Y"

        Dim Mirr1 As New Steema.TeeChart.Data.TextSource(Mirr1IV_TB.Text)
        Mirr1.HeaderLines = 0
        Mirr1.DecimalSeparator = "."
        Mirr1.Separator = ","
        Mirr1.Fields.Add(0, "X")
        Mirr1.Fields.Add(1, "Y")
        Mirr1_Curve.DataSource = Mirr1

        ' Assign Text File to Series
        Line5.DataSource = Mirr1_Curve
        Line5.XValues.DataMember = "X" ' Current
        Line5.YValues.DataMember = "Y" ' Voltage

        Dim Mirr2 As New Steema.TeeChart.Data.TextSource(Mirr2IV_TB.Text)
        Mirr2.HeaderLines = 0
        Mirr2.DecimalSeparator = "."
        Mirr2.Separator = ","
        Mirr2.Fields.Add(0, "X")
        Mirr2.Fields.Add(1, "Y")
        Mirr2_Curve.DataSource = Mirr2

        ' Assign Text File to Series
        Line6.DataSource = Mirr2_Curve
        Line6.XValues.DataMember = "X"
        Line6.YValues.DataMember = "Y"

        Dim Phase1 As New Steema.TeeChart.Data.TextSource(Phase1IV_TB.Text)
        Phase1.HeaderLines = 0
        Phase1.DecimalSeparator = "."
        Phase1.Separator = ","
        Phase1.Fields.Add(0, "X")
        Phase1.Fields.Add(1, "Y")
        Phase1_Curve.DataSource = Phase1

        ' Assign Text File to Series
        Line7.DataSource = Phase1_Curve
        Line7.XValues.DataMember = "X"
        Line7.YValues.DataMember = "Y"

        TChart2.Refresh() ' Redraw chart with data
        TChart2.Draw()

        ' Calculate Rs at 100mA on Gain IV - take 100mA as X2, Y2 and 90mA as Y1, X1
        Dim mACounter As Integer = 0
        Dim RsCurrent As Double = 0.1
        Dim Current1 As Double = 0
        Dim Voltage1 As Double = 0
        Dim Current2 As Double = 0
        Dim Voltage2 As Double = 0
        Do Until Current1 >= RsCurrent ' Acquire Rs current location from data
            Current1 = Line3.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current1 = Line3.XValues(mACounter) ' Set I at RsCurrent values
        Voltage1 = Line3.YValues(mACounter) ' Set V at RsCurrent values
        mACounter = 0
        Do Until Current2 > RsCurrent - RsCurrent / 10 ' Acquire Rs current location from data
            Current2 = Line3.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current2 = Line3.XValues(mACounter) ' Set I at RsCurrent values
        Voltage2 = Line3.YValues(mACounter) ' Set V at RsCurrent values

        Dim Rs As Double = (Voltage2 - Voltage1) / (Current2 - Current1)
        GainRs_TB.Text = Rs
        GainRs_TB.Refresh()

        ' Calculate Rs at 5mA on LaPha IV - take 5mA as X2, Y2 and 10% as Y1, X1
        mACounter = 0
        RsCurrent = 0.005
        Current1 = 0
        Voltage1 = 0
        Current2 = 0
        Voltage2 = 0
        Do Until Current1 > RsCurrent ' Acquire Rs current location from data
            Current1 = Line4.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current1 = Line4.XValues(mACounter) ' Set I at RsCurrent values
        Voltage1 = Line4.YValues(mACounter) ' Set V at RsCurrent values
        mACounter = 0
        Do Until Current2 > RsCurrent - RsCurrent / 10 ' Acquire Rs current location from data
            Current2 = Line4.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current2 = Line4.XValues(mACounter) ' Set I at RsCurrent values
        Voltage2 = Line4.YValues(mACounter) ' Set V at RsCurrent values

        Rs = (Voltage2 - Voltage1) / (Current2 - Current1)
        LaPhaRs_TB.Text = Rs
        LaPhaRs_TB.Refresh()

        ' Calculate Rs at 40mA on Mirr1 IV - take 40mA as X2, Y2 and 10% as Y1, X1
        mACounter = 0
        RsCurrent = 0.04
        Current1 = 0
        Voltage1 = 0
        Current2 = 0
        Voltage2 = 0
        Do Until Current1 > RsCurrent ' Acquire Rs current location from data
            Current1 = Line5.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current1 = Line5.XValues(mACounter) ' Set I at RsCurrent values
        Voltage1 = Line5.YValues(mACounter) ' Set V at RsCurrent values
        mACounter = 0
        Do Until Current2 > RsCurrent - RsCurrent / 10 ' Acquire Rs current location from data
            Current2 = Line5.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current2 = Line5.XValues(mACounter) ' Set I at RsCurrent values
        Voltage2 = Line5.YValues(mACounter) ' Set V at RsCurrent values

        Rs = (Voltage2 - Voltage1) / (Current2 - Current1)
        Mirr1Rs_TB.Text = Rs
        Mirr1Rs_TB.Refresh()

        ' Calculate Rs at 40mA on Mirr2 IV - take 40mA as X2, Y2 and 10% as Y1, X1
        mACounter = 0
        RsCurrent = 0.04
        Current1 = 0
        Voltage1 = 0
        Current2 = 0
        Voltage2 = 0
        Do Until Current1 > RsCurrent ' Acquire Rs current location from data
            Current1 = Line6.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current1 = Line6.XValues(mACounter) ' Set I at RsCurrent values
        Voltage1 = Line6.YValues(mACounter) ' Set V at RsCurrent values
        mACounter = 0
        Do Until Current2 > RsCurrent - RsCurrent / 10 ' Acquire Rs current location from data
            Current2 = Line6.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current2 = Line6.XValues(mACounter) ' Set I at RsCurrent values
        Voltage2 = Line6.YValues(mACounter) ' Set V at RsCurrent values

        Rs = (Voltage2 - Voltage1) / (Current2 - Current1)
        Mirr2Rs_TB.Text = Rs
        Mirr2Rs_TB.Refresh()

        ' Calculate Rs at 10mA on PowMon IV - take 10mA as X2, Y2 and 10% as Y1, X1
        mACounter = 0
        RsCurrent = 0.01
        Current1 = 0
        Voltage1 = 0
        Current2 = 0
        Voltage2 = 0
        Do Until Current1 > RsCurrent ' Acquire Rs current location from data
            Current1 = Line7.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current1 = Line7.XValues(mACounter) ' Set I at RsCurrent values
        Voltage1 = Line7.YValues(mACounter) ' Set V at RsCurrent values
        mACounter = 0
        Do Until Current2 > RsCurrent - RsCurrent / 10 ' Acquire Rs current location from data
            Current2 = Line7.XValues.Value(mACounter)
            mACounter += 1
        Loop
        Current2 = Line7.XValues(mACounter) ' Set I at RsCurrent values
        Voltage2 = Line7.YValues(mACounter) ' Set V at RsCurrent values

        Rs = (Voltage2 - Voltage1) / (Current2 - Current1)
        Phase1Rs_TB.Text = Rs
        Phase1Rs_TB.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog2.Title = "Please Select a File"
        OpenFileDialog2.InitialDirectory = "PIC_Folder_TB.Text"
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        OpenFileDialog3.Title = "Please Select a File"
        OpenFileDialog3.InitialDirectory = "PIC_Folder_TB.Text"
        OpenFileDialog3.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OpenFileDialog4.Title = "Please Select a File"
        OpenFileDialog4.InitialDirectory = "PIC_Folder_TB.Text"
        OpenFileDialog4.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OpenFileDialog5.Title = "Please Select a File"
        OpenFileDialog5.InitialDirectory = "PIC_Folder_TB.Text"
        OpenFileDialog5.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        OpenFileDialog6.Title = "Please Select a File"
        OpenFileDialog6.InitialDirectory = "PIC_Folder_TB.Text"
        OpenFileDialog6.ShowDialog()
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog2.OpenFile()
        GainIV_TB.Text = OpenFileDialog2.FileName.ToString()
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
        End If
    End Sub

    Private Sub OpenFileDialog3_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog3.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog3.OpenFile()
        LaPhaIV_TB.Text = OpenFileDialog3.FileName.ToString()
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
        End If
    End Sub

    Private Sub OpenFileDialog4_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog4.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog4.OpenFile()
        Mirr1IV_TB.Text = OpenFileDialog4.FileName.ToString()
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
        End If
    End Sub

    Private Sub OpenFileDialog5_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog5.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog5.OpenFile()
        Mirr2IV_TB.Text = OpenFileDialog5.FileName.ToString()
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
        End If
    End Sub

    Private Sub OpenFileDialog6_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog6.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog6.OpenFile()
        Phase1IV_TB.Text = OpenFileDialog6.FileName.ToString()
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Create Excel file to populate the current data sets with up to date analysis data
        Dim excel As Application = New Application
        ' Open Excel spreadsheet.
        'Start a new workbook in Excel.
        'Create a new workbook in Excel.
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add

        'Add data to cells of the first worksheet in the new workbook.
        oSheet = oBook.Worksheets(1)
        oSheet.Range("A1").Value = "Gain Rs@100mA"
        oSheet.Range("B1").Value = "LaPha Rs@5mA"
        oSheet.Range("C1").Value = "Mirr1 Rs@40mA"
        oSheet.Range("D1").Value = "Mirr2 Rs@40mA"
        oSheet.Range("E1").Value = "Phase1 Rs@10mA"
        oSheet.Range("F1").Value = "LIV Ith"
        oSheet.Range("A1:F1").Font.Bold = True
        oSheet.Range("A2").Value = GainRs_TB.Text
        oSheet.Range("B2").Value = LaPhaRs_TB.Text
        oSheet.Range("C2").Value = Mirr1Rs_TB.Text
        oSheet.Range("D2").Value = Mirr2Rs_TB.Text
        oSheet.Range("E2").Value = Phase1Rs_TB.Text

        'Save the Workbook and quit Excel.
        oBook.SaveAs("c:\" & "Book1.xlsx")
        oSheet = Nothing
        oBook = Nothing
        oExcel.Quit()
        oExcel = Nothing
        GC.Collect()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim strm As System.IO.Stream
        FolderBrowserDialog1.SelectedPath = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\"
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            PIC_Folder_TB.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest
        FolderBrowserDialog1.SelectedPath = "G:\10G TOSA Product\PIC Development\PIC_Measurement_Data\" 'Dim strm As System.IO.Stream
    End Sub
End Class
