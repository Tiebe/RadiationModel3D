
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium90m";
        public override double halfLife { get; } = 0.56d;
        public override double atomicWeight { get; } = 89.94457d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium90() } },

        };
    }
}
    
    