using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium244";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 244.08116d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9967002.09), new Einsteinium240() } },

        };
    }
}
    
    