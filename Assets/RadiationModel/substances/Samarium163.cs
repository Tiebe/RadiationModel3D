using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium163";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 162.94568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5973800.0), new Europium163() } },

        };
    }
}
    
    