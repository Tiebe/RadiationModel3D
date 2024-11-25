using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium160m";
        public override double halfLife { get; } = 30.8d;
        public override double atomicWeight { get; } = 159.93194d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium160() }, { 1.0d, new BetaParticle(-1, 2270849.99999) } } },

        };
    }
}
    