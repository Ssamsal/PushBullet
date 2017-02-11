//#define DEBUG
//GreenPOint TDI - SAS
#undef DEBUG

using System;
using System.Text;
using System.Collections.Generic;
using Crestron.SimplSharp;
using Crestron.SimplSharp.Net;
using Crestron.SimplSharp.Net.Https;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Crestron.SimplSharp.Reflection;
using Crestron.SimplSharp.CrestronIO;                          				
using Crestron.SimplSharp.CrestronXml;
using Crestron.SimplSharp.CrestronWebSocketClient;

namespace PushBullet_Client
{
    
    public class Client
    {

        

     
            
        public Client()
        {
            
            //GetRequest = false;
            //client.Verbose = true;
            
            
        }
        public Newtonsoft.Json.JsonSerializerSettings jsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,

            //TypeNameHandling = TypeNameHandling,
            NullValueHandling = NullValueHandling.Ignore,
            //ObjectCreationHandling = ObjectCreationHandling
           //ConstructorHandling = ConstructorHandling,
            //DefaultValueHandling = DefaultValueHandling,            
        };
        public getnameobject Getnameobject = new getnameobject();
        //public getdeviceobject Getdeviceobject = new getdeviceobject();
        public gettypeobject Gettypeobject = new gettypeobject();
        public postmessage Postmessage = new postmessage();
        WebSocketClient websocket = new WebSocketClient();
        
        public serialDelagate message_ { get; set; }

        private string _message = "";
        public string Message
        {
            set
            {
                if (value.Length > 0)
                {
                    _message = value;
                    if (message_ != null)
                    {
                        message_(value);
                    }
                }
            }
            get
            {
                return _message;
            }
        }
        public serialDelagate Debug_ { get; set; }
        public serialDelagate token_ { get; set; }
        private string _token = "";
        public string Token
        {
            set
            {
                if (value.Length > 0)
                {
                    _token = value;
                    if (token_ != null)
                    {
                        token_(value);
                    }
                }
            }
            get
            {
                return _token;
            }
        }
        public serialDelagate bmessage_ { get; set; }
        private string _bmessage = "";
        public string Bmessage
        {
            set
            {
                if (value.Length > 0)
                {
                    _bmessage = value;
                    if (bmessage_ != null)
                    {
                        bmessage_(value);
                    }
                }
            }
            get
            {
                return _bmessage;
            }
        }
        public analogDelagate socket_busy_ { get; set; }
        private ushort _socket_busy;
        public ushort Socket_Busy
        {
            set
            {
                _socket_busy = value;
                if (socket_busy_ != null)
                {
                    socket_busy_(_socket_busy);
                }
            }
            get
            {
                return _socket_busy;
            }
        }
        public serialDelagate user_name_ { get; set; }
        public serialDelagate user_id_ { get; set; }
        public serialDelagate user_email_ { get; set; }
        private static string baseUri = "https://";

