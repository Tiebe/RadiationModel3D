
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese54 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese54";
        public override double halfLife { get; } = 26963798.4d;
        public override double atomicWeight { get; } = 53.94036d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Chromium54() } },

            { 9.3e-07d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron54() } },

            { 1.2800000000000001e-09d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium54() } },

        };
    }
}
    
    