using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten168 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten168";
        public override double halfLife { get; } = 50.9d;
        public override double atomicWeight { get; } = 167.95181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3501000.0), new Tantalum168() } },
            { 3.2e-05d, new List<RadioactiveSubstance> { new AlphaParticle(5522002.09), new Hafnium164() } },

        };
    }
}
    
    