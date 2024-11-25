using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium214";
        public override double halfLife { get; } = 8.2d;
        public override double atomicWeight { get; } = 214.00691d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium210() }, { 1.0d, new AlphaParticle(8374002.09) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium214() } } },

        };
    }
}
    