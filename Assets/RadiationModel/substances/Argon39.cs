using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon39 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon39";
        public override double halfLife { get; } = 8457263136.0d;
        public override double atomicWeight { get; } = 38.96431d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 565195.0), new Potassium39() } },

        };
    }
}
    
    