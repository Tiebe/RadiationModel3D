
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum193 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum193";
        public override double halfLife { get; } = 0.22d;
        public override double atomicWeight { get; } = 192.97766d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    