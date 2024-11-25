using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium120";
        public override double halfLife { get; } = 50.8d;
        public override double atomicWeight { get; } = 119.90987d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium120() }, { 1.0d, new BetaParticle(-1, 886500.0) } } },

        };
    }
}
    