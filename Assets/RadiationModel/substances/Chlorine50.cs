
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine50 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine50";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 50.00827d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    