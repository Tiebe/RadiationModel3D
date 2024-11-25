using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium111";
        public override double halfLife { get; } = 19.3d;
        public override double atomicWeight { get; } = 110.921d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin111() }, { 1.0d, new BetaParticle(1, 6176000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    