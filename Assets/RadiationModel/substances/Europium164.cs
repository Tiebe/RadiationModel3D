using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium164";
        public override double halfLife { get; } = 4.15d;
        public override double atomicWeight { get; } = 163.94285d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium164() }, { 1.0d, new BetaParticle(-1, 3230800.0) } } },

        };
    }
}
    