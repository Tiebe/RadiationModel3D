using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium201m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium201m";
        public override double halfLife { get; } = 537.6d;
        public override double atomicWeight { get; } = 200.98272d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.55d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead201() }, { 1.0d, new BetaParticle(1, 4587000.0) }, { 0.001d, new GammaParticle(95260.0, 0.01302) }, { 0.001d, new GammaParticle(217600.0, 0.0057) }, { 0.011000000000000001d, new GammaParticle(271910.0, 0.00456) }, { 0.052000000000000005d, new GammaParticle(411860.0, 0.00301) }, { 0.005d, new GammaParticle(532400.0, 0.00233) }, { 0.017d, new GammaParticle(534200.0, 0.00232) }, { 0.039d, new GammaParticle(537500.0, 0.00231) }, { 0.013999999999999999d, new GammaParticle(540100.0, 0.0023) }, { 0.006999999999999999d, new GammaParticle(697600.0, 0.00178) }, { 0.011000000000000001d, new GammaParticle(754600.0, 0.00164) }, { 0.003d, new GammaParticle(798500.0, 0.00155) }, { 0.133d, new GammaParticle(964300.0, 0.00129) }, { 0.157d, new GammaParticle(967400.0, 0.00128) }, { 0.0012d, new GammaParticle(1502400.0, 0.00083) }, { 0.0013d, new GammaParticle(1504300.0, 0.00082) }, { 0.006d, new GammaParticle(1762900.0, 0.0007) }, { 0.26664d, new GammaParticle(511000.0, 0.00243) }, { 0.139d, new GammaParticle(12904.0, 0.09608) }, { 0.1d, new GammaParticle(74815.0, 0.01657) }, { 0.16699999999999998d, new GammaParticle(77108.0, 0.01608) }, { 0.057300000000000004d, new GammaParticle(87388.0, 0.01419) }, { 0.07490000000000001d, new GammaParticle(88458.0, 0.01402) }, { 0.0175d, new GammaParticle(89784.0, 0.01381) } } },
            { 0.426d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium201() }, { 0.0728d, new GammaParticle(417800.0, 0.00297) }, { 0.11011229611199999d, new GammaParticle(13292.0, 0.09328) }, { 0.05633503436182432d, new GammaParticle(76862.0, 0.01613) }, { 0.09381354598138937d, new GammaParticle(79290.0, 0.01564) }, { 0.03229740629808259d, new GammaParticle(89837.0, 0.0138) }, { 0.04234189965678627d, new GammaParticle(90941.0, 0.01363) }, { 0.010044493358703683d, new GammaParticle(92315.0, 0.01343) } } },
            { 0.024d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead197() }, { 1.0d, new AlphaParticle(7245002.09) } } },

        };
    }
}
    