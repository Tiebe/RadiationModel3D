
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth203m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth203m";
        public override double halfLife { get; } = 0.305d;
        public override double atomicWeight { get; } = 202.97807d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Bismuth203() } },

        };
    }
}
    
    