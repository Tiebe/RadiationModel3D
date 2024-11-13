
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium158m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium158m";
        public override double halfLife { get; } = 1680.0d;
        public override double atomicWeight { get; } = 157.92902d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.91d, new List<RadioactiveSubstance> { new GammaParticle(), new Holmium158() } },

            { 0.09d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium158() } },

        };
    }
}
    
    