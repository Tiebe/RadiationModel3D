
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum146m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum146m";
        public override double halfLife { get; } = 6.08d;
        public override double atomicWeight { get; } = 145.92584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium146() } },

        };
    }
}
    
    