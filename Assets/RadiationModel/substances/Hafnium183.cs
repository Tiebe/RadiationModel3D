using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium183";
        public override double halfLife { get; } = 3664.8d;
        public override double atomicWeight { get; } = 182.95354d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2013500.0), new Tantalum183() } },

        };
    }
}
    
    