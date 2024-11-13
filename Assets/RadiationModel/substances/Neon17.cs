
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon17 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon17";
        public override double halfLife { get; } = 0.1092d;
        public override double atomicWeight { get; } = 17.01771d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fluorine17() } },

        };
    }
}
    
    