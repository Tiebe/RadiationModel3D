using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium203m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium203m";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 202.98211d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00193, 642000.0), new Polonium203() } },

        };
    }
}
    
    