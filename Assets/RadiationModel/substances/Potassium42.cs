using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium42";
        public override double halfLife { get; } = 44478.0d;
        public override double atomicWeight { get; } = 41.9624d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium42() }, { 1.0d, new BetaParticle(-1, 1762630.0) }, { 0.00336288d, new GammaParticle(312600.0, 0.00397) }, { 3.2544e-05d, new GammaParticle(692000.0, 0.00179) }, { 0.00051528d, new GammaParticle(899700.0, 0.00138) }, { 0.000200688d, new GammaParticle(1021200.0, 0.00121) }, { 2.3503999999999997e-05d, new GammaParticle(1228000.0, 0.00101) }, { 0.1808d, new GammaParticle(1524600.0, 0.00081) }, { 0.000412224d, new GammaParticle(1920800.0, 0.00065) }, { 0.00019888d, new GammaParticle(2424300.0, 0.00051) }, { 3.934556484768e-08d, new GammaParticle(358.0, 3.46325) }, { 5.24104168470317e-07d, new GammaParticle(3688.0, 0.33618) }, { 1.0355743301132525e-06d, new GammaParticle(3692.0, 0.33582) }, { 2.021343334164306e-07d, new GammaParticle(4013.0, 0.30896) }, { 2.021343334164306e-07d, new GammaParticle(4013.0, 0.30896) } } },

        };
    }
}
    