using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium161";
        public override double halfLife { get; } = 26.2d;
        public override double atomicWeight { get; } = 160.93366d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3714100.0), new Gadolinium161() } },

        };
    }
}
    
    