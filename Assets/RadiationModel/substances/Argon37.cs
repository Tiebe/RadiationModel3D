using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon37 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon37";
        public override double halfLife { get; } = 3024950.4d;
        public override double atomicWeight { get; } = 36.96678d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Chlorine37() } },

        };
    }
}
    
    