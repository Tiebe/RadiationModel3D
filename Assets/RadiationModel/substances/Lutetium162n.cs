using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium162n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium162n";
        public override double halfLife { get; } = 114.0d;
        public override double atomicWeight { get; } = 161.94361d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    