using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead198 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead198";
        public override double halfLife { get; } = 8640.0d;
        public override double atomicWeight { get; } = 197.97202d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury198() }, { 1.0d, new BetaParticle(1, 2443650.00001) }, { 0.0007643999999999999d, new GammaParticle(30800.0, 0.04025) }, { 7.28e-05d, new GammaParticle(107300.0, 0.01155) }, { 0.01183d, new GammaParticle(116900.0, 0.01061) }, { 0.0011466d, new GammaParticle(122600.0, 0.01011) }, { 0.001456d, new GammaParticle(138300.0, 0.00896) }, { 0.182d, new GammaParticle(173400.0, 0.00715) }, { 0.00041860000000000004d, new GammaParticle(216500.0, 0.00573) }, { 0.05824d, new GammaParticle(259500.0, 0.00478) }, { 0.008736d, new GammaParticle(266700.0, 0.00465) }, { 0.0027300000000000002d, new GammaParticle(275400.0, 0.0045) }, { 0.364d, new GammaParticle(290300.0, 0.00427) }, { 0.19474d, new GammaParticle(365400.0, 0.00339) }, { 0.056420000000000005d, new GammaParticle(382000.0, 0.00325) }, { 0.002184d, new GammaParticle(396500.0, 0.00313) }, { 0.02912d, new GammaParticle(397700.0, 0.00312) }, { 0.00728d, new GammaParticle(467800.0, 0.00265) }, { 0.03094d, new GammaParticle(575000.0, 0.00216) }, { 0.005642d, new GammaParticle(605900.0, 0.00205) }, { 0.0182d, new GammaParticle(649000.0, 0.00191) }, { 0.014742d, new GammaParticle(743000.0, 0.00167) }, { 0.06006d, new GammaParticle(865300.0, 0.00143) }, { 0.4083846486442808d, new GammaParticle(12148.0, 0.10206) }, { 0.2843534342955715d, new GammaParticle(70832.0, 0.0175) }, { 0.48000242116065406d, new GammaParticle(72874.0, 0.01701) }, { 0.16324330914523863d, new GammaParticle(82629.0, 0.015) }, { 0.2117265719613745d, new GammaParticle(83631.0, 0.01483) }, { 0.04848326281613588d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    