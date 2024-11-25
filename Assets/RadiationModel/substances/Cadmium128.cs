using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium128";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 127.92782d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium128() }, { 1.0d, new BetaParticle(-1, 3476050.0) }, { 0.2888d, new GammaParticle(68020.0, 0.01823) }, { 0.76d, new GammaParticle(247920.0, 0.005) }, { 0.03648d, new GammaParticle(462700.0, 0.00268) }, { 0.02964d, new GammaParticle(462700.0, 0.00268) }, { 0.722d, new GammaParticle(857050.0, 0.00145) }, { 0.09423999999999999d, new GammaParticle(925000.0, 0.00134) }, { 0.08208d, new GammaParticle(1172400.0, 0.00106) }, { 0.03990219894144d, new GammaParticle(3571.0, 0.3472) }, { 0.12937404728919377d, new GammaParticle(24001.0, 0.05166) }, { 0.2427280436945474d, new GammaParticle(24209.0, 0.05121) }, { 0.06810406337500742d, new GammaParticle(27367.0, 0.0453) }, { 0.08104383541625883d, new GammaParticle(27581.0, 0.04495) }, { 0.012939772041251409d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    