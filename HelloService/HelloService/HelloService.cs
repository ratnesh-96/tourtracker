﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
