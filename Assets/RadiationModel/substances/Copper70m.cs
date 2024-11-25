using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper70m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper70m";
        public override double halfLife { get; } = 33.0d;
        public override double atomicWeight { get; } = 69.9325d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.52d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc70() }, { 1.0d, new BetaParticle(-1, 3344700.0) }, { 0.051d, new GammaParticle(208750.0, 0.00594) }, { 0.05d, new GammaParticle(387100.0, 0.0032) }, { 0.027000000000000003d, new GammaParticle(553200.0, 0.00224) }, { 0.094d, new GammaParticle(708420.0, 0.00175) }, { 0.032d, new GammaParticle(779100.0, 0.00159) }, { 0.039d, new GammaParticle(874330.0, 0.00142) }, { 0.49d, new GammaParticle(884880.0, 0.0014) }, { 0.25d, new GammaParticle(901700.0, 0.00138) }, { 0.026000000000000002d, new GammaParticle(906500.0, 0.00137) }, { 0.07400000000000001d, new GammaParticle(1072200.0, 0.00116) }, { 0.034d, new GammaParticle(1100500.0, 0.00113) }, { 0.017d, new GammaParticle(1191500.0, 0.00104) }, { 0.051d, new GammaParticle(1251700.0, 0.00099) }, { 0.019d, new GammaParticle(1460400.0, 0.00085) }, { 0.079d, new GammaParticle(1653900.0, 0.00075) }, { 0.027000000000000003d, new GammaParticle(1759600.0, 0.0007) }, { 0.054000000000000006d, new GammaParticle(1809100.0, 0.00069) }, { 0.069d, new GammaParticle(1975000.0, 0.00063) }, { 1.0965737134799998e-05d, new GammaParticle(1035.0, 1.19791) }, { 0.0001028969186774301d, new GammaParticle(8616.0, 0.1439) }, { 0.0002001106936550566d, new GammaParticle(8639.0, 0.14352) }, { 4.293617866751337e-05d, new GammaParticle(9610.0, 0.12902) }, { 4.293617866751337e-05d, new GammaParticle(9610.0, 0.12902) } } },
            { 0.48d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper70() }, { 0.075d, new GammaParticle(101100.0, 0.01226) }, { 0.005047290239999999d, new GammaParticle(952.0, 1.30236) }, { 0.046721197655391615d, new GammaParticle(8028.0, 0.15444) }, { 0.09102123057742376d, new GammaParticle(8048.0, 0.15406) }, { 0.01915997176718462d, new GammaParticle(8940.0, 0.13868) }, { 0.01915997176718462d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    