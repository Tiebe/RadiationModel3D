using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon9 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon9";
        public override double halfLife { get; } = 0.1265d;
        public override double atomicWeight { get; } = 9.03104d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium9() }, { 1.0d, new BetaParticle(1, 8781275.0) }, { 1.9274d, new GammaParticle(511000.0, 0.00243) } } },
            { 0.62d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium8() }, { 1.0d, new BetaParticle(1, 477731716.736) }, { 1.0d, new ProtonParticle() } } },
            { 0.379d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron9() }, { 1.0d, new BetaParticle(1, 8247250.0) } } },

        };
    }
}
    