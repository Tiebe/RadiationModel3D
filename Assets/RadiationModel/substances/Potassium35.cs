
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium35";
        public override double halfLife { get; } = 0.1752d;
        public override double atomicWeight { get; } = 34.98801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Argon35() } },

        };
    }
}
    
    