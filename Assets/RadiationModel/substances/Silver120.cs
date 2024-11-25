using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver120 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver120";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 119.91878d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium120() }, { 1.0d, new BetaParticle(-1, 4152500.0) }, { 0.71d, new GammaParticle(505900.0, 0.00245) }, { 0.3d, new GammaParticle(697800.0, 0.00178) }, { 0.11d, new GammaParticle(817100.0, 0.00152) }, { 0.09d, new GammaParticle(1323100.0, 0.00094) } } },
            { 3e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium120() }, { 1.0d, new BetaParticle(-1, 4152500.0) }, { 0.71d, new GammaParticle(505900.0, 0.00245) }, { 0.3d, new GammaParticle(697800.0, 0.00178) }, { 0.11d, new GammaParticle(817100.0, 0.00152) }, { 0.09d, new GammaParticle(1323100.0, 0.00094) } } },

        };
    }
}
    