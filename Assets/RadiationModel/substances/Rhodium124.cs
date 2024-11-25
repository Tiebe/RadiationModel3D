using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium124";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 123.952d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium124() }, { 1.0d, new BetaParticle(-1, 6845000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    