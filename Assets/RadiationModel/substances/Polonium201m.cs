using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium201m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium201m";
        public override double halfLife { get; } = 537.6d;
        public override double atomicWeight { get; } = 200.98272d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.562d, new List<RadioactiveSubstance> { new GammaParticle(0.00292), new Polonium201() } },
            { 0.414d, new List<RadioactiveSubstance> { new BetaParticle(1, 5332000.0), new Bismuth201() } },
            { 0.024d, new List<RadioactiveSubstance> { new AlphaParticle(7243047.4), new Lead197() } },

        };
    }
}
    
    