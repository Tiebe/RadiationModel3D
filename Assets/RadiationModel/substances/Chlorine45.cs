using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine45 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine45";
        public override double halfLife { get; } = 0.413d;
        public override double atomicWeight { get; } = 44.9804d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11510800.0), new Argon45() } },

        };
    }
}
    
    