
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten193 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten193";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 192.97188d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    