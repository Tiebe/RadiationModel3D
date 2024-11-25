using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon19 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon19";
        public override double halfLife { get; } = 0.0463d;
        public override double atomicWeight { get; } = 19.03479d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen19() }, { 1.0d, new BetaParticle(-1, 8277000.0) } } },
            { 0.47d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen19() }, { 1.0d, new BetaParticle(-1, 8277000.0) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen17() }, { 1.0d, new BetaParticle(-1, 943764103.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    