using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon22 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon22";
        public override double halfLife { get; } = 0.0061d;
        public override double atomicWeight { get; } = 22.05755d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen22() }, { 1.0d, new BetaParticle(-1, 10925000.0) } } },
            { 0.61d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen22() }, { 1.0d, new BetaParticle(-1, 10925000.0) } } },
            { 0.37d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen20() }, { 1.0d, new BetaParticle(-1, 947414103.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    