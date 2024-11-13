
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon43 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon43";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 43.02612d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    