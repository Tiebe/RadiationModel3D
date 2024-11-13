
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine208 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine208";
        public override double halfLife { get; } = 5868.0d;
        public override double atomicWeight { get; } = 207.98661d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9945d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium208() } },

            { 0.0055000000000000005d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth204() } },

        };
    }
}
    
    