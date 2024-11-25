using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth201m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth201m";
        public override double halfLife { get; } = 3510.0d;
        public override double atomicWeight { get; } = 200.9779d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.887d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium201() }, { 1.0d, new BetaParticle(1, 3299000.0) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth201() } } },
            { 0.003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium197() }, { 1.0d, new AlphaParticle(6368002.09) } } },

        };
    }
}
    