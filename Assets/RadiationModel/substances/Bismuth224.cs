using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth224 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth224";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 224.0398d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium224() }, { 1.0d, new BetaParticle(-1, 3580000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    