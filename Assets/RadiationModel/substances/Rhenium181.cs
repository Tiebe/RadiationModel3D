using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium181";
        public override double halfLife { get; } = 71640.0d;
        public override double atomicWeight { get; } = 180.95006d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1716900.0), new Tungsten181() } },

        };
    }
}
    
    