using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium286";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 286.18246d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Roentgenium282() }, { 1.0d, new AlphaParticle(10817002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    