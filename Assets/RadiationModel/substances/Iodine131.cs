
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine131 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine131";
        public override double halfLife { get; } = 693351.36d;
        public override double atomicWeight { get; } = 130.90613d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon131() } },

        };
    }
}
    
    