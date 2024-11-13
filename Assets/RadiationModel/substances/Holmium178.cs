
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium178";
        public override double halfLife { get; } = 0.75d;
        public override double atomicWeight { get; } = 177.96551d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    