
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium185 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium185";
        public override double halfLife { get; } = 19.5d;
        public override double atomicWeight { get; } = 184.97879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury185() } },

        };
    }
}
    
    