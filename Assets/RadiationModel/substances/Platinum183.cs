using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum183 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum183";
        public override double halfLife { get; } = 390.0d;
        public override double atomicWeight { get; } = 182.9616d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium183() }, { 1.0d, new BetaParticle(1, 3943500.0) } } },
            { 9.599999999999999e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium179() }, { 1.0d, new AlphaParticle(5844002.09) } } },

        };
    }
}
    