using Crestron.SimplSharp;
using Crestron.SimplSharp.Net;
using Crestron.SimplSharp.Net.Https;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using Crestron.SimplSharp.CrestronIO;
using Crestron.SimplSharp.CrestronXml;
using Crestron.SimplSharp.Reflection;

namespace PushBullet_Client
{
    public class getdevicetypeobject
    {
        private List<getdeviceobject> _devices = new List<getdeviceobject>();
        public List<getdeviceobject> devices { get; set; }

       
    }
    public class getdeviceobject
    {
        private string _nickname;
        private string _active;
        private string _push_token;
        private string _model;
        private string _diden;

        //[JsonProperty(PropertyName = "active")]
        public string active
        {
            get
            {
                return _active;
            }
            set
            {
                if (_active == value)
                    return;
                _active = value;
            }
        }



        [JsonProperty(PropertyName = "iden")]
        public string diden
        {
            get
            {
                return _diden;
            }
            set
            {
                if (_diden == value)
                    return;
                _diden = value;
            }
        }
        
        //[JsonProperty(PropertyName = "model")]
        public string model
        {
            get
            {
                return _model;
            }
            set
            {
                if (_model == value)
                    return;
                _model = value;
            }
        }
        
        //[JsonProperty(PropertyName = "nickname")]
        public string nickname
        {
            get
            {
                return _nickname;
            }
            set
            {
                if (_nickname == value)
                    return;
                _nickname = value;
            }
        }
         //[JsonProperty(PropertyName = "push_token")]
        public string push_token
        {
            get
            {
                return _push_token;
            }
            set
            {
                if (_push_token == value)
                    return;
                _push_token = value;
            }
        }
        public getdeviceobject()
        {
            _nickname = "";
            _active = "";
            _model = "";
            _push_token = "";
            _diden = "";
        }
    }
}