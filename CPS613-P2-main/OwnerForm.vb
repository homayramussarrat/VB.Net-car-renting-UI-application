Public Class OwnerForm

    Dim TextDate As String
    Dim TextTime As String
    Dim TextTime1 As String
    Dim TextDistance As String

    Private Sub OwnerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Feedback.Visible = False
        Notification2.Visible = False
        TripSum.Visible = False
        Notification1.Visible = False

    End Sub
    Private Sub MakeCarAvailable1_Click(sender As Object, e As EventArgs) Handles MakeCarAvailable1.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Feedback.Visible = False
        Notification2.Visible = False
        TripSum.Visible = False
        Notification1.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub MakeCarAvailable2_Click(sender As Object, e As EventArgs) Handles MakeCarAvailable2.Click
        TextDate = TextBoxDate.Text
        TextTime = TextBoxTime.Text
        TextTime1 = TextBoxTime1.Text
        TextDistance = TextBoxDistance.Text
        Panel4.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel1.Visible = False
        Feedback.Visible = False
        Notification2.Visible = False
        TripSum.Visible = False
        Notification1.Visible = False
        Label5.Text = "Date: " + TextDate & vbNewLine & "Time: " + TextTime + "-" + TextTime1 & vbNewLine & "Distance: " + TextDistance
        RiderForm.Label18.Text = TextTime
        RiderForm.Label19.Text = TextTime1
    End Sub

    Private Sub BackToHomePage_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Feedback.Visible = True
        Notification2.Visible = False
        Notification1.Visible = False
        TripSum.Visible = False
    End Sub

    Private Sub temp_label_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub pop_up_acc_Click(sender As Object, e As EventArgs) Handles pop_up_acc.Click
        TripSum.Visible = True
        Notification1.Visible = False
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Feedback.Visible = False
        Notification2.Visible = False
        RiderForm.Loading.Hide()
        RiderForm.RideDetails.Show()
    End Sub

    'Private Sub temp_Scroll(sender As Object, e As ScrollEventArgs) Handles temp.Scroll
    '    If temp.Value >= 44 And temp.Value <= 75 Then
    '        temp_color.BackColor = Color.PaleVioletRed
    '    ElseIf temp.Value >= 75 Then
    '        temp_color.BackColor = Color.Red
    '    ElseIf temp.Value <= 43 And temp.Value >= 25 Then
    '        temp_color.BackColor = Color.LightBlue
    '    ElseIf temp.Value <= 25 Then
    '        temp_color.BackColor = Color.Blue
    '    End If
    'End Sub


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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        RiderForm.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel4.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Feedback_Paint(sender As Object, e As PaintEventArgs) Handles Feedback.Paint

    End Sub
End Class