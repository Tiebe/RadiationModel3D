
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver102m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver102m";
        public override double halfLife { get; } = 462.0d;
        public override double atomicWeight { get; } = 101.91171d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.51d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium102() } },

            { 0.49d, new List<RadioactiveSubstance> { new GammaParticle(), new Silver102() } },

        };
    }
}
    
    