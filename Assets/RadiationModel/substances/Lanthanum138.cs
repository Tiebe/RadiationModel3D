using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum138 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum138";
        public override double halfLife { get; } = 3.250366056e+18d;
        public override double atomicWeight { get; } = 137.90712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.655d, new List<RadioactiveSubstance> { new BetaParticle(1, 1748410.0), new Barium138() } },
            { 0.345d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1052500.0), new Cerium138() } },

        };
    }
}
    
    