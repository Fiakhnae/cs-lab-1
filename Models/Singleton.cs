﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab1.Models {
    public static class Singleton {
        public static List<Processor> Processors { get; set; } = new();
    }
}
