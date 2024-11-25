using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium220";
        public override double halfLife { get; } = 27.4d;
        public override double atomicWeight { get; } = 220.01233d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9965d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine216() }, { 1.0d, new AlphaParticle(7822002.09) }, { 7.000000000000001e-05d, new GammaParticle(34600.0, 0.03583) }, { 0.005580000000000001d, new GammaParticle(44600.0, 0.0278) }, { 0.00015d, new GammaParticle(54800.0, 0.02262) }, { 0.0007000000000000001d, new GammaParticle(61300.0, 0.02023) }, { 0.0005d, new GammaParticle(64900.0, 0.0191) }, { 0.0003d, new GammaParticle(75700.0, 0.01638) }, { 0.0003986d, new GammaParticle(96400.0, 0.01286) }, { 0.00299d, new GammaParticle(105880.0, 0.01171) }, { 0.00045d, new GammaParticle(108800.0, 0.0114) }, { 5e-05d, new GammaParticle(112100.0, 0.01106) }, { 0.00035000000000000005d, new GammaParticle(116200.0, 0.01067) }, { 0.0007000000000000001d, new GammaParticle(124700.0, 0.00994) }, { 0.00012d, new GammaParticle(128700.0, 0.00963) }, { 7.000000000000001e-05d, new GammaParticle(132800.0, 0.00934) }, { 0.00023d, new GammaParticle(138300.0, 0.00896) }, { 0.00031d, new GammaParticle(139700.0, 0.00888) }, { 0.0008d, new GammaParticle(142100.0, 0.00873) }, { 0.0025900000000000003d, new GammaParticle(153400.0, 0.00808) }, { 0.0004d, new GammaParticle(154500.0, 0.00802) }, { 0.0011d, new GammaParticle(156100.0, 0.00794) }, { 0.00379d, new GammaParticle(160730.0, 0.00771) }, { 0.00179d, new GammaParticle(163400.0, 0.00759) }, { 6e-05d, new GammaParticle(173000.0, 0.00717) }, { 5e-05d, new GammaParticle(182100.0, 0.00681) }, { 0.0002d, new GammaParticle(196900.0, 0.0063) }, { 7.000000000000001e-05d, new GammaParticle(208000.0, 0.00596) }, { 0.0001d, new GammaParticle(218600.0, 0.00567) }, { 0.0002d, new GammaParticle(221100.0, 0.00561) }, { 8e-05d, new GammaParticle(222200.0, 0.00558) }, { 0.00035000000000000005d, new GammaParticle(233600.0, 0.00531) }, { 8.999999999999999e-05d, new GammaParticle(242000.0, 0.00512) }, { 0.00048d, new GammaParticle(258200.0, 0.0048) }, { 7.000000000000001e-05d, new GammaParticle(260500.0, 0.00476) }, { 8.999999999999999e-05d, new GammaParticle(268300.0, 0.00462) }, { 0.0003d, new GammaParticle(302700.0, 0.0041) }, { 0.00025d, new GammaParticle(318600.0, 0.00389) }, { 0.0001d, new GammaParticle(323900.0, 0.00383) }, { 5e-05d, new GammaParticle(336000.0, 0.00369) }, { 0.00032d, new GammaParticle(381000.0, 0.00325) }, { 5e-05d, new GammaParticle(410000.0, 0.00302) }, { 0.08800000000000001d, new GammaParticle(13686.0, 0.09059) }, { 0.01738262295361174d, new GammaParticle(78947.0, 0.0157) }, { 0.02881256912582751d, new GammaParticle(81517.0, 0.01521) }, { 0.009976756312213496d, new GammaParticle(92333.0, 0.01343) }, { 0.013119434550560747d, new GammaParticle(93473.0, 0.01326) }, { 0.003142678238347251d, new GammaParticle(94897.0, 0.01307) } } },
            { 0.0034999999999999996d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium220() }, { 1.0d, new BetaParticle(-1, 605000.0) }, { 0.0002d, new GammaParticle(178300.0, 0.00695) }, { 0.00010999999999999999d, new GammaParticle(234500.0, 0.00529) }, { 0.00015d, new GammaParticle(413000.0, 0.003) }, { 6.4059469028e-05d, new GammaParticle(14920.0, 0.0831) }, { 1.3570736792931398e-05d, new GammaParticle(85432.0, 0.01451) }, { 2.216716235369389e-05d, new GammaParticle(88471.0, 0.01401) }, { 7.777298835372521e-06d, new GammaParticle(100119.0, 0.01238) }, { 1.032825285337471e-05d, new GammaParticle(101370.0, 0.01223) }, { 2.5509540180021875e-06d, new GammaParticle(102948.0, 0.01204) } } },

        };
    }
}
    