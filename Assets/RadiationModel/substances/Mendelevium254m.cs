using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium254m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium254m";
        public override double halfLife { get; } = 1680.0d;
        public override double atomicWeight { get; } = 254.08964d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2597500.0), new Fermium254() } },

        };
    }
}
    
    