using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium155n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium155n";
        public override double halfLife { get; } = 0.00269d;
        public override double atomicWeight { get; } = 154.95624d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99964d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium151() }, { 1.0d, new AlphaParticle(8604002.09) } } },

        };
    }
}
    