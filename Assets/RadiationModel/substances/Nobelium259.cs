using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium259";
        public override double halfLife { get; } = 3480.0d;
        public override double atomicWeight { get; } = 259.101d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> { new AlphaParticle(8874047.4), new Fermium255() } },
            { 0.25d, new List<RadioactiveSubstance> { new Mendelevium259() } },
            { 0.1d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    