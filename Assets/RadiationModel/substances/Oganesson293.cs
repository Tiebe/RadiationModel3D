using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oganesson293 : RadioactiveSubstance
    {
        public override string name { get; } = "Oganesson293";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 293.21342d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    