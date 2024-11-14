using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine141 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine141";
        public override double halfLife { get; } = 0.42d;
        public override double atomicWeight { get; } = 140.93567d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8270299.999999999), new Xenon141() } },

        };
    }
}
    
    