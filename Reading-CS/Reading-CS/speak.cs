using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Runtime;
using System.Diagnostics;

namespace Reading_CS
{
    class speak
    {
        static SpeechSynthesizer synth = new SpeechSynthesizer();
        public static void Say(string text)
        {
            synth.SpeakAsync(text);
        }
        public static void _go(string url)
        {
            Process.Start(url);
        }
    }
}
