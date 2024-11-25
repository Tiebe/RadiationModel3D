using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium162";
        public override double halfLife { get; } = 39.4d;
        public override double atomicWeight { get; } = 161.94722d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99992d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium162() }, { 1.0d, new BetaParticle(1, 5326500.0) } } },
            { 8e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium158() }, { 1.0d, new AlphaParticle(5439002.09) } } },

        };
    }
}
    