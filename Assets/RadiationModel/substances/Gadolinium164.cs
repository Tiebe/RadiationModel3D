using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium164";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 163.93592d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium164() }, { 1.0d, new BetaParticle(-1, 1205650.00001) } } },

        };
    }
}
    