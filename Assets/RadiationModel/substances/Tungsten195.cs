using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten195 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten195";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 194.97773d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    