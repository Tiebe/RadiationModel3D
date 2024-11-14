using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium138";
        public override double halfLife { get; } = 1.46d;
        public override double atomicWeight { get; } = 137.92947d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6284000.0), new Iodine138() } },

        };
    }
}
    
    