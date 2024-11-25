using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum197m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum197m";
        public override double halfLife { get; } = 5724.6d;
        public override double atomicWeight { get; } = 196.96777d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9670000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum197() }, { 0.0109045d, new GammaParticle(53100.0, 0.02335) }, { 0.110975d, new GammaParticle(346500.0, 0.00358) }, { 0.458869353095d, new GammaParticle(11070.0, 0.112) }, { 0.13576712866846244d, new GammaParticle(65122.0, 0.01904) }, { 0.23208056182643155d, new GammaParticle(66832.0, 0.01855) }, { 0.0780889731765988d, new GammaParticle(75821.0, 0.01635) }, { 0.10042241950510605d, new GammaParticle(76725.0, 0.01616) }, { 0.02233344632850726d, new GammaParticle(77832.0, 0.01593) } } },
            { 0.033d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold197() }, { 1.0d, new BetaParticle(-1, 559800.00001) }, { 0.0001128d, new GammaParticle(77000.0, 0.0161) }, { 0.0010728d, new GammaParticle(130000.0, 0.00954) }, { 0.0003504d, new GammaParticle(202000.0, 0.00614) }, { 0.024d, new GammaParticle(279000.0, 0.00444) }, { 3.6e-05d, new GammaParticle(409000.0, 0.00303) }, { 0.0109980160186176d, new GammaParticle(11419.0, 0.10858) }, { 0.002409228277305444d, new GammaParticle(66991.0, 0.01851) }, { 0.004101512218769908d, new GammaParticle(68806.0, 0.01802) }, { 0.001383974318017569d, new GammaParticle(78048.0, 0.01589) }, { 0.0017839428959246465d, new GammaParticle(78983.0, 0.0157) }, { 0.00039996857790707745d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    