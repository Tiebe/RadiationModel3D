using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium161";
        public override double halfLife { get; } = 11556.0d;
        public override double atomicWeight { get; } = 160.93d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1995300.0), new Holmium161() } },

        };
    }
}
    
    