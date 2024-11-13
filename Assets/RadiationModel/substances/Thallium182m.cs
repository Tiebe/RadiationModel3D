
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium182m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium182m";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 181.98574d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury182() } },

            { 0.025d, new List<RadioactiveSubstance> { new AlphaParticle(), new Gold178() } },

        };
    }
}
    
    