using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium261";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 261.10877d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.82d, new List<RadioactiveSubstance> {  } },
            { 0.18d, new List<RadioactiveSubstance> { new AlphaParticle(9670002.09), new Nobelium257() } },

        };
    }
}
    
    