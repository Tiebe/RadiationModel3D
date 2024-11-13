
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium175";
        public override double halfLife { get; } = 6104160.0d;
        public override double atomicWeight { get; } = 174.94151d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Lutetium175() } },

        };
    }
}
    
    