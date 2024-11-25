using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon38 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon38";
        public override double halfLife { get; } = 0.063d;
        public override double atomicWeight { get; } = 37.99552d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus38() }, { 1.0d, new BetaParticle(-1, 5225000.0) }, { 0.07139999999999999d, new GammaParticle(1120000.0, 0.00111) }, { 0.1734d, new GammaParticle(1694000.0, 0.00073) }, { 0.51d, new GammaParticle(1874000.0, 0.00066) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus38() }, { 1.0d, new BetaParticle(-1, 5225000.0) }, { 0.07139999999999999d, new GammaParticle(1120000.0, 0.00111) }, { 0.1734d, new GammaParticle(1694000.0, 0.00073) }, { 0.51d, new GammaParticle(1874000.0, 0.00066) } } },

        };
    }
}
    