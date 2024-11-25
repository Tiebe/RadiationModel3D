using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium272";
        public override double halfLife { get; } = 0.0038d;
        public override double atomicWeight { get; } = 272.15327d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Meitnerium268() }, { 1.0d, new AlphaParticle(12217002.09) } } },

        };
    }
}
    