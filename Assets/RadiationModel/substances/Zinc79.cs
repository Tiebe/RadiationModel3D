
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc79 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc79";
        public override double halfLife { get; } = 0.746d;
        public override double atomicWeight { get; } = 78.94264d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium79() } },

        };
    }
}
    
    