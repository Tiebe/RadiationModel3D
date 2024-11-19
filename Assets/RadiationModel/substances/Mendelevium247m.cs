using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium247m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium247m";
        public override double halfLife { get; } = 0.25d;
        public override double atomicWeight { get; } = 247.0818d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.79d, new List<RadioactiveSubstance> { new AlphaParticle(10047002.09), new Einsteinium243() } },
            { 0.21d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    