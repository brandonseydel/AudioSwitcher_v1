﻿using System.Net;
using FortyOne.AudioSwitcher.Properties;

namespace FortyOne.AudioSwitcher.Helpers
{
    public static class ConnectionHelper
    {
        public static bool IsServerOnline
        {
            get
            {
                try
                {
                    var wc = new WebClient();
                    wc.DownloadData(Resources.WebServiceURL);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static AudioSwitcherService.AudioSwitcher GetAudioSwitcherProxy()
        {
            if (IsServerOnline)
                return new AudioSwitcherService.AudioSwitcher();
            return null;
        }
    }
}