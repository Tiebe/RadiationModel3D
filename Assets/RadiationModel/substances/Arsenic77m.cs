using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic77m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic77m";
        public override double halfLife { get; } = 0.00011d;
        public override double atomicWeight { get; } = 76.92116d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00261), new Arsenic77() } },

        };
    }
}
    
    