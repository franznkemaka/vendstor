using System;
using System.Drawing;
using System.Windows.Forms;
using Quobject.SocketIoClientDotNet.Client;
using Newtonsoft.Json;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Hardwares;
using Vendstor.Backend.Database.Queries;
using Newtonsoft.Json.Linq;

namespace Vendstor.UserControls.Auth
{
    public partial class CodeLogin : UserControl
    {
        #region Variables

        public EventHandler OnLogin;
        Color SoftColor;

        #endregion

        #region Constructors

        public CodeLogin()
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

        #endregion

        #region Control - Event Handler

        private void OnClick(object sender, EventArgs e)
        {
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            // Connect to WebSocket
            Listen();

            Translate();
        }

        void Listen()
        {
            // Connect to WebSocket
            var socket = IO.Socket(ServerConstants.ScannerWebSocketUrl);
            socket.On(Socket.EVENT_CONNECT, () =>
            {
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
            JObject obj = JObject.Parse(JsonConvert.SerializeObject(token));
            var code = (string)obj["data"];
            Login(code);
        }

        void Login(string token)
        {
            var user = new Backend.Objects.User { Token = token };
            var response = QueryController.User.TokenLogin(user);
            if (response.StatusCode == 200)
            {
                new Sound
                {
                    SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.Beep)
                }.Play();

                user = (Backend.Objects.User)response.Data;
                this.OnLogin(user, null);
            }
            else
            {
                new Sound
                {
                    SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.Error)
                }.Play();
            }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            this.BackColor = SoftColor;
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                hint_Guide.Text = Translation.Translate(hint_Guide.Text);
            }
            Util.Methods.AlignToParent(hint_Guide, this);
        }

        #endregion

        #region OnClose

        #endregion
    }
}
