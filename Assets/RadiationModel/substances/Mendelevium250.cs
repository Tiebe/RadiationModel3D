using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium250";
        public override double halfLife { get; } = 54.0d;
        public override double atomicWeight { get; } = 250.08417d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new List<RadioactiveSubstance> { new BetaParticle(1, 4328000.0), new Fermium250() } },
            { 0.07d, new List<RadioactiveSubstance> { new AlphaParticle(9177002.09), new Einsteinium246() } },

        };
    }
}
    
    