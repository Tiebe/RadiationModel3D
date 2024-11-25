using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium98";
        public override double halfLife { get; } = 9.3d;
        public override double atomicWeight { get; } = 97.92739d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium98() }, { 1.0d, new BetaParticle(1, 6840500.0) }, { 0.35100000000000003d, new GammaParticle(60550.0, 0.02048) }, { 0.43700000000000006d, new GammaParticle(107280.0, 0.01156) }, { 0.7809999999999999d, new GammaParticle(347180.0, 0.00357) }, { 0.034d, new GammaParticle(551700.0, 0.00225) }, { 0.08199999999999999d, new GammaParticle(624900.0, 0.00198) }, { 0.047d, new GammaParticle(775600.0, 0.0016) }, { 0.048d, new GammaParticle(794700.0, 0.00156) }, { 0.034d, new GammaParticle(874500.0, 0.00142) }, { 0.125d, new GammaParticle(898500.0, 0.00138) }, { 0.023d, new GammaParticle(1098000.0, 0.00113) }, { 0.021d, new GammaParticle(1124000.0, 0.0011) }, { 0.66d, new GammaParticle(1176100.0, 0.00105) }, { 0.015600000000000001d, new GammaParticle(1346000.0, 0.00092) }, { 0.034d, new GammaParticle(1523000.0, 0.00081) }, { 0.0078000000000000005d, new GammaParticle(1650000.0, 0.00075) }, { 0.016d, new GammaParticle(1996500.0, 0.00062) }, { 0.016d, new GammaParticle(2030000.0, 0.00061) }, { 0.032d, new GammaParticle(2229500.0, 0.00056) }, { 0.012d, new GammaParticle(2376000.0, 0.00052) }, { 1.5859999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.079517971688804d, new GammaParticle(3218.0, 0.38528) }, { 0.2778901624025489d, new GammaParticle(21990.0, 0.05638) }, { 0.5238268848304408d, new GammaParticle(22163.0, 0.05594) }, { 0.14511488291057098d, new GammaParticle(25030.0, 0.04953) }, { 0.17036487253701033d, new GammaParticle(25211.0, 0.04918) }, { 0.02524998962643935d, new GammaParticle(25454.0, 0.04871) } } },
            { 0.00029d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium97() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    