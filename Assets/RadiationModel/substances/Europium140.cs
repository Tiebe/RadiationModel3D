using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium140";
        public override double halfLife { get; } = 1.51d;
        public override double atomicWeight { get; } = 139.92808d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium140() }, { 1.0d, new BetaParticle(1, 5611000.0) }, { 0.00116d, new GammaParticle(352400.0, 0.00352) }, { 0.0319d, new GammaParticle(459900.0, 0.0027) }, { 0.29d, new GammaParticle(531000.0, 0.00233) }, { 0.00551d, new GammaParticle(608600.0, 0.00204) }, { 0.00261d, new GammaParticle(685100.0, 0.00181) }, { 0.0017399999999999998d, new GammaParticle(715400.0, 0.00173) }, { 0.00058d, new GammaParticle(882700.0, 0.0014) }, { 0.0319d, new GammaParticle(1068000.0, 0.00116) }, { 0.0058d, new GammaParticle(1097700.0, 0.00113) }, { 0.0034799999999999996d, new GammaParticle(1293600.0, 0.00096) }, { 0.0008699999999999999d, new GammaParticle(1299400.0, 0.00095) }, { 0.00261d, new GammaParticle(1402200.0, 0.00088) }, { 0.0034799999999999996d, new GammaParticle(1420300.0, 0.00087) }, { 0.00609d, new GammaParticle(1491300.0, 0.00083) }, { 0.00551d, new GammaParticle(1752800.0, 0.00071) }, { 0.00116d, new GammaParticle(1758700.0, 0.0007) }, { 0.00406d, new GammaParticle(1952000.0, 0.00064) }, { 0.00928d, new GammaParticle(2064900.0, 0.0006) }, { 0.00145d, new GammaParticle(2283900.0, 0.00054) }, { 0.00058d, new GammaParticle(2289100.0, 0.00054) }, { 1.8980000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.0071832972286590005d, new GammaParticle(6354.0, 0.19513) }, { 0.011946784737695382d, new GammaParticle(39522.0, 0.03137) }, { 0.021623139796733724d, new GammaParticle(40117.0, 0.03091) }, { 0.006759349669770184d, new GammaParticle(45523.0, 0.02724) }, { 0.008503261884570892d, new GammaParticle(45998.0, 0.02695) }, { 0.0017439122148007074d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    