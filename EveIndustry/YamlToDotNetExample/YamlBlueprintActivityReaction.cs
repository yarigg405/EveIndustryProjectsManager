﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yamldotnet
{
    class YamlBlueprintActivityReaction
    {
        public List<YamlBlueprintMaterial> materials { get; set; }
        public List<YamlBlueprintMaterial> products { get; set; }
        public List<YamlBlueprintSkill> skills { get; set; }
        public int time { get; set; }


    }
}
