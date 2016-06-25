Imports Cairo
Imports Gtk

Namespace App

    ''' <summary> A program. </summary>
    Public Class Program

        ''' <summary> Main entry-point for this application. </summary>
        Public Shared Sub Main()
            Application.Init()
            ApplyTheme()

            ' Create the Form
            Dim win As TestForm1 = TestForm1.Create()
            win.Show()
            Application.Run()
        End Sub

        Public Shared Sub ApplyTheme()
            ' Based on this Link http://awesome.naquadah.org/wiki/Better_Font_Rendering

            ' Get the Global Settings
            Dim setts = Gtk.Settings.Default
            ' This enables clear text on Win32, makes the text look a lot less crappy
            setts.XftRgba = "rgb"
            ' This enlarges the size of the controls based on the dpi
            setts.XftDpi = 96
            ' By Default Anti-aliasing is enabled, if you want to disable it for any reason set this value to 0
            'setts.XftAntialias = 0
            ' Enable text hinting
            setts.XftHinting = 1
            'setts.XftHintstyle = "hintslight"
            setts.XftHintstyle = "hintfull"

            ' Load the Theme
            Dim css_provider As New Gtk.CssProvider
            'css_provider.LoadFromPath("themes/DeLorean-3.14/gtk-3.0/gtk.css")
            css_provider.LoadFromPath("themes/DeLorean-Dark-3.14/gtk-3.0/gtk.css")
            Gtk.StyleContext.AddProviderForScreen(Gdk.Screen.Default, css_provider, 800)

        End Sub

    End Class

End Namespace
