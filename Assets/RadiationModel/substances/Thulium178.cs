using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium178";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 177.95251d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    