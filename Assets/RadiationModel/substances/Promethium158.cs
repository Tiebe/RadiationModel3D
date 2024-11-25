using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium158";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 157.93655d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium158() }, { 1.0d, new BetaParticle(-1, 3072950.0) } } },

        };
    }
}
    