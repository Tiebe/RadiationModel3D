using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium171";
        public override double halfLife { get; } = 53.0d;
        public override double atomicWeight { get; } = 170.94147d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium171() }, { 1.0d, new BetaParticle(-1, 1598900.00001) } } },

        };
    }
}
    