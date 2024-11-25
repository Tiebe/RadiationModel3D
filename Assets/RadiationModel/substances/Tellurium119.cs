using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium119";
        public override double halfLife { get; } = 57780.0d;
        public override double atomicWeight { get; } = 118.90641d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin119() }, { 1.0d, new BetaParticle(1, 1441000.0) }, { 0.00028594d, new GammaParticle(149360.0, 0.0083) }, { 0.0011773999999999999d, new GammaParticle(270450.0, 0.00458) }, { 0.000841d, new GammaParticle(429500.0, 0.00289) }, { 0.00014297d, new GammaParticle(627720.0, 0.00198) }, { 0.841d, new GammaParticle(644010.0, 0.00193) }, { 0.0010933d, new GammaParticle(683210.0, 0.00181) }, { 0.0009251d, new GammaParticle(694500.0, 0.00179) }, { 0.10092000000000001d, new GammaParticle(699850.0, 0.00177) }, { 0.0005886999999999999d, new GammaParticle(713200.0, 0.00174) }, { 0.0010933d, new GammaParticle(769300.0, 0.00161) }, { 0.0026912000000000004d, new GammaParticle(787760.0, 0.00157) }, { 0.0005886999999999999d, new GammaParticle(794800.0, 0.00156) }, { 0.0029435d, new GammaParticle(843570.0, 0.00147) }, { 0.0055506d, new GammaParticle(1105570.0, 0.00112) }, { 0.0020184d, new GammaParticle(1121300.0, 0.00111) }, { 0.0071484999999999995d, new GammaParticle(1177040.0, 0.00105) }, { 4.2049999999999996e-06d, new GammaParticle(1216870.0, 0.00102) }, { 8.410000000000001e-05d, new GammaParticle(1327380.0, 0.00093) }, { 0.0022707d, new GammaParticle(1338700.0, 0.00093) }, { 0.010933d, new GammaParticle(1413190.0, 0.00088) }, { 0.00033640000000000005d, new GammaParticle(1479500.0, 0.00084) }, { 8.409999999999999e-06d, new GammaParticle(1487360.0, 0.00083) }, { 0.0002523d, new GammaParticle(1700700.0, 0.00073) }, { 0.039527d, new GammaParticle(1749650.0, 0.00071) }, { 0.00033640000000000005d, new GammaParticle(1821300.0, 0.00068) }, { 0.0004205d, new GammaParticle(1875300.0, 0.00066) }, { 0.040999999999999995d, new GammaParticle(511000.0, 0.00243) }, { 0.0709867008165924d, new GammaParticle(3941.0, 0.3146) }, { 0.20860212646256898d, new GammaParticle(26111.0, 0.04748) }, { 0.38947372379120426d, new GammaParticle(26359.0, 0.04704) }, { 0.11079516165430298d, new GammaParticle(29821.0, 0.04158) }, { 0.1337297601167437d, new GammaParticle(30069.0, 0.04123) }, { 0.022934598462440715d, new GammaParticle(30387.0, 0.0408) } } },
            { 0.0206d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony119() }, { 1.0d, new BetaParticle(1, 1146500.0) } } },

        };
    }
}
    