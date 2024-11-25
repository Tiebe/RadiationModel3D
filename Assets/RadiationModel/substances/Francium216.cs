using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium216";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 216.00319d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine212() }, { 1.0d, new AlphaParticle(10196102.09) }, { 8e-05d, new GammaParticle(45000.0, 0.02755) }, { 0.0017000000000000001d, new GammaParticle(160300.0, 0.00773) }, { 0.00238628416d, new GammaParticle(13686.0, 0.09059) }, { 0.0012320250045029788d, new GammaParticle(78947.0, 0.0157) }, { 0.002042143219796086d, new GammaParticle(81517.0, 0.01521) }, { 0.0007071207419778969d, new GammaParticle(92333.0, 0.01343) }, { 0.0009298637757009344d, new GammaParticle(93473.0, 0.01326) }, { 0.00022274303372303754d, new GammaParticle(94897.0, 0.01307) } } },
            { 1.9999999999999997e-09d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon216() } } },

        };
    }
}
    