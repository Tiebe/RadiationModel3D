using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium151m";
        public override double halfLife { get; } = 0.58d;
        public override double atomicWeight { get; } = 150.94023d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.953d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium151() }, { 0.003d, new GammaParticle(28000.0, 0.04428) }, { 0.00074d, new GammaParticle(57700.0, 0.02149) }, { 0.019d, new GammaParticle(136900.0, 0.00906) }, { 0.003d, new GammaParticle(225300.0, 0.0055) }, { 0.863d, new GammaParticle(288700.0, 0.00429) }, { 0.02d, new GammaParticle(338500.0, 0.00366) }, { 0.013000000000000001d, new GammaParticle(354000.0, 0.0035) }, { 0.016d, new GammaParticle(526800.0, 0.00235) }, { 0.016d, new GammaParticle(580400.0, 0.00214) }, { 0.025d, new GammaParticle(801600.0, 0.00155) }, { 0.003d, new GammaParticle(919300.0, 0.00135) }, { 0.006999999999999999d, new GammaParticle(935000.0, 0.00133) }, { 0.024d, new GammaParticle(1071400.0, 0.00116) }, { 0.8640000000000001d, new GammaParticle(1098900.0, 0.00113) }, { 0.87d, new GammaParticle(1140200.0, 0.00109) }, { 0.003d, new GammaParticle(1495900.0, 0.00083) }, { 0.027999999999999997d, new GammaParticle(1548200.0, 0.0008) }, { 0.17878585788604798d, new GammaParticle(7933.0, 0.15629) }, { 0.021489121907348804d, new GammaParticle(48222.0, 0.02571) }, { 0.038141856420569414d, new GammaParticle(49128.0, 0.02524) }, { 0.012394724781017288d, new GammaParticle(55779.0, 0.02223) }, { 0.015617353224081783d, new GammaParticle(56399.0, 0.02198) }, { 0.0032226284430644948d, new GammaParticle(57145.0, 0.0217) } } },
            { 0.047d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium151() }, { 1.0d, new BetaParticle(1, 6536000.0) }, { 0.0039000000000000003d, new GammaParticle(128800.0, 0.00963) }, { 0.037000000000000005d, new GammaParticle(296900.0, 0.00418) }, { 0.0062d, new GammaParticle(307200.0, 0.00404) }, { 0.0068000000000000005d, new GammaParticle(403600.0, 0.00307) }, { 0.027000000000000003d, new GammaParticle(414000.0, 0.00299) }, { 0.044000000000000004d, new GammaParticle(597400.0, 0.00208) }, { 0.051d, new GammaParticle(789300.0, 0.00157) }, { 0.0007599999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.0015d, new GammaParticle(7656.0, 0.16194) }, { 0.0017000000000000001d, new GammaParticle(46700.0, 0.02655) }, { 0.0031d, new GammaParticle(47547.0, 0.02608) }, { 0.00099d, new GammaParticle(53982.0, 0.02297) }, { 0.0012d, new GammaParticle(54577.0, 0.02272) }, { 0.00026d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    