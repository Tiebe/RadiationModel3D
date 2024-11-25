using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium198m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium198m";
        public override double halfLife { get; } = 6732.0d;
        public override double atomicWeight { get; } = 197.97103d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5589999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold198() }, { 1.0d, new BetaParticle(1, 1297900.00001) }, { 0.0025568d, new GammaParticle(47740.0, 0.02597) }, { 0.0015776000000000002d, new GammaParticle(149300.0, 0.0083) }, { 0.007942399999999999d, new GammaParticle(194600.0, 0.00637) }, { 0.013056000000000002d, new GammaParticle(215600.0, 0.00575) }, { 0.055488d, new GammaParticle(226200.0, 0.00548) }, { 0.014688000000000001d, new GammaParticle(227500.0, 0.00545) }, { 0.0032640000000000004d, new GammaParticle(249800.0, 0.00496) }, { 0.015776d, new GammaParticle(274000.0, 0.00452) }, { 0.002176d, new GammaParticle(292700.0, 0.00424) }, { 0.0079968d, new GammaParticle(375900.0, 0.0033) }, { 0.017408d, new GammaParticle(390400.0, 0.00318) }, { 0.59296d, new GammaParticle(411800.0, 0.00301) }, { 0.009248d, new GammaParticle(422200.0, 0.00294) }, { 0.0112064d, new GammaParticle(423300.0, 0.00293) }, { 0.022848d, new GammaParticle(441800.0, 0.00281) }, { 0.046784d, new GammaParticle(489600.0, 0.00253) }, { 0.036992d, new GammaParticle(519200.0, 0.00239) }, { 0.00544d, new GammaParticle(531600.0, 0.00233) }, { 0.008159999999999999d, new GammaParticle(541000.0, 0.00229) }, { 0.002176d, new GammaParticle(567000.0, 0.00219) }, { 0.544d, new GammaParticle(587200.0, 0.00211) }, { 0.0028288000000000002d, new GammaParticle(606000.0, 0.00205) }, { 0.59296d, new GammaParticle(636700.0, 0.00195) }, { 0.0079968d, new GammaParticle(698000.0, 0.00178) }, { 0.0032640000000000004d, new GammaParticle(744200.0, 0.00167) }, { 0.011587199999999999d, new GammaParticle(767300.0, 0.00162) }, { 0.0046784d, new GammaParticle(832900.0, 0.00149) }, { 0.0087584d, new GammaParticle(898500.0, 0.00138) }, { 0.0026112d, new GammaParticle(1050200.0, 0.00118) }, { 0.003808d, new GammaParticle(1281500.0, 0.00097) }, { 0.0040256d, new GammaParticle(1392000.0, 0.00089) }, { 0.019428d, new GammaParticle(511000.0, 0.00243) }, { 0.301657852010432d, new GammaParticle(11777.0, 0.10528) }, { 0.14554334434811153d, new GammaParticle(68894.0, 0.018) }, { 0.24672545236160626d, new GammaParticle(70820.0, 0.01751) }, { 0.08373255057376808d, new GammaParticle(80316.0, 0.01544) }, { 0.10826618789188211d, new GammaParticle(81285.0, 0.01525) }, { 0.024533637318114046d, new GammaParticle(82477.0, 0.01503) } } },
            { 0.441d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium198() }, { 0.00037536d, new GammaParticle(23100.0, 0.05367) }, { 0.027744d, new GammaParticle(259600.0, 0.00478) }, { 0.012512d, new GammaParticle(260900.0, 0.00475) }, { 0.272d, new GammaParticle(282800.0, 0.00438) }, { 0.173211269879808d, new GammaParticle(12148.0, 0.10206) }, { 0.08367238493640722d, new GammaParticle(70832.0, 0.0175) }, { 0.14124305357259828d, new GammaParticle(72874.0, 0.01701) }, { 0.04803513991287166d, new GammaParticle(82629.0, 0.015) }, { 0.06230157646699453d, new GammaParticle(83631.0, 0.01483) }, { 0.014266436554122883d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    