
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium170";
        public override double halfLife { get; } = 165.6d;
        public override double atomicWeight { get; } = 169.93962d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium170() } },

        };
    }
}
    
    