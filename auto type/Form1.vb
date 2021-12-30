Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SendKeys.Send(T1.Text)
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub Ambiance_Button_21_Click(sender As Object, e As EventArgs) Handles Ambiance_Button_21.Click
        Timer1.Interval = TIM.Text * 1000
        Timer1.Start()
        Ambiance_Button_21.Enabled = False
        Ambiance_Button_11.Enabled = True
    End Sub

    Private Sub Ambiance_Button_11_Click(sender As Object, e As EventArgs) Handles Ambiance_Button_11.Click
        Timer1.Stop()
        Ambiance_Button_21.Enabled = True
        Ambiance_Button_11.Enabled = False
    End Sub

    Private Sub Ambiance_Button_12_Click(sender As Object, e As EventArgs) Handles Ambiance_Button_12.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCLF-eRNc52VslhdctpHaAzg")
    End Sub
End Class
