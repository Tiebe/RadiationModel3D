
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine39 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine39";
        public override double halfLife { get; } = 3372.0d;
        public override double atomicWeight { get; } = 38.96801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Argon39() } },

        };
    }
}
    
    