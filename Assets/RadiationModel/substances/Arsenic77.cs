using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic77 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic77";
        public override double halfLife { get; } = 139644.0d;
        public override double atomicWeight { get; } = 76.92065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 683200.0), new Selenium77() } },

        };
    }
}
    
    