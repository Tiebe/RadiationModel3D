using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium260";
        public override double halfLife { get; } = 2747520.0d;
        public override double atomicWeight { get; } = 260.10365d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.42d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium256() }, { 1.0d, new AlphaParticle(7957002.09) } } },
            { 0.23d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    