using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine121 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine121";
        public override double halfLife { get; } = 7632.0d;
        public override double atomicWeight { get; } = 120.90741d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2297000.0), new Tellurium121() } },

        };
    }
}
    
    