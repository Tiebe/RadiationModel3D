using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium246m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium246m";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 246.08177d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium242() }, { 1.0d, new AlphaParticle(9967002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    