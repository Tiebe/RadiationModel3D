using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum153 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum153";
        public override double halfLife { get; } = 0.245d;
        public override double atomicWeight { get; } = 152.95055d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium153() }, { 1.0d, new BetaParticle(-1, 4425000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    