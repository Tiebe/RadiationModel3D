using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine36 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine36";
        public override double halfLife { get; } = 9508109637600.0d;
        public override double atomicWeight { get; } = 35.96831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.981d, new List<RadioactiveSubstance> { new BetaParticle(-1, 709532.0), new Argon36() } },
            { 0.019d, new List<RadioactiveSubstance> { new BetaParticle(1, 1142130.0), new Sulfur36() } },

        };
    }
}
    
    