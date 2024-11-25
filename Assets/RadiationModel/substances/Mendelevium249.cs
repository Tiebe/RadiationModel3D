using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium249";
        public override double halfLife { get; } = 24.8d;
        public override double atomicWeight { get; } = 249.08286d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium245() }, { 1.0d, new AlphaParticle(9457002.09) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium249() }, { 1.0d, new BetaParticle(1, 3000000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    