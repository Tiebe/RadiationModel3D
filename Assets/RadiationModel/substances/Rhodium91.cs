using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium91";
        public override double halfLife { get; } = 1.47d;
        public override double atomicWeight { get; } = 90.93712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9669800.0), new Ruthenium91() } },

        };
    }
}
    
    