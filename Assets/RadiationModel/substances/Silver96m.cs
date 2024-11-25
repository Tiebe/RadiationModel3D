using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver96m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver96m";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 95.93075d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium96() }, { 1.0d, new BetaParticle(1, 7589000.0) }, { 0.313072d, new GammaParticle(106200.0, 0.01167) }, { 0.02302d, new GammaParticle(224600.0, 0.00552) }, { 0.870156d, new GammaParticle(325200.0, 0.00381) }, { 0.029925999999999998d, new GammaParticle(549600.0, 0.00226) }, { 0.067909d, new GammaParticle(653400.0, 0.0019) }, { 0.9150449999999999d, new GammaParticle(683700.0, 0.00181) }, { 0.014962999999999999d, new GammaParticle(706200.0, 0.00176) }, { 0.052946d, new GammaParticle(759800.0, 0.00163) }, { 0.036832d, new GammaParticle(976100.0, 0.00127) }, { 0.05755d, new GammaParticle(1253000.0, 0.00099) }, { 0.055248d, new GammaParticle(1300500.0, 0.00095) }, { 0.9150449999999999d, new GammaParticle(1415300.0, 0.00088) }, { 0.059851999999999995d, new GammaParticle(1498700.0, 0.00083) }, { 0.013812d, new GammaParticle(1526500.0, 0.00081) }, { 0.01151d, new GammaParticle(1695700.0, 0.00073) }, { 0.005755d, new GammaParticle(2099200.0, 0.00059) }, { 0.016114d, new GammaParticle(2180200.0, 0.00057) }, { 0.024171d, new GammaParticle(2853100.0, 0.00043) }, { 0.86d, new GammaParticle(511000.0, 0.00243) }, { 1.284d, new GammaParticle(511000.0, 0.00243) }, { 0.00012d, new GammaParticle(3053.0, 0.40611) }, { 0.0192d, new GammaParticle(3053.0, 0.40611) }, { 0.0005d, new GammaParticle(21020.0, 0.05898) }, { 0.0702d, new GammaParticle(21020.0, 0.05898) }, { 0.00094d, new GammaParticle(21177.0, 0.05855) }, { 0.133d, new GammaParticle(21177.0, 0.05855) }, { 0.00026d, new GammaParticle(23904.0, 0.05187) }, { 0.0364d, new GammaParticle(23904.0, 0.05187) }, { 0.0003d, new GammaParticle(24070.0, 0.05151) }, { 0.0426d, new GammaParticle(24070.0, 0.05151) }, { 4.4000000000000006e-05d, new GammaParticle(24297.0, 0.05103) }, { 0.0062d, new GammaParticle(24297.0, 0.05103) } } },
            { 0.085d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium95() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    