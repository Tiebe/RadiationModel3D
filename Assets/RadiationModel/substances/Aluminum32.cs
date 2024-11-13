
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum32 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum32";
        public override double halfLife { get; } = 0.0326d;
        public override double atomicWeight { get; } = 31.98808d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon32() } },

        };
    }
}
    
    