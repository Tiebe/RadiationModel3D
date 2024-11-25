using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium162";
        public override double halfLife { get; } = 11.4d;
        public override double atomicWeight { get; } = 161.93696d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium162() }, { 1.0d, new BetaParticle(-1, 2779050.0) } } },

        };
    }
}
    