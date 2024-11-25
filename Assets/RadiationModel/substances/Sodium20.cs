using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium20 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium20";
        public override double halfLife { get; } = 0.4479d;
        public override double atomicWeight { get; } = 20.00735d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon20() }, { 3e-05d, new GammaParticle(654900.0, 0.00189) }, { 0.7929999999999999d, new GammaParticle(1633602.0, 0.00076) }, { 8.099999999999999e-05d, new GammaParticle(2445000.0, 0.00051) }, { 7e-06d, new GammaParticle(2451000.0, 0.00051) }, { 2.6e-05d, new GammaParticle(2613800.0, 0.00047) }, { 0.0021d, new GammaParticle(2852000.0, 0.00043) }, { 0.00037d, new GammaParticle(3332540.0, 0.00037) }, { 0.000543d, new GammaParticle(3987300.0, 0.00031) }, { 1.5e-05d, new GammaParticle(4252000.0, 0.00029) }, { 0.00066d, new GammaParticle(4652000.0, 0.00027) }, { 1e-05d, new GammaParticle(4905000.0, 0.00025) }, { 2.2e-06d, new GammaParticle(4965850.0, 0.00025) }, { 0.0004d, new GammaParticle(5306000.0, 0.00023) }, { 4.7000000000000004e-05d, new GammaParticle(5620600.0, 0.00022) }, { 2.6e-05d, new GammaParticle(5624000.0, 0.00022) }, { 4e-05d, new GammaParticle(6635000.0, 0.00019) }, { 0.00017d, new GammaParticle(8237000.0, 0.00015) }, { 0.0259d, new GammaParticle(8638000.0, 0.00014) }, { 0.00013d, new GammaParticle(9248000.0, 0.00013) }, { 0.00032d, new GammaParticle(9626100.0, 0.00013) }, { 1e-06d, new GammaParticle(9870000.0, 0.00013) }, { 0.00023d, new GammaParticle(10271000.0, 0.00012) }, { 0.0017100000000000001d, new GammaParticle(11258900.0, 0.00011) }, { 2.002092d, new GammaParticle(511000.0, 0.00243) }, { 2.7800000000000003e-07d, new GammaParticle(848.0, 1.46208) }, { 5.5e-07d, new GammaParticle(848.0, 1.46208) } } },
            { 0.2005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen16() }, { 1.0d, new AlphaParticle(10184504.19) } } },

        };
    }
}
    