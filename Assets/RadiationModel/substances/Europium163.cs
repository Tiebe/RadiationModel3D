using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium163";
        public override double halfLife { get; } = 7.7d;
        public override double atomicWeight { get; } = 162.93927d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium163() }, { 1.0d, new BetaParticle(-1, 2407399.99999) } } },

        };
    }
}
    