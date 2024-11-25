using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium218";
        public override double halfLife { get; } = 0.0011d;
        public override double atomicWeight { get; } = 218.00758d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine214() }, { 1.0d, new AlphaParticle(9035002.09) } } },

        };
    }
}
    