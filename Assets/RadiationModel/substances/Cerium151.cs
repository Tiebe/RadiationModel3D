using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium151";
        public override double halfLife { get; } = 1.76d;
        public override double atomicWeight { get; } = 150.93427d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium151() }, { 1.0d, new BetaParticle(-1, 2777500.0) } } },

        };
    }
}
    