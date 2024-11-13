
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum132 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum132";
        public override double halfLife { get; } = 16524.0d;
        public override double atomicWeight { get; } = 131.91012d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium132() } },

        };
    }
}
    
    