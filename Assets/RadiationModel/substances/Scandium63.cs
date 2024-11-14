using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium63";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 63.01403d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    