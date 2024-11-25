using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium235";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 235.05154d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.011000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium231() }, { 1.0d, new AlphaParticle(8298002.09) } } },

        };
    }
}
    