using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum91 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum91";
        public override double halfLife { get; } = 929.4d;
        public override double atomicWeight { get; } = 90.91175d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium91() }, { 1.0d, new BetaParticle(1, 2843295.0) }, { 5.264e-05d, new GammaParticle(1050900.0, 0.00118) }, { 0.00020726999999999999d, new GammaParticle(1082300.0, 0.00115) }, { 3.619e-05d, new GammaParticle(1156300.0, 0.00107) }, { 0.00012502d, new GammaParticle(1447200.0, 0.00086) }, { 0.0022602300000000002d, new GammaParticle(1581500.0, 0.00078) }, { 0.00010198999999999999d, new GammaParticle(1605800.0, 0.00077) }, { 0.00329d, new GammaParticle(1637300.0, 0.00076) }, { 0.00013489d, new GammaParticle(1740400.0, 0.00071) }, { 0.00029939d, new GammaParticle(1790820.0, 0.00069) }, { 4.2770000000000006e-05d, new GammaParticle(2530800.0, 0.00049) }, { 0.00118111d, new GammaParticle(2631900.0, 0.00047) }, { 9.87e-05d, new GammaParticle(2792000.0, 0.00044) }, { 0.00084882d, new GammaParticle(3028500.0, 0.00041) }, { 0.00054943d, new GammaParticle(3149200.0, 0.00039) }, { 5.264e-05d, new GammaParticle(3187800.0, 0.00039) }, { 2.961e-05d, new GammaParticle(3837600.0, 0.00032) }, { 2.3029999999999998e-05d, new GammaParticle(3886700.0, 0.00032) }, { 1.645e-05d, new GammaParticle(3916700.0, 0.00032) }, { 1.974e-05d, new GammaParticle(4180600.0, 0.0003) }, { 1.87477352d, new GammaParticle(511000.0, 0.00243) }, { 0.0022183387095054945d, new GammaParticle(2299.0, 0.5393) }, { 0.011851701542968728d, new GammaParticle(16521.0, 0.07505) }, { 0.022635029684814224d, new GammaParticle(16615.0, 0.07462) }, { 0.005856746616335662d, new GammaParticle(18694.0, 0.06632) }, { 0.006735258608786011d, new GammaParticle(18795.0, 0.06597) }, { 0.0008785119924503492d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    