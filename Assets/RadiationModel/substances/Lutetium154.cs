
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium154";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 153.95741d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    