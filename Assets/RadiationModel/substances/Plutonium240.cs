using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium240";
        public override double halfLife { get; } = 207045162072.0d;
        public override double atomicWeight { get; } = 240.05381d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6275747.4), new Uranium236() } },
            { 5.796e-08d, new List<RadioactiveSubstance> {  } },
            { 1.3e-13d, new List<RadioactiveSubstance> { new Silicon34(), new Mercury206() } },

        };
    }
}
    
    