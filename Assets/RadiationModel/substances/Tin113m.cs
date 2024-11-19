using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin113m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin113m";
        public override double halfLife { get; } = 1284.0d;
        public override double atomicWeight { get; } = 112.90526d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9109999999999999d, new List<RadioactiveSubstance> { new GammaParticle((77399.99999, 0.01602)), new Tin113() } },
            { 0.08900000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 1116420.0), new Indium113() } },

        };
    }
}
    
    