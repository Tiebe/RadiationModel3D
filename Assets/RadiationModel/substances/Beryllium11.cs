using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium11 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium11";
        public override double halfLife { get; } = 13.76d;
        public override double atomicWeight { get; } = 11.02166d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron11() }, { 1.0d, new BetaParticle(-1, 5754731.0) } } },
            { 0.031d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron11() }, { 1.0d, new BetaParticle(-1, 5754731.0) } } },
            { 8.3e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron11() }, { 1.0d, new BetaParticle(-1, 5754731.0) } } },

        };
    }
}
    