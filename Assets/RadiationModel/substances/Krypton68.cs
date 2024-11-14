using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton68 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton68";
        public override double halfLife { get; } = 0.0216d;
        public override double atomicWeight { get; } = 67.97249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    