
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium128";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 127.93502d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    