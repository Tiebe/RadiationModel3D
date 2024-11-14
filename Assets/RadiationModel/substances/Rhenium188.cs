using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium188 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium188";
        public override double halfLife { get; } = 61218.0d;
        public override double atomicWeight { get; } = 187.95811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2120400.0), new Osmium188() } },

        };
    }
}
    
    