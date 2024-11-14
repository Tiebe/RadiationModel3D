using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver121 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver121";
        public override double halfLife { get; } = 0.777d;
        public override double atomicWeight { get; } = 120.92013d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6670800.0), new Cadmium121() } },

        };
    }
}
    
    