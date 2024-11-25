using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold203 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold203";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 202.97515d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury203() }, { 1.0d, new BetaParticle(-1, 1063099.99999) }, { 0.009000000000000001d, new GammaParticle(43500.0, 0.0285) }, { 0.0084d, new GammaParticle(50800.0, 0.02441) }, { 0.0095d, new GammaParticle(217600.0, 0.0057) }, { 0.0076d, new GammaParticle(318100.0, 0.0039) }, { 0.0073d, new GammaParticle(368900.0, 0.00336) }, { 0.0665557051225d, new GammaParticle(11777.0, 0.10528) }, { 0.0024284421043120744d, new GammaParticle(68894.0, 0.018) }, { 0.004116701312615824d, new GammaParticle(70820.0, 0.01751) }, { 0.0013971071794834494d, new GammaParticle(80316.0, 0.01544) }, { 0.0018064595830721d, new GammaParticle(81285.0, 0.01525) }, { 0.00040935240358865065d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    