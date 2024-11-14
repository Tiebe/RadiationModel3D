using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton73m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton73m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 72.93975d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00286), new Krypton73() } },

        };
    }
}
    
    