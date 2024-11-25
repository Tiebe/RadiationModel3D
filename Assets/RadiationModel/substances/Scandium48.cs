using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium48";
        public override double halfLife { get; } = 157356.0d;
        public override double atomicWeight { get; } = 47.95222d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium48() }, { 1.0d, new BetaParticle(-1, 1994475.0) }, { 0.0747d, new GammaParticle(175361.0, 0.00707) }, { 1.0d, new GammaParticle(983526.0, 0.00126) }, { 0.975d, new GammaParticle(1037522.0, 0.0012) }, { 0.023799999999999998d, new GammaParticle(1212880.0, 0.00102) }, { 1.0d, new GammaParticle(1312120.0, 0.00094) }, { 3.06879713328e-06d, new GammaParticle(477.0, 2.59925) }, { 3.878081992693971e-05d, new GammaParticle(4505.0, 0.27521) }, { 7.640035446599627e-05d, new GammaParticle(4511.0, 0.27485) }, { 1.5261505607064017e-05d, new GammaParticle(4947.0, 0.25063) }, { 1.5261505607064017e-05d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    