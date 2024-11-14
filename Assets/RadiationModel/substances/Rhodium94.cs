using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium94";
        public override double halfLife { get; } = 70.6d;
        public override double atomicWeight { get; } = 93.92173d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9676000.0), new Ruthenium94() } },

        };
    }
}
    
    