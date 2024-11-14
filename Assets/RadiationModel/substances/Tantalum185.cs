using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum185 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum185";
        public override double halfLife { get; } = 2964.0d;
        public override double atomicWeight { get; } = 184.95556d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1993900.0), new Tungsten185() } },

        };
    }
}
    
    