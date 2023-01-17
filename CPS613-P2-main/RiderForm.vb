Imports System.Security.Authentication.ExtendedProtection
Imports System.Windows

Public Class RiderForm
    Dim Locate1 As String
    Dim Destination1 As String

    Private Sub RiderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RiderMenu.Show()
        RiderSched.Hide()
        SelectCar.Hide()
        SelectedCar1.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub toSchedule_Click(sender As Object, e As EventArgs) Handles toSchedule.Click
        Locate1 = LocationText.Text
        Destination1 = DestinationText.Text
        RiderSched.Show()
        RiderMenu.Hide()
        SelectCar.Hide()
        SelectedCar1.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
        Label38.Text = Locate1
        Label39.Text = Destination1
    End Sub

    Private Sub toSelectCar_Click(sender As Object, e As EventArgs) Handles toSelectCar.Click
        SelectCar.Show()
        RiderSched.Hide()
        RiderMenu.Hide()
        SelectedCar1.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
        Label36.Text = "From: " + LocationText.Text
        Label37.Text = "To: " + DestinationText.Text
        OwnerForm.Label36.Text = "From: " + LocationText.Text
        OwnerForm.Label37.Text = "To: " + DestinationText.Text
    End Sub

    Private Sub toSelectedCar_Click(sender As Object, e As EventArgs) Handles toSelectedCar1.Click
        SelectedCar1.Show()
        SelectedCar2.Hide()
        SelectedCar3.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub toRideDetails_Click(sender As Object, e As EventArgs) Handles toRideDetails.Click
        ApproveRide.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Show()
        OwnerForm.Notification1.Visible = True
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub backRideDetails_Click(sender As Object, e As EventArgs) Handles backRideDetails.Click
        ApproveRide.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        RideDetails.Show()
        ClimateControl.Hide()
        GroupBox1.Hide()
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
        Label38.Text = Locate1
        Label39.Text = Destination1
    End Sub

    Private Sub toClimate_Click(sender As Object, e As EventArgs) Handles toClimate.Click
        ApproveRide.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        RideDetails.Hide()
        ClimateControl.Show()
        GroupBox1.Hide()
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub toRideComp_Click(sender As Object, e As EventArgs) Handles toRideComp.Click
        ApproveRide.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Show()
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hour.SelectedIndexChanged

    End Sub

    Private Sub SelectCar_Paint(sender As Object, e As PaintEventArgs) Handles SelectCar.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked Then
            OwnerForm.Label11.Text = RichTextBox1.Text + Constants.vbCrLf + Constants.vbCrLf + "Rating: 1/5"
        End If
        If RadioButton2.Checked Then
            OwnerForm.Label11.Text = RichTextBox1.Text + Constants.vbCrLf + Constants.vbCrLf + "Rating 4/5"
        End If
        If RadioButton3.Checked Then
            OwnerForm.Label11.Text = RichTextBox1.Text + Constants.vbCrLf + Constants.vbCrLf + "Rating 2/5"
        End If
        If RadioButton4.Checked Then
            OwnerForm.Label11.Text = RichTextBox1.Text + Constants.vbCrLf + Constants.vbCrLf + "Rating 5/5"
        End If
        If RadioButton5.Checked Then
            OwnerForm.Label11.Text = RichTextBox1.Text + Constants.vbCrLf + Constants.vbCrLf + "Rating 3/5"
        End If

        OwnerForm.Notification2.Visible = True
        OwnerForm.Label11.Text = RichTextBox1.Text
        Me.Hide()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub SelectedCar_Paint(sender As Object, e As PaintEventArgs) Handles SelectedCar1.Paint

    End Sub

    Private Sub temp_Scroll(sender As Object, e As ScrollEventArgs) Handles temp.Scroll
        If temp.Value >= 44 And temp.Value <= 75 Then
            temp_color.BackColor = Color.PaleVioletRed
        ElseIf temp.Value >= 75 Then
            temp_color.BackColor = Color.Red
        ElseIf temp.Value <= 43 And temp.Value >= 25 Then
            temp_color.BackColor = Color.LightBlue
        ElseIf temp.Value <= 25 Then
            temp_color.BackColor = Color.Blue
        End If
    End Sub

    Private Sub fan_speed_plus_Click(sender As Object, e As EventArgs) Handles fan_speed_plus.Click
        If fan_speed.Value = 100 Then
            fan_speed.Value = 100
        Else
            fan_speed.Value = fan_speed.Value + 25
        End If
    End Sub

    Private Sub fan_speed_minus_Click(sender As Object, e As EventArgs) Handles fan_speed_minus.Click
        If fan_speed.Value = 0 Then
            fan_speed.Value = 0
        Else
            fan_speed.Value = fan_speed.Value - 25
        End If
    End Sub

    Private Sub toSelectedCar2_Click(sender As Object, e As EventArgs) Handles toSelectedCar2.Click
        SelectedCar2.Show()
        SelectedCar1.Hide()
        SelectedCar3.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub toSelectedCar3_Click(sender As Object, e As EventArgs) Handles toSelectedCar3.Click
        SelectedCar3.Show()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back1.Click, Back2.Click, Back3.Click
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        SelectCar.Show()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles toReport.Click
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Show()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub fan_speed_Click(sender As Object, e As EventArgs) Handles fan_speed.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If window_control.Value = 100 Then
            window_control.Value = 100
        Else
            window_control.Value = window_control.Value + 25
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If window_control.Value = 0 Then
            window_control.Value = 0
        Else
            window_control.Value = window_control.Value - 25
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.BackColor = Color.DarkGray
        Button10.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button10.BackColor = Color.DarkGray
        Button9.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        OwnerForm.Label13.Text = RichTextBox2.Text
        OwnerForm.Panel4.Visible = True
        Report.Hide()
        RideDetails.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Hide()
        ModTrip.Show()
        MediaControl.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Show()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Hide()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        SelectedCar3.Hide()
        SelectedCar2.Hide()
        SelectedCar1.Hide()
        SelectCar.Hide()
        RiderSched.Hide()
        RiderMenu.Hide()
        ApproveRide.Hide()
        RideDetails.Show()
        ClimateControl.Hide()
        GroupBox1.Hide()
        Loading.Hide()
        Report.Hide()
        ModTrip.Hide()
        MediaControl.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Button16.BackColor = Color.DarkGray
        Button15.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Button15.BackColor = Color.DarkGray
        Button16.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Button23.BackColor = Color.DarkGray
        Button21.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Button21.BackColor = Color.DarkGray
        Button23.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Button18.BackColor = Color.DarkGray
        Button17.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button17.BackColor = Color.DarkGray
        Button18.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Button25.BackColor = Color.DarkGray
        Button24.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button24.BackColor = Color.DarkGray
        Button25.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If SpeakerVol.Value = 100 Then
            SpeakerVol.Value = 100
        Else
            SpeakerVol.Value = SpeakerVol.Value + 25
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If SpeakerVol.Value = 0 Then
            SpeakerVol.Value = 0
        Else
            SpeakerVol.Value = SpeakerVol.Value - 25
        End If
    End Sub

    Private Sub MediaControl_Paint(sender As Object, e As PaintEventArgs) Handles MediaControl.Paint

    End Sub

    Private Sub RideDetails_Paint(sender As Object, e As PaintEventArgs) Handles RideDetails.Paint

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ride_end_Click(sender As Object, e As EventArgs) Handles ride_end.Click
        Report.Hide()
        ' RideDetails.Show()
        'RideDetails.Show()
        GroupBox1.Show()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class