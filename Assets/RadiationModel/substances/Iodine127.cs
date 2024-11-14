using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine127 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine127";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 126.90447d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    