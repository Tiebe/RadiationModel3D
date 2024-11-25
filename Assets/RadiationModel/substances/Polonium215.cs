using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium215";
        public override double halfLife { get; } = 0.00178d;
        public override double atomicWeight { get; } = 214.99942d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999977d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead211() }, { 1.0d, new AlphaParticle(8548202.09) } } },
            { 2.3e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine215() }, { 1.0d, new BetaParticle(-1, 357599.99999) } } },

        };
    }
}
    