using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon227 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon227";
        public override double halfLife { get; } = 20.2d;
        public override double atomicWeight { get; } = 227.0353d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium227() }, { 1.0d, new BetaParticle(-1, 1602000.0) } } },

        };
    }
}
    