using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium285 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium285";
        public override double halfLife { get; } = 0.93d;
        public override double atomicWeight { get; } = 285.18011d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Roentgenium281() }, { 1.0d, new AlphaParticle(11037002.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    