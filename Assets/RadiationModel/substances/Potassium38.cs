using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium38 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium38";
        public override double halfLife { get; } = 459.06d;
        public override double atomicWeight { get; } = 37.96908d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5914070.0), new Argon38() } },

        };
    }
}
    
    