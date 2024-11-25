using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium233";
        public override double halfLife { get; } = 1254.0d;
        public override double atomicWeight { get; } = 233.043d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9987999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium233() }, { 1.0d, new BetaParticle(1, 1565450.0) } } },
            { 0.0012d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium229() }, { 1.0d, new AlphaParticle(7436002.09) } } },

        };
    }
}
    