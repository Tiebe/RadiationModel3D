using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium114";
        public override double halfLife { get; } = 71.9d;
        public override double atomicWeight { get; } = 113.90492d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1989935.0), new Tin114() } },
            { 0.005d, new List<RadioactiveSubstance> { new BetaParticle(1, 1445130.0), new Cadmium114() } },

        };
    }
}
    
    