
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine229 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine229";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 229.04819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    