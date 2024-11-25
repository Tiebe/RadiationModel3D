using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium105";
        public override double halfLife { get; } = 2.91d;
        public override double atomicWeight { get; } = 104.92494d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum105() }, { 1.0d, new BetaParticle(-1, 3707500.0) } } },
            { 0.017d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum105() }, { 1.0d, new BetaParticle(-1, 3707500.0) } } },

        };
    }
}
    