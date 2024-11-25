using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine117 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine117";
        public override double halfLife { get; } = 133.2d;
        public override double atomicWeight { get; } = 116.91365d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony117() }, { 1.0d, new BetaParticle(1, 4100500.0) }, { 0.00017d, new GammaParticle(21600.0, 0.0574) }, { 0.00075d, new GammaParticle(30100.0, 0.04119) }, { 0.0022500000000000003d, new GammaParticle(45600.0, 0.02719) }, { 0.013000000000000001d, new GammaParticle(52200.0, 0.02375) }, { 0.00375d, new GammaParticle(112300.0, 0.01104) }, { 0.0022500000000000003d, new GammaParticle(122200.0, 0.01015) }, { 0.204d, new GammaParticle(274400.0, 0.00452) }, { 0.00375d, new GammaParticle(296000.0, 0.00419) }, { 0.01125d, new GammaParticle(303400.0, 0.00409) }, { 0.75d, new GammaParticle(325800.0, 0.00381) }, { 0.0045000000000000005d, new GammaParticle(340900.0, 0.00364) }, { 0.0045000000000000005d, new GammaParticle(353000.0, 0.00351) }, { 0.00825d, new GammaParticle(407000.0, 0.00305) }, { 0.0045000000000000005d, new GammaParticle(475900.0, 0.00261) }, { 0.00525d, new GammaParticle(583300.0, 0.00213) }, { 0.0045000000000000005d, new GammaParticle(609800.0, 0.00203) }, { 0.02475d, new GammaParticle(638900.0, 0.00194) }, { 0.00375d, new GammaParticle(655400.0, 0.00189) }, { 0.051d, new GammaParticle(661500.0, 0.00187) }, { 0.03225d, new GammaParticle(684000.0, 0.00181) }, { 0.006d, new GammaParticle(689700.0, 0.0018) }, { 0.01275d, new GammaParticle(695800.0, 0.00178) }, { 0.00975d, new GammaParticle(858800.0, 0.00144) }, { 0.0045000000000000005d, new GammaParticle(935500.0, 0.00133) }, { 0.003d, new GammaParticle(948600.0, 0.00131) }, { 0.006750000000000001d, new GammaParticle(964400.0, 0.00129) }, { 0.00525d, new GammaParticle(969900.0, 0.00128) }, { 0.0045000000000000005d, new GammaParticle(989700.0, 0.00125) }, { 0.006d, new GammaParticle(1084500.0, 0.00114) }, { 0.003d, new GammaParticle(1232400.0, 0.00101) }, { 0.01275d, new GammaParticle(1302900.0, 0.00095) }, { 1.6632d, new GammaParticle(511000.0, 0.00243) }, { 0.027999999999999997d, new GammaParticle(4135.0, 0.29984) }, { 0.053d, new GammaParticle(27202.0, 0.04558) }, { 0.099d, new GammaParticle(27473.0, 0.04513) }, { 0.027999999999999997d, new GammaParticle(31093.0, 0.03988) }, { 0.034d, new GammaParticle(31359.0, 0.03954) }, { 0.0060999999999999995d, new GammaParticle(31698.0, 0.03911) } } },
            { 0.77d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium117() }, { 1.0d, new BetaParticle(1, 2328500.0) } } },

        };
    }
}
    