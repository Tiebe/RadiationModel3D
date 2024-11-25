using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon46 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon46";
        public override double halfLife { get; } = 8.4d;
        public override double atomicWeight { get; } = 45.96804d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium46() }, { 1.0d, new BetaParticle(-1, 2821300.0) }, { 0.006999999999999999d, new GammaParticle(288100.0, 0.0043) }, { 0.004d, new GammaParticle(584700.0, 0.00212) }, { 0.008d, new GammaParticle(1020300.0, 0.00122) }, { 1.0d, new GammaParticle(1944300.0, 0.00064) } } },

        };
    }
}
    