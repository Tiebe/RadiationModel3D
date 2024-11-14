using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium261";
        public override double halfLife { get; } = 10800.0d;
        public override double atomicWeight { get; } = 261.1057d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    