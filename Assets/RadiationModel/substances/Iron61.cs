using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron61 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron61";
        public override double halfLife { get; } = 358.8d;
        public override double atomicWeight { get; } = 60.93675d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt61() }, { 1.0d, new BetaParticle(-1, 1988850.0) }, { 0.051239999999999994d, new GammaParticle(120340.0, 0.0103) }, { 0.01932d, new GammaParticle(177610.0, 0.00698) }, { 0.21420000000000003d, new GammaParticle(297900.0, 0.00416) }, { 0.002142d, new GammaParticle(333000.0, 0.00372) }, { 0.001554d, new GammaParticle(349700.0, 0.00355) }, { 0.0021d, new GammaParticle(440500.0, 0.00281) }, { 0.00063d, new GammaParticle(542600.0, 0.00229) }, { 0.000546d, new GammaParticle(561400.0, 0.00221) }, { 0.000714d, new GammaParticle(603300.0, 0.00206) }, { 0.008988000000000001d, new GammaParticle(618400.0, 0.002) }, { 0.002142d, new GammaParticle(657300.0, 0.00189) }, { 0.0038640000000000002d, new GammaParticle(686000.0, 0.00181) }, { 0.001092d, new GammaParticle(696900.0, 0.00178) }, { 0.00777d, new GammaParticle(748100.0, 0.00166) }, { 0.001554d, new GammaParticle(769400.0, 0.00161) }, { 0.0018479999999999998d, new GammaParticle(806300.0, 0.00154) }, { 0.003276d, new GammaParticle(925600.0, 0.00134) }, { 0.00105d, new GammaParticle(945400.0, 0.00131) }, { 0.000714d, new GammaParticle(978000.0, 0.00127) }, { 0.00588d, new GammaParticle(984100.0, 0.00126) }, { 0.00588d, new GammaParticle(989200.0, 0.00125) }, { 0.41159999999999997d, new GammaParticle(1027420.0, 0.00121) }, { 0.00672d, new GammaParticle(1097800.0, 0.00113) }, { 0.42d, new GammaParticle(1205070.0, 0.00103) }, { 0.00588d, new GammaParticle(1275000.0, 0.00097) }, { 0.00357d, new GammaParticle(1285700.0, 0.00096) }, { 0.0038640000000000002d, new GammaParticle(1381400.0, 0.0009) }, { 0.001134d, new GammaParticle(1403900.0, 0.00088) }, { 0.002646d, new GammaParticle(1538800.0, 0.00081) }, { 0.003528d, new GammaParticle(1618900.0, 0.00077) }, { 0.0672d, new GammaParticle(1645950.0, 0.00075) }, { 0.007476d, new GammaParticle(1659300.0, 0.00075) }, { 0.001344d, new GammaParticle(1837200.0, 0.00067) }, { 0.00252d, new GammaParticle(1879400.0, 0.00066) }, { 0.001722d, new GammaParticle(1889000.0, 0.00066) }, { 0.000714d, new GammaParticle(1899300.0, 0.00065) }, { 0.000588d, new GammaParticle(1972700.0, 0.00063) }, { 0.00126d, new GammaParticle(1999800.0, 0.00062) }, { 0.04242d, new GammaParticle(2011600.0, 0.00062) }, { 0.002016d, new GammaParticle(2177100.0, 0.00057) }, { 0.00105d, new GammaParticle(2230800.0, 0.00056) }, { 0.001176d, new GammaParticle(2484400.0, 0.0005) }, { 0.007391999999999999d, new GammaParticle(2754400.0, 0.00045) }, { 0.000672d, new GammaParticle(2920000.0, 0.00042) }, { 0.000798d, new GammaParticle(3191000.0, 0.00039) }, { 0.00042d, new GammaParticle(3204200.0, 0.00039) }, { 0.000546d, new GammaParticle(3239100.0, 0.00038) }, { 0.00042d, new GammaParticle(3364900.0, 0.00037) } } },

        };
    }
}
    