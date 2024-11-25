using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel71m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel71m";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 70.94052d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper71() }, { 1.0d, new BetaParticle(-1, 3652550.0) }, { 0.4d, new GammaParticle(454000.0, 0.00273) } } },

        };
    }
}
    