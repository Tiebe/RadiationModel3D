using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium151";
        public override double halfLife { get; } = 23.5d;
        public override double atomicWeight { get; } = 150.93745d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium151() }, { 1.0d, new BetaParticle(1, 5243000.0) }, { 0.08856d, new GammaParticle(100100.0, 0.01239) }, { 0.010496d, new GammaParticle(230700.0, 0.00537) }, { 0.17056000000000002d, new GammaParticle(256500.0, 0.00483) }, { 0.021320000000000002d, new GammaParticle(302400.0, 0.0041) }, { 0.019024d, new GammaParticle(455000.0, 0.00272) }, { 0.016072d, new GammaParticle(462000.0, 0.00268) }, { 0.017384d, new GammaParticle(537000.0, 0.00231) }, { 0.056416d, new GammaParticle(553000.0, 0.00224) }, { 0.041328d, new GammaParticle(558800.0, 0.00222) }, { 0.32799999999999996d, new GammaParticle(638300.0, 0.00194) }, { 0.05576d, new GammaParticle(641500.0, 0.00193) }, { 0.16728d, new GammaParticle(667200.0, 0.00186) }, { 0.047232d, new GammaParticle(694400.0, 0.00179) }, { 0.032144d, new GammaParticle(720600.0, 0.00172) }, { 0.041328d, new GammaParticle(739500.0, 0.00168) }, { 0.026896d, new GammaParticle(768900.0, 0.00161) }, { 0.043624d, new GammaParticle(860500.0, 0.00144) }, { 0.10824d, new GammaParticle(868900.0, 0.00143) }, { 0.01968d, new GammaParticle(874400.0, 0.00142) }, { 0.029192d, new GammaParticle(898000.0, 0.00138) }, { 0.041984d, new GammaParticle(987900.0, 0.00126) }, { 0.052808d, new GammaParticle(992000.0, 0.00125) }, { 0.008199999999999999d, new GammaParticle(1061000.0, 0.00117) }, { 0.011808d, new GammaParticle(1073000.0, 0.00116) }, { 0.058384d, new GammaParticle(1194500.0, 0.00104) }, { 0.058056d, new GammaParticle(1435200.0, 0.00086) }, { 0.031816d, new GammaParticle(1549300.0, 0.0008) }, { 0.03608d, new GammaParticle(1935100.0, 0.00064) }, { 0.01312d, new GammaParticle(2133700.0, 0.00058) }, { 1.088d, new GammaParticle(511000.0, 0.00243) }, { 0.124d, new GammaParticle(7656.0, 0.16194) }, { 0.162d, new GammaParticle(46700.0, 0.02655) }, { 0.289d, new GammaParticle(47547.0, 0.02608) }, { 0.09300000000000001d, new GammaParticle(53982.0, 0.02297) }, { 0.11800000000000001d, new GammaParticle(54577.0, 0.02272) }, { 0.024300000000000002d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    