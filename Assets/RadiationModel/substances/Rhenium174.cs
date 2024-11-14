using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium174";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 173.95312d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6554000.0), new Tungsten174() } },

        };
    }
}
    
    