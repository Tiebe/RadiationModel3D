using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium75";
        public override double halfLife { get; } = 126.0d;
        public override double atomicWeight { get; } = 74.9265d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium75() }, { 1.0d, new BetaParticle(-1, 1698185.0) } } },

        };
    }
}
    