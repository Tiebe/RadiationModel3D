using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine133 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine133";
        public override double halfLife { get; } = 74988.0d;
        public override double atomicWeight { get; } = 132.90783d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1786600.0), new Xenon133() } },

        };
    }
}
    
    