using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium96";
        public override double halfLife { get; } = 0.2015d;
        public override double atomicWeight { get; } = 95.93413d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11564000.0), new Strontium96() } },

        };
    }
}
    
    