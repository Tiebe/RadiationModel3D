
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron14i : RadioactiveSubstance
    {
        public override string name { get; } = "Boron14i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 14.04372d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    