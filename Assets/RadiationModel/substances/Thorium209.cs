using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium209";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 209.01761d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium205() }, { 1.0d, new AlphaParticle(9193002.09) } } },

        };
    }
}
    