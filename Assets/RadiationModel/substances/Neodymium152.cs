using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium152";
        public override double halfLife { get; } = 684.0d;
        public override double atomicWeight { get; } = 151.92469d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium152() }, { 1.0d, new BetaParticle(-1, 552000.0) }, { 0.04341999999999999d, new GammaParticle(16090.0, 0.07706) }, { 0.001586d, new GammaParticle(19500.0, 0.06358) }, { 0.000988d, new GammaParticle(25100.0, 0.0494) }, { 0.00832d, new GammaParticle(28500.0, 0.0435) }, { 0.055380000000000006d, new GammaParticle(44440.0, 0.0279) }, { 0.0005434d, new GammaParticle(94100.0, 0.01318) }, { 0.0008709999999999999d, new GammaParticle(156000.0, 0.00795) }, { 0.00037699999999999995d, new GammaParticle(176600.0, 0.00702) }, { 0.001066d, new GammaParticle(184500.0, 0.00672) }, { 0.0002678d, new GammaParticle(200500.0, 0.00618) }, { 0.000832d, new GammaParticle(240500.0, 0.00516) }, { 0.1638d, new GammaParticle(250150.0, 0.00496) }, { 0.000858d, new GammaParticle(250300.0, 0.00495) }, { 0.0002652d, new GammaParticle(261400.0, 0.00474) }, { 0.00247d, new GammaParticle(269400.0, 0.0046) }, { 0.00052d, new GammaParticle(273200.0, 0.00454) }, { 0.000624d, new GammaParticle(276100.0, 0.00449) }, { 0.26d, new GammaParticle(278560.0, 0.00445) }, { 0.029380000000000003d, new GammaParticle(294470.0, 0.00421) }, { 0.000936d, new GammaParticle(302900.0, 0.00409) }, { 0.0008060000000000001d, new GammaParticle(314400.0, 0.00394) }, { 0.000936d, new GammaParticle(340500.0, 0.00364) }, { 0.000104d, new GammaParticle(350000.0, 0.00354) }, { 0.000416d, new GammaParticle(365400.0, 0.00339) }, { 0.000208d, new GammaParticle(392000.0, 0.00316) }, { 0.000208d, new GammaParticle(406400.0, 0.00305) }, { 0.000728d, new GammaParticle(526300.0, 0.00236) }, { 0.00832d, new GammaParticle(545700.0, 0.00227) }, { 0.001092d, new GammaParticle(547700.0, 0.00226) }, { 0.00091d, new GammaParticle(567500.0, 0.00218) }, { 0.003536d, new GammaParticle(570700.0, 0.00217) }, { 0.003406d, new GammaParticle(576700.0, 0.00215) }, { 0.00988d, new GammaParticle(592500.0, 0.00209) }, { 0.001898d, new GammaParticle(635000.0, 0.00195) }, { 0.001248d, new GammaParticle(660000.0, 0.00188) }, { 0.05264656795801624d, new GammaParticle(6109.0, 0.20295) }, { 0.0022184737064152318d, new GammaParticle(38171.0, 0.03248) }, { 0.0040277300406957725d, new GammaParticle(38724.0, 0.03202) }, { 0.001248743835838501d, new GammaParticle(43934.0, 0.02822) }, { 0.0015696710016489953d, new GammaParticle(44387.0, 0.02793) }, { 0.0003209271658104947d, new GammaParticle(44938.0, 0.02759) } } },

        };
    }
}
    