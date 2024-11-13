
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead187 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead187";
        public override double halfLife { get; } = 15.2d;
        public override double atomicWeight { get; } = 186.98391d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.905d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium187() } },

            { 0.095d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mercury183() } },

        };
    }
}
    
    