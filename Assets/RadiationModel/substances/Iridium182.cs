
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium182";
        public override double halfLife { get; } = 900.0d;
        public override double atomicWeight { get; } = 181.95808d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium182() } },

        };
    }
}
    
    