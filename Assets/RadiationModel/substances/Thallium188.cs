using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium188 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium188";
        public override double halfLife { get; } = 71.0d;
        public override double atomicWeight { get; } = 187.97602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7862000.0), new Mercury188() } },

        };
    }
}
    
    