Imports Gtk

Namespace App

    ''' <summary> Example Test Form for GTKSharp and Glade. </summary>
    Public Class TestForm1
        Inherits Window

#Region "Properties"

        ''' <summary> Used to load in the glade file resource as a window. </summary>
        Private _builder As Builder

        ''' <summary> Connects to the SendButton on the Glade Window. </summary>
        <Builder.Object>
        Private SendButton As Button

        ''' <summary> Connects to the InputText Control on the Glade Window. </summary>
        <Builder.Object>
        Private StdInputTxt As Entry

#End Region

#Region "Constructors / Destructors"

        ''' <summary> Default Shared Constructor. </summary>
        ''' <returns> A TestForm1. </returns>
        Public Shared Function Create() As TestForm1
            Dim builder As New Builder(Nothing, "GtkSharp_BasicForm1_VB.TestForm1.glade", Nothing)
            Return New TestForm1(builder, builder.GetObject("window1").Handle)
        End Function

        ''' <summary> Specialised constructor for use only by derived class. </summary>
        ''' <param name="builder"> The builder. </param>
        ''' <param name="handle">  The handle. </param>
        Protected Sub New(builder As Builder, handle As IntPtr)
            MyBase.New(handle)
            _builder = builder
            builder.Autoconnect(Me)
            SetupHandlers()
        End Sub

#End Region

#Region "Handlers"

        ''' <summary> Sets up the handlers. </summary>
        Protected Sub SetupHandlers()
            AddHandler DeleteEvent, AddressOf OnLocalDeleteEvent
            AddHandler SendButton.Clicked, AddressOf OnSendClick
        End Sub

        ''' <summary> Handle Close of Form, Quit Application. </summary>
        ''' <param name="sender"> Source of the event. </param>
        ''' <param name="a">      Event information to send to registered event handlers. </param>
        Protected Sub OnLocalDeleteEvent(sender As Object, a As DeleteEventArgs)
            Application.Quit()
            a.RetVal = True
        End Sub

        ''' <summary> Handle Click of Button. </summary>
        ''' <param name="sender"> Source of the event. </param>
        ''' <param name="a">      Event information to send to registered event handlers. </param>
        Protected Sub OnSendClick(sender As Object, a As EventArgs)
            StdInputTxt.Text = "Hello World"
        End Sub

#End Region

    End Class

End Namespace
