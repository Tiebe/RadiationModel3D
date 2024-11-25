using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold191m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold191m";
        public override double halfLife { get; } = 0.92d;
        public override double atomicWeight { get; } = 190.964d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold191() }, { 8.4e-08d, new GammaParticle(13700.0, 0.0905) }, { 0.131d, new GammaParticle(241000.0, 0.00514) }, { 0.615d, new GammaParticle(253000.0, 0.0049) }, { 0.2377442255104d, new GammaParticle(11419.0, 0.10858) }, { 0.05191676093822841d, new GammaParticle(66991.0, 0.01851) }, { 0.08838399887338852d, new GammaParticle(68806.0, 0.01802) }, { 0.029823435367248293d, new GammaParticle(78048.0, 0.01589) }, { 0.03844240818838304d, new GammaParticle(78983.0, 0.0157) }, { 0.008618972821134756d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    