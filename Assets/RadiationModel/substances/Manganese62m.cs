
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese62m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese62m";
        public override double halfLife { get; } = 0.671d;
        public override double atomicWeight { get; } = 61.94828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron62() } },

        };
    }
}
    
    