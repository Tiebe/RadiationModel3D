using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium165";
        public override double halfLife { get; } = 2.24d;
        public override double atomicWeight { get; } = 164.94554d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium165() }, { 1.0d, new BetaParticle(-1, 2898400.00001) } } },
            { 0.004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium165() }, { 1.0d, new BetaParticle(-1, 2898400.00001) } } },

        };
    }
}
    