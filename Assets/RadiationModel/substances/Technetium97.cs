
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium97";
        public override double halfLife { get; } = 132854767920000.0d;
        public override double atomicWeight { get; } = 96.90636d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Molybdenum97() } },

        };
    }
}
    
    