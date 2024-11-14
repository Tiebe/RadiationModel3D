using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt62m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt62m";
        public override double halfLife { get; } = 831.6d;
        public override double atomicWeight { get; } = 61.93408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5344400.0), new Nickel62() } },
            { 0.005d, new List<RadioactiveSubstance> { new GammaParticle(0.05636), new Cobalt62() } },

        };
    }
}
    
    