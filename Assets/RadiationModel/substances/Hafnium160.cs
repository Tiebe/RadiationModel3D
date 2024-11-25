using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium160";
        public override double halfLife { get; } = 13.6d;
        public override double atomicWeight { get; } = 159.95068d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.993d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium160() }, { 1.0d, new BetaParticle(1, 6112000.0) } } },
            { 0.006999999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium156() }, { 1.0d, new AlphaParticle(5924002.09) } } },

        };
    }
}
    