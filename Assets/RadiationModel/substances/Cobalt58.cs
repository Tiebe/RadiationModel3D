using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt58 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt58";
        public override double halfLife { get; } = 6120921.6d;
        public override double atomicWeight { get; } = 57.93575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2308000.0), new Iron58() } },
            { 0.1479d, new List<RadioactiveSubstance> { new BetaParticle(1, 2308000.0), new Iron58() } },
            { 0.8521d, new List<RadioactiveSubstance> { new Iron58() } },

        };
    }
}
    
    