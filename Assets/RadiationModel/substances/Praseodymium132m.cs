using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium132m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium132m";
        public override double halfLife { get; } = 96.0d;
        public override double atomicWeight { get; } = 131.91927d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum132() }, { 1.0d, new BetaParticle(1, 4260000.0) } } },

        };
    }
}
    