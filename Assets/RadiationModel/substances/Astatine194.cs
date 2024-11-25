using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine194 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine194";
        public override double halfLife { get; } = 0.286d;
        public override double atomicWeight { get; } = 193.99923d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth190() }, { 1.0d, new AlphaParticle(8477002.09) } } },
            { 0.008d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    