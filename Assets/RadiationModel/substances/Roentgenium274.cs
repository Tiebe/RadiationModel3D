using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium274 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium274";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 274.15525d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Meitnerium270() }, { 1.0d, new AlphaParticle(12497002.09) } } },

        };
    }
}
    