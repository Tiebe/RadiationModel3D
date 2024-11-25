using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium84";
        public override double halfLife { get; } = 0.0952d;
        public override double atomicWeight { get; } = 83.95266d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium84() }, { 1.0d, new BetaParticle(-1, 7027000.0) } } },
            { 0.46d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium84() }, { 1.0d, new BetaParticle(-1, 7027000.0) } } },
            { 0.016d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium82() }, { 1.0d, new BetaParticle(-1, 942154653.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    