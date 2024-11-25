using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium208";
        public override double halfLife { get; } = 0.0017d;
        public override double atomicWeight { get; } = 208.01792d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium204() }, { 1.0d, new AlphaParticle(9226002.09) } } },

        };
    }
}
    