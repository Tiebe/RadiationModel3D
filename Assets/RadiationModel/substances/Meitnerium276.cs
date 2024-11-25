using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium276 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium276";
        public override double halfLife { get; } = 0.69d;
        public override double atomicWeight { get; } = 276.1517d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bohrium272() }, { 1.0d, new AlphaParticle(11117002.09) } } },

        };
    }
}
    