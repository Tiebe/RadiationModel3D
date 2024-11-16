using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium158";
        public override double halfLife { get; } = 8244.0d;
        public override double atomicWeight { get; } = 157.92989d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Holmium158() } },

        };
    }
}
    
    