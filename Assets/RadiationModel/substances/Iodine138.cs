using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine138 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine138";
        public override double halfLife { get; } = 6.26d;
        public override double atomicWeight { get; } = 137.92273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7992200.0), new Xenon138() } },

        };
    }
}
    
    