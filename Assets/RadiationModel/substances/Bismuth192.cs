using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth192 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth192";
        public override double halfLife { get; } = 34.6d;
        public override double atomicWeight { get; } = 191.98547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(1, 9022000.0), new Lead192() } },
            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(7403002.09), new Thallium188() } },

        };
    }
}
    
    