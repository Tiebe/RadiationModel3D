using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine212 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine212";
        public override double halfLife { get; } = 0.314d;
        public override double atomicWeight { get; } = 211.99074d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth208() }, { 1.0d, new AlphaParticle(8839102.09) } } },

        };
    }
}
    