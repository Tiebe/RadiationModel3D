using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium89";
        public override double halfLife { get; } = 0.43d;
        public override double atomicWeight { get; } = 88.93667d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9282000.0), new Bromine89() } },

        };
    }
}
    
    