        public serialDelagate Ip_ { get; set; }
        private string _Ip = "api.pushbullet.com/v2/";
        public string Ip
        {
            set
            {
                if (value.Length > 0)
                {
                    _Ip = value;
                    if (Ip_ != null)
                    {
                        Ip_(value);
                    }

                }
            }
            get
            {
                return _Ip;
            }
        }
        public serialDelagate last_modified_ { get; set; }
        private string _last_modified = "";
        public string Last_modified
        {
            set
            {
                if (value.Length > 0)
                {
                    _last_modified = value;
                    if (last_modified_ != null)
                    {
                        last_modified_(value);
                    }

                }
            }
            get
            {
                return _last_modified;
            }
        }
        public analogDelagate push_list_busy_ { get; set; }
        private ushort _push_list_busy= 0;
        public ushort Push_list_Busy
        {
            set
            {
                _push_list_busy = value;
                if (push_list_busy_ != null)
                {
                    push_list_busy_(_push_list_busy);
                }
            }
            get
            {
                return _push_list_busy;
            }
        }
        public analogDelagate push_list_change{get; set; }
        public analogDelagate device_list_change { get; set; }
        public string convertUnix(int TimeStamp)
        {
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(TimeStamp).ToLocalTime() ;
            string date = dateTime.ToShortDateString() + " ," + dateTime.ToShortTimeString();
            Message = date;
            return date;
        }
        public analogDelagate device_list_busy_ { get; set; }
        private ushort _device_list_busy = 0;
        public ushort device_list_Busy
        {
            set
            {
                _device_list_busy = value;
                if (device_list_busy_ != null)
                {
                    device_list_busy_(_device_list_busy);
                }
            }
            get
            {
                return _device_list_busy;
            }
        }
        public analogDelagate webconnected_{ get; set; }
        private ushort _webconnected = 0;
        public ushort Webconnected
        {
            set
            {
                _webconnected = value;
                if (webconnected_ != null)
                {
                    webconnected_(_webconnected);
                }
            }
            get
            {
                return _webconnected;
            }
        }
        public string getTx(string URL)
        {
            if (URL.Length == 0)
            {
                Message = "Tx: URL Length Zero. Returning from Tx method without excuting.";
                return "";
            }
            else
            {
                Message = " Entered getTx Function";
                Socket_Busy = (ushort)1;
                HttpsClient Getclient = new HttpsClient();
                HttpsClientRequest GetRequest = new HttpsClientRequest();
                GetRequest.Url.Parse(URL);
                GetRequest.RequestType = Crestron.SimplSharp.Net.Https.RequestType.Get;
                GetRequest.Header.SetHeaderValue("Accept", "application/json");
                GetRequest.Header.SetHeaderValue("Content-Type", "application/json");
                GetRequest.Header.SetHeaderValue("Access-Token", Token);

               
                try
                {
                    HttpsClientResponse GetclientResponse = Getclient.Dispatch(GetRequest);
                    Socket_Busy = (ushort)0;
                    if (GetclientResponse.Code == 200)
                    {
                        //Message = " Server response = " + GetclientResponse.ContentString;
                        return GetclientResponse.ContentString;
                    }
                    Message = "Server Replied: " + GetclientResponse.Code.ToString();
                    return "";

                }
                catch (HttpsException ex)
                {
                    switch (ex.Response.Code)
                    {
                        case 404:
                            this.Message = "Server Replied: 404 Forbidden.";
                            break;
                        case 409:
                            this.Message = "Server Replied: 409 Conflict.";
                            break;
                        case 500:
                            this.Message = "Server Replied: 500 Internal Server Error.";
                            break;
                        case 501:
                            this.Message = "Server Replied: 501 Not implemented.";
                            break;
                        case 503:
                            this.Message = "Server Replied: 503 Service Unavailable.";
                            break;
                        case 505:
                            this.Message = "Server Replied: 505 Conflict.";
                            break;
                        case 304:
                            this.Message = "Server Replied: 304 Not Modified.";
                            break;
                        case 400:
                            this.Message = "Server Replied: 400 Bad Request.";
                            break;
                        default:
                            this.Message = "Server Replied: " + ex.Response.Code.ToString();
                            break;
                    }
                    Socket_Busy = (ushort)0;
                    return ex.Response.ContentString;
                }
                catch (Exception ex)
                {
                    Message = "Exception thrown on Dispatch:" + ex.Message;
                    Getclient.Abort();
                    Socket_Busy = (ushort)0;
                    return "";
                }
            }
        }
        public string postTx(string URL, string content)
        {
            if (URL.Length == 0)
            {
                Message = "Tx: URL Length Zero. Returning from Tx method without excuting.";
                return "";
            }
            else
            {
                Message = " Entered getTx Function";
                Socket_Busy = (ushort)1;
                HttpsClient Postclient = new HttpsClient();
                HttpsClientRequest PostRequest = new HttpsClientRequest();
                PostRequest.Url.Parse(URL);
                PostRequest.RequestType = Crestron.SimplSharp.Net.Https.RequestType.Post;
                PostRequest.Header.SetHeaderValue("Accept", "application/json");
                PostRequest.Header.SetHeaderValue("Content-Type", "application/json");
                PostRequest.Header.SetHeaderValue("Access-Token", Token);
                PostRequest.ContentSource = ContentSource.ContentString;
                PostRequest.ContentString = content;
                try
                {
                    HttpsClientResponse PostclientResponse = Postclient.Dispatch(PostRequest);
                    Socket_Busy = (ushort)0;
                    if (PostclientResponse.Code == 200)
                    {
                        //Message = " Server response = " + GetclientResponse.ContentString;
                        return PostclientResponse.ContentString;
                    }
                    Message = "Server Replied: " + PostclientResponse.Code.ToString();
                    return "";

                }
                catch (HttpsException ex)
                {
                    switch (ex.Response.Code)
                    {
                        case 404:
                            this.Message = "Server Replied: 404 Forbidden.";
                            break;
                        case 409:
                            this.Message = "Server Replied: 409 Conflict.";
                            break;
                        case 500:
                            this.Message = "Server Replied: 500 Internal Server Error.";
                            break;
                        case 501:
                            this.Message = "Server Replied: 501 Not implemented.";
                            break;
                        case 503:
                            this.Message = "Server Replied: 503 Service Unavailable.";
                            break;
                        case 505:
                            this.Message = "Server Replied: 505 Conflict.";
                            break;
                        case 304:
                            this.Message = "Server Replied: 304 Not Modified.";
                            break;
                        case 400:
                            this.Message = "Server Replied: 400 Bad Request.";
                            break;
                        default:
                            this.Message = "Server Replied: " + ex.Response.Code.ToString();
                            break;
                    }
                    Socket_Busy = (ushort)0;
                    return ex.Response.ContentString;
                }
                catch (Exception ex)
                {
                    Message = "Exception thrown on Post Dispatch:" + ex.Message;
                    Postclient.Abort();
                    Socket_Busy = (ushort)0;
                    return "";
                }
            }
        }

