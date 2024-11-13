
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium138";
        public override double halfLife { get; } = 194.4d;
        public override double atomicWeight { get; } = 137.91958d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium138() } },

        };
    }
}
    
    