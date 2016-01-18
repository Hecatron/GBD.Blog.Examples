using System;
using Gtk;

namespace GtkSharp_Test2.App
{

    public class TestForm1 : Window
    {
        #region Properties

        // Used to load in the glade file resource as a window
        private Builder _builder;

#pragma warning disable 649
        [Builder.Object]
        private Button SendButton;
        [Builder.Object]
        private Entry StdInputTxt;
#pragma warning restore 649

        #endregion

        #region Constructors / Destructors

        // Default Shared Constructor
        public static TestForm1 Create()
        {
            Builder builder = new Builder(null, "GtkSharp_Test2.App.TestForm1.glade", null);
            return new TestForm1(builder, builder.GetObject("window1").Handle);
        }

        // Protected Class Constructor
        protected TestForm1(Builder builder, IntPtr handle) : base(handle)
        {
            _builder = builder;
            builder.Autoconnect(this);
            SetupHandlers();
        }

        #endregion

        #region Handlers

        // Setup Handlers
        protected void SetupHandlers()
        {
            DeleteEvent += OnLocalDeleteEvent;
            SendButton.Clicked += OnSendClick;
        }

        // Handle Close of Form, Quit Application
        protected void OnLocalDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        // Handle Click of Button
        protected void OnSendClick(object sender, EventArgs a)
        {
            StdInputTxt.Text = "Hello World";
        }

        #endregion

    }

}
