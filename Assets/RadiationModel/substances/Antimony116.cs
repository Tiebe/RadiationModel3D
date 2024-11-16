using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony116 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony116";
        public override double halfLife { get; } = 948.0d;
        public override double atomicWeight { get; } = 115.90679d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4703980.0), new Tin116() } },

        };
    }
}
    
    