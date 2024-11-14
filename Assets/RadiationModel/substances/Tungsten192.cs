using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten192 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten192";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 191.9682d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    