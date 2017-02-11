using System;
using System.Text;

using Crestron.SimplSharp;
using Crestron.SimplSharp.Net;
using Crestron.SimplSharp.Net.Https;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

using Crestron.SimplSharp.CrestronIO;
using Crestron.SimplSharp.CrestronXml;
using Crestron.SimplSharp.Reflection;

namespace PushBullet_Client
{
    
    public class gettypeobject
    {

        private string _type;
        private string _subtype;


        //[JsonProperty(PropertyName = "type")]
        public string type
        {
            get
            {
                return _type;
            }
            set
            {
                if (_type == value)
                    return;
                _type = value;
            }
        }
        //[JsonProperty(PropertyName = "subtype")]
        public string subtype
        {
            get
            {
                return _subtype;
            }
            set
            {
                if (_subtype == value)
                    return;
                _subtype = value;
            }
        }
        public gettypeobject()
        {
            _type = "";
            _subtype = "";

        }
    }
}