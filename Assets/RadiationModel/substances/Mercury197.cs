using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury197 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury197";
        public override double halfLife { get; } = 233748.0d;
        public override double atomicWeight { get; } = 196.96721d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Gold197() } },

        };
    }
}
    
    