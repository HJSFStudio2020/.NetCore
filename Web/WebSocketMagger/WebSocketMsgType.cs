﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebSocketMagger
{
    public class WebSocketMsgType
    {
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string MessageType { get; set; }
        public string Content { get; set; }
    }
}
