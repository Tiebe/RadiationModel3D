using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon43 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon43";
        public override double halfLife { get; } = 322.2d;
        public override double atomicWeight { get; } = 42.96564d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4565400.0), new Potassium43() } },

        };
    }
}
    
    