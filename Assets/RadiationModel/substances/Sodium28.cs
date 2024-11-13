
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium28 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium28";
        public override double halfLife { get; } = 0.0331d;
        public override double atomicWeight { get; } = 27.99894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium28() } },

        };
    }
}
    
    