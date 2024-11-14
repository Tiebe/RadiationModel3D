using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium181";
        public override double halfLife { get; } = 3662496.0d;
        public override double atomicWeight { get; } = 180.94911d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1036099.9999999999), new Tantalum181() } },

        };
    }
}
    
    