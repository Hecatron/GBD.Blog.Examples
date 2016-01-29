Imports Gtk

Namespace App

    ''' <summary> A program. </summary>
    Public Class Program

        ''' <summary> Main entry-point for this application. </summary>
        Public Shared Sub Main()

            Application.Init()

            ' Load the Theme
            Dim css_provider As New Gtk.CssProvider
            'css_provider.LoadFromPath("themes/DeLorean-3.14/gtk-3.0/gtk.css")
            css_provider.LoadFromPath("themes/DeLorean-Dark-3.14/gtk-3.0/gtk.css")
            Gtk.StyleContext.AddProviderForScreen(Gdk.Screen.Default, css_provider, 800)

            ' Create the Form
            Dim win As TestForm1 = TestForm1.Create()
            win.Show()

            Application.Run()
        End Sub

        Public Shared Sub ApplyTheme()


        End Sub

    End Class

End Namespace
