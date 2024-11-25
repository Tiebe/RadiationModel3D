using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium131";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 130.92697d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin131() }, { 1.0d, new BetaParticle(-1, 4620300.0) }, { 0.0006d, new GammaParticle(331720.0, 0.00374) }, { 0.017d, new GammaParticle(779640.0, 0.00159) }, { 0.0006d, new GammaParticle(1322900.0, 0.00094) }, { 0.0013d, new GammaParticle(1555600.0, 0.0008) }, { 0.017d, new GammaParticle(1654550.0, 0.00075) }, { 0.008d, new GammaParticle(2192200.0, 0.00057) }, { 0.9d, new GammaParticle(2434120.0, 0.00051) }, { 0.0006d, new GammaParticle(2677700.0, 0.00046) }, { 0.0011d, new GammaParticle(2750000.0, 0.00045) }, { 0.005d, new GammaParticle(2978300.0, 0.00042) }, { 0.0005d, new GammaParticle(3936500.0, 0.00031) }, { 0.035d, new GammaParticle(3989900.0, 0.00031) }, { 0.0024d, new GammaParticle(4098700.0, 0.0003) }, { 0.0011d, new GammaParticle(4262100.0, 0.00029) }, { 0.0029d, new GammaParticle(4292700.0, 0.00029) }, { 0.001d, new GammaParticle(4352600.0, 0.00028) }, { 0.0017000000000000001d, new GammaParticle(4404900.0, 0.00028) }, { 0.027999999999999997d, new GammaParticle(4487000.0, 0.00028) }, { 0.004d, new GammaParticle(4770800.0, 0.00026) }, { 0.0016d, new GammaParticle(5215600.0, 0.00024) }, { 0.0013d, new GammaParticle(5323000.0, 0.00023) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin131() }, { 1.0d, new BetaParticle(-1, 4620300.0) }, { 0.0006d, new GammaParticle(331720.0, 0.00374) }, { 0.017d, new GammaParticle(779640.0, 0.00159) }, { 0.0006d, new GammaParticle(1322900.0, 0.00094) }, { 0.0013d, new GammaParticle(1555600.0, 0.0008) }, { 0.017d, new GammaParticle(1654550.0, 0.00075) }, { 0.008d, new GammaParticle(2192200.0, 0.00057) }, { 0.9d, new GammaParticle(2434120.0, 0.00051) }, { 0.0006d, new GammaParticle(2677700.0, 0.00046) }, { 0.0011d, new GammaParticle(2750000.0, 0.00045) }, { 0.005d, new GammaParticle(2978300.0, 0.00042) }, { 0.0005d, new GammaParticle(3936500.0, 0.00031) }, { 0.035d, new GammaParticle(3989900.0, 0.00031) }, { 0.0024d, new GammaParticle(4098700.0, 0.0003) }, { 0.0011d, new GammaParticle(4262100.0, 0.00029) }, { 0.0029d, new GammaParticle(4292700.0, 0.00029) }, { 0.001d, new GammaParticle(4352600.0, 0.00028) }, { 0.0017000000000000001d, new GammaParticle(4404900.0, 0.00028) }, { 0.027999999999999997d, new GammaParticle(4487000.0, 0.00028) }, { 0.004d, new GammaParticle(4770800.0, 0.00026) }, { 0.0016d, new GammaParticle(5215600.0, 0.00024) }, { 0.0013d, new GammaParticle(5323000.0, 0.00023) } } },

        };
    }
}
    