        public void getName(string restParams)
        {
            string URL = baseUri + _Ip + restParams;
            //Message = "URL for send=" + URL;
            string json = getTx(URL);
            if (json.Length <= 1)
            {
                return;
            }
            try
            {
                //o = JsonConvert.DeserializeObject<getnameobject>(json);
                Getnameobject = JsonConvert.DeserializeObject<getnameobject>(json, jsonSerializerSettings);
                if (user_name_ != null)
                {
                    user_name_(Getnameobject.name);
                }
                if (user_id_ != null)
                {
                    user_id_(Getnameobject.ident);
                }
                if (user_email_ != null)
                {
                    user_email_(Getnameobject.email);
                }
            }
            catch (Exception Ex)
            {
                Message=Ex.Message;
            }
        }
        
        public void sendMessage(string restParams, string body,string title,string type)
        {
            string URL = baseUri + _Ip + restParams;
            Postmessage.body = body;
            Postmessage.title = title;
            Postmessage.type = type;


            string content = JsonConvert.SerializeObject(Postmessage);
            string jsonIn = postTx(URL,content);
            if (jsonIn.Length <= 1)
            {
                return;
            }
            try
            {
                Postmessage = JsonConvert.DeserializeObject<postmessage>(jsonIn, jsonSerializerSettings);
                Message = " Message sent Successfully";
              
            }
            catch (Exception Ex)
            {
                Message = Ex.Message;
            }
        }
        public string[] DeviceList = new string[25];
        public void getDevice(string restParams)
        {
            string htmlFormat = "<FONT size=\"14\" face=\"Crestron Sans Pro\" color=\"#e5e239\">";
            string htmlFormat2 = "<FONT size=\"12\" face=\"Crestron Sans Pro\" color=\"#e5a339\">";
            string URL = baseUri + _Ip + restParams;
            //Message = "URL for send=" + URL;
            string json = getTx(URL);
            if (json.Length <= 1)
            {
                return;
            }
            try
            {
                getdevicetypeobject Getdevices = JsonConvert.DeserializeObject<getdevicetypeobject>(json, jsonSerializerSettings);
                Message = " Device List count = " + Getdevices.devices.Count.ToString();
                if (Getdevices.devices.Count > 0)
                {
                    device_list_busy_(1);
                    for (int i = 0; i < Getdevices.devices.Count; i++)
                    {

                        DeviceList[i] = htmlFormat + "<B>" + Getdevices.devices[i].nickname + "</B></FONT><BR>" + htmlFormat2 + "<B>" + Getdevices.devices[i].model + "</B></FONT><BR>";
                        //Message = DeviceList[i];
                    }
                    device_list_busy_(0);
                    device_list_change((ushort)Getdevices.devices.Count);
                }
               
            }
            catch (Exception Ex)
            {
                Message = Ex.Message;
            }
        }
        public string[] PushList = new string[100];
        
