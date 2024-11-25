using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium79";
        public override double halfLife { get; } = 135.0d;
        public override double atomicWeight { get; } = 78.9297d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton79() }, { 1.0d, new BetaParticle(1, 4481000.0) }, { 0.28d, new GammaParticle(39410.0, 0.03146) }, { 0.2184d, new GammaParticle(105000.0, 0.01181) }, { 0.0308d, new GammaParticle(134870.0, 0.00919) }, { 0.044800000000000006d, new GammaParticle(140920.0, 0.0088) }, { 0.0308d, new GammaParticle(144410.0, 0.00859) }, { 0.005600000000000001d, new GammaParticle(167430.0, 0.00741) }, { 0.0588d, new GammaParticle(218980.0, 0.00566) }, { 0.0308d, new GammaParticle(245800.0, 0.00504) }, { 0.01288d, new GammaParticle(308900.0, 0.00401) }, { 0.0504d, new GammaParticle(317760.0, 0.0039) }, { 0.053200000000000004d, new GammaParticle(324030.0, 0.00383) }, { 0.022400000000000003d, new GammaParticle(366340.0, 0.00338) }, { 0.0756d, new GammaParticle(413800.0, 0.003) }, { 0.047599999999999996d, new GammaParticle(612500.0, 0.00202) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 0.011761003276799999d, new GammaParticle(1767.0, 0.70166) }, { 0.07818909630896077d, new GammaParticle(13336.0, 0.09297) }, { 0.15050836633101208d, new GammaParticle(13396.0, 0.09255) }, { 0.03664077627242576d, new GammaParticle(15021.0, 0.08254) }, { 0.04089110632002715d, new GammaParticle(15070.0, 0.08227) }, { 0.004250330047601388d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    