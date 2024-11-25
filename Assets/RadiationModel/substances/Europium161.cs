using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium161";
        public override double halfLife { get; } = 26.0d;
        public override double atomicWeight { get; } = 160.93366d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium161() }, { 1.0d, new BetaParticle(-1, 1857050.0) } } },

        };
    }
}
    