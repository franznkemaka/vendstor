using System;
using System.Windows.Forms;

namespace Uninstaller
{
    public partial class Main : Form
    {
        #region Variables

        public int Counter = 5;
        public Manager Manager { get; set; }

        #endregion

        #region Constructors

        public Main()
        {
            InitializeComponent();
            Util.SetIcon(this);
        }

        #endregion

        #region Event Handlers

        private void OnLoad(object sender, EventArgs e)
        {
            this.timSplash.Start();
        }

        private void OnComplete(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnCatchException(object sender, EventArgs e)
        {
            Exception exception = (Exception)sender;
            MessageBox.Show(exception.Message, " An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        void Initialize()
        {
            Manager = new Manager
            {
                OnCatchException = this.OnCatchException,
                OnComplete = this.OnComplete,
            };

            // Check, Uninstall ...
            Manager.Initialize();
        }

        private void TimSplash_Tick(object sender, EventArgs e)
        {
            Counter--;
            if (Counter == 0)
            {
                Initialize();
                timSplash.Stop();
            }
        }

        #endregion
    }
}

