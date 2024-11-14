using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium115";
        public override double halfLife { get; } = 0.318d;
        public override double atomicWeight { get; } = 114.92903d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8124000.0), new Rhodium115() } },

        };
    }
}
    
    