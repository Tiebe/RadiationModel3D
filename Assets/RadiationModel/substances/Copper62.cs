using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper62 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper62";
        public override double halfLife { get; } = 580.2d;
        public override double atomicWeight { get; } = 61.93259d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt62() }, { 1.0d, new BetaParticle(1, -681750.0) }, { 2.394e-06d, new GammaParticle(479600.0, 0.00259) }, { 1.3679999999999999e-06d, new GammaParticle(856200.0, 0.00145) }, { 0.0014705999999999999d, new GammaParticle(875660.0, 0.00142) }, { 3.078e-06d, new GammaParticle(968900.0, 0.00128) }, { 1.026e-06d, new GammaParticle(971000.0, 0.00128) }, { 6.4979999999999994e-06d, new GammaParticle(1067000.0, 0.00116) }, { 0.00031806d, new GammaParticle(1128820.0, 0.0011) }, { 0.0034200000000000003d, new GammaParticle(1172970.0, 0.00106) }, { 1.026e-05d, new GammaParticle(1321600.0, 0.00094) }, { 2.7702e-05d, new GammaParticle(1717600.0, 0.00072) }, { 1.026e-05d, new GammaParticle(1985000.0, 0.00062) }, { 4.7879999999999996e-05d, new GammaParticle(2084800.0, 0.00059) }, { 2.8728e-05d, new GammaParticle(2097600.0, 0.00059) }, { 0.00042066d, new GammaParticle(2301950.0, 0.00054) }, { 6.156e-06d, new GammaParticle(3158200.0, 0.00039) }, { 1.4364e-06d, new GammaParticle(3257300.0, 0.00038) }, { 7.182e-06d, new GammaParticle(3271400.0, 0.00038) }, { 8.413199999999999e-05d, new GammaParticle(3370300.0, 0.00037) }, { 2.7359999999999997e-06d, new GammaParticle(3861700.0, 0.00032) }, { 1.95664d, new GammaParticle(511000.0, 0.00243) }, { 0.00024181062582102032d, new GammaParticle(874.0, 1.41858) }, { 0.0024118510336040067d, new GammaParticle(7461.0, 0.16618) }, { 0.004706969230296656d, new GammaParticle(7478.0, 0.1658) }, { 0.0009809734323655112d, new GammaParticle(8296.0, 0.14945) }, { 0.0009809734323655112d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    