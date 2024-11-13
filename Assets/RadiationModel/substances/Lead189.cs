
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead189 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead189";
        public override double halfLife { get; } = 39.0d;
        public override double atomicWeight { get; } = 188.98084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9958d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium189() } },

            { 0.0042d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mercury185() } },

        };
    }
}
    
    