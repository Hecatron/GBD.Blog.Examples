Imports Gtk

Namespace App

    Partial Public Class TestForm1
        Inherits Window

#Region "Properties"

        ''' <summary> Used to load in the glade file resource as a window. </summary>
        Private _builder As Builder

        ' Put a list here of all the controls you want to access on the glade form from code

        ' Note When using WithEvents, we need to link to the objects on the form within the constructor
        ' Instead of using the Builder.Object attribute, this seems to be the only way when using WithEvents and Handles

        ''' <summary> Connects to the SendButton on the Glade Window. </summary>
        Friend WithEvents SendButton As Button

        ''' <summary> Connects to the InputText Control on the Glade Window. </summary>
        Friend WithEvents StdInputTxt As Entry

        ''' <summary> Event queue for all listeners interested in Loaded events. </summary>
        Public Event Loaded As EventHandler

#End Region

#Region "Constructors / Destructors"

        ''' <summary> Default Shared Constructor. </summary>
        ''' <returns> A TestForm1. </returns>
        Public Shared Function Create() As TestForm1
            Dim builder As New Builder(Nothing, "GtkSharp_Test3.TestForm1.glade", Nothing)
            Return New TestForm1(builder, builder.GetObject("window1").Handle)
        End Function

        ''' <summary> Specialised constructor for use only by derived class. </summary>
        ''' <param name="builder"> The builder. </param>
        ''' <param name="handle">  The handle. </param>
        Protected Sub New(builder As Builder, handle As IntPtr)
            MyBase.New(handle)
            _builder = builder
            builder.Autoconnect(Me)

            ' Link the Controls here instead of using Attributes
            SendButton = builder.GetObject("SendButton")
            StdInputTxt = builder.GetObject("StdInputTxt")

            ' Form Loaded
            RaiseEvent Loaded(Me, Nothing)
        End Sub

#End Region

    End Class

End Namespace
