using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton73m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton73m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 72.93975d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton73() }, { 0.030314999999999998d, new GammaParticle(40800.0, 0.03039) }, { 0.17625d, new GammaParticle(65800.0, 0.01884) }, { 0.22325d, new GammaParticle(144200.0, 0.0086) }, { 0.38775d, new GammaParticle(223600.0, 0.00554) }, { 0.01645d, new GammaParticle(248600.0, 0.00499) }, { 0.03055d, new GammaParticle(265100.0, 0.00468) }, { 0.5428499999999999d, new GammaParticle(367800.0, 0.00337) }, { 0.051699999999999996d, new GammaParticle(392800.0, 0.00316) }, { 0.0190933081792777d, new GammaParticle(1648.0, 0.75233) }, { 0.12625492065037586d, new GammaParticle(12596.0, 0.09843) }, { 0.24345337572382542d, new GammaParticle(12649.0, 0.09802) }, { 0.05833787343768055d, new GammaParticle(14169.0, 0.0875) }, { 0.06421833108019875d, new GammaParticle(14209.0, 0.08726) }, { 0.0058804576425182d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    