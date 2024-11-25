using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium260";
        public override double halfLife { get; } = 0.035d;
        public override double atomicWeight { get; } = 260.12144d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dubnium256() }, { 1.0d, new AlphaParticle(11417002.09) } } },
            { 0.18d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium260() } } },
            { 0.18d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    