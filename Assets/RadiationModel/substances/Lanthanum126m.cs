
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum126m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum126m";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 125.91974d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium126() } },

        };
    }
}
    
    