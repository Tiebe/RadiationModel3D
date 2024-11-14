using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium187";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 186.97019d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    