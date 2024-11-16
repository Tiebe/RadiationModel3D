using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium138";
        public override double halfLife { get; } = 186.0d;
        public override double atomicWeight { get; } = 137.92324d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3416000.0), new Promethium138() } },

        };
    }
}
    
    