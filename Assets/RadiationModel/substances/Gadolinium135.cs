using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium135";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 134.9525d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium135() }, { 1.0d, new BetaParticle(1, 9305000.0) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium134() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    