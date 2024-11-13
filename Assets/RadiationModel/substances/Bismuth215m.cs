
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth215m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth215m";
        public override double halfLife { get; } = 36.9d;
        public override double atomicWeight { get; } = 215.00322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.769d, new List<RadioactiveSubstance> { new GammaParticle(), new Bismuth215() } },

            { 0.231d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium215() } },

        };
    }
}
    
    