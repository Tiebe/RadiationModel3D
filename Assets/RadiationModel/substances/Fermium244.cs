using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium244";
        public override double halfLife { get; } = 0.00312d;
        public override double atomicWeight { get; } = 244.07403d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.97d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium244() } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium240() }, { 1.0d, new AlphaParticle(9568002.09) } } },

        };
    }
}
    