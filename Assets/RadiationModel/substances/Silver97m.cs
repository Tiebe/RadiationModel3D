
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver97m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver97m";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 96.92454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    