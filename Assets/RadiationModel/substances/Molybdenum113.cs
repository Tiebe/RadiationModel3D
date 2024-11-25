using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum113 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum113";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 112.94348d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium113() }, { 1.0d, new BetaParticle(-1, 5081000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    