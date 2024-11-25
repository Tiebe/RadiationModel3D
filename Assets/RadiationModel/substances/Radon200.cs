using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon200 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon200";
        public override double halfLife { get; } = 1.03d;
        public override double atomicWeight { get; } = 199.99571d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium196() }, { 1.0d, new AlphaParticle(8066002.09) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium200() }, { 1.0d, new BetaParticle(1, 6471000.0) } } },

        };
    }
}
    