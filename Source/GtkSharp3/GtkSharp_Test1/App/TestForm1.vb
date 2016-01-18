Imports Gtk

Namespace App

    Public Class TestForm1
        Inherits Window

#Region "Properties"

        ' Used to load in the glade file resource as a window
        Private _builder As Builder

        <Builder.Object>
        Private SendButton As Button
        <Builder.Object>
        Private StdInputTxt As Entry

#End Region

#Region "Constructors / Destructors"

        ' Default Shared Constructor
        Public Shared Function Create() As TestForm1
            Dim builder As New Builder(Nothing, "GtkSharp_Test1.TestForm1.glade", Nothing)
            Return New TestForm1(builder, builder.GetObject("window1").Handle)
        End Function

        ' Protected Class Constructor
        Protected Sub New(builder As Builder, handle As IntPtr)
            MyBase.New(handle)
            _builder = builder
            builder.Autoconnect(Me)
            SetupHandlers()
        End Sub

#End Region

#Region "Handlers"

        ' Setup Handlers
        Protected Sub SetupHandlers()
            AddHandler DeleteEvent, AddressOf OnLocalDeleteEvent
            AddHandler SendButton.Clicked, AddressOf OnSendClick
        End Sub

        ' Handle Close of Form, Quit Application
        Protected Sub OnLocalDeleteEvent(sender As Object, a As DeleteEventArgs)
            Application.Quit()
            a.RetVal = True
        End Sub

        ' Handle Click of Button
        Protected Sub OnSendClick(sender As Object, a As EventArgs)
            StdInputTxt.Text = "Hello World"
        End Sub

#End Region

    End Class

End Namespace
