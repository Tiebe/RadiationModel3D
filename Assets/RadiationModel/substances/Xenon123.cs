using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon123 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon123";
        public override double halfLife { get; } = 7488.0d;
        public override double atomicWeight { get; } = 122.90848d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2695000.0), new Iodine123() } },

        };
    }
}
    
    