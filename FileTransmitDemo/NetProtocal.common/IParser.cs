﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetProtocal.Common
{
    interface IParser
    {
       object Unpack();
       IMessage Pack();

    }
}
