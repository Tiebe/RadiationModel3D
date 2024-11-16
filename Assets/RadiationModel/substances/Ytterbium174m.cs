using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium174m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium174m";
        public override double halfLife { get; } = 0.00083d;
        public override double atomicWeight { get; } = 173.9405d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00082), new Ytterbium174() } },

        };
    }
}
    
    