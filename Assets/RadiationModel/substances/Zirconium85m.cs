
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium85m";
        public override double halfLife { get; } = 10.9d;
        public override double atomicWeight { get; } = 84.92176d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    