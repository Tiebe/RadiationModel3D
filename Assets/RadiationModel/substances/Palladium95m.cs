
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium95m";
        public override double halfLife { get; } = 13.3d;
        public override double atomicWeight { get; } = 94.9269d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.89d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium95() } },

            { 0.11d, new List<RadioactiveSubstance> { new GammaParticle(), new Palladium95() } },

        };
    }
}
    
    