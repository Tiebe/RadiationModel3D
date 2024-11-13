
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium172";
        public override double halfLife { get; } = 59011500.24d;
        public override double atomicWeight { get; } = 171.93945d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Lutetium172() } },

        };
    }
}
    
    