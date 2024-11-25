using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium208m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium208m";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 208.01209d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium204() }, { 1.0d, new AlphaParticle(9248002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium208() } } },

        };
    }
}
    