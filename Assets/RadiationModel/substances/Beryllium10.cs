using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium10 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium10";
        public override double halfLife { get; } = 47650958221633.92d;
        public override double atomicWeight { get; } = 10.01353d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron10() }, { 1.0d, new BetaParticle(-1, 278439.5) } } },

        };
    }
}
    