﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrument_Application.Interface
{
    public interface IMessageProducer
    {
        
        void SendMessage<T>(T message);
    }
}

