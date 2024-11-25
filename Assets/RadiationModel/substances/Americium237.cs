using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium237";
        public override double halfLife { get; } = 4416.0d;
        public override double atomicWeight { get; } = 237.04999d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997499999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium237() }, { 1.0d, new BetaParticle(1, 849200.0) }, { 7.000000000000001e-05d, new GammaParticle(9903.0, 0.1252) }, { 0.00027d, new GammaParticle(40748.0, 0.03043) }, { 8.999999999999999e-05d, new GammaParticle(45724.0, 0.02712) }, { 0.00053d, new GammaParticle(47710.0, 0.02599) }, { 0.00021d, new GammaParticle(55638.0, 0.02228) }, { 0.00032d, new GammaParticle(68800.0, 0.01802) }, { 0.002d, new GammaParticle(79050.0, 0.01568) }, { 0.00039989999999999996d, new GammaParticle(123800.0, 0.01001) }, { 0.0028000000000000004d, new GammaParticle(124720.0, 0.00994) }, { 0.0011d, new GammaParticle(127500.0, 0.00972) }, { 0.0048d, new GammaParticle(145552.0, 0.00852) }, { 0.0007000000000000001d, new GammaParticle(158300.0, 0.00783) }, { 0.0024d, new GammaParticle(179940.0, 0.00689) }, { 0.0019d, new GammaParticle(183700.0, 0.00675) }, { 0.0009d, new GammaParticle(193400.0, 0.00641) }, { 0.0042d, new GammaParticle(203030.0, 0.00611) }, { 0.0033d, new GammaParticle(206700.0, 0.006) }, { 0.0024d, new GammaParticle(214900.0, 0.00577) }, { 0.0024d, new GammaParticle(224860.0, 0.00551) }, { 0.0015d, new GammaParticle(229100.0, 0.00541) }, { 0.0059d, new GammaParticle(248700.0, 0.00499) }, { 0.0027d, new GammaParticle(252200.0, 0.00492) }, { 0.0015d, new GammaParticle(252200.0, 0.00492) }, { 0.0076d, new GammaParticle(273300.0, 0.00454) }, { 0.473d, new GammaParticle(280230.0, 0.00442) }, { 0.013999999999999999d, new GammaParticle(321000.0, 0.00386) }, { 0.0055000000000000005d, new GammaParticle(390700.0, 0.00317) }, { 0.0063d, new GammaParticle(407800.0, 0.00304) }, { 0.0194d, new GammaParticle(425800.0, 0.00291) }, { 0.0025d, new GammaParticle(435200.0, 0.00285) }, { 0.083d, new GammaParticle(438400.0, 0.00283) }, { 0.001d, new GammaParticle(453200.0, 0.00274) }, { 0.0009d, new GammaParticle(455800.0, 0.00272) }, { 0.043d, new GammaParticle(473500.0, 0.00262) }, { 0.0028000000000000004d, new GammaParticle(501200.0, 0.00247) }, { 0.0019d, new GammaParticle(504800.0, 0.00246) }, { 0.0026d, new GammaParticle(648500.0, 0.00191) }, { 0.013000000000000001d, new GammaParticle(655300.0, 0.00189) }, { 0.002d, new GammaParticle(696200.0, 0.00178) }, { 0.0024d, new GammaParticle(720400.0, 0.00172) }, { 0.0027d, new GammaParticle(743500.0, 0.00167) }, { 0.0016d, new GammaParticle(792000.0, 0.00157) }, { 0.0037d, new GammaParticle(861200.0, 0.00144) }, { 0.026000000000000002d, new GammaParticle(908800.0, 0.00136) }, { 0.0019d, new GammaParticle(1000600.0, 0.00124) }, { 0.67d, new GammaParticle(17604.0, 0.07043) }, { 0.268d, new GammaParticle(99533.0, 0.01246) }, { 0.42d, new GammaParticle(103741.0, 0.01195) }, { 0.156d, new GammaParticle(117130.0, 0.01059) }, { 0.21d, new GammaParticle(118619.0, 0.01045) }, { 0.054000000000000006d, new GammaParticle(120544.0, 0.01029) } } },
            { 0.00025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium233() }, { 1.0d, new AlphaParticle(7217002.09) } } },

        };
    }
}
    