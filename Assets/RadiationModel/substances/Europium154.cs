using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium154";
        public override double halfLife { get; } = 271137331.584d;
        public override double atomicWeight { get; } = 153.92299d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99982d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1968000.0), new Gadolinium154() } },
            { 0.00017999999999999998d, new List<RadioactiveSubstance> { new Samarium154() } },

        };
    }
}
    
    