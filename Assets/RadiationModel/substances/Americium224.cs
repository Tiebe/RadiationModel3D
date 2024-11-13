
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium224";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 224.04644d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    