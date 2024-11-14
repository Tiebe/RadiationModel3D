using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth211 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth211";
        public override double halfLife { get; } = 128.4d;
        public override double atomicWeight { get; } = 210.98727d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7770047.4), new Thallium207() } },
            { 0.0027600000000000003d, new List<RadioactiveSubstance> { new BetaParticle(-1, 573500.0), new Polonium211() } },

        };
    }
}
    
    