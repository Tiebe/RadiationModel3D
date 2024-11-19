using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine79m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine79m";
        public override double halfLife { get; } = 4.85d;
        public override double atomicWeight { get; } = 78.91856d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((207599.99999, 0.00597)), new Bromine79() } },

        };
    }
}
    
    