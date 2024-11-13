
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium85";
        public override double halfLife { get; } = 0.0953d;
        public override double atomicWeight { get; } = 84.95734d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium85() } },

        };
    }
}
    
    