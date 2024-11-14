using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium234";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 234.04814d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4228000.0), new Thorium234() } },

        };
    }
}
    
    