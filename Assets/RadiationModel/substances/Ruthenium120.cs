using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium120";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 119.94662d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8900000.0), new Rhodium120() } },

        };
    }
}
    
    