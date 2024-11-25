using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium282";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 282.17577d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Roentgenium278() }, { 1.0d, new AlphaParticle(11807002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    