
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium70 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium70";
        public override double halfLife { get; } = 1268.4d;
        public override double atomicWeight { get; } = 69.92602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9959d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium70() } },

            { 0.0040999999999999995d, new List<RadioactiveSubstance> { new Zinc70() } },

        };
    }
}
    
    