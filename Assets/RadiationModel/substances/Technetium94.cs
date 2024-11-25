using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium94";
        public override double halfLife { get; } = 17580.0d;
        public override double atomicWeight { get; } = 93.90965d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium94() }, { 1.0d, new BetaParticle(1, 1105550.0) }, { 0.0048951d, new GammaParticle(83000.0, 0.01494) }, { 0.032966999999999996d, new GammaParticle(449200.0, 0.00276) }, { 0.023476499999999997d, new GammaParticle(532100.0, 0.00233) }, { 0.9960030000000001d, new GammaParticle(702670.0, 0.00176) }, { 0.0120879d, new GammaParticle(742300.0, 0.00167) }, { 0.957042d, new GammaParticle(849740.0, 0.00146) }, { 0.9990000000000001d, new GammaParticle(871050.0, 0.00142) }, { 0.07592399999999999d, new GammaParticle(916100.0, 0.00135) }, { 0.0067932d, new GammaParticle(1509300.0, 0.00082) }, { 0.022477499999999997d, new GammaParticle(1592100.0, 0.00078) }, { 0.0028971d, new GammaParticle(1765600.0, 0.0007) }, { 0.21047999999999997d, new GammaParticle(511000.0, 0.00243) }, { 0.03410002680977535d, new GammaParticle(2440.0, 0.50813) }, { 0.17103883495373812d, new GammaParticle(17374.0, 0.07136) }, { 0.32597452821371853d, new GammaParticle(17479.0, 0.07093) }, { 0.08553453546365414d, new GammaParticle(19681.0, 0.063) }, { 0.09870685392505689d, new GammaParticle(19794.0, 0.06264) }, { 0.013172318461402736d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    