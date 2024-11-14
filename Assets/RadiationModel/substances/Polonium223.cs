using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium223";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 223.02907d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    