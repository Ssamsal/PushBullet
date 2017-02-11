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
    public class getnameobject
    {
        
        private string _name;
        private string _email;
        private string _ident;
        private string _image_url;

        //[JsonProperty(PropertyName = "name")]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value)
                    return;
                _name = value;
            }
        }



        //[JsonProperty(PropertyName = "email")]
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email == value)
                    return;
                _email = value;
            }
        }
        
        [JsonProperty(PropertyName = "iden")]
        public string ident
        {
            get
            {
                return _ident;
            }
            set
            {
                if (_ident == value)
                    return;
                _ident = value;
            }
        }
        
        //[JsonProperty(PropertyName = "image_url")]
        public string image_url
        {
            get
            {
                return _image_url;
            }
            set
            {
                if (_image_url == value)
                    return;
                _image_url = value;
            }
        }
        public getnameobject()
        {
            _name = "";
            _email = "";
            _ident = "";
            _image_url = "";
        }
    }
}