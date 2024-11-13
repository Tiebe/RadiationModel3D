
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Helium3 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium3";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 3.01603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    