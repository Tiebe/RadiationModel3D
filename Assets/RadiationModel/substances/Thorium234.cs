
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium234";
        public override double halfLife { get; } = 2082844.8d;
        public override double atomicWeight { get; } = 234.0436d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Protactinium234() } },

        };
    }
}
    
    