using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium118m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium118m";
        public override double halfLife { get; } = 0.31d;
        public override double atomicWeight { get; } = 117.93055d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10698400.0), new Palladium118() } },

        };
    }
}
    
    