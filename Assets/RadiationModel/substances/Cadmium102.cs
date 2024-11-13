
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium102";
        public override double halfLife { get; } = 330.0d;
        public override double atomicWeight { get; } = 101.91448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver102() } },

        };
    }
}
    
    