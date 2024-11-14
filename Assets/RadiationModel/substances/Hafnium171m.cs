using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium171m";
        public override double halfLife { get; } = 29.5d;
        public override double atomicWeight { get; } = 170.94052d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.05636), new Hafnium171() } },

        };
    }
}
    
    