using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium155";
        public override double halfLife { get; } = 1.47d;
        public override double atomicWeight { get; } = 154.94051d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium155() }, { 1.0d, new BetaParticle(-1, 3434500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    