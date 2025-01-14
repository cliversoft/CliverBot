using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;

namespace Cliver.Bot
{
    public partial class Settings
    {
        public static readonly EngineSettings Engine;

        public class EngineSettings : Cliver.UserSettings
        {
            public bool RestoreBrokenSession = true;
            public int MaxBotThreadNumber = 1;
            public bool RestoreErrorItemsAsNew = false;
            public bool WriteSessionRestoringLog = true;
            public int MaxProcessorErrorNumber = 5;
            public int MaxTime2WaitForSessionStopInSecs = 90;
        }
    }
}