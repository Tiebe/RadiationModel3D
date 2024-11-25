using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium250";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 250.08417d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium250() } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium246() }, { 1.0d, new AlphaParticle(9177002.09) } } },

        };
    }
}
    