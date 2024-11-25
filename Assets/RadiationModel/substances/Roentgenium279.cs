using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium279 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium279";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 279.16288d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Meitnerium275() }, { 1.0d, new AlphaParticle(11547002.09) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    