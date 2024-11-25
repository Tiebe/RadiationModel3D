using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead211 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead211";
        public override double halfLife { get; } = 2166.0d;
        public override double atomicWeight { get; } = 210.98874d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth211() }, { 1.0d, new BetaParticle(-1, 683000.0) }, { 0.0007746d, new GammaParticle(65420.0, 0.01895) }, { 0.00045185d, new GammaParticle(81000.0, 0.01531) }, { 0.00058095d, new GammaParticle(83800.0, 0.0148) }, { 0.00016783d, new GammaParticle(88200.0, 0.01406) }, { 0.00011619000000000001d, new GammaParticle(94300.0, 0.01315) }, { 0.00018074d, new GammaParticle(95000.0, 0.01305) }, { 0.00011619000000000001d, new GammaParticle(97300.0, 0.01274) }, { 0.0003873d, new GammaParticle(244000.0, 0.00508) }, { 0.00030984000000000003d, new GammaParticle(313590.0, 0.00395) }, { 0.00034857d, new GammaParticle(342910.0, 0.00362) }, { 0.00042603000000000004d, new GammaParticle(362072.0, 0.00342) }, { 0.0378263d, new GammaParticle(404853.0, 0.00306) }, { 0.0175576d, new GammaParticle(427088.0, 0.0029) }, { 6.455e-05d, new GammaParticle(430000.0, 0.00288) }, { 0.0001291d, new GammaParticle(478000.0, 0.00259) }, { 5.164e-05d, new GammaParticle(479620.0, 0.00259) }, { 0.0002582d, new GammaParticle(481100.0, 0.00258) }, { 0.00010328d, new GammaParticle(481920.0, 0.00257) }, { 4.1312e-05d, new GammaParticle(491820.0, 0.00252) }, { 1.6783e-05d, new GammaParticle(494200.0, 0.00251) }, { 0.00011619000000000001d, new GammaParticle(500400.0, 0.00248) }, { 3.6148e-05d, new GammaParticle(502000.0, 0.00247) }, { 5.8095000000000005e-05d, new GammaParticle(504120.0, 0.00246) }, { 0.00042603000000000004d, new GammaParticle(609380.0, 0.00203) }, { 0.0001291d, new GammaParticle(676690.0, 0.00183) }, { 0.00462178d, new GammaParticle(704640.0, 0.00176) }, { 0.00617098d, new GammaParticle(766510.0, 0.00162) }, { 0.0352443d, new GammaParticle(832010.0, 0.00149) }, { 5.9386e-05d, new GammaParticle(865930.0, 0.00143) }, { 0.00021947d, new GammaParticle(951000.0, 0.0013) }, { 0.000172994d, new GammaParticle(1014640.0, 0.00122) }, { 0.000122645d, new GammaParticle(1080160.0, 0.00115) }, { 2.582e-05d, new GammaParticle(1090500.0, 0.00114) }, { 4.6476e-05d, new GammaParticle(1103520.0, 0.00112) }, { 0.00114899d, new GammaParticle(1109480.0, 0.00112) }, { 0.000101989d, new GammaParticle(1196330.0, 0.00104) }, { 1.291e-05d, new GammaParticle(1234300.0, 0.001) }, { 6.8423e-05d, new GammaParticle(1270710.0, 0.00098) }, { 0.004928582033163666d, new GammaParticle(12904.0, 0.09608) }, { 0.0022352609569870744d, new GammaParticle(74815.0, 0.01657) }, { 0.0037397707160566752d, new GammaParticle(77108.0, 0.01608) }, { 0.0012810175103003443d, new GammaParticle(87388.0, 0.01419) }, { 0.00167300886845225d, new GammaParticle(88458.0, 0.01402) }, { 0.0003919913581519054d, new GammaParticle(89784.0, 0.01381) } } },

        };
    }
}
    