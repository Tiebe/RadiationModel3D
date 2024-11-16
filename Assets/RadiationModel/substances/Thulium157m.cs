using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium157m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium157m";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 156.93708d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    