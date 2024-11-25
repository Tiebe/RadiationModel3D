using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium160";
        public override double halfLife { get; } = 1536.0d;
        public override double atomicWeight { get; } = 159.92874d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium160() }, { 1.0d, new BetaParticle(1, 727250.0) } } },

        };
    }
}
    