using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium27 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium27";
        public override double halfLife { get; } = 567.48d;
        public override double atomicWeight { get; } = 26.98434d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum27() }, { 1.0d, new BetaParticle(-1, 1305135.0) }, { 0.0086d, new GammaParticle(170820.0, 0.00726) }, { 0.718d, new GammaParticle(843760.0, 0.00147) }, { 0.282d, new GammaParticle(1014520.0, 0.00122) } } },

        };
    }
}
    