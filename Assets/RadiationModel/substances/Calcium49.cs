using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium49";
        public override double halfLife { get; } = 523.08d;
        public override double atomicWeight { get; } = 48.95566d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium49() }, { 1.0d, new BetaParticle(-1, 2631200.0) }, { 0.00031d, new GammaParticle(143200.0, 0.00866) }, { 0.000135d, new GammaParticle(712600.0, 0.00174) }, { 0.00146d, new GammaParticle(856100.0, 0.00145) }, { 7.5e-05d, new GammaParticle(976700.0, 0.00127) }, { 0.00077d, new GammaParticle(987300.0, 0.00126) }, { 0.00098d, new GammaParticle(1144500.0, 0.00108) }, { 0.0005099999999999999d, new GammaParticle(1288400.0, 0.00096) }, { 0.00599d, new GammaParticle(1408900.0, 0.00088) }, { 0.00319d, new GammaParticle(2228900.0, 0.00056) }, { 0.00042d, new GammaParticle(2264700.0, 0.00055) }, { 0.0055000000000000005d, new GammaParticle(2371700.0, 0.00052) }, { 0.00031d, new GammaParticle(2486300.0, 0.0005) }, { 0.9072d, new GammaParticle(3084400.0, 0.0004) }, { 0.08121d, new GammaParticle(4071900.0, 0.0003) }, { 6.1000000000000005e-05d, new GammaParticle(4332000.0, 0.00029) }, { 0.0007000000000000001d, new GammaParticle(4493000.0, 0.00028) }, { 5.1000000000000006e-05d, new GammaParticle(4714400.0, 0.00026) }, { 0.0028100000000000004d, new GammaParticle(4738200.0, 0.00026) }, { 4.37385287808e-08d, new GammaParticle(422.0, 2.93801) }, { 5.654219825167865e-07d, new GammaParticle(4086.0, 0.30344) }, { 1.115450744755941e-06d, new GammaParticle(4091.0, 0.30307) }, { 2.2170711272727273e-07d, new GammaParticle(4474.0, 0.27712) }, { 2.2170711272727273e-07d, new GammaParticle(4474.0, 0.27712) } } },

        };
    }
}
    