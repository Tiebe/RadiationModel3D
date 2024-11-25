using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt62 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt62";
        public override double halfLife { get; } = 92.4d;
        public override double atomicWeight { get; } = 61.93406d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel62() }, { 1.0d, new BetaParticle(-1, 2661200.0) }, { 0.106496d, new GammaParticle(1128900.0, 0.0011) }, { 0.8320000000000001d, new GammaParticle(1172900.0, 0.00106) }, { 0.00416d, new GammaParticle(1886300.0, 0.00066) }, { 0.017472d, new GammaParticle(1985100.0, 0.00062) }, { 0.003328d, new GammaParticle(2083000.0, 0.0006) }, { 0.009152d, new GammaParticle(2097000.0, 0.00059) }, { 0.147264d, new GammaParticle(2301900.0, 0.00054) }, { 0.013312d, new GammaParticle(2345800.0, 0.00053) }, { 0.00832d, new GammaParticle(3158000.0, 0.00039) }, { 0.002912d, new GammaParticle(3271100.0, 0.00038) }, { 0.003744d, new GammaParticle(3370000.0, 0.00037) }, { 0.000832d, new GammaParticle(3519000.0, 0.00035) }, { 0.003328d, new GammaParticle(4063000.0, 0.00031) }, { 1.86594074913792e-06d, new GammaParticle(874.0, 1.41858) }, { 1.874409948782166e-05d, new GammaParticle(7461.0, 0.16618) }, { 3.658099041339122e-05d, new GammaParticle(7478.0, 0.1658) }, { 7.623797388387134e-06d, new GammaParticle(8296.0, 0.14945) }, { 7.623797388387134e-06d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    