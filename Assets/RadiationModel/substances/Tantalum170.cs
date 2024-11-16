using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum170 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum170";
        public override double halfLife { get; } = 405.6d;
        public override double atomicWeight { get; } = 169.94617d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6116000.0), new Hafnium170() } },

        };
    }
}
    
    