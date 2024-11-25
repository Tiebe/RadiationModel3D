using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium151";
        public override double halfLife { get; } = 0.167d;
        public override double atomicWeight { get; } = 150.95175d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum151() }, { 1.0d, new BetaParticle(-1, 4185000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    