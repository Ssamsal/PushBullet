using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Runtime.CompilerServices;

namespace PushBullet_Client
{
    public delegate void analogDelagate(ushort x);
    public class analogEventArgs : EventArgs
    {
        public ushort value { get; set; }
        public analogEventArgs()
        {
        }
        public analogEventArgs(ushort v)
        {
            value = v;
        }
    }
    public delegate void serialDelagate(SimplSharpString x);
    public class serialEventArgs : EventArgs
    {
        public string value { get; set; }
        public serialEventArgs()
        {
        }
        public serialEventArgs(string v)
        {
            value = v;
        }
    }
  
}