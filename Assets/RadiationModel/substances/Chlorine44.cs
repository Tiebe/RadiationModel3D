using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine44 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine44";
        public override double halfLife { get; } = 0.562d;
        public override double atomicWeight { get; } = 43.97801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12193300.0), new Argon44() } },

        };
    }
}
    
    