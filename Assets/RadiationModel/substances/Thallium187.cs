
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium187";
        public override double halfLife { get; } = 51.0d;
        public override double atomicWeight { get; } = 186.9759d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury187() } },

        };
    }
}
    
    