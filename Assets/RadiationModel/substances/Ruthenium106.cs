using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium106";
        public override double halfLife { get; } = 32123520.0d;
        public override double atomicWeight { get; } = 105.90733d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium106() }, { 1.0d, new BetaParticle(-1, 20000.0) } } },

        };
    }
}
    