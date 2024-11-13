
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine43 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine43";
        public override double halfLife { get; } = 3.13d;
        public override double atomicWeight { get; } = 42.97406d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Argon43() } },

        };
    }
}
    
    