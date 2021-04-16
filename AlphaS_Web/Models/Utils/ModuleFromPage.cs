﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaS_Web.Models.Utils
{
    public class ModuleFromPage
    {

        public int ModuleId { get; set; }

        public string ModuleName { get; set; }
        public string ModuleTypeName { get; set; }

        public List<MyKeyValuePair> InputVariables { get; set; }

        public List<MyKeyValuePair> OutputVariables { get; set; }

        public string PathToExe { get; set; }

        public string Description { get; set; }
        public ModuleFromPage()
        {
            InputVariables = new List<MyKeyValuePair>();
            OutputVariables = new List<MyKeyValuePair>();
        }

    }
}