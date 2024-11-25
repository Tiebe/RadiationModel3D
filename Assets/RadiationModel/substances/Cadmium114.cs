using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium114";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 113.90337d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin114() }, { 1.0d, new BetaParticle(-1, 272402.5) }, { 1.0d, new BetaParticle(-1, 272402.5) } } },

        };
    }
}
    