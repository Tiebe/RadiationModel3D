using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth192m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth192m";
        public override double halfLife { get; } = 39.6d;
        public override double atomicWeight { get; } = 191.98562d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new BetaParticle(1, 9154000.0), new Lead192() } },
            { 0.1d, new List<RadioactiveSubstance> { new AlphaParticle(7535002.09), new Thallium188() } },

        };
    }
}
    
    