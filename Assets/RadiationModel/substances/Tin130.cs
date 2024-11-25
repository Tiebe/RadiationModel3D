using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin130 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin130";
        public override double halfLife { get; } = 223.2d;
        public override double atomicWeight { get; } = 129.91397d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony130() }, { 1.0d, new BetaParticle(-1, 1076900.0) }, { 0.015812d, new GammaParticle(69090.0, 0.01795) }, { 0.34103d, new GammaParticle(70010.0, 0.01771) }, { 0.67d, new GammaParticle(192419.0, 0.00644) }, { 0.195305d, new GammaParticle(229140.0, 0.00541) }, { 0.000603d, new GammaParticle(271600.0, 0.00456) }, { 0.013333d, new GammaParticle(316480.0, 0.00392) }, { 0.026867000000000002d, new GammaParticle(341610.0, 0.00363) }, { 0.0024790000000000003d, new GammaParticle(345100.0, 0.00359) }, { 0.008509d, new GammaParticle(384800.0, 0.00322) }, { 0.0034839999999999997d, new GammaParticle(403200.0, 0.00308) }, { 0.136814d, new GammaParticle(435050.0, 0.00285) }, { 0.007503999999999999d, new GammaParticle(472200.0, 0.00263) }, { 0.013467d, new GammaParticle(482000.0, 0.00257) }, { 0.01809d, new GammaParticle(551370.0, 0.00225) }, { 0.026465000000000002d, new GammaParticle(627510.0, 0.00198) }, { 0.005896d, new GammaParticle(656300.0, 0.00189) }, { 0.003216d, new GammaParticle(663700.0, 0.00187) }, { 0.004489d, new GammaParticle(674600.0, 0.00184) }, { 0.001206d, new GammaParticle(692300.0, 0.00179) }, { 0.002278d, new GammaParticle(701600.0, 0.00177) }, { 0.005829d, new GammaParticle(726370.0, 0.00171) }, { 0.001139d, new GammaParticle(729300.0, 0.0017) }, { 0.161269d, new GammaParticle(743660.0, 0.00167) }, { 0.02479d, new GammaParticle(744580.0, 0.00167) }, { 0.000737d, new GammaParticle(757900.0, 0.00164) }, { 0.0028810000000000003d, new GammaParticle(763600.0, 0.00162) }, { 0.5642739999999999d, new GammaParticle(780440.0, 0.00159) }, { 0.0017419999999999998d, new GammaParticle(825900.0, 0.0015) }, { 0.0017419999999999998d, new GammaParticle(925100.0, 0.00134) }, { 0.00067d, new GammaParticle(956700.0, 0.0013) }, { 0.002144d, new GammaParticle(1047300.0, 0.00118) }, { 0.001139d, new GammaParticle(1128000.0, 0.0011) }, { 0.002546d, new GammaParticle(1288300.0, 0.00096) }, { 0.0490414912227344d, new GammaParticle(3941.0, 0.3146) }, { 0.14623032787195128d, new GammaParticle(26111.0, 0.04748) }, { 0.2730215232859434d, new GammaParticle(26359.0, 0.04704) }, { 0.07766753431558017d, new GammaParticle(29821.0, 0.04158) }, { 0.09374471391890526d, new GammaParticle(30069.0, 0.04123) }, { 0.016077179603325095d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    