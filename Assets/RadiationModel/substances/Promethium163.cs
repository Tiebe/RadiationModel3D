using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium163";
        public override double halfLife { get; } = 0.43d;
        public override double atomicWeight { get; } = 162.95388d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium163() }, { 1.0d, new BetaParticle(-1, 3820000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    