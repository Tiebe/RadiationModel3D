using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium125";
        public override double halfLife { get; } = 3.3d;
        public override double atomicWeight { get; } = 124.93766d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum125() }, { 1.0d, new BetaParticle(1, 7844500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    