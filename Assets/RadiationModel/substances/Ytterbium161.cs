using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium161";
        public override double halfLife { get; } = 252.0d;
        public override double atomicWeight { get; } = 160.93791d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium161() }, { 1.0d, new BetaParticle(1, 3683500.0) } } },

        };
    }
}
    