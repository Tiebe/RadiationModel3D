using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium197";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 196.97308d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3184000.0), new Iridium197() } },

        };
    }
}
    
    