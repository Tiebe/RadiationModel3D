
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium145";
        public override double halfLife { get; } = 0.075d;
        public override double atomicWeight { get; } = 144.96778d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    