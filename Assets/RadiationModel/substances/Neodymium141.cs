using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium141";
        public override double halfLife { get; } = 8964.0d;
        public override double atomicWeight { get; } = 140.90962d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium141() }, { 1.0d, new BetaParticle(1, 619550.0) }, { 0.0024d, new GammaParticle(145450.0, 0.00852) }, { 0.00021799999999999999d, new GammaParticle(981700.0, 0.00126) }, { 0.00796d, new GammaParticle(1126910.0, 0.0011) }, { 0.00307d, new GammaParticle(1147300.0, 0.00108) }, { 9.8e-05d, new GammaParticle(1289580.0, 0.00096) }, { 0.0046d, new GammaParticle(1292640.0, 0.00096) }, { 0.00127d, new GammaParticle(1298600.0, 0.00095) }, { 3.2000000000000003e-06d, new GammaParticle(1306000.0, 0.00095) }, { 4e-06d, new GammaParticle(1310600.0, 0.00095) }, { 5.6e-05d, new GammaParticle(1434600.0, 0.00086) }, { 8e-06d, new GammaParticle(1435100.0, 0.00086) }, { 8e-06d, new GammaParticle(1456120.0, 0.00085) }, { 6.1000000000000005e-05d, new GammaParticle(1580170.0, 0.00078) }, { 0.000184d, new GammaParticle(1608350.0, 0.00077) }, { 9.6e-06d, new GammaParticle(1657040.0, 0.00075) }, { 0.0518d, new GammaParticle(511000.0, 0.00243) }, { 0.11027901755966774d, new GammaParticle(5637.0, 0.21995) }, { 0.21378215681547152d, new GammaParticle(35551.0, 0.03488) }, { 0.390398387172154d, new GammaParticle(36027.0, 0.03441) }, { 0.11876765629820443d, new GammaParticle(40857.0, 0.03035) }, { 0.14917217631054477d, new GammaParticle(41266.0, 0.03005) }, { 0.030404520012340334d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    