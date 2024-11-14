using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium94n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium94n";
        public override double halfLife { get; } = 25.8d;
        public override double atomicWeight { get; } = 93.92205d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9974000.0), new Ruthenium94() } },

        };
    }
}
    
    