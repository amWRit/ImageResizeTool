Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration

Public Class splash

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Value = ProgressBar2.Value + 5
        counter.Text = CType(ProgressBar2.Value, String)
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Timer1.Enabled = False
            Me.Hide()
            homeForm.Show()
        End If
    End Sub

End Class
