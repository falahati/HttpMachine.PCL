﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMachine
{
    public interface IHttpParserCombinedDelegate : IHttpParserDelegate, IHttpRequestParserDelegate, IHttpResponseParserDelegate
    {
    }
}
