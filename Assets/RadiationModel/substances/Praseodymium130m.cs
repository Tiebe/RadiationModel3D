using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium130m";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 129.92369d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum130() }, { 1.0d, new BetaParticle(1, 5273500.0) } } },

        };
    }
}
    