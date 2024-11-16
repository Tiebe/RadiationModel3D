using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine123 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine123";
        public override double halfLife { get; } = 47603.52d;
        public override double atomicWeight { get; } = 122.90559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1228000.0), new Tellurium123() } },

        };
    }
}
    
    