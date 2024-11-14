using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel68 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel68";
        public override double halfLife { get; } = 29.0d;
        public override double atomicWeight { get; } = 67.93187d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2103200.0), new Copper68() } },

        };
    }
}
    
    