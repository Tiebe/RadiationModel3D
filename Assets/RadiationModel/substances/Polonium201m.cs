
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

            { 0.562d, new List<RadioactiveSubstance> { new GammaParticle(), new Polonium201() } },

            { 0.414d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth201() } },

            { 0.024d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead197() } },

        };
    }
}
    
    