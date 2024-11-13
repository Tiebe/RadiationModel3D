
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium188 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium188";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 187.9669d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    