using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium242";
        public override double halfLife { get; } = 17.8d;
        public override double atomicWeight { get; } = 242.06957d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium238() }, { 1.0d, new AlphaParticle(9177002.09) } } },
            { 0.43d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium242() }, { 1.0d, new BetaParticle(1, 3525000.0) } } },

        };
    }
}
    