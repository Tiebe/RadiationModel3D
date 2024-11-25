using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium201m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium201m";
        public override double halfLife { get; } = 0.0016d;
        public override double atomicWeight { get; } = 201.0131d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon197() }, { 1.0d, new AlphaParticle(9287002.09) } } },

        };
    }
}
    