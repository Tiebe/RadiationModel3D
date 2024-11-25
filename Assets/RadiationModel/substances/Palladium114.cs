using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium114";
        public override double halfLife { get; } = 145.2d;
        public override double atomicWeight { get; } = 113.91037d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver114() }, { 1.0d, new BetaParticle(-1, 720500.0) }, { 0.04488d, new GammaParticle(126700.0, 0.00979) }, { 0.008976d, new GammaParticle(136700.0, 0.00907) }, { 0.006936d, new GammaParticle(222000.0, 0.00558) }, { 0.04896d, new GammaParticle(232000.0, 0.00534) }, { 0.016319999999999998d, new GammaParticle(358500.0, 0.00346) }, { 0.000817335495891552d, new GammaParticle(3218.0, 0.38528) }, { 0.0030557115086479684d, new GammaParticle(21990.0, 0.05638) }, { 0.005760059394246878d, new GammaParticle(22163.0, 0.05594) }, { 0.0015956995884711714d, new GammaParticle(25030.0, 0.04953) }, { 0.001873351316865155d, new GammaParticle(25211.0, 0.04918) }, { 0.0002776517283939838d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    