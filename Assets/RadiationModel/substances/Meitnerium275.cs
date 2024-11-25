using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium275 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium275";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 275.14898d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bohrium271() }, { 1.0d, new AlphaParticle(11507002.09) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    