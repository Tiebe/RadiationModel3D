using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead189m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead189m";
        public override double halfLife { get; } = 50.5d;
        public override double atomicWeight { get; } = 188.98089d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6812000.0), new Thallium189() } },
            { 0.004d, new List<RadioactiveSubstance> { new AlphaParticle(6975047.4), new Mercury185() } },

        };
    }
}
    
    