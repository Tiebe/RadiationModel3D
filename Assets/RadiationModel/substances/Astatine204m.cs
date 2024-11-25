using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine204m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine204m";
        public override double halfLife { get; } = 0.108d;
        public override double atomicWeight { get; } = 203.98788d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine204() }, { 0.9329999999999999d, new GammaParticle(587300.0, 0.00211) }, { 0.021564779808d, new GammaParticle(13686.0, 0.09059) }, { 0.01061789270080226d, new GammaParticle(78947.0, 0.0157) }, { 0.017599689542188397d, new GammaParticle(81517.0, 0.01521) }, { 0.006094139434988096d, new GammaParticle(92333.0, 0.01343) }, { 0.008013793357009346d, new GammaParticle(93473.0, 0.01326) }, { 0.0019196539220212503d, new GammaParticle(94897.0, 0.01307) } } },

        };
    }
}
    