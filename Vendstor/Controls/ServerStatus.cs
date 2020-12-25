using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Hardwares;

namespace Vendstor.Controls
{
    public partial class ServerStatus : UserControl
    {
        #region Variables
                
        Sound Sound = new Sound();
        public bool IsPlaying { get; set; }
        public bool IsStateOk { get; set; }
        public bool PlaySound = true;


        Stream ErrorAlarm
        {
            get { return Sound.GetSoundEffect(Sound.SoundEffects.ErrorAlarm); }
        }


        #endregion

        #region Constructors

        public ServerStatus()
        {
            InitializeComponent();
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Event Handler

        private void OnStateClick(object sender, EventArgs e)
        {
            PlaySound = false;
        }

        private void TimSignal_Tick(object sender, EventArgs e)
        {
            Loop();
        }

        #endregion

        #region Methods 

        void Initialize()
        {
            timSignal.Stop();
        }

        public void Start()
        {
            timSignal.Start();
        }

        public void Stop()
        {
            timSignal.Stop();
            StopPlaying();
        }

        void Loop()
        {
            GetStateImage();
            Play();
        }

        void Play()
        {
            GetState();
            GetStateImage();

            if (!IsPlaying && !IsStateOk && PlaySound)
            {
                Sound.SoundToPlay = ErrorAlarm;
                Sound.PlayLooping = true;
                Sound.Play();
                IsPlaying = true;
            }
            else
                StopPlaying();
        }

        void StopPlaying()
        {
            //Stop Sound
            Sound.Stop();
            IsPlaying = false;
        }

        void GetStateImage()
        {
            imgServerStatus.Image = IsStateOk ? Properties.Resources.led_green : Properties.Resources.led_blinksred;
        }
        
        private void GetState()
        {
            if (!ServerUtil.IsServerAvailable)
                IsStateOk = false;            
            else if (!ServerUtil.IsDatabaseAvailable)
                IsStateOk = false;
            else if (!ServerUtil.IsNetworkAvailable())
                IsStateOk = false;           
            else
                IsStateOk = true;
        }

        #endregion

    }
}
