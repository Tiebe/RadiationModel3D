
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium253";
        public override double halfLife { get; } = 1538784.0d;
        public override double atomicWeight { get; } = 253.08513d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9969d, new List<RadioactiveSubstance> { new BetaParticle(), new Einsteinium253() } },

            { 0.0031d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium249() } },

        };
    }
}
    
    