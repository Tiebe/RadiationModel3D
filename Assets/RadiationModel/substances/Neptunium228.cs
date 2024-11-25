using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium228";
        public override double halfLife { get; } = 61.4d;
        public override double atomicWeight { get; } = 228.03632d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium228() } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium224() }, { 1.0d, new AlphaParticle(8565002.09) } } },

        };
    }
}
    