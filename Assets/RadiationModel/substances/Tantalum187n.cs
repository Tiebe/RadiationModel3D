
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum187n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum187n";
        public override double halfLife { get; } = 300.0d;
        public override double atomicWeight { get; } = 186.96353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    