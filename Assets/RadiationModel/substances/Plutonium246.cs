using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium246";
        public override double halfLife { get; } = 936576.0d;
        public override double atomicWeight { get; } = 246.0702d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium246() }, { 1.0d, new BetaParticle(-1, 200500.0) }, { 0.03525d, new GammaParticle(27580.0, 0.04495) }, { 0.25d, new GammaParticle(43810.0, 0.0283) }, { 0.00255d, new GammaParticle(66600.0, 0.01862) }, { 0.0018d, new GammaParticle(75640.0, 0.01639) }, { 0.000575d, new GammaParticle(149420.0, 0.0083) }, { 0.00035000000000000005d, new GammaParticle(158420.0, 0.00783) }, { 0.09699999999999999d, new GammaParticle(179940.0, 0.00689) }, { 0.000475d, new GammaParticle(189000.0, 0.00656) }, { 0.0011250000000000001d, new GammaParticle(216550.0, 0.00573) }, { 0.235d, new GammaParticle(223750.0, 0.00554) }, { 0.0008d, new GammaParticle(232750.0, 0.00533) }, { 0.0023d, new GammaParticle(255540.0, 0.00485) }, { 0.0003d, new GammaParticle(299340.0, 0.00414) }, { 0.41723125021999996d, new GammaParticle(18078.0, 0.06858) }, { 0.12723928508756813d, new GammaParticle(102031.0, 0.01215) }, { 0.2003137359690934d, new GammaParticle(106468.0, 0.01165) }, { 0.07424535143950993d, new GammaParticle(120157.0, 0.01032) }, { 0.10023122444333842d, new GammaParticle(121688.0, 0.01019) }, { 0.025985873003828475d, new GammaParticle(123677.0, 0.01002) } } },

        };
    }
}
    