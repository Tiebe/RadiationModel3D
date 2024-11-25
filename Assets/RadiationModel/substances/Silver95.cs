using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver95 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver95";
        public override double halfLife { get; } = 1.75d;
        public override double atomicWeight { get; } = 94.93568d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium95() }, { 1.0d, new BetaParticle(1, 9215500.0) }, { 0.0033536d, new GammaParticle(89300.0, 0.01388) }, { 0.0291344d, new GammaParticle(539000.0, 0.0023) }, { 0.013204800000000001d, new GammaParticle(580800.0, 0.00213) }, { 0.0079648d, new GammaParticle(597500.0, 0.00208) }, { 0.0079648d, new GammaParticle(605100.0, 0.00205) }, { 0.0108992d, new GammaParticle(621900.0, 0.00199) }, { 0.025152d, new GammaParticle(675700.0, 0.00183) }, { 0.0048208d, new GammaParticle(720000.0, 0.00172) }, { 0.0064976d, new GammaParticle(763100.0, 0.00162) }, { 0.0119472d, new GammaParticle(802100.0, 0.00155) }, { 0.0190736d, new GammaParticle(1014700.0, 0.00122) }, { 0.031230400000000002d, new GammaParticle(1021700.0, 0.00121) }, { 0.12156800000000001d, new GammaParticle(1219600.0, 0.00102) }, { 0.007126400000000001d, new GammaParticle(1226200.0, 0.00101) }, { 0.0123664d, new GammaParticle(1254100.0, 0.00099) }, { 0.2096d, new GammaParticle(1261800.0, 0.00098) }, { 0.253616d, new GammaParticle(1351100.0, 0.00092) }, { 0.0121568d, new GammaParticle(1384000.0, 0.0009) }, { 0.0090128d, new GammaParticle(1471700.0, 0.00084) }, { 0.12576d, new GammaParticle(1686000.0, 0.00074) }, { 0.0280864d, new GammaParticle(1800600.0, 0.00069) }, { 0.092224d, new GammaParticle(2024900.0, 0.00061) }, { 0.019492799999999998d, new GammaParticle(2570800.0, 0.00048) }, { 0.021379199999999998d, new GammaParticle(2940200.0, 0.00042) }, { 1.7278d, new GammaParticle(511000.0, 0.00243) }, { 0.000551038887d, new GammaParticle(3053.0, 0.40611) }, { 0.002192801166515656d, new GammaParticle(21020.0, 0.05898) }, { 0.004142832356916032d, new GammaParticle(21177.0, 0.05855) }, { 0.0011366234842464203d, new GammaParticle(23904.0, 0.05187) }, { 0.0013298494765683116d, new GammaParticle(24070.0, 0.05151) }, { 0.00019322599232189145d, new GammaParticle(24297.0, 0.05103) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    