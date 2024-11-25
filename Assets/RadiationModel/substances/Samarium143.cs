using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium143";
        public override double halfLife { get; } = 525.0d;
        public override double atomicWeight { get; } = 142.91463d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium143() }, { 1.0d, new BetaParticle(1, 2242600.0) }, { 0.003824d, new GammaParticle(272180.0, 0.00456) }, { 0.0004541d, new GammaParticle(458110.0, 0.00271) }, { 0.0001912d, new GammaParticle(797490.0, 0.00155) }, { 0.0239d, new GammaParticle(1056580.0, 0.00117) }, { 0.0052341d, new GammaParticle(1173180.0, 0.00106) }, { 0.0027484999999999996d, new GammaParticle(1242950.0, 0.001) }, { 0.0003585d, new GammaParticle(1341810.0, 0.00092) }, { 0.0043976d, new GammaParticle(1403060.0, 0.00088) }, { 0.0082933d, new GammaParticle(1514980.0, 0.00082) }, { 0.0006453d, new GammaParticle(1544870.0, 0.0008) }, { 0.0001195d, new GammaParticle(1753450.0, 0.00071) }, { 1.673e-05d, new GammaParticle(1808640.0, 0.00069) }, { 0.0003107d, new GammaParticle(1816780.0, 0.00068) }, { 0.00014340000000000002d, new GammaParticle(1854080.0, 0.00067) }, { 0.0001912d, new GammaParticle(2008870.0, 0.00062) }, { 0.00016729999999999997d, new GammaParticle(2080830.0, 0.0006) }, { 0.0001912d, new GammaParticle(2171950.0, 0.00057) }, { 4.78e-05d, new GammaParticle(2192840.0, 0.00057) }, { 7.170000000000001e-05d, new GammaParticle(2342200.0, 0.00053) }, { 9.56e-05d, new GammaParticle(2444200.0, 0.00051) }, { 4.78e-05d, new GammaParticle(2459500.0, 0.0005) }, { 0.0004541d, new GammaParticle(2613150.0, 0.00047) }, { 7.170000000000001e-05d, new GammaParticle(2633400.0, 0.00047) }, { 1.673e-05d, new GammaParticle(2904000.0, 0.00043) }, { 0.8984605999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.069d, new GammaParticle(6109.0, 0.20295) }, { 0.1219d, new GammaParticle(38171.0, 0.03248) }, { 0.2213d, new GammaParticle(38724.0, 0.03202) }, { 0.06860000000000001d, new GammaParticle(43934.0, 0.02822) }, { 0.0863d, new GammaParticle(44387.0, 0.02793) }, { 0.0176d, new GammaParticle(44938.0, 0.02759) } } },

        };
    }
}
    