using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine72 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine72";
        public override double halfLife { get; } = 78.6d;
        public override double atomicWeight { get; } = 71.93659d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic72() }, { 1.0d, new BetaParticle(1, 4584100.0) }, { 0.026000000000000002d, new GammaParticle(75000.0, 0.01653) }, { 0.035802d, new GammaParticle(379900.0, 0.00326) }, { 0.035802d, new GammaParticle(379900.0, 0.00326) }, { 0.131274d, new GammaParticle(454700.0, 0.00273) }, { 0.020358d, new GammaParticle(512000.0, 0.00242) }, { 0.012636000000000001d, new GammaParticle(537600.0, 0.00231) }, { 0.025974d, new GammaParticle(559300.0, 0.00222) }, { 0.016146d, new GammaParticle(710200.0, 0.00175) }, { 0.029484d, new GammaParticle(752800.0, 0.00165) }, { 0.070902d, new GammaParticle(774800.0, 0.0016) }, { 0.020358d, new GammaParticle(832000.0, 0.00149) }, { 0.7020000000000001d, new GammaParticle(862000.0, 0.00144) }, { 0.007019999999999999d, new GammaParticle(1014000.0, 0.00122) }, { 0.037206d, new GammaParticle(1054700.0, 0.00118) }, { 0.055458d, new GammaParticle(1061600.0, 0.00117) }, { 0.03159d, new GammaParticle(1089200.0, 0.00114) }, { 0.03159d, new GammaParticle(1089200.0, 0.00114) }, { 0.053352000000000004d, new GammaParticle(1125100.0, 0.0011) }, { 0.0702d, new GammaParticle(1136400.0, 0.00109) }, { 0.01053d, new GammaParticle(1227300.0, 0.00101) }, { 0.008424000000000001d, new GammaParticle(1269500.0, 0.00098) }, { 0.172692d, new GammaParticle(1316700.0, 0.00094) }, { 0.022463999999999998d, new GammaParticle(1349900.0, 0.00092) }, { 0.009828d, new GammaParticle(1433600.0, 0.00086) }, { 0.032993999999999996d, new GammaParticle(1509800.0, 0.00082) }, { 0.037908d, new GammaParticle(1571300.0, 0.00079) }, { 0.015444d, new GammaParticle(1648500.0, 0.00075) }, { 0.034398d, new GammaParticle(1724000.0, 0.00072) }, { 0.01755d, new GammaParticle(1807400.0, 0.00069) }, { 0.013338000000000001d, new GammaParticle(1909400.0, 0.00065) }, { 0.009828d, new GammaParticle(2150700.0, 0.00058) }, { 0.075114d, new GammaParticle(2371900.0, 0.00052) }, { 0.012636000000000001d, new GammaParticle(2432700.0, 0.00051) }, { 0.009828d, new GammaParticle(2465000.0, 0.0005) }, { 2.02d, new GammaParticle(511000.0, 0.00243) }, { 0.0014000000000000002d, new GammaParticle(1426.0, 0.86945) }, { 0.01d, new GammaParticle(11183.0, 0.11087) }, { 0.02d, new GammaParticle(11223.0, 0.11047) }, { 0.004699999999999999d, new GammaParticle(12546.0, 0.09882) }, { 0.005d, new GammaParticle(12571.0, 0.09863) }, { 0.00026d, new GammaParticle(12652.0, 0.098) } } },

        };
    }
}
    