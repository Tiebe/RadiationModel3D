using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium181p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium181p";
        public override double halfLife { get; } = 0.0015d;
        public override double atomicWeight { get; } = 180.95098d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00071, 1741900.0), new Hafnium181() } },

        };
    }
}
    
    