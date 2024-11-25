using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium87";
        public override double halfLife { get; } = 0.14d;
        public override double atomicWeight { get; } = 86.9532d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic87() }, { 1.0d, new BetaParticle(-1, 6013950.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    