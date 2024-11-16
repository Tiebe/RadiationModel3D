using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium163";
        public override double halfLife { get; } = 6516.0d;
        public override double atomicWeight { get; } = 162.93266d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2439000.0), new Erbium163() } },

        };
    }
}
    
    