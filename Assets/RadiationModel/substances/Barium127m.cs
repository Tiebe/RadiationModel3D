using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium127m";
        public override double halfLife { get; } = 1.93d;
        public override double atomicWeight { get; } = 126.91118d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0155, 80000.0), new Barium127() } },

        };
    }
}
    
    