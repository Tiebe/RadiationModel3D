using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium78";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 77.95615d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    