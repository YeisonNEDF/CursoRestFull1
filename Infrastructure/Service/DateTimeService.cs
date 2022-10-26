﻿using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Service
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc =>DateTime.UtcNow;
    }
}
