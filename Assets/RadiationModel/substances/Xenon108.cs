using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon108 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon108";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 107.95423d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5595047.4), new Tellurium104() } },

        };
    }
}
    
    