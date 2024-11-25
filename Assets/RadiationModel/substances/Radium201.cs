using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium201";
        public override double halfLife { get; } = 0.008d;
        public override double atomicWeight { get; } = 201.01281d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon197() }, { 1.0d, new AlphaParticle(9024002.09) } } },

        };
    }
}
    