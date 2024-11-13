
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium34 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium34";
        public override double halfLife { get; } = 0.0055d;
        public override double atomicWeight { get; } = 34.03401d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium34() } },

        };
    }
}
    
    