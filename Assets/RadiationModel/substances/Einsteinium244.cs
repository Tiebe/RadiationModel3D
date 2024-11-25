using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium244";
        public override double halfLife { get; } = 37.0d;
        public override double atomicWeight { get; } = 244.07089d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.96d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium244() } } },
            { 0.04d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium240() }, { 1.0d, new AlphaParticle(8967002.09) } } },

        };
    }
}
    