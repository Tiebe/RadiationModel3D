using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium261p : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium261p";
        public override double halfLife { get; } = 1.9d;
        public override double atomicWeight { get; } = 261.10902d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.73d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.27d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium257() }, { 1.0d, new AlphaParticle(9900002.09) } } },

        };
    }
}
    