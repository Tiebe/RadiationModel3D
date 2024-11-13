
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum93 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum93";
        public override double halfLife { get; } = 126227808000.0d;
        public override double atomicWeight { get; } = 92.90681d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Niobium93() } },

        };
    }
}
    
    