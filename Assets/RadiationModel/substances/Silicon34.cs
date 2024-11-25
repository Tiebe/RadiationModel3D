using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon34 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon34";
        public override double halfLife { get; } = 2.77d;
        public override double atomicWeight { get; } = 33.97854d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus34() }, { 1.0d, new BetaParticle(-1, 2278500.0) } } },

        };
    }
}
    