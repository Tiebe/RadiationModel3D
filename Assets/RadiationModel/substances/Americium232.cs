using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium232";
        public override double halfLife { get; } = 79.0d;
        public override double atomicWeight { get; } = 232.04661d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.97d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium232() } } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium228() }, { 1.0d, new AlphaParticle(8187002.09) } } },
            { 0.0006900000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium232() } } },

        };
    }
}
    