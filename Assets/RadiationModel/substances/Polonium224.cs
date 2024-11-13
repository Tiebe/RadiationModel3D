
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium224";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 224.03211d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    