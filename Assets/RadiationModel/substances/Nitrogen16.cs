using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen16 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen16";
        public override double halfLife { get; } = 7.13d;
        public override double atomicWeight { get; } = 16.0061d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen16() }, { 1.0d, new BetaParticle(-1, 5210451.05) }, { 3.0000000000000004e-08d, new GammaParticle(787200.0, 0.00158) }, { 2.1000000000000002e-06d, new GammaParticle(867700.0, 0.00143) }, { 3.4e-05d, new GammaParticle(986930.0, 0.00126) }, { 3e-07d, new GammaParticle(1067500.0, 0.00116) }, { 0.00121d, new GammaParticle(1754900.0, 0.00071) }, { 0.00037999999999999997d, new GammaParticle(1954700.0, 0.00063) }, { 0.008199999999999999d, new GammaParticle(2741500.0, 0.00045) }, { 0.0013d, new GammaParticle(2822200.0, 0.00044) }, { 0.67d, new GammaParticle(6128630.0, 0.0002) }, { 0.00037999999999999997d, new GammaParticle(6915500.0, 0.00018) }, { 0.049d, new GammaParticle(7115150.0, 0.00017) }, { 0.0007599999999999999d, new GammaParticle(8869300.0, 0.00014) } } },
            { 1.1999999999999999e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen16() }, { 1.0d, new BetaParticle(-1, 5210451.05) }, { 3.0000000000000004e-08d, new GammaParticle(787200.0, 0.00158) }, { 2.1000000000000002e-06d, new GammaParticle(867700.0, 0.00143) }, { 3.4e-05d, new GammaParticle(986930.0, 0.00126) }, { 3e-07d, new GammaParticle(1067500.0, 0.00116) }, { 0.00121d, new GammaParticle(1754900.0, 0.00071) }, { 0.00037999999999999997d, new GammaParticle(1954700.0, 0.00063) }, { 0.008199999999999999d, new GammaParticle(2741500.0, 0.00045) }, { 0.0013d, new GammaParticle(2822200.0, 0.00044) }, { 0.67d, new GammaParticle(6128630.0, 0.0002) }, { 0.00037999999999999997d, new GammaParticle(6915500.0, 0.00018) }, { 0.049d, new GammaParticle(7115150.0, 0.00017) }, { 0.0007599999999999999d, new GammaParticle(8869300.0, 0.00014) } } },

        };
    }
}
    