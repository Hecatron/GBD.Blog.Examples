Imports Gtk

Namespace App

    ''' <summary> Example Test Form for GTKSharp and Glade. </summary>
    Partial Public Class TestForm1

#Region "Handlers"

        Private Sub TestForm1_Loaded(sender As Object, e As EventArgs) Handles Me.Loaded

        End Sub

        ''' <summary> Handle Close of Form, Quit Application. </summary>
        ''' <param name="o">    Source of the event. </param>
        ''' <param name="args"> Event information to send to registered event handlers. </param>
        Private Sub TestForm1_DeleteEvent(o As Object, args As DeleteEventArgs) Handles Me.DeleteEvent
            Application.Quit()
            args.RetVal = True
        End Sub

        ''' <summary> Handle Click of Button. </summary>
        ''' <param name="sender"> Source of the event. </param>
        ''' <param name="e">      Event information to send to registered event handlers. </param>
        Private Sub SendButton_Clicked(sender As Object, e As EventArgs) Handles SendButton.Clicked
            StdInputTxt.Text = "Hello World"
        End Sub

#End Region

    End Class

End Namespace
