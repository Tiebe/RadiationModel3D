
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium160";
        public override double halfLife { get; } = 1536.0d;
        public override double atomicWeight { get; } = 159.92874d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium160() } },

        };
    }
}
    
    