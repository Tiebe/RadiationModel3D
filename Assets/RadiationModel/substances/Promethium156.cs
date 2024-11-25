using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium156";
        public override double halfLife { get; } = 26.7d;
        public override double atomicWeight { get; } = 155.93111d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium156() }, { 1.0d, new BetaParticle(-1, 2597099.99999) }, { 0.125d, new GammaParticle(75880.0, 0.01634) }, { 0.138d, new GammaParticle(117420.0, 0.01056) }, { 0.52d, new GammaParticle(173750.0, 0.00714) }, { 0.01d, new GammaParticle(223310.0, 0.00555) }, { 0.133d, new GammaParticle(267320.0, 0.00464) }, { 0.006d, new GammaParticle(370940.0, 0.00334) }, { 0.009000000000000001d, new GammaParticle(376750.0, 0.00329) }, { 0.006d, new GammaParticle(380400.0, 0.00326) }, { 0.003d, new GammaParticle(494400.0, 0.00251) }, { 0.003d, new GammaParticle(503370.0, 0.00246) }, { 0.009000000000000001d, new GammaParticle(518400.0, 0.00239) }, { 0.01d, new GammaParticle(524900.0, 0.00236) }, { 0.006d, new GammaParticle(625270.0, 0.00198) }, { 0.006d, new GammaParticle(626370.0, 0.00198) }, { 0.021d, new GammaParticle(684650.0, 0.00181) }, { 0.055999999999999994d, new GammaParticle(690900.0, 0.00179) }, { 0.009000000000000001d, new GammaParticle(727600.0, 0.0017) }, { 0.021d, new GammaParticle(750260.0, 0.00165) }, { 0.021d, new GammaParticle(756510.0, 0.00164) }, { 0.026000000000000002d, new GammaParticle(770770.0, 0.00161) }, { 0.036000000000000004d, new GammaParticle(799700.0, 0.00155) }, { 0.011000000000000001d, new GammaParticle(803900.0, 0.00154) }, { 0.006d, new GammaParticle(827030.0, 0.0015) }, { 0.012d, new GammaParticle(832080.0, 0.00149) }, { 0.011000000000000001d, new GammaParticle(860260.0, 0.00144) }, { 0.10400000000000001d, new GammaParticle(880390.0, 0.00141) }, { 0.084d, new GammaParticle(894350.0, 0.00139) }, { 0.12300000000000001d, new GammaParticle(934000.0, 0.00133) }, { 0.003d, new GammaParticle(992000.0, 0.00125) }, { 0.013999999999999999d, new GammaParticle(1034250.0, 0.0012) }, { 0.205d, new GammaParticle(1147840.0, 0.00108) }, { 0.126d, new GammaParticle(1259440.0, 0.00098) }, { 0.018000000000000002d, new GammaParticle(1360560.0, 0.00091) }, { 0.023d, new GammaParticle(1374910.0, 0.0009) }, { 0.057d, new GammaParticle(1382240.0, 0.0009) }, { 0.006d, new GammaParticle(1416600.0, 0.00088) }, { 0.084d, new GammaParticle(1433700.0, 0.00086) }, { 0.005d, new GammaParticle(1473600.0, 0.00084) }, { 0.027999999999999997d, new GammaParticle(1509120.0, 0.00082) }, { 0.07400000000000001d, new GammaParticle(1516560.0, 0.00082) }, { 0.004d, new GammaParticle(1555600.0, 0.0008) }, { 0.006999999999999999d, new GammaParticle(2269900.0, 0.00055) }, { 0.006999999999999999d, new GammaParticle(2276180.0, 0.00054) }, { 0.01d, new GammaParticle(2360000.0, 0.00053) }, { 0.008d, new GammaParticle(2366780.0, 0.00052) }, { 0.01d, new GammaParticle(2406700.0, 0.00052) }, { 0.024d, new GammaParticle(2443340.0, 0.00051) }, { 0.027000000000000003d, new GammaParticle(2450170.0, 0.00051) }, { 0.1476938955464d, new GammaParticle(6354.0, 0.19513) }, { 0.14511510081327325d, new GammaParticle(39522.0, 0.03137) }, { 0.2626517661778701d, new GammaParticle(40117.0, 0.03091) }, { 0.08210440970497347d, new GammaParticle(45523.0, 0.02724) }, { 0.10328734740885662d, new GammaParticle(45998.0, 0.02695) }, { 0.021182937703883152d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    