using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine70 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine70";
        public override double halfLife { get; } = 0.0788d;
        public override double atomicWeight { get; } = 69.94479d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10503900.0), new Selenium70() } },

        };
    }
}
    
    