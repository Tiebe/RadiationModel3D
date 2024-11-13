
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium34 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium34";
        public override double halfLife { get; } = 0.0449d;
        public override double atomicWeight { get; } = 34.00894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum34() } },

        };
    }
}
    
    