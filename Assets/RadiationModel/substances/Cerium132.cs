
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium132";
        public override double halfLife { get; } = 12636.0d;
        public override double atomicWeight { get; } = 131.91147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum132() } },

        };
    }
}
    
    