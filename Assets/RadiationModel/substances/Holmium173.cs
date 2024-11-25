using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium173";
        public override double halfLife { get; } = 6.9d;
        public override double atomicWeight { get; } = 172.94702d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium173() }, { 1.0d, new BetaParticle(-1, 2150000.0) } } },

        };
    }
}
    