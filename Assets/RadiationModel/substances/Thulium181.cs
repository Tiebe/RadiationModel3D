
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium181";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 180.96195d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    