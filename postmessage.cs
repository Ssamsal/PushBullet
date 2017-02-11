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
    public class postmessage
    {
        private string _body;
        private string _title;
        private string _type;
        
        //[JsonProperty(PropertyName = "body")]
        public string body
        {
            get
            {
                return _body;
            }
            set
            {
                if (_body == value)
                    return;
                _body = value;
            }
        }
        //[JsonProperty(PropertyName = "title")]
        public string title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title == value)
                    return;
                _title = value;
            }
        }
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
         public postmessage()
        {
            _body = "";
            _title = "";
             _type = "";

        }
    }
}