using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium260";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 260.10281d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    