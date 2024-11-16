using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium161";
        public override double halfLife { get; } = 1812.0d;
        public override double atomicWeight { get; } = 160.93355d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3302000.0), new Erbium161() } },

        };
    }
}
    
    