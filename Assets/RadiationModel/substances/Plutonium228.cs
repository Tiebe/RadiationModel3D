using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium228";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 228.03876d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8960047.4), new Uranium224() } },

        };
    }
}
    
    