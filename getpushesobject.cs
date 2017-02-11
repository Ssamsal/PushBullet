using System;
using System.Text;

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
    public class getpushtypeobject
    {
        private List<getpushesobject> _pushes = new List<getpushesobject>();
        public List<getpushesobject> pushes { get; set; }

        //private string _pushes;
        //[JsonProperty(PropertyName = "pushes")]
        //public string pushes
        //{
        //    get
        //    {
        //        return _pushes;
        //    }
        //    set
        //    {
        //        if (_pushes == value)
        //            return;
        //        _pushes = value;
        //    }
        //}
    }
    public class getpushesobject
    {

        private string _active;
        private string _body;
        private string _created;
        private string _direction;
        private string _dismissed;
        private string _iden;
        private string _modified;
        private string _receiver_email;
        private string _receiver_iden;
        private string _sender_email;
        private string _sender_iden;
        private string _sender_name;
        private string _title;
        private string _type;

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

        //[JsonProperty(PropertyName = "created")]
        public string created
        {
            get
            {
                return _created;
            }
            set
            {
                if (_created == value)
                    return;
                _created = value;
            }
        }
       
        //[JsonProperty(PropertyName = "direction")]
        public string direction
        {
            get
            {
                return _direction;
            }
            set
            {
                if (_direction == value)
                    return;
                _direction = value;
            }
        }
        //[JsonProperty(PropertyName = "dismissed")]
        public string dismissed
        {
            get
            {
                return _dismissed;
            }
            set
            {
                if (_dismissed == value)
                    return;
                _dismissed = value;
            }
        }
         //[JsonProperty(PropertyName = "iden")]
        public string iden
        {
            get
            {
                return _iden;
            }
            set
            {
                if (_iden == value)
                    return;
                _iden = value;
            }
        }
          //[JsonProperty(PropertyName = "modified")]
        public string modified
        {
            get
            {
                return _modified;
            }
            set
            {
                if (_modified == value)
                    return;
                _modified = value;
            }
        }
          //[JsonProperty(PropertyName = "receiver_email")]
        public string receiver_email
        {
            get
            {
                return _receiver_email;
            }
            set
            {
                if (_receiver_email == value)
                    return;
                _receiver_email = value;
            }
        }
            //[JsonProperty(PropertyName = "receiver_iden")]
        public string receiver_iden
        {
            get
            {
                return _receiver_iden;
            }
            set
            {
                if (_receiver_iden == value)
                    return;
                _receiver_iden = value;
            }
        }
            //[JsonProperty(PropertyName = "sender_email")]
        public string sender_email
        {
            get
            {
                return _sender_email;
            }
            set
            {
                if (_sender_email == value)
                    return;
                _sender_email = value;
            }
        }
            //[JsonProperty(PropertyName = "sender_iden")]
        public string sender_iden
        {
            get
            {
                return _sender_iden;
            }
            set
            {
                if (_sender_iden == value)
                    return;
                _sender_iden = value;
            }
        }
               //[JsonProperty(PropertyName = "sender_name")]
        public string sender_name
        {
            get
            {
                return _sender_name;
            }
            set
            {
                if (_sender_name == value)
                    return;
                _sender_name = value;
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
        public getpushesobject()
        {
            _active = "" ;
            _body = "";
            _created = "";
            _direction = "";
            _dismissed = "";
            _iden = "";
            _modified = "";
            _receiver_email = "";
            _receiver_iden = "";
            _sender_email = "";
            _sender_iden = "";
            _sender_name = "";
            _title = "";
            _type = "";
        }
    }
}