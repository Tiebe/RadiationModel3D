using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium179";
        public override double halfLife { get; } = 18.0d;
        public override double atomicWeight { get; } = 178.95502d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    