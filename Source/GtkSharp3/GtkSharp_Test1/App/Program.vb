Imports Gtk

Namespace App

    ''' <summary> A program. </summary>
    Public Class Program

        ''' <summary> Main entry-point for this application. </summary>
        Public Shared Sub Main()
            Application.Init()
            Dim win As TestForm1 = TestForm1.Create()
            win.Show()
            Application.Run()
        End Sub

    End Class

End Namespace
