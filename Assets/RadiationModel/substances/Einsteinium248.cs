
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium248";
        public override double halfLife { get; } = 1440.0d;
        public override double atomicWeight { get; } = 248.07547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Californium248() } },

            { 0.0025d, new List<RadioactiveSubstance> { new AlphaParticle(), new Berkelium244() } },

        };
    }
}
    
    