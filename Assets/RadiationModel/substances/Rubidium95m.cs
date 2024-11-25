using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium95m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 94.93016d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium95() }, { 0.07200000000000001d, new GammaParticle(192000.0, 0.00646) }, { 0.085d, new GammaParticle(618000.0, 0.00201) }, { 0.066d, new GammaParticle(810000.0, 0.00153) }, { 0.002d, new GammaParticle(835000.0, 0.00148) } } },

        };
    }
}
    