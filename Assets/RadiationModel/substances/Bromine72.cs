using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine72 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine72";
        public override double halfLife { get; } = 78.6d;
        public override double atomicWeight { get; } = 71.93659d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8806400.0), new Selenium72() } },

        };
    }
}
    
    