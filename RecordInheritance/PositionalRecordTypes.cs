﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{
    public record PositionalCar(string Make, string Model, string Color);
    
    public record PosotionalMiniVan(string Make,string Model, string Color) : PositionalCar(Make,Model,Color);



}
