using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium48";
        public override double halfLife { get; } = 1380153.6d;
        public override double atomicWeight { get; } = 47.95225d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium48() }, { 1.0d, new BetaParticle(1, 13000.0) }, { 0.0013597280000000002d, new GammaParticle(803050.0, 0.00154) }, { 0.007828434d, new GammaParticle(928326.0, 0.00134) }, { 1.39972e-06d, new GammaParticle(938000.0, 0.00132) }, { 0.078704256d, new GammaParticle(944129.0, 0.00131) }, { 0.9998d, new GammaParticle(983525.0, 0.00126) }, { 4.999e-05d, new GammaParticle(1063900.0, 0.00117) }, { 0.9818035999999999d, new GammaParticle(1312105.0, 0.00094) }, { 0.00119976d, new GammaParticle(1437521.0, 0.00086) }, { 0.023325334d, new GammaParticle(2240396.0, 0.00055) }, { 8.698259999999999e-05d, new GammaParticle(2375200.0, 0.00052) }, { 6.69866e-05d, new GammaParticle(2420940.0, 0.00051) }, { 1.0080200000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.0024d, new GammaParticle(477.0, 2.59925) }, { 0.0302d, new GammaParticle(4505.0, 0.27521) }, { 0.059500000000000004d, new GammaParticle(4511.0, 0.27485) }, { 0.011899999999999999d, new GammaParticle(4947.0, 0.25063) }, { 0.011899999999999999d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    