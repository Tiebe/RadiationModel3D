
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine139 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine139";
        public override double halfLife { get; } = 2.28d;
        public override double atomicWeight { get; } = 138.92649d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon139() } },

        };
    }
}
    
    