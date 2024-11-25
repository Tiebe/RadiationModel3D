using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium170";
        public override double halfLife { get; } = 9.2d;
        public override double atomicWeight { get; } = 169.95823d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum170() }, { 1.0d, new BetaParticle(1, 5617000.0) }, { 0.541d, new GammaParticle(156670.0, 0.00791) }, { 0.007574d, new GammaParticle(249900.0, 0.00496) }, { 0.780663d, new GammaParticle(305700.0, 0.00406) }, { 0.004869d, new GammaParticle(344600.0, 0.0036) }, { 0.016771d, new GammaParticle(376300.0, 0.00329) }, { 0.614035d, new GammaParticle(413100.0, 0.003) }, { 0.009197d, new GammaParticle(418900.0, 0.00296) }, { 0.053559d, new GammaParticle(428400.0, 0.00289) }, { 0.150398d, new GammaParticle(487900.0, 0.00254) }, { 0.012443d, new GammaParticle(611300.0, 0.00203) }, { 0.036247d, new GammaParticle(641700.0, 0.00193) }, { 0.012443d, new GammaParticle(690700.0, 0.0018) }, { 0.075199d, new GammaParticle(702600.0, 0.00176) }, { 0.069789d, new GammaParticle(739800.0, 0.00168) }, { 0.015688999999999998d, new GammaParticle(757600.0, 0.00164) }, { 0.005410000000000001d, new GammaParticle(780600.0, 0.00159) }, { 0.021099d, new GammaParticle(796000.0, 0.00156) }, { 0.01623d, new GammaParticle(843400.0, 0.00147) }, { 0.010279d, new GammaParticle(852300.0, 0.00145) }, { 0.021099d, new GammaParticle(916000.0, 0.00135) }, { 0.0541d, new GammaParticle(916700.0, 0.00135) }, { 0.018394d, new GammaParticle(935600.0, 0.00133) }, { 0.067625d, new GammaParticle(936800.0, 0.00132) }, { 0.029214000000000004d, new GammaParticle(996300.0, 0.00124) }, { 0.036247d, new GammaParticle(1030300.0, 0.0012) }, { 0.005951d, new GammaParticle(1055000.0, 0.00118) }, { 0.009197d, new GammaParticle(1063200.0, 0.00117) }, { 0.01623d, new GammaParticle(1099200.0, 0.00113) }, { 0.012443d, new GammaParticle(1157500.0, 0.00107) }, { 0.022722000000000003d, new GammaParticle(1170800.0, 0.00106) }, { 0.017312d, new GammaParticle(1204500.0, 0.00103) }, { 0.040034d, new GammaParticle(1256400.0, 0.00099) }, { 0.010820000000000001d, new GammaParticle(1413300.0, 0.00088) }, { 0.068707d, new GammaParticle(1469300.0, 0.00084) }, { 0.041657d, new GammaParticle(1567300.0, 0.00079) }, { 0.022722000000000003d, new GammaParticle(1605600.0, 0.00077) }, { 0.017312d, new GammaParticle(1677300.0, 0.00074) }, { 0.024886d, new GammaParticle(1774800.0, 0.0007) }, { 1.7080000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.1584316482783234d, new GammaParticle(9740.0, 0.12729) }, { 0.1154084692986129d, new GammaParticle(57983.0, 0.02138) }, { 0.20046633541534292d, new GammaParticle(59320.0, 0.0209) }, { 0.06644776111722148d, new GammaParticle(67335.0, 0.01841) }, { 0.08465444766334017d, new GammaParticle(68117.0, 0.0182) }, { 0.018206686546118685d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    