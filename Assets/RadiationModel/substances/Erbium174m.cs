using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium174m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium174m";
        public override double halfLife { get; } = 3.9d;
        public override double atomicWeight { get; } = 173.94542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00112, 1110000.0), new Erbium174() } },

        };
    }
}
    
    