
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium113";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 112.97172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    