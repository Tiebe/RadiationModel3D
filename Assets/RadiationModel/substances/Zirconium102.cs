using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium102";
        public override double halfLife { get; } = 2.9d;
        public override double atomicWeight { get; } = 101.92315d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium102() }, { 1.0d, new BetaParticle(-1, 2358650.0) }, { 0.005600000000000001d, new GammaParticle(20380.0, 0.06084) }, { 0.086d, new GammaParticle(64460.0, 0.01923) }, { 0.011699999999999999d, new GammaParticle(73580.0, 0.01685) }, { 0.006999999999999999d, new GammaParticle(85590.0, 0.01449) }, { 0.011000000000000001d, new GammaParticle(96400.0, 0.01286) }, { 0.0137d, new GammaParticle(102020.0, 0.01215) }, { 0.013999999999999999d, new GammaParticle(136350.0, 0.00909) }, { 0.009899999999999999d, new GammaParticle(152400.0, 0.00814) }, { 0.034d, new GammaParticle(156140.0, 0.00794) }, { 0.0087d, new GammaParticle(225350.0, 0.0055) }, { 0.005600000000000001d, new GammaParticle(246550.0, 0.00503) }, { 0.0069d, new GammaParticle(258520.0, 0.0048) }, { 0.0026d, new GammaParticle(270000.0, 0.00459) }, { 0.009000000000000001d, new GammaParticle(362900.0, 0.00342) }, { 0.0049d, new GammaParticle(442300.0, 0.0028) }, { 0.011000000000000001d, new GammaParticle(458690.0, 0.0027) }, { 0.107d, new GammaParticle(535130.0, 0.00232) }, { 0.016d, new GammaParticle(549000.0, 0.00226) }, { 0.139d, new GammaParticle(599480.0, 0.00207) }, { 0.0055000000000000005d, new GammaParticle(641200.0, 0.00193) }, { 0.006d, new GammaParticle(875800.0, 0.00142) }, { 0.011000000000000001d, new GammaParticle(940600.0, 0.00132) }, { 0.005160036005455d, new GammaParticle(2299.0, 0.5393) }, { 0.02744166677587111d, new GammaParticle(16521.0, 0.07505) }, { 0.05240960041228249d, new GammaParticle(16615.0, 0.07462) }, { 0.013560828245083822d, new GammaParticle(18694.0, 0.06632) }, { 0.015594952481846397d, new GammaParticle(18795.0, 0.06597) }, { 0.0020341242367625735d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    