using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon213 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon213";
        public override double halfLife { get; } = 0.0194d;
        public override double atomicWeight { get; } = 212.99389d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium209() }, { 1.0d, new AlphaParticle(9267002.09) } } },

        };
    }
}
    