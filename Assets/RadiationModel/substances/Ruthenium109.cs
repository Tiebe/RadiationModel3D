using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium109";
        public override double halfLife { get; } = 34.4d;
        public override double atomicWeight { get; } = 108.91332d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4261000.0), new Rhodium109() } },

        };
    }
}
    
    