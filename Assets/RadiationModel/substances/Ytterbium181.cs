using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium181";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 180.95589d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    