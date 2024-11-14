using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium135m";
        public override double halfLife { get; } = 101196.0d;
        public override double atomicWeight { get; } = 134.90598d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00462), new Barium135() } },

        };
    }
}
    
    