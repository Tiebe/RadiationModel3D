using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth186m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth186m";
        public override double halfLife { get; } = 0.0098d;
        public override double atomicWeight { get; } = 185.9968d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8942047.4), new Thallium182() } },

        };
    }
}
    
    