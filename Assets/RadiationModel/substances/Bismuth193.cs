using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth193 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth193";
        public override double halfLife { get; } = 63.6d;
        public override double atomicWeight { get; } = 192.98295d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.965d, new List<RadioactiveSubstance> { new BetaParticle(1, 6344000.0), new Lead193() } },
            { 0.035d, new List<RadioactiveSubstance> { new AlphaParticle(7326047.4), new Thallium189() } },

        };
    }
}
    
    