using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium98";
        public override double halfLife { get; } = 132539089093286.4d;
        public override double atomicWeight { get; } = 97.90721d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium98() }, { 1.0d, new BetaParticle(-1, 896500.0) }, { 1.0d, new GammaParticle(652410.0, 0.0019) }, { 1.02d, new GammaParticle(745350.0, 0.00166) }, { 0.000192978d, new GammaParticle(2737.0, 0.45299) }, { 0.0008681221883773007d, new GammaParticle(19150.0, 0.06474) }, { 0.0016472906800328285d, new GammaParticle(19279.0, 0.06431) }, { 0.0004426866881152078d, new GammaParticle(21736.0, 0.05704) }, { 0.0005144019315898714d, new GammaParticle(21875.0, 0.05668) }, { 7.171524347466366e-05d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    