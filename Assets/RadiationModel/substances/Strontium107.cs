using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium107";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 106.96967d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    