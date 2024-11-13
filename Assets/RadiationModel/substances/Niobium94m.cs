
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium94m";
        public override double halfLife { get; } = 375.78d;
        public override double atomicWeight { get; } = 93.90732d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.995d, new List<RadioactiveSubstance> { new GammaParticle(), new Niobium94() } },

            { 0.005d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum94() } },

        };
    }
}
    
    