
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium199m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium199m";
        public override double halfLife { get; } = 250.2d;
        public override double atomicWeight { get; } = 198.98398d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.735d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth199() } },

            { 0.24d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead195() } },

            { 0.025d, new List<RadioactiveSubstance> { new GammaParticle(), new Polonium199() } },

        };
    }
}
    
    