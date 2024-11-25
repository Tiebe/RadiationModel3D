using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium163";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 162.94568d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium163() }, { 1.0d, new BetaParticle(-1, 2986900.00001) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    