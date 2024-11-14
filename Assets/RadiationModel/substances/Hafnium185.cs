using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium185 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium185";
        public override double halfLife { get; } = 210.0d;
        public override double atomicWeight { get; } = 184.95886d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3074000.0), new Tantalum185() } },

        };
    }
}
    
    