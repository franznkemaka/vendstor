using System;
using System.Drawing;
using System.Windows.Forms;
using Quobject.SocketIoClientDotNet.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

//Vendstor
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Hardwares;

namespace Vendstor.Forms
{
    public partial class Scanner : Form
    {
        #region Variables

        public Backend.Objects.ScanToken ScanToken { get; set; }
        public string Currency { get; set; }

        Enums.ActionDialog ActionDialog { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public Scanner()
        {
            InitializeComponent();

            InitializeUI();
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        private void OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Control - Event Handler

        public Enums.ActionDialog ShowWithResult()
        {
            this.ShowDialog();
            return ActionDialog;
        }

        public FormResponse ShowWithResponse()
        {
            this.ShowDialog();
            return new FormResponse
            {
                ActionDialog = ActionDialog,
                Data = ScanToken,
            };
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            Listen();

            Translate();
        }

        void Listen()
        {
            // Connect to WebSocket
            var socket = IO.Socket(ServerConstants.ScannerWebSocketUrl);
            socket.On(Socket.EVENT_CONNECT, () => {

            });
            socket.On(SocketConstants.EventScan, (token) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    OnScan(token);
                });
            });
        }

        void OnScan(object token)
        {
            new Sound
            {
                SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.Beep)
            }.Play();

            JObject obj = JObject.Parse(JsonConvert.SerializeObject(token));
            var code = obj["data"];
            var type = obj["type"];
            ScanToken = new Backend.Objects.ScanToken { Token = code, Type = Util.Func.GetTokenType(type) };
            ActionDialog = Enums.ActionDialog.Scanned;
            this.Close();
        }
        
        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnScanning, SoftColor);
        }

        #endregion

        #region Translate 

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_ScannedToken);
                Translation.TranslateControl(btnScanning);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}
