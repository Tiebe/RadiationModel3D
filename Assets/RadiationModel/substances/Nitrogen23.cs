using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen23 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen23";
        public override double halfLife { get; } = 0.0141d;
        public override double atomicWeight { get; } = 23.03942d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen23() }, { 1.0d, new BetaParticle(-1, 11050000.0) } } },
            { 0.42d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen23() }, { 1.0d, new BetaParticle(-1, 11050000.0) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen21() }, { 1.0d, new BetaParticle(-1, 945823103.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    