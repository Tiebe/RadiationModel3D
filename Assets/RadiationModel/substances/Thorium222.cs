using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium222";
        public override double halfLife { get; } = 0.00196d;
        public override double atomicWeight { get; } = 222.01847d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium218() }, { 1.0d, new AlphaParticle(9154002.09) } } },

        };
    }
}
    