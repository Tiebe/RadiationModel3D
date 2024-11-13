
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium254m : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium254m";
        public override double halfLife { get; } = 20.3d;
        public override double atomicWeight { get; } = 254.09635d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    