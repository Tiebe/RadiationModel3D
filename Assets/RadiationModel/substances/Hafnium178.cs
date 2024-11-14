using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium178";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 177.94371d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    