        public void getPushes(string restParams)
        {
            string htmlFormat = "<FONT size=\"14\" face=\"Crestron Sans Pro\" color=\"#e5e239\">";
            string htmlFormat2 = "<FONT size=\"12\" face=\"Crestron Sans Pro\" color=\"#e5a339\">";
            string htmlFormat3 = "<FONT size=\"10\" face=\"Crestron Sans Pro\" color=\"#FFFFFF\">";
            string URL = baseUri + _Ip + restParams;
            string TimeDate = "";
            string json = getTx(URL);
            if (json.Length <= 1)
            {
                return;
            }
            try
            {
                getpushtypeobject Getpushes = JsonConvert.DeserializeObject<getpushtypeobject>(json, jsonSerializerSettings) ;
                Message = " Push List count = " + Getpushes.pushes.Count.ToString();
                if (Getpushes.pushes.Count > 0)
                {
                    push_list_busy_(1);

                    for (int i = 0; i < Getpushes.pushes.Count; i++)
                    {
                        try
                        {
                            //Message = Getpushes.pushes[i].created;
                            TimeDate = convertUnix(Int32.Parse(Getpushes.pushes[i].created.Split('.')[0]));
                        }
                        catch
                        {
                            Message = " TIMEStamp Exception Thrown";
                        }
                        PushList[i] = htmlFormat + "<B>" + TimeDate + "</B></FONT><BR>" + htmlFormat2 + "<B>" + Getpushes.pushes[i].sender_name + "</B></FONT><BR>" +
                        htmlFormat3 + "<I>" + Getpushes.pushes[i].body + "</I></FONT>";
                        //Message = PushList[i];
                    }
                    push_list_change((ushort)Getpushes.pushes.Count);
                    bmessage_(Getpushes.pushes[0].body);
                    //Message = Push_list_change.ToString(); 
                    push_list_busy_(0);
                    last_modified_(Getpushes.pushes[0].modified);
                }
                else { Message = " Push Request returned no new entries !"; }
                
            }
            catch (JsonSerializationException jsonErr)
            {
                Message = "Push List Exception:" + jsonErr.ToString();
            }
        }
        
        public void initiateWebSocket(uint status)
        {
            //byte[] ReceiveData;
            WebSocketClient.WEBSOCKET_RESULT_CODES ret;
            //WebSocketClient.WEBSOCKET_PACKET_TYPES opcode; 
            
            WebSocketClient.WEBSOCKET_RESULT_CODES result;
            websocket.ReceiveCallBack = ReceiveCallback;
            if (status == 1)
            {
                websocket.Port = 443;
                websocket.VerifyServerCertificate = false;
                websocket.SSL = true;
                websocket.URL = "wss://stream.pushbullet.com/websocket/" + Token;

                
                Message = " websocket URL parsed: " + websocket.URL.ToString();
                result = websocket.Connect();
                websocket.KeepAlive = true;
                if (result == (int)WebSocketClient.WEBSOCKET_RESULT_CODES.WEBSOCKET_CLIENT_SUCCESS)
                {
                    
                    Message = "Websocket connected \r\n";
                    webconnected_(1);
                    try
                    {
                        
                        ret = websocket.ReceiveAsync();
                        Message = "Receiver connected" + ret.ToString();
                       // Message = " MEssage Received: " + Encoding.UTF8.GetString(ReceiveData, 0, ReceiveData.Length);
                            
                            
                        
                        
                       
                    }
                    catch (Exception e)
                    {
                        Message = " Websocket received Exception:" + e.ToString();
                    }
                   
                }
                else
                {
                    Message = "Websocket could not connect to server.  Connect return code: " + result.ToString();
                    websocket.Disconnect();
                    webconnected_(0);
                }
                
            }
            else
            {
                websocket.Disconnect();
                webconnected_(0);
            }
            
        }
        
