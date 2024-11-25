using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium239";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 239.05824d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium239() } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium235() }, { 1.0d, new AlphaParticle(8227002.09) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    