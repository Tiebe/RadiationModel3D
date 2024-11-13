
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium204";
        public override double halfLife { get; } = 12668.4d;
        public override double atomicWeight { get; } = 203.98031d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9933d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth204() } },

            { 0.0067d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead200() } },

        };
    }
}
    
    