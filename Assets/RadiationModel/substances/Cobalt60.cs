using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt60 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt60";
        public override double halfLife { get; } = 166344192.0d;
        public override double atomicWeight { get; } = 59.93382d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel60() }, { 1.0d, new BetaParticle(-1, 1411400.0) }, { 7.5e-05d, new GammaParticle(347140.0, 0.00357) }, { 7.6e-05d, new GammaParticle(826100.0, 0.0015) }, { 0.9984999999999999d, new GammaParticle(1173228.0, 0.00106) }, { 0.9998260000000001d, new GammaParticle(1332492.0, 0.00093) }, { 1.1999999999999999e-05d, new GammaParticle(2158570.0, 0.00057) }, { 2e-08d, new GammaParticle(2505692.0, 0.00049) }, { 3.2925827471659586e-06d, new GammaParticle(874.0, 1.41858) }, { 3.30765880354868e-05d, new GammaParticle(7461.0, 0.16618) }, { 6.455227953842076e-05d, new GammaParticle(7478.0, 0.1658) }, { 1.3453257951684462e-05d, new GammaParticle(8296.0, 0.14945) }, { 1.3453257951684462e-05d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    