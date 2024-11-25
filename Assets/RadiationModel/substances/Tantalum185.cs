using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum185 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum185";
        public override double halfLife { get; } = 2964.0d;
        public override double atomicWeight { get; } = 184.95556d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten185() }, { 1.0d, new BetaParticle(-1, 996950.0) }, { 0.0012850000000000001d, new GammaParticle(23600.0, 0.05254) }, { 0.000514d, new GammaParticle(42500.0, 0.02917) }, { 0.03855d, new GammaParticle(66100.0, 0.01876) }, { 0.020045999999999998d, new GammaParticle(69700.0, 0.01779) }, { 0.00019532000000000002d, new GammaParticle(93300.0, 0.01329) }, { 0.00015934d, new GammaParticle(94600.0, 0.01311) }, { 0.027499d, new GammaParticle(107800.0, 0.0115) }, { 0.0001542d, new GammaParticle(122050.0, 0.01016) }, { 0.011822d, new GammaParticle(147300.0, 0.00842) }, { 0.0012336d, new GammaParticle(150300.0, 0.00825) }, { 0.0012336d, new GammaParticle(164900.0, 0.00752) }, { 0.22616d, new GammaParticle(173910.0, 0.00713) }, { 0.257d, new GammaParticle(177590.0, 0.00698) }, { 0.0012336d, new GammaParticle(188200.0, 0.00659) }, { 0.037522d, new GammaParticle(243700.0, 0.00509) }, { 0.00771d, new GammaParticle(394400.0, 0.00314) }, { 0.00771d, new GammaParticle(541700.0, 0.00229) }, { 0.005397d, new GammaParticle(580500.0, 0.00214) }, { 0.007967d, new GammaParticle(588700.0, 0.00211) }, { 0.0012079d, new GammaParticle(913000.0, 0.00136) }, { 0.0008995d, new GammaParticle(965000.0, 0.00128) }, { 0.002313d, new GammaParticle(993000.0, 0.00125) }, { 0.002313d, new GammaParticle(1059000.0, 0.00117) }, { 2.056e-05d, new GammaParticle(1122000.0, 0.00111) }, { 7.71e-05d, new GammaParticle(1138000.0, 0.00109) }, { 7.71e-05d, new GammaParticle(1147000.0, 0.00108) }, { 0.2772714801442147d, new GammaParticle(9740.0, 0.12729) }, { 0.08712983106063207d, new GammaParticle(57983.0, 0.02138) }, { 0.15134589379995148d, new GammaParticle(59320.0, 0.0209) }, { 0.050166008055444584d, new GammaParticle(67335.0, 0.01841) }, { 0.0639114942626364d, new GammaParticle(68117.0, 0.0182) }, { 0.013745486207191815d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    