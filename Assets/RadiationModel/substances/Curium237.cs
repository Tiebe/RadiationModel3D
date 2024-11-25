using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium237";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 237.05287d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium233() }, { 1.0d, new AlphaParticle(7797002.09) } } },

        };
    }
}
    