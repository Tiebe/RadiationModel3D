using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium200n : RadioactiveSubstance
    {
        public override string name { get; } = "Francium200n";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 200.00674d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine196() }, { 1.0d, new AlphaParticle(8787002.09) } } },

        };
    }
}
    