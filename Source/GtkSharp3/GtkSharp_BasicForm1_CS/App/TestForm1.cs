using System;
using Gtk;

namespace GtkSharp_BasicForm1_CS.App
{

    /// <summary> Example Test Form for GTKSharp and Glade. </summary>
    public class TestForm1 : Window
    {
        #region Properties

        /// <summary> Used to load in the glade file resource as a window. </summary>
        private Builder _builder;

#pragma warning disable 649

        /// <summary> Connects to the SendButton on the Glade Window. </summary>
        [Builder.Object]
        private Button SendButton;

        /// <summary> Connects to the InputText Control on the Glade Window. </summary>
        [Builder.Object]
        private Entry StdInputTxt;
#pragma warning restore 649

        #endregion

        #region Constructors / Destructors
        /// <summary> Default Shared Constructor. </summary>
        /// <returns> A TestForm1. </returns>
        public static TestForm1 Create()
        {
            Builder builder = new Builder(null, "GtkSharp_BasicForm1_CS.App.TestForm1.glade", null);
            return new TestForm1(builder, builder.GetObject("window1").Handle);
        }

        /// <summary> Specialised constructor for use only by derived class. </summary>
        /// <param name="builder"> The builder. </param>
        /// <param name="handle">  The handle. </param>
        protected TestForm1(Builder builder, IntPtr handle) : base(handle)
        {
            _builder = builder;
            builder.Autoconnect(this);
            SetupHandlers();
        }

        #endregion

        #region Handlers

        /// <summary> Sets up the handlers. </summary>
        protected void SetupHandlers()
        {
            DeleteEvent += OnLocalDeleteEvent;
            SendButton.Clicked += OnSendClick;
        }

        /// <summary> Handle Close of Form, Quit Application. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="a">      Event information to send to registered event handlers. </param>
        protected void OnLocalDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        /// <summary> Handle Click of Button. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="a">      Event information to send to registered event handlers. </param>
        protected void OnSendClick(object sender, EventArgs a)
        {
            StdInputTxt.Text = "Hello World";
        }

        #endregion

    }

}
