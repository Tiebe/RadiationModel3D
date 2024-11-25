using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver106 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver106";
        public override double halfLife { get; } = 1437.6d;
        public override double atomicWeight { get; } = 105.90666d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium106() }, { 1.0d, new BetaParticle(1, -289500.0) }, { 7.719e-05d, new GammaParticle(428600.0, 0.00289) }, { 2.241e-05d, new GammaParticle(434280.0, 0.00285) }, { 5.7270000000000006e-05d, new GammaParticle(439230.0, 0.00282) }, { 0.17031600000000002d, new GammaParticle(511900.0, 0.00242) }, { 6.474e-05d, new GammaParticle(578400.0, 0.00214) }, { 0.0014193d, new GammaParticle(616190.0, 0.00201) }, { 0.0031623000000000003d, new GammaParticle(621950.0, 0.00199) }, { 3.237e-05d, new GammaParticle(680200.0, 0.00182) }, { 7.221000000000001e-06d, new GammaParticle(715600.0, 0.00173) }, { 1.1703e-05d, new GammaParticle(717100.0, 0.00173) }, { 0.001992d, new GammaParticle(873460.0, 0.00142) }, { 0.0016683000000000002d, new GammaParticle(1050310.0, 0.00118) }, { 4.2329999999999996e-05d, new GammaParticle(1109000.0, 0.00112) }, { 6.225e-05d, new GammaParticle(1114500.0, 0.00111) }, { 0.0007220999999999999d, new GammaParticle(1127980.0, 0.0011) }, { 5.478e-05d, new GammaParticle(1180700.0, 0.00105) }, { 0.0003984d, new GammaParticle(1194500.0, 0.00104) }, { 2.9880000000000002e-05d, new GammaParticle(1397600.0, 0.00089) }, { 1.4940000000000001e-05d, new GammaParticle(1489600.0, 0.00083) }, { 6.972e-06d, new GammaParticle(1498800.0, 0.00083) }, { 0.00017181d, new GammaParticle(1562200.0, 0.00079) }, { 9.461999999999999e-07d, new GammaParticle(1572300.0, 0.00079) }, { 1.245e-05d, new GammaParticle(1730000.0, 0.00072) }, { 2.49e-05d, new GammaParticle(1766000.0, 0.0007) }, { 8.217000000000001e-05d, new GammaParticle(1797000.0, 0.00069) }, { 1.1952e-05d, new GammaParticle(1909500.0, 0.00065) }, { 8.466e-06d, new GammaParticle(1927500.0, 0.00064) }, { 2.988e-06d, new GammaParticle(1988600.0, 0.00062) }, { 4.482e-06d, new GammaParticle(2113800.0, 0.00059) }, { 2.49e-05d, new GammaParticle(2193400.0, 0.00057) }, { 7.967999999999999e-06d, new GammaParticle(2242700.0, 0.00055) }, { 6.972e-06d, new GammaParticle(2309300.0, 0.00054) }, { 2.49e-06d, new GammaParticle(2316600.0, 0.00054) }, { 3.486e-06d, new GammaParticle(2365900.0, 0.00052) }, { 4.731e-06d, new GammaParticle(2438600.0, 0.00051) }, { 8.466e-06d, new GammaParticle(2704900.0, 0.00046) }, { 1.182d, new GammaParticle(511000.0, 0.00243) }, { 0.020850107368455002d, new GammaParticle(3053.0, 0.40611) }, { 0.0829543128348564d, new GammaParticle(21020.0, 0.05898) }, { 0.15672456609646024d, new GammaParticle(21177.0, 0.05855) }, { 0.042998800587763564d, new GammaParticle(23904.0, 0.05187) }, { 0.050308596687683366d, new GammaParticle(24070.0, 0.05151) }, { 0.007309796099919805d, new GammaParticle(24297.0, 0.05103) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium106() }, { 1.0d, new BetaParticle(-1, 95100.0) } } },

        };
    }
}
    