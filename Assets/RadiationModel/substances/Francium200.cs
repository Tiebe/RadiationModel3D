using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium200";
        public override double halfLife { get; } = 0.0496d;
        public override double atomicWeight { get; } = 200.00658d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.975d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine196() }, { 1.0d, new AlphaParticle(8637002.09) } } },
            { 0.025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine200() }, { 1.0d, new BetaParticle(1, 7559000.0) } } },

        };
    }
}
    