
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium170";
        public override double halfLife { get; } = 0.42d;
        public override double atomicWeight { get; } = 169.95615d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium170() } },

        };
    }
}
    
    