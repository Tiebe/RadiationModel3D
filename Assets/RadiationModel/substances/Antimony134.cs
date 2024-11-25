using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony134 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony134";
        public override double halfLife { get; } = 0.78d;
        public override double atomicWeight { get; } = 133.92054d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium134() }, { 1.0d, new BetaParticle(-1, 4257400.0) }, { 0.0003d, new GammaParticle(52800.0, 0.02348) }, { 0.0012d, new GammaParticle(166930.0, 0.00743) }, { 0.0008d, new GammaParticle(921500.0, 0.00135) }, { 0.0008d, new GammaParticle(1117300.0, 0.00111) }, { 0.0006d, new GammaParticle(1185600.0, 0.00105) }, { 0.011000000000000001d, new GammaParticle(1279010.0, 0.00097) }, { 0.00017999999999999998d, new GammaParticle(1325600.0, 0.00094) }, { 0.009300000000000001d, new GammaParticle(1352140.0, 0.00092) }, { 0.0026d, new GammaParticle(1654570.0, 0.00075) }, { 0.0003d, new GammaParticle(1710200.0, 0.00072) }, { 0.0029d, new GammaParticle(2464290.0, 0.0005) }, { 0.0096d, new GammaParticle(2631470.0, 0.00047) }, { 0.00013d, new GammaParticle(2934000.0, 0.00042) }, { 0.0004d, new GammaParticle(3630400.0, 0.00034) }, { 0.0006d, new GammaParticle(3660200.0, 0.00034) }, { 0.0006d, new GammaParticle(4103200.0, 0.0003) }, { 0.0009d, new GammaParticle(5645000.0, 0.00022) }, { 0.0007000000000000001d, new GammaParticle(6279600.0, 0.0002) }, { 0.0012d, new GammaParticle(6450900.0, 0.00019) }, { 0.0007000000000000001d, new GammaParticle(6624000.0, 0.00019) }, { 0.0014000000000000002d, new GammaParticle(6686700.0, 0.00019) }, { 0.0004d, new GammaParticle(6733200.0, 0.00018) }, { 0.0006d, new GammaParticle(6820400.0, 0.00018) }, { 1.6043063004e-05d, new GammaParticle(4135.0, 0.29984) }, { 4.437842448369323e-05d, new GammaParticle(27202.0, 0.04558) }, { 8.264138637559261e-05d, new GammaParticle(27473.0, 0.04513) }, { 2.3650525177250757e-05d, new GammaParticle(31093.0, 0.03988) }, { 2.8782689140714173e-05d, new GammaParticle(31359.0, 0.03954) }, { 5.1321639634634155e-06d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    