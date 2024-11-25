using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon20 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon20";
        public override double halfLife { get; } = 0.0163d;
        public override double atomicWeight { get; } = 20.04026d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen20() }, { 1.0d, new BetaParticle(-1, 7865000.0) } } },
            { 0.65d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen20() }, { 1.0d, new BetaParticle(-1, 7865000.0) } } },
            { 0.18600000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen18() }, { 1.0d, new BetaParticle(-1, 943687603.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    