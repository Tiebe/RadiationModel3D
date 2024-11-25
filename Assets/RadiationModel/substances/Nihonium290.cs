using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium290";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 290.19143d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Roentgenium286() }, { 1.0d, new AlphaParticle(10407002.09) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    