using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium110";
        public override double halfLife { get; } = 0.0375d;
        public override double atomicWeight { get; } = 109.95467d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium110() }, { 1.0d, new BetaParticle(-1, 5045000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    