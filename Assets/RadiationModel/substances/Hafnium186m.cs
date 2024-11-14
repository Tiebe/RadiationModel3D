using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium186m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium186m";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 185.96409d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    