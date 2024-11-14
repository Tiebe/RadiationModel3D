using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin137 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin137";
        public override double halfLife { get; } = 0.249d;
        public override double atomicWeight { get; } = 136.94616d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9910000.0), new Antimony137() } },

        };
    }
}
    
    