
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium74 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium74";
        public override double halfLife { get; } = 487.2d;
        public override double atomicWeight { get; } = 73.92695d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium74() } },

        };
    }
}
    
    