        public int ReceiveCallback(byte[] data, uint datalen, WebSocketClient.WEBSOCKET_PACKET_TYPES opcode, WebSocketClient.WEBSOCKET_RESULT_CODES error)
        {
            Message = "Receive Callback function fired:" + datalen.ToString(); 
            try
            {
                string json = Encoding.UTF8.GetString(data, 0, data.Length);
                //Message = "data resceived from web callback" + json;
                Gettypeobject = JsonConvert.DeserializeObject<gettypeobject>(json, jsonSerializerSettings);
                if (Gettypeobject.type == "tickle")
                {
                    Message = "Gots us a tickle"; 
                    if(Gettypeobject.subtype=="push")
                    {
                        getPushes("pushes");
                    }

                }


            }
            catch (Exception e)
            {
                Message = "Receive Callback Exception:" + e.ToString();
                return -1;
            }
            return 0;
        }
       
        
  

#if (DEBUG)
            this.Debug_("HTTPS_CALLBACK_ERROR err: " + err.ToString());
            this.Debug_("response.Code: " + response.Code.ToString());
            this.Debug_("response.Chunked: " + response.Chunked.ToString());
            this.Debug_("response.Header: " + response.Header.ToString());
            this.Debug_("response.IsCompleted: " + response.IsCompleted.ToString());
            this.Debug_("response.KeepAlive: " + response.KeepAlive.ToString());
            this.Debug_("response.ResponseUrl: " + response.ResponseUrl);
            this.Debug_("response.HasContentLength: " + response.HasContentLength.ToString());
            this.Debug_("response.ContentLength: " + response.ContentLength.ToString());
            this.Message_("response.ContentString: " + response.ContentString);
            //thi.Debug_("response.: " + response);
#endif
        
        public static string serverCode(int c)// There has to be a STRUCT/Enum or HTTP member that does this
        {
            string s = "";

            switch (c)
            {
                case 200: { s = "OK"; break; }
                case 201: { s = "Created"; break; }
                case 202: { s = "Accepted"; break; }
                case 203: { s = "Non-Authoritative Information"; break; }
                case 204: { s = "No Content"; break; }
                case 205: { s = "Reset Content"; break; }
                case 206: { s = "Partial Content"; break; }
                case 300: { s = "Redirect Multiple Choice"; break; }
                case 301: { s = "Moved Permanently"; break; }
                case 302: { s = "Found"; break; }
                case 303: { s = "See Other"; break; }
                case 304: { s = "Not Modified"; break; }
                case 305: { s = "Use Proxy"; break; }
                case 307: { s = "Temporary Redirect"; break; }
                case 400: { s = "Bad Request"; break; }
                case 401: { s = "Unauthorized"; break; }
                case 402: { s = "Payment Required"; break; }
                case 403: { s = "Forbidden"; break; }
                case 404: { s = "Not Found"; break; }
                case 405: { s = "Method Required"; break; }
                case 406: { s = "Not Acceptable"; break; }
                case 407: { s = "Proxy Authentication Required"; break; }
                case 408: { s = "Request Timeout"; break; }
                case 409: { s = "Conflict"; break; }
                case 410: { s = "Gone"; break; }
                case 411: { s = "Length Required"; break; }
                case 412: { s = "Precondition Failed"; break; }
                case 413: { s = "Request Entity Too Large"; break; }
                case 414: { s = "Request-URI Too Long"; break; }
                case 415: { s = "Unsupported Media Type"; break; }
                case 416: { s = "Requested Range Not Satisfiable"; break; }
                case 417: { s = "Expectation Failed"; break; }
                case 500: { s = "Internal Server Error"; break; }
                case 501: { s = "Not Implemented"; break; }
                case 502: { s = "Bad Gateway"; break; }
                case 503: { s = "Service Unavailable"; break; }
                case 504: { s = "Gateway Timout"; break; }
                case 505: { s = "HTTP Version Not Supported"; break; }
            }
            return s;
        }
    }
    
}
