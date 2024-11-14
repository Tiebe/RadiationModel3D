using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium59";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 58.98837d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    