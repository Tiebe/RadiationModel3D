using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium205";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 205.01515d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium201() }, { 1.0d, new AlphaParticle(9118002.09) } } },

        };
    }
}
    