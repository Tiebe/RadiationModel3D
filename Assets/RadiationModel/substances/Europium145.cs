using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium145";
        public override double halfLife { get; } = 512352.0d;
        public override double atomicWeight { get; } = 144.91627d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2659400.0), new Samarium145() } },

        };
    }
}
    
    