
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine204 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine204";
        public override double halfLife { get; } = 547.2d;
        public override double atomicWeight { get; } = 203.98725d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9620000000000001d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium204() } },

            { 0.038d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth200() } },

        };
    }
}
    
    