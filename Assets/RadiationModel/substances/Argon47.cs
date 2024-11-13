
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon47 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon47";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 46.97277d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Potassium47() } },

        };
    }
}
    
    