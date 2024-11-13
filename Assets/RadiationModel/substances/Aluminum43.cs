
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum43 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum43";
        public override double halfLife { get; } = 0.004d;
        public override double atomicWeight { get; } = 43.05182d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    