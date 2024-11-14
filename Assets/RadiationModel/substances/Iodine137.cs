using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine137 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine137";
        public override double halfLife { get; } = 24.13d;
        public override double atomicWeight { get; } = 136.91803d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6027410.0), new Xenon137() } },

        };
    }
}
    
    