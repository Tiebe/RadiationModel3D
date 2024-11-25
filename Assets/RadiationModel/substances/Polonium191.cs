using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium191 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium191";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 190.99456d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead187() }, { 1.0d, new AlphaParticle(8515002.09) } } },

        };
    }
}
    