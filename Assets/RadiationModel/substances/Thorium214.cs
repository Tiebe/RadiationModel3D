using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium214";
        public override double halfLife { get; } = 0.087d;
        public override double atomicWeight { get; } = 214.01148d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium210() }, { 1.0d, new AlphaParticle(8849002.09) } } },

        };
    }
}
    