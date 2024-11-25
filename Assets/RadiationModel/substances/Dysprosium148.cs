using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium148";
        public override double halfLife { get; } = 198.0d;
        public override double atomicWeight { get; } = 147.92715d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium148() }, { 1.0d, new BetaParticle(1, 4205200.0) }, { 0.00038556d, new GammaParticle(85800.0, 0.01445) }, { 0.00028917d, new GammaParticle(102300.0, 0.01212) }, { 0.00048195000000000003d, new GammaParticle(109400.0, 0.01133) }, { 0.00125307d, new GammaParticle(136900.0, 0.00906) }, { 9.639e-05d, new GammaParticle(156000.0, 0.00795) }, { 0.00520506d, new GammaParticle(178300.0, 0.00695) }, { 0.00038556d, new GammaParticle(339600.0, 0.00365) }, { 0.00125307d, new GammaParticle(442000.0, 0.00281) }, { 0.00106029d, new GammaParticle(462100.0, 0.00268) }, { 9.639e-05d, new GammaParticle(616200.0, 0.00201) }, { 0.9639d, new GammaParticle(620240.0, 0.002) }, { 0.00067473d, new GammaParticle(627000.0, 0.00198) }, { 0.00163863d, new GammaParticle(657800.0, 0.00188) }, { 0.00163863d, new GammaParticle(691900.0, 0.00179) }, { 9.639e-05d, new GammaParticle(772000.0, 0.00161) }, { 0.00202419d, new GammaParticle(794900.0, 0.00156) }, { 0.00077112d, new GammaParticle(847100.0, 0.00146) }, { 0.00240975d, new GammaParticle(890000.0, 0.00139) }, { 0.0038556000000000003d, new GammaParticle(950800.0, 0.0013) }, { 0.0027953099999999996d, new GammaParticle(1045900.0, 0.00119) }, { 0.00077112d, new GammaParticle(1068900.0, 0.00116) }, { 0.00038556d, new GammaParticle(1085400.0, 0.00114) }, { 9.639e-05d, new GammaParticle(1097000.0, 0.00113) }, { 0.00028917d, new GammaParticle(1187500.0, 0.00104) }, { 0.0144585d, new GammaParticle(1247200.0, 0.00099) }, { 0.00183141d, new GammaParticle(1276900.0, 0.00097) }, { 0.0014458499999999998d, new GammaParticle(1332700.0, 0.00093) }, { 0.00019278d, new GammaParticle(1366000.0, 0.00091) }, { 9.639e-05d, new GammaParticle(1547000.0, 0.0008) }, { 9.639e-05d, new GammaParticle(1642900.0, 0.00075) }, { 0.00038556d, new GammaParticle(1650200.0, 0.00075) }, { 0.00057834d, new GammaParticle(1840100.0, 0.00067) }, { 0.075846d, new GammaParticle(511000.0, 0.00243) }, { 0.15d, new GammaParticle(7118.0, 0.17418) }, { 0.21559999999999999d, new GammaParticle(43743.0, 0.02834) }, { 0.3865d, new GammaParticle(44481.0, 0.02787) }, { 0.1234d, new GammaParticle(50494.0, 0.02455) }, { 0.15539999999999998d, new GammaParticle(51040.0, 0.02429) }, { 0.032d, new GammaParticle(51699.0, 0.02398) } } },

        };
    }
}
    