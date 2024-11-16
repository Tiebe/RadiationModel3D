using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium226";
        public override double halfLife { get; } = 108.0d;
        public override double atomicWeight { get; } = 226.02795d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.74d, new List<RadioactiveSubstance> { new AlphaParticle(8009002.09), new Actinium222() } },
            { 0.26d, new List<RadioactiveSubstance> { new BetaParticle(1, 2836000.0), new Thorium226() } },

        };
    }
}
    
    