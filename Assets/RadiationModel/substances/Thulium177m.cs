using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium177m";
        public override double halfLife { get; } = 95.0d;
        public override double atomicWeight { get; } = 176.94904d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium177() }, { 1.0d, new BetaParticle(-1, 1758200.0) } } },

        };
    }
}
    