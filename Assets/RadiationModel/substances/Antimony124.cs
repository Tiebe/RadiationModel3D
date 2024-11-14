using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony124 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony124";
        public override double halfLife { get; } = 5201280.0d;
        public override double atomicWeight { get; } = 123.90594d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2905000.0), new Tellurium124() } },

        };
    }
}
    
    