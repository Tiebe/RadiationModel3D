using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium100n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium100n";
        public override double halfLife { get; } = 276.0d;
        public override double atomicWeight { get; } = 99.90823d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.983d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium100() }, { 1.7517100000000002e-05d, new GammaParticle(32700.0, 0.03792) }, { 0.079623d, new GammaParticle(32700.0, 0.03792) }, { 0.0087585d, new GammaParticle(42100.0, 0.02945) }, { 0.06369799999999999d, new GammaParticle(74900.0, 0.01655) }, { 0.0159246d, new GammaParticle(74900.0, 0.01655) }, { 0.080081202525233d, new GammaParticle(2892.0, 0.42871) }, { 0.24102478964979754d, new GammaParticle(20073.0, 0.06177) }, { 0.45631349801173327d, new GammaParticle(20215.0, 0.06133) }, { 0.12391809022595986d, new GammaParticle(22806.0, 0.05436) }, { 0.14448849320346918d, new GammaParticle(22957.0, 0.05401) }, { 0.02057040297750934d, new GammaParticle(23170.0, 0.05351) } } },
            { 0.017d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium100() }, { 1.0d, new BetaParticle(1, 269000.0) }, { 0.00062d, new GammaParticle(262300.0, 0.00473) }, { 0.0168d, new GammaParticle(539600.0, 0.0023) }, { 0.0101d, new GammaParticle(686900.0, 0.0018) }, { 0.0005600000000000001d, new GammaParticle(701200.0, 0.00177) }, { 0.0002d, new GammaParticle(822500.0, 0.00151) }, { 0.00052d, new GammaParticle(836400.0, 0.00148) }, { 0.000101d, new GammaParticle(849000.0, 0.00146) }, { 8e-05d, new GammaParticle(951500.0, 0.0013) }, { 0.00012d, new GammaParticle(1087100.0, 0.00114) }, { 0.00015d, new GammaParticle(1097800.0, 0.00113) }, { 0.00061d, new GammaParticle(1140700.0, 0.00109) }, { 0.0003d, new GammaParticle(1341600.0, 0.00092) }, { 0.00017d, new GammaParticle(1362100.0, 0.00091) }, { 0.0003d, new GammaParticle(1380500.0, 0.0009) }, { 0.00027d, new GammaParticle(1523700.0, 0.00081) }, { 0.0032d, new GammaParticle(1535600.0, 0.00081) }, { 0.00035000000000000005d, new GammaParticle(1773900.0, 0.0007) }, { 0.004d, new GammaParticle(1827500.0, 0.00068) }, { 0.008964d, new GammaParticle(511000.0, 0.00243) }, { 0.000639d, new GammaParticle(2737.0, 0.45299) }, { 0.0028599999999999997d, new GammaParticle(19150.0, 0.06474) }, { 0.005430000000000001d, new GammaParticle(19279.0, 0.06431) }, { 0.001459d, new GammaParticle(21736.0, 0.05704) }, { 0.0016950000000000001d, new GammaParticle(21875.0, 0.05668) }, { 0.000236d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    