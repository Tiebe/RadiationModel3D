
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine33 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine33";
        public override double halfLife { get; } = 2.5038d;
        public override double atomicWeight { get; } = 32.97745d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sulfur33() } },

        };
    }
}
    
    