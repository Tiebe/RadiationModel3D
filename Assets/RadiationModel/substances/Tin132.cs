using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin132 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin132";
        public override double halfLife { get; } = 39.7d;
        public override double atomicWeight { get; } = 131.91782d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony132() }, { 1.0d, new BetaParticle(-1, 1544350.0) }, { 0.4802d, new GammaParticle(85580.0, 0.01449) }, { 0.000833d, new GammaParticle(91700.0, 0.01352) }, { 0.00098d, new GammaParticle(93900.0, 0.0132) }, { 0.001176d, new GammaParticle(134700.0, 0.0092) }, { 0.000735d, new GammaParticle(162800.0, 0.00762) }, { 0.4214d, new GammaParticle(246870.0, 0.00502) }, { 0.49d, new GammaParticle(340530.0, 0.00364) }, { 0.0049d, new GammaParticle(426100.0, 0.00291) }, { 0.002254d, new GammaParticle(443500.0, 0.0028) }, { 0.021070000000000002d, new GammaParticle(529090.0, 0.00234) }, { 0.02303d, new GammaParticle(549230.0, 0.00226) }, { 0.026949999999999998d, new GammaParticle(652310.0, 0.0019) }, { 0.003087d, new GammaParticle(795700.0, 0.00156) }, { 0.4459d, new GammaParticle(899040.0, 0.00138) }, { 0.3675d, new GammaParticle(992660.0, 0.00125) }, { 0.024990000000000002d, new GammaParticle(1078300.0, 0.00115) }, { 0.09702d, new GammaParticle(1239630.0, 0.001) }, { 0.001421d, new GammaParticle(1739100.0, 0.00071) }, { 0.00735d, new GammaParticle(1842220.0, 0.00067) }, { 0.03672908185149d, new GammaParticle(3941.0, 0.3146) }, { 0.10778312539478899d, new GammaParticle(26111.0, 0.04748) }, { 0.20123809819788832d, new GammaParticle(26359.0, 0.04704) }, { 0.05724701374923168d, new GammaParticle(29821.0, 0.04158) }, { 0.06909714559532265d, new GammaParticle(30069.0, 0.04123) }, { 0.01185013184609096d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    