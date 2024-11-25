using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium161";
        public override double halfLife { get; } = 77.0d;
        public override double atomicWeight { get; } = 160.94357d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium161() }, { 1.0d, new BetaParticle(1, 4668500.0) } } },

        };
    }
}
    