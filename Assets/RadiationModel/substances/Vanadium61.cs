using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium61";
        public override double halfLife { get; } = 0.0483d;
        public override double atomicWeight { get; } = 60.9676d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium61() }, { 1.0d, new BetaParticle(-1, 6158250.0) }, { 0.09300000000000001d, new GammaParticle(70800.0, 0.01751) }, { 0.249d, new GammaParticle(97700.0, 0.01269) }, { 0.081d, new GammaParticle(126700.0, 0.00979) }, { 0.017d, new GammaParticle(331000.0, 0.00375) }, { 0.012d, new GammaParticle(353600.0, 0.00351) }, { 0.017d, new GammaParticle(407600.0, 0.00304) }, { 0.045d, new GammaParticle(450500.0, 0.00275) }, { 0.015d, new GammaParticle(467000.0, 0.00265) }, { 0.006999999999999999d, new GammaParticle(576700.0, 0.00215) }, { 0.01d, new GammaParticle(645000.0, 0.00192) }, { 0.009000000000000001d, new GammaParticle(676400.0, 0.00183) }, { 0.051d, new GammaParticle(715900.0, 0.00173) }, { 0.023d, new GammaParticle(773700.0, 0.0016) }, { 0.037000000000000005d, new GammaParticle(929400.0, 0.00133) }, { 0.047d, new GammaParticle(1026300.0, 0.00121) }, { 0.013999999999999999d, new GammaParticle(1151200.0, 0.00108) }, { 0.022000000000000002d, new GammaParticle(1964500.0, 0.00063) }, { 0.025d, new GammaParticle(2164000.0, 0.00057) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium61() }, { 1.0d, new BetaParticle(-1, 6158250.0) }, { 0.09300000000000001d, new GammaParticle(70800.0, 0.01751) }, { 0.249d, new GammaParticle(97700.0, 0.01269) }, { 0.081d, new GammaParticle(126700.0, 0.00979) }, { 0.017d, new GammaParticle(331000.0, 0.00375) }, { 0.012d, new GammaParticle(353600.0, 0.00351) }, { 0.017d, new GammaParticle(407600.0, 0.00304) }, { 0.045d, new GammaParticle(450500.0, 0.00275) }, { 0.015d, new GammaParticle(467000.0, 0.00265) }, { 0.006999999999999999d, new GammaParticle(576700.0, 0.00215) }, { 0.01d, new GammaParticle(645000.0, 0.00192) }, { 0.009000000000000001d, new GammaParticle(676400.0, 0.00183) }, { 0.051d, new GammaParticle(715900.0, 0.00173) }, { 0.023d, new GammaParticle(773700.0, 0.0016) }, { 0.037000000000000005d, new GammaParticle(929400.0, 0.00133) }, { 0.047d, new GammaParticle(1026300.0, 0.00121) }, { 0.013999999999999999d, new GammaParticle(1151200.0, 0.00108) }, { 0.022000000000000002d, new GammaParticle(1964500.0, 0.00063) }, { 0.025d, new GammaParticle(2164000.0, 0.00057) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    