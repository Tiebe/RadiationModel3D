using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth194n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth194n";
        public override double halfLife { get; } = 115.0d;
        public override double atomicWeight { get; } = 193.98297d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8348000.0), new Lead194() } },
            { 0.002d, new List<RadioactiveSubstance> { new AlphaParticle(7101047.4), new Thallium190() } },

        };
    }
}
    
    