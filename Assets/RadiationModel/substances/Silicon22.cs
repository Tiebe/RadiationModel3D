using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon22 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon22";
        public override double halfLife { get; } = 0.029d;
        public override double atomicWeight { get; } = 22.03611d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium22() }, { 1.0d, new BetaParticle(1, 17019995.0) }, { 0.56d, new GammaParticle(511000.0, 0.00243) } } },
            { 0.32d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium21() }, { 1.0d, new BetaParticle(1, 477115101.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    