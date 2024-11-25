using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium127m";
        public override double halfLife { get; } = 28.6d;
        public override double atomicWeight { get; } = 126.92273d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium127() }, { 1.0d, new BetaParticle(1, 5423000.0) } } },

        };
    }
}
    