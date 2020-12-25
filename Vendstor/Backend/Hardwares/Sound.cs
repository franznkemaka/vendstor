using System;
using System.IO;
using System.Media;

namespace Vendstor.Backend.Hardwares
{
    public class Sound
    {

        internal SoundPlayer Player = new SoundPlayer();
        public Stream SoundToPlay { get; set; }
        public bool PlayLooping { get; set; }
               
        public enum SoundEffects { Error, ErrorBeep, ErrorAlarm, Beep, BeepScanner, LogOn, LogOff, Shutdown, Ding, StartUp }
        public enum Sounds { Click = 3, Beep }
       
        /// <summary>
        /// Play a sound
        /// </summary>
        public void Play()
        {
            try
            {
                //Create SoundPlayer
                Player = new SoundPlayer(SoundToPlay);

                //Play Sound
                if (PlayLooping)
                    Player.PlayLooping();
                else
                    Player.Play();
            }
            catch { }
        }

        /// <summary>
        /// Get Sound from Properties.Resources
        /// </summary>
        /// <returns> Stream Sound</returns>
        public static Stream GetSoundEffect(SoundEffects effect)
        {
            switch (effect)
            {
                case SoundEffects.Error:
                    return Properties.Resources.error;

                case SoundEffects.ErrorBeep:
                    return Properties.Resources.errorbeep_01;

                case SoundEffects.ErrorAlarm:
                    return Properties.Resources.erroralert_01;

                case SoundEffects.Beep:
                    return Properties.Resources.beep_ok;

                case SoundEffects.BeepScanner:
                    return Properties.Resources.beep_01;

                case SoundEffects.Ding:
                    return Properties.Resources.ding;

                case SoundEffects.LogOff:
                    return Properties.Resources.logoff;

                case SoundEffects.LogOn:
                    return Properties.Resources.logon;

                case SoundEffects.Shutdown:
                    return Properties.Resources.shutdown;

                case SoundEffects.StartUp:
                    return Properties.Resources.startup;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Stop Sound
        /// </summary>
        public void Stop()
        {
            try
            {
                //Close Player If Exists
                if (Player != null)
                    Player.Stop();
            }
            catch { }
        }


    }
}
