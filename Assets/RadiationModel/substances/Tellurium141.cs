using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium141";
        public override double halfLife { get; } = 0.193d;
        public override double atomicWeight { get; } = 140.9456d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine141() }, { 1.0d, new BetaParticle(-1, 4628500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    