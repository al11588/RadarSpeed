Public Class Form1

    Private Sub lblHighwayRadarCheckpoint_Click(sender As System.Object, e As System.EventArgs) Handles lblHighwayRadarCheckpoint.Click

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mnuClear.Click
        Me.lstRadarSpeed.Items.Clear()
        Me.lblAveragespeed.Visible = False
        Me.btnEnterSpeed.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnterSpeed_Click(sender As System.Object, e As System.EventArgs) Handles btnEnterSpeed.Click
        Dim strVehicleSpeed As String
        Dim decVehicleSpeed As Decimal
        Dim decAverageSpeed As Decimal
        Dim decTotalOfAllSpeeds As Decimal = 0D

        Dim strInputBoxMessage As String = "Enter the speed for vehicle #"
        Dim strInputBoxHeading As String = "Radar Speed"
        Dim strNormalBoxMessage As String = " Enter the speed for the vehicle #"
        Dim strNonNumericErrorMessage As String = "Enter = the speed for the vehicle #"
        Dim strNegativeNumberErrorMessage As String = "Error - Enter a positive number for vehicle #"

        Dim strCancleButtonClicked As String = " "
        Dim intMaximumNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        strVehicleSpeed = InputBox(strInputBoxMessage & intNumberOfEntries, strInputBoxHeading, "")

        Do Until intNumberOfEntries > intMaximumNumberOfEntries Or strVehicleSpeed = strCancleButtonClicked
            If IsNumeric(strVehicleSpeed) Then

            End If
            decVehicleSpeed = Convert.ToDecimal(strVehicleSpeed)
            If decVehicleSpeed > 0 Then
                Me.lstRadarSpeed.Items.Add(decVehicleSpeed)
                decTotalOfAllSpeeds += decVehicleSpeed
                intNumberOfEntries += 1
                strInputBoxMessage = strNormalBoxMessage
            Else
                strInputBoxMessage = strNegativeNumberErrorMessage
            End If
            If intNumberOfEntries <= intMaximumNumberOfEntries Then
                strVehicleSpeed = InputBox(strInputBoxMessage & intNumberOfEntries, strInputBoxHeading, " ")
            End If
        Loop
        Me.lblAveragespeed.Visible = True

        If intNumberOfEntries > 1 Then
            decAverageSpeed = decTotalOfAllSpeeds / (intNumberOfEntries - 1)
            Me.lblAveragespeed.Text = "Average speed at checkpoints is" & decAverageSpeed.ToString("F1") & "mph"
        Else
            Me.lblAveragespeed.Text = "No speed entered"
        End If
        Me.btnEnterSpeed.Enabled = False

    End Sub

    Private Sub lstRadarSpeed_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstRadarSpeed.SelectedIndexChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub lblPostedSpeedLimit_Click(sender As System.Object, e As System.EventArgs) Handles lblPostedSpeedLimit.Click

    End Sub

    Private Sub lblAveragespeed_Click(sender As System.Object, e As System.EventArgs) Handles lblAveragespeed.Click

    End Sub
End Class
