using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium191m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium191m";
        public override double halfLife { get; } = 0.093d;
        public override double atomicWeight { get; } = 190.99462d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead187() }, { 1.0d, new AlphaParticle(8576002.09) } } },

        };
    }
}
    