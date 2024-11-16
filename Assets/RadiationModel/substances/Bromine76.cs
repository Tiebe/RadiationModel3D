using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine76 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine76";
        public override double halfLife { get; } = 58320.0d;
        public override double atomicWeight { get; } = 75.92454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4962959.0), new Selenium76() } },

        };
    }
}
    
    