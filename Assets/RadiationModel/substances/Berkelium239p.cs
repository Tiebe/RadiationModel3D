using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium239p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium239p";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 239.05828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    