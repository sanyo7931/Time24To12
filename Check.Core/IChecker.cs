﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check.Core
{
    public interface IChecker
    {
        string MilitaryTimeToRegularTime(string militaryTime);
    }
}
